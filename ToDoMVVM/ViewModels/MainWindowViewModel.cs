namespace ToDoMVVM.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _userName;

        public string  UserName
        {
            get { return _userName = "test"; }
            set { _userName = value ; }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

     

        public string labelUserName => "UserName";
        public string labelPassword => "Password";

    }
}
