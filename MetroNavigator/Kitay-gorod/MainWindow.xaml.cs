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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kitay_gorod
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            image2.Visibility = Visibility.Hidden;
            image1.Visibility = System.Windows.Visibility.Visible;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            image2.Visibility = Visibility.Visible;
            image1.Visibility = Visibility.Hidden;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            image1.Visibility = System.Windows.Visibility.Visible;
            image2.Visibility = Visibility.Visible;
        }
    }
}
