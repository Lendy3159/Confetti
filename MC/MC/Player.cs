using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace frmMC
{
    public class Player
    {
        public string nickName;
        public int correctNumber;
        public Socket socket;
        public string ip;
    }
    [Serializable]
    public class PlayerInfo
    {
        public string nickName;
        public string ip;
    }

    [Serializable]
    public class PlayerAnswer
    {
        public string nickName;
        public int answer;
    }
}
