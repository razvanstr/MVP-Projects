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

        public void setName(string name)
        {
            this.name = name;
        }

        public User()
        {
            
        }

        public User(string name)
        {
            this.name = name;
        }       
    }
}