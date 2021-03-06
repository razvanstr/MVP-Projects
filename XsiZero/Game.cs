using System;
using System.Collections.Generic;
using System.Text;

namespace XsiZero
{
    public class Game
    {
        private DateTime startDate;
        private User user;
        public Game(User user)
        {
            this.startDate = DateTime.Now;
            this.user = user;
        }
        public string salut()
        {
            StringBuilder sb = new StringBuilder("Salut, ");
            sb.Append(this.user.getName());
            sb.Append("! Jocul a inceput la ora: ");
            sb.Append(this.startDate.Hour).Append(':').Append(this.startDate.Minute);
            return sb.ToString();
        }
    }
}
