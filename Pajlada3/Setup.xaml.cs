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
using System.Windows.Shapes;
using System.Diagnostics;

namespace Pajlada3
{
    /// <summary>
    /// Interaction logic for Setup.xaml
    /// </summary>
    public partial class Setup : Window
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine(txtURL.Text);
            MainWindow main = new MainWindow(txtURL.Text);
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            txtURL.SelectAll();
            txtURL.Focus();
        }


    }
}
