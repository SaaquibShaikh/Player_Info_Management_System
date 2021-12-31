﻿using System;
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

namespace PlayerInfoMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void asAdmin_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Owner = this;
            asAdmin.Visibility = Visibility.Collapsed;
            asGuest.Visibility = Visibility.Collapsed;
            login.Show();
            
        }

        private void asGuest_Click(object sender, RoutedEventArgs e)
        {
            
        }

        //Exit on window close button
        private void windowClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        // Right click to minimize
        private void windowClose_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        //Navbar Home button actions
        private void radioHome_Click(object sender, RoutedEventArgs e)
        {
            asAdmin.Visibility = Visibility.Collapsed;
            asGuest.Visibility = Visibility.Collapsed;
        }

        //Navbar Home button actions
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {

        }

        //Navbar Home button actions
        private void radioTournaments_Click(object sender, RoutedEventArgs e)
        {

        }

        //Navbar Home button actions
        private void radioTeams_Click(object sender, RoutedEventArgs e)
        {

        }

        //Navbar Home button actions
        private void radioLogin_Click(object sender, RoutedEventArgs e)
        {
            asAdmin.Visibility = Visibility.Visible;
            asGuest.Visibility = Visibility.Visible;
        }
    }
}