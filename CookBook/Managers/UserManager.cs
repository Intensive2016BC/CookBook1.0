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

        public void ChangeUserPoints(string username, int points, List<int>recipes)
        {
            List<User> users = GetList();
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Login == username)
                {
                    users[i].Points += points;
                    for (int j = 0; j < recipes.Count; j++)
                    {
                        if (!users[i].DoneIds.Contains(recipes[j]))
                        users[i].DoneIds.Add(recipes[j]);
                    }
                }
            }
            WriteUsers(users);
        }

        public void WriteUsers(List<User>users)
        {
            using (StreamWriter sw = File.CreateText(Path))
            {
                for (int i = 0; i < users.Count; i++)
                {
                    sw.WriteLine(users[i].Login);
                    sw.WriteLine(users[i].Pass);
                    if (users[i].IsAdmin)sw.WriteLine("1");
                    else sw.WriteLine("0");
                    sw.WriteLine(users[i].Points);
                    for(int j = 0; j < users[i].DoneIds.Count; j++)
                    {
                        if (j != users[i].DoneIds.Count - 1)
                            sw.Write(users[i].DoneIds[j].ToString() + ",");
                        else
                        {
                            if (i != users.Count-1)
                            {
                                sw.WriteLine(users[i].DoneIds[j].ToString());
                            }
                            else sw.Write(users[i].DoneIds[j].ToString());
                        }
                    }
                }
            }
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
                    sw.Write("0");
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
            if (Level > 5) Level = 5;
            return Level;
        }
    }
}
