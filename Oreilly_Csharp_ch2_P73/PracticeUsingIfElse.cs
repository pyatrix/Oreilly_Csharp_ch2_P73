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

namespace UseTheDebugger
{
    public partial class MainPage : Window
    {
        private void EnableCheckbox_Click(object sender, RoutedEventArgs e)
        {
            if (enableCheckbox.IsChecked == true)
            {
                if (labelToChange.Text == "Right")
                {
                    labelToChange.HorizontalAlignment = HorizontalAlignment.Left;
                    labelToChange.Text = "Left";
                }
                else
                {
                    labelToChange.HorizontalAlignment = HorizontalAlignment.Right
                        ;
                    labelToChange.Text = "Right";
                }
            }
            else
            {
                labelToChange.Text = "";
                labelToChange.HorizontalAlignment = HorizontalAlignment.Center;
                labelToChange.Text = "Text Changeing is disabled";
            }
        }
    }
}
