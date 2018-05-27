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
    /// Interaction logic for AddNewAccountWindow.xaml
    /// </summary>
    public partial class AddNewSiteWindow : Window
    {
        public string userLogin = string.Empty;
        int addInfSwitch = 0;
        bool addAccount = false;

        public AddNewSiteWindow()
        {
            InitializeComponent();
        }

        private void AddNewAccountButton_Click(object sender, RoutedEventArgs e)
        {
            WCFDAL dal = new WCFDAL();
            var allSitesNames = dal.GetAllSitesNamesByLogin(userLogin);
            var allSitesReferences = dal.GetAllSitesReferencesByLogin(userLogin);
            bool exist = false;
            if (NameOfSiteTextBox.Text != string.Empty && ReferenceForSite.Text
                != string.Empty && DescriptionOfSite.Text != string.Empty)
            {
                foreach (var item in allSitesNames)
                {
                    if (item == NameOfSiteTextBox.Text)
                    {
                        exist = true;
                        MessageBox.Show("This name for site allready exist!");
                    }
                }
                foreach (var item in allSitesReferences)
                {
                    if (item == ReferenceForSite.Text)
                    {
                        exist = true;
                        MessageBox.Show("This site refernce allready exist!");
                    }
                }
                if (exist == false)
                {
                    
                    dal.AddSite(userLogin, NameOfSiteTextBox.Text, ReferenceForSite.Text, DescriptionOfSite.Text,
                        LoginForSiteTextBox.Text, PasswordForSiteTextBox.Text, addAccount);
                    this.Close();
                }
             }
             else
             {
                 MessageBox.Show("Enter all information");
             }
        }

        private void AdditionalInfoButton_Click(object sender, RoutedEventArgs e)
        {
            addInfSwitch++;
            if (addInfSwitch % 2 != 0)
            {
                LoginForSiteTextBox.IsEnabled = true;
                PasswordForSiteTextBox.IsEnabled = true;
                addAccount = true;
            }
            else
            {
                LoginForSiteTextBox.IsEnabled = false;
                PasswordForSiteTextBox.IsEnabled = false;
                addAccount = false;
            }
        }
    }
}
