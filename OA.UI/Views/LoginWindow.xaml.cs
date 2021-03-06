﻿using Ay.Framework.WPF.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OA.UI.Views
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : AyWindow
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnMinWindow_Click(object sender, RoutedEventArgs e)
        {
            base.MinWindowOperation();
        }

        private void btnCloseWindow_Click(object sender, RoutedEventArgs e)
        {
            base.CloseWindowOperate();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
          
            m.Show();
            this.Close();
        }
    }
}
