using frmMC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//Stream video
using AForge.Video;
using AForge.Video.DirectShow;

namespace MC
{
    public partial class frmMC : Form
    {
        //Khai báo + Khởi Tạo
        //Stream video
        VideoCaptureDevice frame;
        //object streamVideo;
        FilterInfoCollection Devices;
        //Audio
        DarrenLee.LiveStream.Audio.Sender audioSender = new DarrenLee.LiveStream.Audio.Sender();
        bool flagVideoLive = false;
        List<Question> listQuestions;
        Image videoStream;
        int questionIndex = 0;
        List<int> totalAnswer = new List<int> { 0, 0, 0 };

        IPEndPoint IP;
        Socket MC;
        List<Player> listPlayer = new List<Player>();

        public frmMC()
        {
            InitializeComponent();
            lblListPlayerWin.Visible = false;
            //Controls.Remove(lblListPlayerWin);
            StartServer();
            readFile();
        }
        //Hàm đọc file
        private void readFile()
        {
            listQuestions = new List<Question>();
            Question question = null;
            string filePath = @"..\..\Question_v1.txt";
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (line.StartsWith("@@"))
                {
                    question = new Question();
                    question.question = line.Substring(2);
                }
                else if (line.StartsWith("--"))
                {
                    question.linkImage = line.Substring(2);
                }
                else if (line.StartsWith("$$"))
                {
                    string answer = line.Substring(2);
                    question.Keys.Add(answer);
                }
                else if (line.StartsWith("&&"))
                {
                    question.answer = int.Parse(line.Substring(2));
                }
                else if (line.StartsWith("##"))
                {
                    listQuestions.Add(question);
                }
            }
        }

        //Hàm load câu hỏi
        private void loadQuestion()
        {
            btnNotification.Text = listQuestions.Count.ToString();
            Question question = listQuestions[questionIndex];
            question.numberOfQuestion = listQuestions.Count;
            lblContentQuestion.Text = question.question;
            btnA.Text = question.Keys[0];
            btnB.Text = question.Keys[1];
            btnC.Text = question.Keys[2];
            List<ePOSOne.btnProduct.Button_WOC> buttons = new List<ePOSOne.btnProduct.Button_WOC>() { btnA, btnB, btnC };
            for(int i =0; i<3; i++)
            {
                buttons[i].ButtonColor = Color.SeaShell;                
            }
            buttons[listQuestions[questionIndex].answer].ButtonColor = Color.DodgerBlue;
        }

