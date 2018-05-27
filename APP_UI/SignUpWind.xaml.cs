using DAL;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace APP_UI
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUpWind : Window
    {
        WCFDAL dal = new WCFDAL();

        public SignUpWind()
        {
            InitializeComponent();
        }


        private void SignUpPasswordIcon_MouseEnter(object sender, MouseEventArgs e)
        {
            SignUpPasswordIcon.Foreground = Brushes.Blue;
            SignUpPasswordTextBox.Text = SignUpPasswordBoxEnter.Password;
            SignUpPasswordBoxEnter.Visibility = Visibility.Hidden;
            SignUpPasswordTextBox.Visibility = Visibility.Visible;
        }

        private void SignUpPasswordIcon_MouseLeave(object sender, MouseEventArgs e)
        {
            SignUpPasswordBoxEnter.Visibility = Visibility.Visible;
            SignUpPasswordTextBox.Visibility = Visibility.Hidden;
            SignUpPasswordIcon.Foreground = Brushes.Black;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (dal.CheckUserLogin(SignUpLogin.Text) == null)
            {
                dal.AddUser(SignUpLogin.Text, SignUpPasswordBoxEnter.Password);
                MessageBox.Show("Done");
                MainWindow wind = new MainWindow();
                wind.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("User with Login allready exist!");
            }
        }
    }
}