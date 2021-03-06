using System;
using System.Collections.Generic;
using System.Text;

namespace XsiZero
{
    public class Utils
    {
        public static string StartJoc(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return "Introduceti un nume!";
            }

            User user = new User(name);
            Game game = new Game(user);
            return game.salut();
        }

    }
}
