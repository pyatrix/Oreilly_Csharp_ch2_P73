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
using System.Windows.Shapes;

namespace UseTheDebugger
{
    /// <summary>
    /// MainPage.xaml 的互動邏輯
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "Question";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            myLabel.Text = "name is " + name
                + " \nx is " + x
                + " \nd is " + d;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                myLabel.Text = "x must be 10";
            }
            else
            {
                myLabel.Text = "x isn't 10";
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 4;
            string name = "Bobbo Jr.";
            if ((someValue == 3) && (name == "Joe"))
            {
                myLabel.Text = "X is 3 and the name is Joe";
            }
            myLabel.Text = "this line runs no matter what";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            while (count < 100000000)
            {
                count = count + 1;
            }
            for (int i = 0; i < 99999923; i++)
            {
                count = count - 1;
            }
            myLabel.Text = "The answer is " + count;
        }


    }
}
