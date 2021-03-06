using System;
using System.Collections.Generic;
using System.Text;

namespace XsiZero
{
    public class User
    {
        private string name;

        public string getName()
        {
            return this.name;
        }

        public void string setName(string name)
        {
            this.name = name;
        }

        public User()
        {
            this.name = name;
        }

        public User(string name)
        {
            this.name = name;
        }

        public string salut()
        {
            StringBuilder sb = new StringBuilder("Hello, ");
            sb.Append(this.name);
            sb.Append('!');
            return sb.ToString();
        }
    }
}
