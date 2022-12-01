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
using BC = BCrypt.Net.BCrypt;

namespace bcrypt_test
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

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            tbx_hashedPWD.Text = BC.HashPassword(tbx_password.Text);
        }

        private void Check_Button_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show(
                BC.Verify(tbx_password_to_check.Text, tbx_hashedPWD.Text)
                ? "Passwords match"
                : "Passwords don't match"
            );

            /*
            string displayString;

            if(BC.Verify(tbx_password_to_check.Text, tbx_hashedPWD.Text))
            {
                displayString = "Passwords match";
            }
            else
            {
                displayString = "Passwords don't match";
            }
            
            
            MessageBox.Show(displayString);
            */
        }
    }
}