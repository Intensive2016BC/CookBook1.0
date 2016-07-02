using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CookBook.Models;
using CookBook.Managers;
using System.Windows.Forms;
using System.Data;

namespace CookBook.Managers
{
    public class UserManager
    {
        public List<User> GetList()
        {
            List<User> usersList = new List<User>();
            DatabaseManager dbManager = new DatabaseManager();
            DataTable users = dbManager.GetFullList("User");
            for (int i = 0; i < users.Rows.Count; i++)
            {
               User user = new User(users.Rows[i][0].ToString(), users.Rows[i][1].ToString(), Convert.ToBoolean(users.Rows[i][2]), int.Parse(users.Rows[i][3].ToString()), new List<int>());
               usersList.Add(user);
            }
            return usersList;
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
                    //for (int j = 0; j < recipes.Count; j++)
                    //{
                    //    if (!users[i].DoneIds.Contains(recipes[j]))
                    //    users[i].DoneIds.Add(recipes[j]);
                    //}
                    DatabaseManager dbManager = new DatabaseManager();
                    dbManager.Update("User", "Points", users[i].Points.ToString(), "Login", username);
                }
            }
        }

        public void CreateNewUser(string userName)
        {
            User newuser = new User(userName, "123", false, 0, new List<int>());
            if (CheckUsers(userName))
            {
                DatabaseManager dbManager = new DatabaseManager();
                dbManager.AddUser(newuser);
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
