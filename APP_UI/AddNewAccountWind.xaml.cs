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
using DAL;

namespace APP_UI
{
    /// <summary>
    /// Interaction logic for AddNewAccountWind.xaml
    /// </summary>
    public partial class AddNewAccountWind : Window
    {
        public string siteName = string.Empty;

        public AddNewAccountWind()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            WCFDAL dal = new WCFDAL();
            dal.AddAccount(siteName, LoginForSiteTextBox.Text, PasswordForSiteTextBox.Text);
            this.Close();
        }
    }
}
