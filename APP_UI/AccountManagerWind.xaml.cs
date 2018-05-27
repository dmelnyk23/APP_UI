using DAL;
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

namespace APP_UI
{
    /// <summary>
    /// Interaction logic for AccountManagerWind.xaml
    /// </summary>
    public partial class AccountManagerWind : Window
    {
        WCFDAL dal = new WCFDAL();
        public string userLogin = string.Empty;

        string siteName;

        public AccountManagerWind()
        {
            InitializeComponent();
        }

        private void AddNewSite_Click(object sender, RoutedEventArgs e)
        {
            AddNewSiteWindow wind = new AddNewSiteWindow();
            wind.userLogin = userLogin;
            wind.Show();
        }

        private void ViewAllSites_Click(object sender, RoutedEventArgs e)
        {
            GetSitesNames();
        }

        private void AddNewAccount_Click(object sender, RoutedEventArgs e)
        {
            if (siteName == string.Empty)
            {
                MessageBox.Show("Choose the site to add account to it!");
            }
            else
            {
                AddNewAccountWind wind = new AddNewAccountWind();
                wind.siteName = siteName;
                wind.Show();
            }
        }

        ////////////
        private void UpdateAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteSite_Click(object sender, RoutedEventArgs e)
        {
            dal.DeleteSite(siteName);
        }

        private void UpdateSite_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            siteName = SiteList.SelectedItem as String;
        }


        public void GetSitesNames()
        {
            SiteList.Items.Clear();
            var all = dal.GetAllSitesNamesByLogin(userLogin);
            foreach (var item in all)
            {
                SiteList.Items.Add(item);
            }
        }
    }
}
