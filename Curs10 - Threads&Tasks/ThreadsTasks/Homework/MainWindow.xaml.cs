using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static bool isInitialized;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNormalExec_Click(object sender, RoutedEventArgs e)
        {
                lblMessage.Content = "Start";

                Thread.Sleep(10000);

                lblMessage.Content = "Stop";
        }

        private async void btnAsyncExec_Click(object sender, RoutedEventArgs e)
        {
            if (!isInitialized)
            {
                isInitialized = true;

                btnAsyncExec.IsEnabled = false;

                await btnAsyncRun();

                btnAsyncExec.IsEnabled = true;

                isInitialized = false;
            }
        }

        private async Task btnAsyncRun()
        {
            lblMessage.Content = "Start";

            await Task.Delay(10000);

            lblMessage.Content = "Stop";
        }
    }
}
