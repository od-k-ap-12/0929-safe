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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
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
        string Password = "12345";
        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.Text == Password)
            {
                MessageBox.Show("You opened it");
            }
        }

        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = "";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text += ((Button)sender).Content.ToString();
        }

    }
}
