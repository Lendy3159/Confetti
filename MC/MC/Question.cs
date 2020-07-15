using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMC
{
    [Serializable]
    public class Question
    {
        public string question;
        public string linkImage;
        public int answer;
        public int numberOfQuestion;
        public List<string> Keys = new List<string>();
    }
}