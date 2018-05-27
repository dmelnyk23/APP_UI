using DAL.ServiceReference1;

namespace DAL
{
    public class WCFDAL
    {
        private readonly Service1Client _service = new Service1Client();

        public User CheckUser(string login, string password)
        {
            return _service.CheckUser(login, password);
        }

        public User CheckUserLogin(string login)
        {
            return _service.CheckUserLogin(login);
        }

        public void AddUser(string login, string password)
        {
            _service.AddUser(login, password);
        }

        public string[] GetAllSitesNamesByLogin(string login)
        {
            return _service.GetAllSitesNamesByLogin(login);
        }

        public string[] GetAllSitesReferencesByLogin(string login)
        {
            return _service.GetAllSitesReferencesByLogin(login);
        }

        public void AddSite(string userLogin, string name, string reference, string description,
                                      string login, string password, bool addAcc)
        {
            _service.AddSite(userLogin, name, reference, description,
                                      login, password, addAcc);
        }

        public void AddAccount(string siteName, string accountLogin, string accountPassworf)
        {
            _service.AddAccount(siteName, accountLogin, accountPassworf);
        }





        public void DeleteUser(User user)
        {
            _service.DeleteUser(user);
        }

        public Account[] GetAllAccounts()
        {
            return _service.GetAllAccounts();
        }



        public void DeleteAccount(Account account)
        {
            _service.DeleteAccount(account);
        }

        public void DeleteSite(string siteName)
        {
            _service.DeleteSite(siteName);
        }

    }
}
