using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAOLib;
namespace SpiderWatcher.model
{
    class TaskInfoItem {
        private string task = "task";
        private string lastTime = "20180516";
        private string ifGood = "Good";
        private string freq = "1day";

        public string Task { get => task; set => task = value; }
        public string LastTime { get => lastTime; set => lastTime = value; }
        public string IfGood { get => ifGood; set => ifGood = value; }
        public string Freq { get => freq; set => freq = value; }

        public TaskInfoItem(string s1, string s2, string s3, string s4)
        {
            Task = s1;
            lastTime = s2;
            freq = s3;
            IfGood = s4;
        }
    }
    class TaskInfo
    {
    }
}
