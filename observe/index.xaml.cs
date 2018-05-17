using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SpiderWatcher.observe
{
    /// <summary>
    /// index.xaml 的交互逻辑
    /// </summary>
    public class doInfo {
        private string task = "task";
        private string lastTime = "20180516";
        private string ifGood = "Good";
        private string freq = "1day";

        public string Task { get => task; set => task = value; }
        public string LastTime { get => lastTime; set => lastTime = value; }
        public string IfGood { get => ifGood; set => ifGood = value; }
        public string Freq { get => freq; set => freq = value; }

        public doInfo(string s1,string s2,string s3,string s4)
        {
            Task = s1;
            lastTime = s2;
            freq = s3;
            IfGood = s4;
        }
    }
    public partial class index : Page
    {
        public index()
        {
            InitializeComponent();
            InitList();
        }

        private void InitList() {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    this.doInfoList.Items.Add(new doInfo("天气日频"+(i*j).ToString(), "2018-05-16", "1 day", "Good"));
                }
            }
        }
    }
}
