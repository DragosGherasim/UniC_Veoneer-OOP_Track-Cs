﻿using System;
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
            isInitialized = true;
            InitializeComponent();
        }

        private void btnNormalExec_Click(object sender, RoutedEventArgs e)
        {
            if (isInitialized)
            {
                lblMessage.Content = "Start";

                Thread.Sleep(10000);

                lblMessage.Content = "Stop";

                isInitialized = false;
            }
        }

        private async void btnAsyncExec_Click(object sender, RoutedEventArgs e)
        {
            await btnAsyncRun();
        }

        private async Task btnAsyncRun()
        {
            lblMessage.Content = "Start";

            await Task.Delay(10000);

            lblMessage.Content = "Stop";
        }
    }
}
