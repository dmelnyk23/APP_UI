using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using DAL;

namespace APP_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        WCFDAL dal = new WCFDAL();

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            SignUpWind signUp = new SignUpWind();
            signUp.Show();
            this.Close();
        }

        private void SignInButtonClick(object sender, RoutedEventArgs e)
        {
           if (dal.CheckUser(LoginTextBox.Text,
               PasswordBoxEnter.Password) != null)
           {
             AccountManagerWind wind = new AccountManagerWind();
             wind.userLogin = LoginTextBox.Text;
             wind.Show();
             this.Close();
           }
           else
           {
               MessageBox.Show("Invalid data");
           }
        }

        private void PasswordIcon_MouseEnter(object sender, MouseEventArgs e)
        {
            PasswordIcon.Foreground = Brushes.Blue;
            PasswordTextBox.Text = PasswordBoxEnter.Password;
            PasswordBoxEnter.Visibility = Visibility.Hidden;
            PasswordTextBox.Visibility = Visibility.Visible;
        }

        private void PasswordIcon_MouseLeave(object sender, MouseEventArgs e)
        {
            PasswordBoxEnter.Visibility = Visibility.Visible;
            PasswordTextBox.Visibility = Visibility.Hidden;
            PasswordIcon.Foreground = Brushes.Black;
        }
    }
}
