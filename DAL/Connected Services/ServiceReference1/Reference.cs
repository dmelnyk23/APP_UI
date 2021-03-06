﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/WCF.DataContracts")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Account", Namespace="http://schemas.datacontract.org/2004/07/WCF.DataContracts")]
    [System.SerializableAttribute()]
    public partial class Account : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckUser", ReplyAction="http://tempuri.org/IService1/CheckUserResponse")]
        DAL.ServiceReference1.User CheckUser(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckUser", ReplyAction="http://tempuri.org/IService1/CheckUserResponse")]
        System.Threading.Tasks.Task<DAL.ServiceReference1.User> CheckUserAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckUserLogin", ReplyAction="http://tempuri.org/IService1/CheckUserLoginResponse")]
        DAL.ServiceReference1.User CheckUserLogin(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckUserLogin", ReplyAction="http://tempuri.org/IService1/CheckUserLoginResponse")]
        System.Threading.Tasks.Task<DAL.ServiceReference1.User> CheckUserLoginAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddUser", ReplyAction="http://tempuri.org/IService1/AddUserResponse")]
        void AddUser(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddUser", ReplyAction="http://tempuri.org/IService1/AddUserResponse")]
        System.Threading.Tasks.Task AddUserAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserByLogin", ReplyAction="http://tempuri.org/IService1/GetUserByLoginResponse")]
        DAL.ServiceReference1.User GetUserByLogin(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserByLogin", ReplyAction="http://tempuri.org/IService1/GetUserByLoginResponse")]
        System.Threading.Tasks.Task<DAL.ServiceReference1.User> GetUserByLoginAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllSitesNamesByLogin", ReplyAction="http://tempuri.org/IService1/GetAllSitesNamesByLoginResponse")]
        string[] GetAllSitesNamesByLogin(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllSitesNamesByLogin", ReplyAction="http://tempuri.org/IService1/GetAllSitesNamesByLoginResponse")]
        System.Threading.Tasks.Task<string[]> GetAllSitesNamesByLoginAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllSitesReferencesByLogin", ReplyAction="http://tempuri.org/IService1/GetAllSitesReferencesByLoginResponse")]
        string[] GetAllSitesReferencesByLogin(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllSitesReferencesByLogin", ReplyAction="http://tempuri.org/IService1/GetAllSitesReferencesByLoginResponse")]
        System.Threading.Tasks.Task<string[]> GetAllSitesReferencesByLoginAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddSite", ReplyAction="http://tempuri.org/IService1/AddSiteResponse")]
        void AddSite(string userLogin, string name, string reference, string description, string login, string password, bool addAcc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddSite", ReplyAction="http://tempuri.org/IService1/AddSiteResponse")]
        System.Threading.Tasks.Task AddSiteAsync(string userLogin, string name, string reference, string description, string login, string password, bool addAcc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddAccount", ReplyAction="http://tempuri.org/IService1/AddAccountResponse")]
        void AddAccount(string siteName, string accountLogin, string accountPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddAccount", ReplyAction="http://tempuri.org/IService1/AddAccountResponse")]
        System.Threading.Tasks.Task AddAccountAsync(string siteName, string accountLogin, string accountPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteSite", ReplyAction="http://tempuri.org/IService1/DeleteSiteResponse")]
        void DeleteSite(string siteName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteSite", ReplyAction="http://tempuri.org/IService1/DeleteSiteResponse")]
        System.Threading.Tasks.Task DeleteSiteAsync(string siteName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAccountBySite", ReplyAction="http://tempuri.org/IService1/DeleteAccountBySiteResponse")]
        void DeleteAccountBySite(int siteID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAccountBySite", ReplyAction="http://tempuri.org/IService1/DeleteAccountBySiteResponse")]
        System.Threading.Tasks.Task DeleteAccountBySiteAsync(int siteID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteUser", ReplyAction="http://tempuri.org/IService1/DeleteUserResponse")]
        void DeleteUser(DAL.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteUser", ReplyAction="http://tempuri.org/IService1/DeleteUserResponse")]
        System.Threading.Tasks.Task DeleteUserAsync(DAL.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllAccounts", ReplyAction="http://tempuri.org/IService1/GetAllAccountsResponse")]
        DAL.ServiceReference1.Account[] GetAllAccounts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllAccounts", ReplyAction="http://tempuri.org/IService1/GetAllAccountsResponse")]
        System.Threading.Tasks.Task<DAL.ServiceReference1.Account[]> GetAllAccountsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAccount", ReplyAction="http://tempuri.org/IService1/DeleteAccountResponse")]
        void DeleteAccount(DAL.ServiceReference1.Account account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAccount", ReplyAction="http://tempuri.org/IService1/DeleteAccountResponse")]
        System.Threading.Tasks.Task DeleteAccountAsync(DAL.ServiceReference1.Account account);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : DAL.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<DAL.ServiceReference1.IService1>, DAL.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DAL.ServiceReference1.User CheckUser(string login, string password) {
            return base.Channel.CheckUser(login, password);
        }
        
        public System.Threading.Tasks.Task<DAL.ServiceReference1.User> CheckUserAsync(string login, string password) {
            return base.Channel.CheckUserAsync(login, password);
        }
        
        public DAL.ServiceReference1.User CheckUserLogin(string login) {
            return base.Channel.CheckUserLogin(login);
        }
        
        public System.Threading.Tasks.Task<DAL.ServiceReference1.User> CheckUserLoginAsync(string login) {
            return base.Channel.CheckUserLoginAsync(login);
        }
        
        public void AddUser(string login, string password) {
            base.Channel.AddUser(login, password);
        }
        
        public System.Threading.Tasks.Task AddUserAsync(string login, string password) {
            return base.Channel.AddUserAsync(login, password);
        }
        
        public DAL.ServiceReference1.User GetUserByLogin(string login) {
            return base.Channel.GetUserByLogin(login);
        }
        
        public System.Threading.Tasks.Task<DAL.ServiceReference1.User> GetUserByLoginAsync(string login) {
            return base.Channel.GetUserByLoginAsync(login);
        }
        
        public string[] GetAllSitesNamesByLogin(string login) {
            return base.Channel.GetAllSitesNamesByLogin(login);
        }
        
        public System.Threading.Tasks.Task<string[]> GetAllSitesNamesByLoginAsync(string login) {
            return base.Channel.GetAllSitesNamesByLoginAsync(login);
        }
        
        public string[] GetAllSitesReferencesByLogin(string login) {
            return base.Channel.GetAllSitesReferencesByLogin(login);
        }
        
        public System.Threading.Tasks.Task<string[]> GetAllSitesReferencesByLoginAsync(string login) {
            return base.Channel.GetAllSitesReferencesByLoginAsync(login);
        }
        
        public void AddSite(string userLogin, string name, string reference, string description, string login, string password, bool addAcc) {
            base.Channel.AddSite(userLogin, name, reference, description, login, password, addAcc);
        }
        
        public System.Threading.Tasks.Task AddSiteAsync(string userLogin, string name, string reference, string description, string login, string password, bool addAcc) {
            return base.Channel.AddSiteAsync(userLogin, name, reference, description, login, password, addAcc);
        }
        
        public void AddAccount(string siteName, string accountLogin, string accountPassword) {
            base.Channel.AddAccount(siteName, accountLogin, accountPassword);
        }
        
        public System.Threading.Tasks.Task AddAccountAsync(string siteName, string accountLogin, string accountPassword) {
            return base.Channel.AddAccountAsync(siteName, accountLogin, accountPassword);
        }
        
        public void DeleteSite(string siteName) {
            base.Channel.DeleteSite(siteName);
        }
        
        public System.Threading.Tasks.Task DeleteSiteAsync(string siteName) {
            return base.Channel.DeleteSiteAsync(siteName);
        }
        
        public void DeleteAccountBySite(int siteID) {
            base.Channel.DeleteAccountBySite(siteID);
        }
        
        public System.Threading.Tasks.Task DeleteAccountBySiteAsync(int siteID) {
            return base.Channel.DeleteAccountBySiteAsync(siteID);
        }
        
        public void DeleteUser(DAL.ServiceReference1.User user) {
            base.Channel.DeleteUser(user);
        }
        
        public System.Threading.Tasks.Task DeleteUserAsync(DAL.ServiceReference1.User user) {
            return base.Channel.DeleteUserAsync(user);
        }
        
        public DAL.ServiceReference1.Account[] GetAllAccounts() {
            return base.Channel.GetAllAccounts();
        }
        
        public System.Threading.Tasks.Task<DAL.ServiceReference1.Account[]> GetAllAccountsAsync() {
            return base.Channel.GetAllAccountsAsync();
        }
        
        public void DeleteAccount(DAL.ServiceReference1.Account account) {
            base.Channel.DeleteAccount(account);
        }
        
        public System.Threading.Tasks.Task DeleteAccountAsync(DAL.ServiceReference1.Account account) {
            return base.Channel.DeleteAccountAsync(account);
        }
    }
}
