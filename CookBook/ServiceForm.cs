using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CookBook.Managers;
using CookBook.Models;

namespace CookBook
{
    public partial class ServiceForm : Form
    {
        int x = 10;
        int y = 10;
        int number = 0;
        public string recordId;
        string entity = "";
        public string mission = "";
        public bool cancel;
        Label[] labels = new Label[8];
        TextBox[] fields = new TextBox[8];
        RichTextBox[] bigFields = new RichTextBox[2];
        Button buttonOk = new Button();
        Button buttonCancel = new Button();
        
        public ServiceForm(string tablename)
        {
            entity = tablename;
            InitializeComponent();
            this.AutoSize = true;
            this.BackColor = Color.Peru;
            cancel = false;
            buttonOk.Click += new EventHandler(buttonOk_Click);
            buttonCancel.Click += new EventHandler(buttonCancel_Click);
            buttonOk.Text = "Ok";
            buttonOk.Name = "buttonOk";
            buttonOk.BackColor = Color.Transparent;
            buttonOk.FlatStyle = FlatStyle.Flat;
            buttonOk.FlatAppearance.BorderSize = 0;
            buttonOk.FlatAppearance.MouseOverBackColor = Color.AntiqueWhite;
            buttonOk.Font = new Font("Candara", 12, FontStyle.Regular);
            buttonCancel.Text = "Отмена";
            buttonCancel.Name = "buttonCancel";
            buttonCancel.BackColor = Color.Transparent;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatAppearance.MouseOverBackColor = Color.AntiqueWhite;
            buttonCancel.Font = new Font("Candara", 12, FontStyle.Regular);
            for (int i = 0; i < 8; i++)
            {
                labels[i] = new Label();
                labels[i].Width = 200;
                labels[i].BackColor = Color.Transparent;
                labels[i].Font = new Font("Candara", 12, FontStyle.Regular);
                fields[i] = new TextBox();
                fields[i].Width = 300;
                fields[i].Font = new Font("Candara", 12, FontStyle.Regular);
            }
            bigFields[0] = new RichTextBox();
            bigFields[0].Width = 300;
            bigFields[0].Height = 100;
            bigFields[0].Font = new Font("Candara", 12, FontStyle.Regular);
            bigFields[1] = new RichTextBox();
            bigFields[1].Width = 300;
            bigFields[1].Height = 100;
            bigFields[1].Font = new Font("Candara", 12, FontStyle.Regular);
            switch (tablename)
            {
                case "Ingredients":
                    {
                        number = 2;
                        labels[0].Text = "ID";
                        labels[1].Text = "Название";
                        for (int i = 0; i < number; i++)
                        {
                            labels[i].Location = new Point(x, y);
                            fields[i].Location = new Point(x + 200, y);
                            y += 40;
                            this.Controls.Add(labels[i]);
                            this.Controls.Add(fields[i]);
                        }
                        break;
                    }
                case "User":
                    {
                        number = 4;
                        labels[0].Text = "Логин";
                        labels[1].Text = "Пароль";
                        labels[2].Text = "Администратор?";
                        labels[3].Text = "Количество баллов";
                        for (int i = 0; i < number; i++)
                        {
                            labels[i].Location = new Point(x, y);
                            fields[i].Location = new Point(x + 200, y);
                            y += 40;
                            this.Controls.Add(labels[i]);
                            this.Controls.Add(fields[i]);
                        }
                        fields[3].Enabled = false;
                        if (mission != "edit") fields[3].Text = "0";
                        break;
                    }
                case "Category":
                    {
                        number = 3;
                        labels[0].Text = "ID";
                        labels[1].Text = "Название";
                        labels[2].Text = "Уровень";
                        for (int i = 0; i < number; i++)
                        {
                            labels[i].Location = new Point(x, y);
                            fields[i].Location = new Point(x + 200, y);
                            y += 40;
                            this.Controls.Add(labels[i]);
                            this.Controls.Add(fields[i]);
                        }
                        break;
                    }
                case "Recipe":
                    {
                        number = 8;
                        labels[0].Text = "ID";
                        labels[1].Text = "Путь к фотографии блюда";
                        labels[2].Text = "Название";
                        labels[3].Text = "Ингредиенты через запятую";
                        labels[4].Text = "Рецепт";
                        labels[5].Text = "Уровень";
                        labels[6].Text = "Количество баллов";
                        labels[7].Text = "Номер категории";
                        for (int i = 0; i < number; i++)
                        {
                            labels[i].Location = new Point(x, y);
                            fields[i].Location = new Point(x + 200, y);
                            if (i == 3 || i == 4)
                            {
                                bigFields[i-3].Location = new Point(x+200, y);
                                y += 100;
                                this.Controls.Add(bigFields[i-3]);
                            }
                            y += 40;
                            this.Controls.Add(labels[i]);
                            if (i!=3 && i!=4) this.Controls.Add(fields[i]);
                        }
                        break;
                    }
            }
            buttonOk.Location = new Point(x, y);
            this.Controls.Add(buttonOk);
            buttonCancel.Location = new Point(x + 200, y);
            this.Controls.Add(buttonCancel);
        }
        
