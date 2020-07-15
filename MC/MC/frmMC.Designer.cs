namespace MC
{
    partial class frmMC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMC));
            this.pcbVideoStream = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumberOfPlayer = new System.Windows.Forms.Label();
            this.circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnIconLive = new System.Windows.Forms.Button();
            this.pnlQusetionAndAnswer = new System.Windows.Forms.Panel();
            this.lblContentQuestion = new System.Windows.Forms.Label();
            this.imgListIcon = new System.Windows.Forms.ImageList(this.components);
            this.timerTimeOut = new System.Windows.Forms.Timer(this.components);
            this.lblListPlayerWin = new System.Windows.Forms.Label();
            this.btnNotification = new ePOSOne.btnProduct.Button_WOC();
            this.btnC = new ePOSOne.btnProduct.Button_WOC();
            this.btnB = new ePOSOne.btnProduct.Button_WOC();
            this.btnA = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVideoStream)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlQusetionAndAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbVideoStream
            // 
            this.pcbVideoStream.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbVideoStream.Location = new System.Drawing.Point(5, 5);
            this.pcbVideoStream.Margin = new System.Windows.Forms.Padding(4);
            this.pcbVideoStream.Name = "pcbVideoStream";
            this.pcbVideoStream.Size = new System.Drawing.Size(729, 379);
            this.pcbVideoStream.TabIndex = 0;
            this.pcbVideoStream.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNumberOfPlayer);
            this.panel1.Controls.Add(this.circularProgressBar);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.btnNextQuestion);
            this.panel1.Controls.Add(this.btnIconLive);
            this.panel1.Controls.Add(this.btnNotification);
            this.panel1.Controls.Add(this.pnlQusetionAndAnswer);
            this.panel1.Controls.Add(this.pcbVideoStream);
            this.panel1.Location = new System.Drawing.Point(5, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 718);
            this.panel1.TabIndex = 3;
            // 
            // lblNumberOfPlayer
            // 
            this.lblNumberOfPlayer.AutoSize = true;
            this.lblNumberOfPlayer.Font = new System.Drawing.Font("UTM Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPlayer.Location = new System.Drawing.Point(13, 11);
            this.lblNumberOfPlayer.Name = "lblNumberOfPlayer";
            this.lblNumberOfPlayer.Size = new System.Drawing.Size(29, 36);
            this.lblNumberOfPlayer.TabIndex = 44;
            this.lblNumberOfPlayer.Text = "0";
            // 
            // circularProgressBar
            // 
            this.circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar.AnimationSpeed = 900;
            this.circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar.InnerMargin = 2;
            this.circularProgressBar.InnerWidth = -1;
            this.circularProgressBar.Location = new System.Drawing.Point(17, 334);
            this.circularProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar.Maximum = 10;
            this.circularProgressBar.Name = "circularProgressBar";
            this.circularProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar.OuterMargin = -25;
            this.circularProgressBar.OuterWidth = 26;
            this.circularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar.ProgressWidth = 2;
            this.circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar.Size = new System.Drawing.Size(45, 46);
            this.circularProgressBar.StartAngle = 270;
            this.circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar.SubscriptText = "";
            this.circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar.SuperscriptText = "";
            this.circularProgressBar.TabIndex = 43;
            this.circularProgressBar.Text = "0";
            this.circularProgressBar.TextMargin = new System.Windows.Forms.Padding(3, 4, 4, 3);
            this.circularProgressBar.Value = 10;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("UTM Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(395, 334);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 47);
            this.btnStart.TabIndex = 41;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("UTM Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(625, 334);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 47);
            this.btnSend.TabIndex = 40;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Font = new System.Drawing.Font("UTM Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.Location = new System.Drawing.Point(509, 334);
            this.btnNextQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(100, 47);
            this.btnNextQuestion.TabIndex = 39;
            this.btnNextQuestion.Text = "Next";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnIconLive
            // 
            this.btnIconLive.BackColor = System.Drawing.SystemColors.Control;
            this.btnIconLive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIconLive.BackgroundImage")));
            this.btnIconLive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIconLive.Location = new System.Drawing.Point(316, 334);
            this.btnIconLive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIconLive.Name = "btnIconLive";
            this.btnIconLive.Size = new System.Drawing.Size(55, 47);
            this.btnIconLive.TabIndex = 38;
            this.btnIconLive.UseVisualStyleBackColor = false;
            this.btnIconLive.Click += new System.EventHandler(this.btnIconLive_Click);
            // 
            // pnlQusetionAndAnswer
            // 
            this.pnlQusetionAndAnswer.BackColor = System.Drawing.Color.FloralWhite;
            this.pnlQusetionAndAnswer.Controls.Add(this.lblContentQuestion);
            this.pnlQusetionAndAnswer.Controls.Add(this.btnC);
            this.pnlQusetionAndAnswer.Controls.Add(this.btnB);
            this.pnlQusetionAndAnswer.Controls.Add(this.btnA);
            this.pnlQusetionAndAnswer.Font = new System.Drawing.Font("UTM Cooper Black", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlQusetionAndAnswer.Location = new System.Drawing.Point(5, 390);
            this.pnlQusetionAndAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlQusetionAndAnswer.Name = "pnlQusetionAndAnswer";
            this.pnlQusetionAndAnswer.Size = new System.Drawing.Size(729, 325);
            this.pnlQusetionAndAnswer.TabIndex = 1;
            // 
            // lblContentQuestion
            // 
            this.lblContentQuestion.Location = new System.Drawing.Point(11, 7);
            this.lblContentQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContentQuestion.Name = "lblContentQuestion";
            this.lblContentQuestion.Size = new System.Drawing.Size(709, 98);
            this.lblContentQuestion.TabIndex = 3;
            this.lblContentQuestion.Text = "Content Question";
            this.lblContentQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgListIcon
            // 
            this.imgListIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListIcon.ImageStream")));
            this.imgListIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListIcon.Images.SetKeyName(0, "liveOff.png");
            this.imgListIcon.Images.SetKeyName(1, "liveOn.png");
            // 
            // timerTimeOut
            // 
            this.timerTimeOut.Interval = 1000;
            this.timerTimeOut.Tick += new System.EventHandler(this.timerTimeOut_Tick);
            // 
            // lblListPlayerWin
            // 
            this.lblListPlayerWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblListPlayerWin.Font = new System.Drawing.Font("UTM Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListPlayerWin.Location = new System.Drawing.Point(453, 12);
            this.lblListPlayerWin.Name = "lblListPlayerWin";
            this.lblListPlayerWin.Size = new System.Drawing.Size(278, 308);
            this.lblListPlayerWin.TabIndex = 43;
            this.lblListPlayerWin.Text = "List Player Win:";
            this.lblListPlayerWin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNotification
            // 
            this.btnNotification.BorderColor = System.Drawing.Color.Silver;
            this.btnNotification.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.btnNotification.FlatAppearance.BorderSize = 0;
            this.btnNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotification.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.Location = new System.Drawing.Point(75, 335);
            this.btnNotification.Margin = new System.Windows.Forms.Padding(4);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnNotification.OnHoverButtonColor = System.Drawing.Color.DodgerBlue;
            this.btnNotification.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnNotification.Size = new System.Drawing.Size(220, 46);
            this.btnNotification.TabIndex = 5;
            this.btnNotification.Text = "Notification";
            this.btnNotification.TextColor = System.Drawing.Color.White;
            this.btnNotification.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.BorderColor = System.Drawing.Color.Silver;
            this.btnC.ButtonColor = System.Drawing.Color.SeaShell;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Location = new System.Drawing.Point(4, 255);
            this.btnC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnC.Name = "btnC";
            this.btnC.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnC.OnHoverButtonColor = System.Drawing.Color.DodgerBlue;
            this.btnC.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnC.Size = new System.Drawing.Size(723, 59);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "C";
            this.btnC.TextColor = System.Drawing.Color.Black;
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            this.btnB.BorderColor = System.Drawing.Color.Silver;
            this.btnB.ButtonColor = System.Drawing.Color.SeaShell;
            this.btnB.FlatAppearance.BorderSize = 0;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Location = new System.Drawing.Point(3, 185);
            this.btnB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnB.Name = "btnB";
            this.btnB.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnB.OnHoverButtonColor = System.Drawing.Color.DodgerBlue;
            this.btnB.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnB.Size = new System.Drawing.Size(723, 59);
            this.btnB.TabIndex = 1;
            this.btnB.Text = "B";
            this.btnB.TextColor = System.Drawing.Color.Black;
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            this.btnA.BorderColor = System.Drawing.Color.Silver;
            this.btnA.ButtonColor = System.Drawing.Color.SeaShell;
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Location = new System.Drawing.Point(3, 111);
            this.btnA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnA.Name = "btnA";
            this.btnA.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnA.OnHoverButtonColor = System.Drawing.Color.DodgerBlue;
            this.btnA.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnA.Size = new System.Drawing.Size(723, 59);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "A";
            this.btnA.TextColor = System.Drawing.Color.Black;
            this.btnA.UseVisualStyleBackColor = true;
            // 
            // frmMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 721);
            this.Controls.Add(this.lblListPlayerWin);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMC_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pcbVideoStream)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlQusetionAndAnswer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbVideoStream;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnIconLive;
        private ePOSOne.btnProduct.Button_WOC btnNotification;
        private System.Windows.Forms.Panel pnlQusetionAndAnswer;
        private System.Windows.Forms.Label lblContentQuestion;
        private ePOSOne.btnProduct.Button_WOC btnC;
        private ePOSOne.btnProduct.Button_WOC btnB;
        private ePOSOne.btnProduct.Button_WOC btnA;
        private System.Windows.Forms.ImageList imgListIcon;
        private System.Windows.Forms.Timer timerTimeOut;
        private System.Windows.Forms.Label lblListPlayerWin;
        private CircularProgressBar.CircularProgressBar circularProgressBar;
        private System.Windows.Forms.Label lblNumberOfPlayer;
    }
}

