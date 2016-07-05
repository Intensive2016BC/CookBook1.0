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
    public partial class AdminForm : Form
    {
        public AdminForm(bool vol)
        {
            InitializeComponent();
            volume = vol;
            dbManager = new DatabaseManager();
            dbManager.CreateDataBase();
            tables.BackgroundColor = Color.AntiqueWhite;
            btnAdd.BackColor = Color.Transparent;
            btnDelete.BackColor = Color.Transparent;
            btnEdit.BackColor = Color.Transparent;
            rbtnCategory.BackColor = Color.Transparent;
            rbtnIngreds.BackColor = Color.Transparent;
            rbtnRecipe.BackColor = Color.Transparent;
            rbtnUser.BackColor = Color.Transparent;
        }
        DatabaseManager dbManager;
        bool volume;

        private void rbtnUser_CheckedChanged(object sender, EventArgs e)
        {
            tables.DataSource = dbManager.GetFullList("User");
            btnEdit.Enabled = true;
        }

        private void rbtnCategory_CheckedChanged(object sender, EventArgs e)
        {
            tables.DataSource = dbManager.GetFullList("Category");
            btnEdit.Enabled = true;
        }

        private void rbtnRecipe_CheckedChanged(object sender, EventArgs e)
        {
            tables.DataSource = dbManager.GetFullList("Recipe");
            btnEdit.Enabled = true;
        }

        private void UpdateTables()
        {
            if (rbtnUser.Checked == true)
                tables.DataSource = dbManager.GetFullList("User");
            if (rbtnCategory.Checked == true)
                tables.DataSource = dbManager.GetFullList("Category");
            if (rbtnRecipe.Checked == true)
                tables.DataSource = dbManager.GetFullList("Recipe");
            if (rbtnIngreds.Checked == true)
                tables.DataSource = dbManager.GetFullList("Ingredients");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ServiceForm f = null;
            if (rbtnUser.Checked == true)
                f = new ServiceForm("User");
            else if (rbtnCategory.Checked == true)
                f = new ServiceForm("Category");
            else if (rbtnRecipe.Checked == true)
                f = new ServiceForm("Recipe");
            else if (rbtnIngreds.Checked == true)
                f = new ServiceForm("Ingredients");
            else
            {
                InfoForm iform = new InfoForm("Выберите таблицу!");
                iform.Show();
                return;
            }
            f.mission = "insert";
            if (f.ShowDialog() == DialogResult.OK)
            {
                if (!f.cancel)
                    UpdateTables();
                f.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ServiceForm f = null;
            ServiceForm insert = null;
            f = new ServiceForm("edit");
            f.mission = "edit";
            if (f.ShowDialog() == DialogResult.OK)
            {
                if (!f.cancel)
                {
                    string id = f.recordId;
                    string entity = "";
                    f.Close();
                    if (rbtnUser.Checked == true)
                    {
                        insert = new ServiceForm("User");
                        entity = "User";
                        if (!dbManager.CheckId("Login='"+id+"'", entity))
                        {
                            InfoForm iform = new InfoForm("ID не существует!");
                            iform.Show();
                            return;
                        }
                    }
                    else if (rbtnCategory.Checked == true)
                    {
                        insert = new ServiceForm("Category");
                        entity = "Category";
                    }
                    else if (rbtnRecipe.Checked == true)
                    {
                        insert = new ServiceForm("Recipe");
                        entity = "Recipe";
                    }
                    else if (rbtnIngreds.Checked == true)
                    {
                        insert = new ServiceForm("Ingredients");
                        entity = "Ingredients";
                    }
                    else
                    {
                        InfoForm iform = new InfoForm("Выберите таблицу!");
                        iform.Show();
                        return;
                    }
                    if (entity != "User")
                    {
                        if (!dbManager.CheckId("id=" + id, entity))
                        {
                            InfoForm iform = new InfoForm("ID не существует!");
                            iform.Show();
                            return;
                        }
                    }
                    insert.recordId = id;
                    insert.mission = "edit";
                    insert.GetRecordData(id);
                    if (insert.ShowDialog() == DialogResult.OK)
                    {
                        insert.Close();
                    }
                }
            }
            UpdateTables();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ServiceForm f = new ServiceForm("delete");
            f.mission = "delete";
            f.ShowDialog();
            string id = f.recordId;
            try
            {
                if (!f.cancel)
                {
                    if (rbtnUser.Checked == true && id !="Admin")
                        dbManager.Delete("User", "Login='" + id+"'");
                    else if (rbtnCategory.Checked == true)
                        dbManager.Delete("Category", "id=" + id);
                    else if (rbtnRecipe.Checked == true)
                        dbManager.Delete("Recipe", "id=" + id);
                    else if (rbtnIngreds.Checked == true)
                        dbManager.Delete("Ingredients", "id="+id);
                    else
                    {
                        InfoForm iform = new InfoForm("Выберите таблицу!");
                        iform.Show();
                    }
                }
            }
            catch
            {
                InfoForm iform = new InfoForm("Записи не найдено!");
                iform.Show();
            }
            UpdateTables();
        }

        private void rbtnIngreds_CheckedChanged(object sender, EventArgs e)
        {
            tables.DataSource = dbManager.GetFullList("Ingredients");
            btnEdit.Enabled = false;
        }
    }
}