        private void buttonOk_Click(object sender, EventArgs e)
        {
            switch (entity)
            {
                case "Ingredients":
                    {
                        try
                        {
                            number = 2;
                            for (int i = 0; i < number; i++)
                            {
                                if (fields[i].Text == "")
                                { throw new System.ArgumentException("Не все данные введены!"); }
                            }
                            int.Parse(fields[0].Text);
                            InsertingEditing();
                            DialogResult = DialogResult.OK;
                        }
                        catch (Exception ex)
                        {
                            InfoForm iform = new InfoForm(ex.Message);
                            iform.Show();
                        }
                        break;
                    }
                case "User":
                    {
                        try
                        {
                            number = 4;
                            for (int i = 0; i < number; i++)
                            {
                                if (fields[i].Text == "")
                                { throw new System.ArgumentException("Не все данные введены!"); }
                            }
                            int.Parse(fields[3].Text);
                            if (fields[2].Text == "True") fields[2].Text = "1";
                            if (fields[2].Text == "False") fields[2].Text = "0";
                            if (fields[2].Text != "0" && fields[2].Text != "1")
                            { throw new System.ArgumentException("Неверный ввод!"); }
                            InsertingEditing();
                            DialogResult = DialogResult.OK;
                        }
                        catch (Exception ex)
                        {
                            InfoForm iform = new InfoForm(ex.Message);
                            iform.Show();
                        }
                        break;
                    }
                case "Recipe":
                    {
                        try
                        {
                            number = 8;
                            for (int i = 0; i < number; i++)
                            {
                                if ((fields[i].Text == "" && i!=3 && i!=4)||(bigFields[0].Text == "")||(bigFields[1].Text == ""))
                                { throw new System.ArgumentException("Не все данные введены!"); }
                                if (i == 0 || i == 5 || i == 6 || i == 7) int.Parse(fields[i].Text);
                            }
                            DatabaseManager dbManager = new DatabaseManager();
                            if (mission == "insert")
                            {
                                if (!fields[1].Text.EndsWith(".jpg") && !fields[1].Text.EndsWith(".jpeg"))
                                { throw new Exception("Файл изображения должен быть в формате JPG!"); }
                            }
                            if (dbManager.Request("Category", "id =" + fields[7].Text).Rows.Count == 0)
                            { throw new Exception("Не существует такой категории!"); }
                            InsertingEditing();
                            DialogResult = DialogResult.OK;
                        }
                        catch (Exception ex)
                        {
                            InfoForm iform = new InfoForm(ex.Message);
                            iform.Show();
                        }
                        break;
                    }
                case "Category":
                    {
                        try
                        {
                            number = 3;
                            for (int i = 0; i < number; i++)
                            {
                                if (fields[i].Text == "") { throw new System.ArgumentException("Не все данные введены!"); }
                            }
                            int.Parse(fields[0].Text);
                            int.Parse(fields[2].Text);
                            InsertingEditing();
                            DialogResult = DialogResult.OK;
                        }
                        catch (Exception ex)
                        {
                            InfoForm iform = new InfoForm(ex.Message);
                            iform.Show();
                        }
                        break;
                    }
            }
        }
        
