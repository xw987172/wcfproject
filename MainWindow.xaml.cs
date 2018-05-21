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
using System.Xml;
using SpiderWatcher.pages;
using SpiderWatcher.observe;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Threading;
using DAOLib;
using System.Data;

namespace SpiderWatcher
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //消息定时器
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(Msg);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 60);
            dispatcherTimer.Start();
        }

        private void Msg(object sender,EventArgs e) {
            string sql = "select * from spider.message order by id desc limit 1";
            DataSet dset = new DataSet();
            dset = dao.Ins.ExecuteDataSet(sql);
            DataRow dRow = dset.Tables[0].Rows[0];
            string msg = dRow["message"] + "\t" + dRow["createtime"].ToString();
            this.msg.Content = msg;
        }

        private void Navigate(string path)
        {
            string uri = "SpiderWatcher." + path;
            Type type = Type.GetType(uri);
            if (type != null) {
                object obj = type.Assembly.CreateInstance(uri);
                Page uControl = obj as Page;
                this.mainFrame.Content = uControl;
                PropertyInfo[] infos = type.GetProperties();
                foreach (PropertyInfo info in infos) {
                    if (info.Name == "ParentWin") {
                        info.SetValue(uControl, this, null);
                        break;
                    }
                }
            }
        }

        private void menuClick(object sender, RoutedEventArgs e)
        {
            MenuItem mi = e.OriginalSource as MenuItem;
            XmlElement xe = mi.Header as XmlElement;
            string name = xe.Attributes["Name"].Value;
            string uid = xe.Attributes["Uid"].Value;
            string model = xe.Attributes["Model"].Value;
            Navigate(uid);
        }

        //private void ShowPage(string title, string uri)
        //{
        //    NavigationWindow window = new NavigationWindow();
        //    window.Title = title;
        //    window.Width = 300;
        //    window.Height = 200;
        //    window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        //    window.ResizeMode = ResizeMode.NoResize;
        //    window.Source = new Uri(uri, UriKind.Relative);
        //    window.ShowsNavigationUI = false;
        //    window.Show();
        //}
        public void callFromChild(string name)
        {
            MessageBox.Show("hello, "+name+ "!");
        }
    }
}
