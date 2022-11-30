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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PathBtn_Ag0_MouseEnter(object sender, MouseEventArgs e)
        {
            int a = 1;
        }

        private void PathBtn_Ag0_MouseLeave(object sender, MouseEventArgs e)
        {
            int a = 1;
        }

        private void PathBtn_Ag60_MouseEnter(object sender, MouseEventArgs e)
        {
            int a = 1;
        }

        private void PathBtn_Ag60_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int a = 1;
        }

        private void PathBtn_Ag60_Click(object sender, RoutedEventArgs e)
        {
            int a = 1;
        }

        private void PathBtn_Ag120_Click(object sender, RoutedEventArgs e)
        {
            int a = 1;
        }

        private void PathBtn_Ag120_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int a = 1;
        }

        private void PathBtn_Ag120_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int a = 1;
        }

        private void PathBtn_Ag120_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            int a = 1;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //PathBtn_Ag120.Click
            //Click = "PathBtn_Ag120_Click"
                PathBtn_Ag120.AddHandler(Button.ClickEvent ,new  RoutedEventHandler(PathBtn_Ag120_Click),true);
        }
    }
}
