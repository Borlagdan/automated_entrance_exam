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
using MaterialDesignThemes.Wpf;

namespace Automated_Entrance_Exam.Windows
{
    /// <summary>
    /// Interaction logic for Scratch.xaml
    /// </summary>
    public partial class Scratch : Window
    {
        public Scratch()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            GroupBox groupBox = new GroupBox{ Height=500, Width=400 };
            StackPanel stackPanel = new StackPanel();
            TextBlock textBlock = new TextBlock();
            TextBox textBox = new TextBox();

            groupBox.Header = "Question #1";
            groupBox.Style = (Style)groupBox.FindResource("MaterialDesignCardGroupBox");
            
            textBlock.Text = "TextBlock";

            

            textBox.Width = 200;
            textBox.Height = 30;

            stackPanel.Children.Add(textBlock);
            stackPanel.Children.Add(textBox);

            groupBox.Content = stackPanel;

            this.grid.Children.Add(groupBox);
        }
    }
}
