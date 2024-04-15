using Welcome.Model;
using Welcome.Others;

namespace Welcome.ViewModel
{
    internal class UserViewModel
    {
        private User _user;

        public UserViewModel(User user)
        {
            _user = user;
        }

        public string Name
        {
            get { return _user.Name; }
            set { _user.Name = value; }
        }

        public string Role
        {
            get { return _user.Role.ToString(); }
        }
    }
}