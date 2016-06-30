using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CookBook.Models;
using System.Windows.Forms;

namespace CookBook.Managers
{
    public class UserManager
    {
        public string Path = AppDomain.CurrentDomain.BaseDirectory + "Users.txt";
        public List<User> GetList()
        {
            List<User> usersList = new List<User>();
            using (StreamReader sr = new StreamReader(Path))
            {
                string line;
                int counter = 0;
                string[] userAttrs = new string[5];

                while ((line = sr.ReadLine()) != null)
                {
                    userAttrs[counter] = line;
                    counter++;
                    if (counter == 5)
                    {
                        List<int> ids = userAttrs[4].Split(',').Select(i => int.Parse(i)).ToList();
                        usersList.Add(new User(userAttrs[0], userAttrs[1], int.Parse(userAttrs[2]) == 1, int.Parse(userAttrs[3]), ids));
                        counter = 0;
                    }
                }
                return usersList;
            }
        }

        public bool CheckUsers(string userName)
        {
            List<User> usersList = GetList();
            if (usersList.Any(user => user.Login.Equals(userName, StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }
            return true;
        }

        public void CreateNewUser(string userName)
        {
            List<int> ids = new List<int>();
            User newuser = new User(userName, "123", false, 0, ids);
            if (CheckUsers(userName))
            {
                using (StreamWriter sw = File.AppendText(Path))
                {
                    sw.WriteLine();
                    sw.WriteLine(newuser.Login);
                    sw.WriteLine(newuser.Pass);
                    sw.WriteLine("0");
                    sw.WriteLine("0");
                    sw.Write("1");
                }
                MessageBox.Show("Пользователь успешно добавлен!");
            }
            else
            {
                MessageBox.Show("Пользователь с такими именем уже существует");
            }
        }

        public int GetLevel(int points)
        {
            int Level = (int)Math.Log(points / 10, 2)+1;
            if (points < 10) Level = 1;
            return Level;
        }
    }
}