        //Mở kết nối + Tạo các Thread
        private void StartServer()
        {

            IP = new IPEndPoint(IPAddress.Any, 9999);
            MC = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            MC.Bind(IP);
            Thread listen = new Thread(() =>
            {
                try
                {
                    MC.Listen(100);
                    while (true)
                    {
                        //A new player connected
                        Socket playerSocket = MC.Accept();
                        Thread Receive = new Thread(ReceiveMessage);
                        Receive.IsBackground = true;
                        Receive.Start(playerSocket);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    MC = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            listen.IsBackground = true;
            listen.Start();
            Thread sendVideoStream = new Thread(SendVideoThread);
            sendVideoStream.IsBackground = true;
            sendVideoStream.Start();
        }

        //Thread gửi video cho từng client
        private void SendVideoThread()
        {
            while (true)
            {
                if (flagVideoLive)
                {
                    foreach (Player item in listPlayer.ToArray())
                    {
                        try
                        {
                            SendVideo(item.socket);
                            Thread.Sleep(50);
                        }
                        catch (Exception e)
                        {
                            
                        }
                    }
                }
            }
        }
        //Hàm gửi video từng client
        private void SendVideo(Socket player)
        {
            if (videoStream != null)
            {
                MessageData data = new MessageData();
                data.type = MessageType.Video;                
                data.data = Utils.ResizeImange(videoStream, new Size(256, 200));
                player.Send(Utils.Serialize(data));
            }
        }

        //Gửi câu hỏi
        private void SendQuestion()
        {
            foreach (Player player in listPlayer)
            {
                MessageData data = new MessageData();
                data.type = MessageType.Question;
                data.data = listQuestions[questionIndex];
                player.socket.Send(Utils.Serialize(data));
            }
        }

        //Nhận dữ liệu từ người chơi
        private void ReceiveMessage(Object obj)
        {
            bool connecting = true;
            Socket playerSocket = obj as Socket;
            //try
            //{
            while (connecting)
            {
                byte[] data = new byte[1024 * 5000];
                playerSocket.Receive(data);
                MessageData messData = (MessageData)Utils.Deserialize(data);
                Invoke(new MethodInvoker(delegate ()
                {
                    switch (messData.type)
                    {
                        case MessageType.Name:
                            {
                                MessageData sendData = new MessageData();
                                sendData.type = MessageType.CheckNameResult;
                                PlayerInfo playerInfo = (PlayerInfo)messData.data;
                                bool isExist = IsExistPlayer(playerInfo.nickName);
                                if (!isExist)
                                {
                                    AddPlayerToList(playerInfo, playerSocket);
                                    SendTotalPlayer();
                                }
                                sendData.data = isExist;
                                playerSocket.Send(Utils.Serialize(sendData));
                            }
                            break;
                        case MessageType.Answer:
                            {
                                PlayerAnswer playerAnswer = (PlayerAnswer)messData.data;
                                totalAnswer[playerAnswer.answer]++;
                                foreach (Player player in listPlayer)
                                {
                                    if (playerAnswer.nickName == player.nickName)
                                    {
                                        if (playerAnswer.answer == listQuestions[questionIndex].answer)
                                        {
                                            player.correctNumber++;
                                        }
                                        break;
                                    }
                                }
                            }
                            break;
                        case MessageType.PlayerDisconnect:
                            {
                                PlayerInfo playerDisconnect = (PlayerInfo)messData.data;
                                foreach (Player player in listPlayer)
                                {
                                    if (playerDisconnect.nickName == player.nickName)
                                    {
                                        connecting = false;
                                        player.socket.Close();
                                        listPlayer.Remove(player);
                                        break;
                                    }
                                }
                                SendTotalPlayer();
                                break;
                            }
                    }
                }));
            }
        }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("" + e);
        //        Close();
        //    }
        //}
        //Gửi thông tin tổng số người chơi
        private void SendTotalPlayer()
        {
            MessageData data = new MessageData();
            data.type = MessageType.TotalPlayer;
            data.data = listPlayer.Count;
            if (listPlayer != null)
            {
                foreach (Player player in listPlayer)
                {
                    player.socket.Send(Utils.Serialize(data));
                }
            }
            Invoke(new MethodInvoker(delegate ()
            {
                lblNumberOfPlayer.Text = listPlayer.Count.ToString();
            }));
        }
        //Gửi thông kêt thúc game và kết quả
        private void SendResult(Socket socketPlayer, int numberCorrect)
        {
            MessageData data = new MessageData();
            data.type = MessageType.EndGameResult;
            data.data = numberCorrect;
            socketPlayer.Send(Utils.Serialize(data));
        }
        //Gửi thông tin câu trả lời
        private void SendToTalAnswer()
        {
            MessageData data = new MessageData();
            data.type = MessageType.TotalAnswer;
            data.data = totalAnswer;
            foreach (Player player in listPlayer)
            {
                player.socket.Send(Utils.Serialize(data));
            }
            totalAnswer = new List<int>() { 0, 0, 0 }; //gán lại tổng số câu trả lời của mỗi câu hỏi bằng 0;
        }
        //Gửi thông điệp đống kết nối Server
        private void SendServerInfoDisconnect()
        {
            MessageData data = new MessageData();
            data.type = MessageType.ServerDisconnect;
            data.data = true;
            foreach (Player player in listPlayer)
            {
                player.socket.Send(Utils.Serialize(data));
            }
            CloseServer();
        }
        //Kiểm tra nick name có tồn tại hay chưa
        private bool IsExistPlayer(string name)
        {
            foreach (Player player in listPlayer.ToArray())
            {
                if (name == player.nickName)
                    return true;
            }
            return false;
        }
        //Thêm vào danh sách người chơi
        private void AddPlayerToList(PlayerInfo info, Socket socket)
        {
            Player player = new Player();
            player.nickName = info.nickName;
            player.ip = info.ip;
            player.correctNumber = 0;
            player.socket = socket;
            listPlayer.Add(player);
        }
        //Mở camera
        private void startCamera()
        {
            Devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            frame = new VideoCaptureDevice(Devices[0].MonikerString);
            frame.NewFrame += new AForge.Video.NewFrameEventHandler(NewFrame_event);
            frame.Start();
            flagVideoLive = true;
        }
        //Lấy giá trị hình ảnh gán vào và gửi
        private void NewFrame_event(object sender, NewFrameEventArgs e)
        {
            try
            {
                pcbVideoStream.BackgroundImage = (Image)e.Frame.Clone();
                videoStream = (Image)e.Frame.Clone();
            }
            catch (Exception ex)
            {
                frame.Stop();
            }
        }
        //Hàm đóng kết nối của server tới các client
        void CloseServer()
        {
            MC.Close();
        }
        //Các nút chức năng
        private void btnIconLive_Click(object sender, EventArgs e)
        {
            if (!flagVideoLive)
            {
                btnIconLive.BackgroundImage = imgListIcon.Images[1];

                startCamera();
                foreach (Player player in listPlayer)
                {
                    audioSender.Send(player.ip, 8888);
                }
            }
            else
            {
                btnIconLive.BackgroundImage = imgListIcon.Images[0];
                frame.Stop();
                audioSender.Disconnect();
                flagVideoLive = false;
                pcbVideoStream.Image = null;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnNextQuestion.Enabled = false;
            loadQuestion();
            btnNotification.Text = "Question " + (questionIndex + 1) + " of " + listQuestions.Count;           
        }
        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = true;
            btnNextQuestion.Enabled = false;
            questionIndex++;
            if (questionIndex < listQuestions.Count)
            {
                loadQuestion();
                btnNotification.Text = "Question " + (questionIndex + 1) + " of " + listQuestions.Count;           
                if (questionIndex + 1 == listQuestions.Count)
                {
                    btnNextQuestion.Text = "Result";
                }               
            }
            else
            {
                //Controls.Add(lblListPlayerWin);
                lblListPlayerWin.Visible = true;
                int count = 0;
                foreach (Player player in listPlayer)
                {
                    if (player.correctNumber == listQuestions.Count)
                    {
                        lblListPlayerWin.Text += "\n" + ++count + ". " + player.nickName;
                    }
                    SendResult(player.socket, player.correctNumber);
                }
                btnSend.Enabled = false;
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            circularProgressBar.Value = 10;
            circularProgressBar.Text = circularProgressBar.Value.ToString();
            timerTimeOut.Enabled = true;
            timerTimeOut.Start();
            SendQuestion();
        }
        private void timerTimeOut_Tick(object sender, EventArgs e)
        {
            circularProgressBar.Value--;
            circularProgressBar.Text = circularProgressBar.Value.ToString();
            if (circularProgressBar.Value <= 0)
            {
                btnNotification.Text = "Time's Up!";
                timerTimeOut.Stop();
                SendToTalAnswer();
                btnNextQuestion.Enabled = true;
            }
        }
        private void frmMC_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Gửi thông điệp đóng kết nối của server tới cho các client
            if (listPlayer != null)
                SendServerInfoDisconnect();
            //Kiểm tra nếu camera bật thì tắt
            if (flagVideoLive)
                frame.Stop();
            //Đóng kết  nối của server giữa các client
            CloseServer();
        }
    }
}