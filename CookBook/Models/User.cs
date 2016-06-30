using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookBook.Models
{
    public class User
    {
        public string Login { get; set; }
        public string Pass { get; set; }
        public bool IsAdmin { get; set; }
        public int Points { get; set; }
        public List<int> DoneIds { get; set; }

        public User(string log, string pass, bool isadm, int points, List<int> ids)
        {
            Login = log;
            Pass = pass;
            IsAdmin = isadm;
            Points = points;
            DoneIds = ids;
        }
    }
}
