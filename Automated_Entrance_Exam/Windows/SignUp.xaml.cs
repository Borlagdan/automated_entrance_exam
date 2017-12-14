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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace Automated_Entrance_Exam.Windows
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : MetroWindow
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            f_SignUp.NavigationService.Navigate(new Pages.SignUp.SignUp());
        }

        private void btn_Next_Click(object sender, RoutedEventArgs e)
        {
            // this.ShowMessageAsync("This is the title", "Some message");

            f_SignUp.NavigationService.Navigate(new Pages.SignUp.Success());
            btn_Next.Content = "Finish";
        }
    }
}
