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
        }

        private void dbsetting(object sender, RoutedEventArgs e)
        {
            dbsetting dbs = new dbsetting();
            Content = dbs;
        }

        private void menuClick(object sender, RoutedEventArgs e)
        {
            MenuItem mi = e.OriginalSource as MenuItem;
            XmlElement xe = mi.Header as XmlElement;
            string name = xe.Attributes["Name"].Value;
            string uid = xe.Attributes["Uid"].Value;
            string model = xe.Attributes["Model"].Value;
            MessageBox.Show(name);
            MessageBox.Show(uid);
            MessageBox.Show(model);
        }
    }
}
