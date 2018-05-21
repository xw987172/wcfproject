using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SpiderWatcher
{
    public class BasePage:Page
    {
        private MainWindow _parentWin;

        public MainWindow ParentWin { get => _parentWin; set => _parentWin = value; }
    }
}
