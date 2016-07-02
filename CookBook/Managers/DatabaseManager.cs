using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;
using CookBook.Managers;
using CookBook.Models;
using System.Drawing;

namespace CookBook.Managers
{
    public class DatabaseManager
    {
        public DatabaseManager()
        { 
            sql = new SQLiteConnection("Data Source=Database.sqlite;Version=3");
        }
        SQLiteConnection sql;

        public void CreateDataBase()
        {
            if (!File.Exists(@"Database.sqlite"))
            {
                SQLiteConnection.CreateFile(@"Database.sqlite");
                SQLiteCommand user = new SQLiteCommand("create table if not exists User (Login TEXT PRIMARY KEY, Pass TEXT, IsAdmin BOOL, Points int)", sql);
                SQLiteCommand category = new SQLiteCommand("create table Category(id INTEGER PRIMARY KEY, Name TEXT, Level INTEGER)", sql);
                SQLiteCommand recipe = new SQLiteCommand("create table Recipe(id INTEGER PRIMARY KEY, Image BLOB, Name TEXT, Ingredients TEXT, Description TEXT, Level INTEGER, Points INTEGER, Category INTEGER, CONSTRAINT recipe_cat_fk FOREIGN KEY (Category) references Category(id) on delete cascade)", sql);
                SQLiteCommand userrecipe = new SQLiteCommand("create table UserRecipe(User TEXT, Recipe INTEGER)", sql);
                sql.Open();
                user.ExecuteNonQuery();
                category.ExecuteNonQuery();
                recipe.ExecuteNonQuery();
                userrecipe.ExecuteNonQuery();
                sql.Close();
            }
        }

        public DataTable GetFullList(string tablename)
        {
            SQLiteCommand command = new SQLiteCommand(String.Format("select * from {0}", tablename), sql);
            sql.Open();
            SQLiteDataReader reader = command.ExecuteReader();
            DataTable FullList = new DataTable();
            FullList.Load(reader);
            sql.Close();
            return FullList;
        }

        public void AddUser(User user)
        {
            string sqlCommand = String.Format("insert into User values (\'{0}\', \'{1}\', \'{2}\', {3})", user.Login, user.Pass, user.IsAdmin, user.Points);
            SQLiteCommand command = new SQLiteCommand(sqlCommand, sql);
            sql.Open();
            command.ExecuteNonQuery();
            sql.Close();
        }

        public void AddCategory(Category cat)
        {
            string sqlCommand = String.Format("insert into Category values ({0}, \'{1}\', {2})", cat.Id, cat.Name, cat.Level);
            SQLiteCommand command = new SQLiteCommand(sqlCommand, sql);
            sql.Open();
            command.ExecuteNonQuery();
            sql.Close();
        }

        public void AddRecipe(Recipe recipe)
        {
            Image photo = recipe.Image;
            byte[] pic;
            using (MemoryStream ms = new MemoryStream())
            {
                photo.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                pic = ms.ToArray();
            }
            string ingreds = "";
            for (int i = 0;  i < recipe.Ingredients.Count; i++)
            {
                if (i != recipe.Ingredients.Count - 1) ingreds += recipe.Ingredients[i] + ",";
                else ingreds += recipe.Ingredients[i];
            }
            string sqlCommand = String.Format("insert into Recipe values ({0}, (@0), \'{1}\', \'{2}\', \'{3}\', {4}, {5}, {6})", recipe.Id, recipe.Name, ingreds, recipe.Description, recipe.Level, recipe.Points, recipe.CategoryId);
            SQLiteCommand cmd = new SQLiteCommand(sqlCommand, sql);
            SQLiteParameter param = new SQLiteParameter("@0", System.Data.DbType.Binary);
            param.Value = pic;
            cmd.Parameters.Add(param);
            sql.Open();
            cmd.ExecuteNonQuery();
            sql.Close();
        }

        public void Delete(string tablename, string query)
        {
            SQLiteCommand command = new SQLiteCommand(String.Format("delete from {0} where {1}", tablename, query), sql);
            sql.Open();
            command.ExecuteNonQuery();
            sql.Close();
            if (tablename == "Category")
            {
                Delete("Recipe", "Category = " + query.Substring(query.IndexOf('=') + 1));
            }
        }

        public void Update(string table, string nameOfLine, string value, string key, string keyValue)
        {
            SQLiteCommand command = new SQLiteCommand(String.Format("update {0} set {1} = \'{2}\' where {3} = \'{4}\'", table, nameOfLine, value, key, keyValue), sql);
            sql.Open();
            command.ExecuteNonQuery();
            sql.Close();
        }

        public DataTable Request(string table, string query)
        {
            SQLiteCommand command = new SQLiteCommand(String.Format("select * from {0} where {1}", table, query), sql);
            sql.Open();
            SQLiteDataReader reader = command.ExecuteReader();
            DataTable TableForResult = new DataTable();
            TableForResult.Load(reader);
            sql.Close();
            return TableForResult;
        }

    }
}