        private void InsertingEditing()
        {
            switch (mission)
            {
                case "insert":
                    {
                        try
                        {
                            DatabaseManager dbManager = new DatabaseManager();
                            switch (entity)
                            {
                                case "Ingredients":
                                    {
                                        if (dbManager.CheckId("id="+fields[0].Text, entity))
                                        {
                                            throw new Exception("Такой id уже существует!");
                                        }
                                        dbManager.AddIngred(fields[0].Text, fields[1].Text);
                                        break;
                                    }
                                case "User":
                                    {
                                        if (dbManager.CheckId("Login='" + fields[0].Text+"'", entity))
                                        {
                                            throw new Exception("Такой логин уже существует!");
                                        }
                                        bool iA = false;
                                        if (fields[2].Text == "0" || fields[2].Text == "False") iA = false;
                                        if (fields[2].Text == "1" || fields[2].Text == "True") iA = true;
                                        User user = new User(fields[0].Text, fields[1].Text, iA, int.Parse(fields[3].Text), null);
                                        dbManager.AddUser(user);
                                        break;
                                    }
                                case "Category":
                                    {
                                        if (dbManager.CheckId("id=" + fields[0].Text, entity))
                                        {
                                            throw new Exception("Такой ID уже существует!");
                                        }
                                        if (dbManager.CheckId("Name='" + fields[1].Text+"'", entity))
                                        {
                                            throw new Exception("Такое название уже существует!");
                                        }
                                        Category cat = new Category(int.Parse(fields[0].Text), fields[1].Text, int.Parse(fields[2].Text));
                                        dbManager.AddCategory(cat);
                                        break;
                                    }
                                case "Recipe":
                                    {
                                        if (dbManager.CheckId("id=" + fields[0].Text, entity))
                                        {
                                            throw new Exception("Такой ID уже существует!");
                                        }
                                        if (dbManager.CheckId("Name='" + fields[2].Text+"'", entity))
                                        {
                                            throw new Exception("Такое название уже существует!");
                                        }
                                        string[] ingreds = bigFields[0].Text.Split(',');
                                        List<string> ingrs = new List<string>();
                                        for (int i = 0; i < ingreds.Length; i++)
                                        {
                                            ingrs.Add(ingreds[i]);
                                        }
                                        Image image = new Bitmap(fields[1].Text);
                                        Recipe recipe = new Recipe(int.Parse(fields[0].Text), image, fields[2].Text, ingrs, bigFields[1].Text, int.Parse(fields[5].Text), int.Parse(fields[6].Text), int.Parse(fields[7].Text));
                                        dbManager.AddRecipe(recipe);
                                        break;
                                    }
                            }
                        }
                        catch (Exception ex)
                        {
                            InfoForm iform = new InfoForm(ex.Message);
                            iform.Show();
                        }
                        break;
                    }
                case "edit":
                    {
                        try
                        {
                            DatabaseManager dbManager = new DatabaseManager();
                            switch (entity)
                            { 
                                case "User":
                                    {
                                        dbManager.Update(entity, "Pass", fields[1].Text, "Login", fields[0].Text);
                                        dbManager.Update(entity, "IsAdmin", fields[2].Text, "Login", fields[0].Text);
                                        dbManager.Update(entity, "Points", fields[3].Text, "Login", fields[0].Text);
                                        break;
                                    }
                                case "Category":
                                    {
                                        if (dbManager.CheckId("Name='" + fields[1].Text+"'", entity)&&fields[0].Text!=recordId)
                                        {
                                            throw new Exception("Такое название уже существует!");
                                        }
                                        dbManager.Update(entity, "Name", fields[1].Text, "id", fields[0].Text);
                                        dbManager.Update(entity, "Level", fields[2].Text, "id", fields[0].Text);
                                       break;
                                    }
                                case "Recipe":
                                    {
                                        if (dbManager.CheckId("Name='" + fields[2].Text+"'", entity)&&fields[0].Text != recordId)
                                        {
                                            throw new Exception("Такое название уже существует!");
                                        }
                                        dbManager.Update(entity, "Name", fields[2].Text, "id", fields[0].Text);
                                        dbManager.Update(entity, "Ingredients", bigFields[0].Text, "id", fields[0].Text);
                                        dbManager.Update(entity, "Description", bigFields[1].Text, "id", fields[0].Text);
                                        dbManager.Update(entity, "Level", fields[5].Text, "id", fields[0].Text);
                                        dbManager.Update(entity, "Points", fields[6].Text, "id", fields[0].Text);
                                        dbManager.Update(entity, "Category", fields[7].Text, "id", fields[0].Text);
                                        break;
                                    }
                            }
                        }
                        catch (Exception ex)
                        {
                            InfoForm iform = new InfoForm(ex.Message);
                            iform.Show();
                        }
                        break;
                    }
            }
        }
        
        public void GetRecordData(string id)
        {
            DatabaseManager dbManager = new DatabaseManager();
            DataTable table;
            if (entity != "User")
                table = dbManager.Request(entity, "id = "+id);
            else
                table = dbManager.Request(entity, "Login = '" + id+"'");
            string values = "";
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    values += table.Rows[i][j] + "@";
                }
            }
            int k = 0;
            while (values != "")
            {
                if (entity == "Recipe")
                {
                    if (k == 3) bigFields[0].Text = values.Substring(0, values.IndexOf('@'));
                    else if (k == 4) bigFields[1].Text = values.Substring(0, values.IndexOf('@'));
                    else fields[k].Text = values.Substring(0, values.IndexOf('@'));
                }
                else fields[k].Text = values.Substring(0, values.IndexOf('@'));
                values = values.Remove(0, values.IndexOf('@') + 1);
                k++;
            }
            fields[0].Enabled = false;
            if (entity == "Recipe")
                fields[1].Enabled = false;
        }
        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            DialogResult = DialogResult.OK;
        }
    }
}
