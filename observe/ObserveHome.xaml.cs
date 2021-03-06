﻿using System;
using System.Collections.Generic;
using System.Data;
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
using DAOLib;
using SpiderWatcher.pages;
using System.Windows.Threading;
namespace SpiderWatcher.observe
{
    /// <summary>
    /// index.xaml 的交互逻辑
    /// </summary>
    public class doInfo
    {
        private string task = "task";
        private string lastTime = "20180516";
        private string ifGood = "Good";
        private string freq = "1day";

        public string Task { get => task; set => task = value; }
        public string LastTime { get => lastTime; set => lastTime = value; }
        public string IfGood { get => ifGood; set => ifGood = value; }
        public string Freq { get => freq; set => freq = value; }

        public doInfo(string s1, string s2, string s3, string s4)
        {
            Task = s1;
            lastTime = s2;
            freq = s3;
            IfGood = s4;
        }
    }
    /// <summary>
    /// ObserveHome.xaml 的交互逻辑
    /// </summary>
    public partial class ObserveHome : SpiderWatcher.BasePage
    {
        public ObserveHome()
        {
            InitializeComponent();
            InitList();
            DispatcherTimer dispatcher = new DispatcherTimer();
            dispatcher.Tick += new EventHandler(timer);
            dispatcher.Interval = new TimeSpan(0, 0, 60);
            dispatcher.Start();
        }

        private void timer(Object sender, EventArgs e)
        {
            //this.doInfoList.ItemsSource = null;
            this.doInfoList.Items.Clear();
            InitList();
        }

        private void InitList()
        {
            string sql = "select task,lastTime,1 as ifGood, freq from sys_task_info where ifdo =1";
            DataTable dt = dao.Ins.ExecuteDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.doInfoList.Items.Add(
                    new doInfo(
                        dt.Rows[i]["task"].ToString(),
                        dt.Rows[i]["lastTime"].ToString(),
                        dt.Rows[i]["freq"].ToString(),
                        dt.Rows[i]["ifGood"].ToString()
                        )
                    );
            }
        }

        private void TaskInfoAdd(object sender, RoutedEventArgs e)
        {
        }
    }
}
