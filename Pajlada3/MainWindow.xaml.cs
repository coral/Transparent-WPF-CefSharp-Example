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

namespace Pajlada3
{

    public partial class MainWindow : Window
    {
        public MainWindow(string url)
        {
            var w = System.Windows.SystemParameters.PrimaryScreenWidth;
            var h = System.Windows.SystemParameters.PrimaryScreenHeight;
            this.Width = w;
            this.Height = h;
            this.Topmost = true;
            this.Top = 0;
            this.Left = 0;
            InitializeComponent();

            web.Address = url;
            

            
        }
    }
}
