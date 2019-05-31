using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZWM.Classes
{
    class UserClass
    {
        private string name;

        public string NameProperty
        {
            get { return name; }
            set { name = value; }
        }

        private string surname;

        public string SurnameProperty
        {
            get { return surname; }
            set { surname = value; }
        }

        private string login;

        public string LoginProperty
        {
            get { return login; }
            set { login = value; }
        }

        private string password;

        public string PasswordProperty
        {
            get { return password; }
            set { password = value; }
        }

        public UserClass(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public UserClass(string name, string surname, string login, string password)
        {
            this.name = name;
            this.surname = surname;
            this.login = login;
            this.password = password;
        }
    }
}
