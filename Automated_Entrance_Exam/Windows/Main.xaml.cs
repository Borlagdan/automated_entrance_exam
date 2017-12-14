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

namespace Automated_Entrance_Exam.Pages.Main
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            f_Main.NavigationService.Navigate(new Pages.Main.Overview());
        }

        private void btn_Overview_Click(object sender, RoutedEventArgs e)
        {
            f_Main.NavigationService.Navigate(new Pages.Main.Overview());
        }

        private void btn_Examinees_Click(object sender, RoutedEventArgs e)
        {
            f_Main.NavigationService.Navigate(new Pages.Main.Examinees());
        }

        private void btn_Examinations_Click(object sender, RoutedEventArgs e)
        {
            f_Main.NavigationService.Navigate(new Pages.Main.Examinations());
        }

        private void btn_Settings_Click(object sender, RoutedEventArgs e)
        {
            f_Main.NavigationService.Navigate(new Pages.Main.Settings());
        }

        private void btn_Logout_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
