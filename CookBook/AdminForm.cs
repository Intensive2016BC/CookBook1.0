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
        public AdminForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            dbManager.CreateDataBase();
        }
        DatabaseManager dbManager;

        private void rbtnUser_CheckedChanged(object sender, EventArgs e)
        {
            tables.DataSource = dbManager.GetFullList("User");
        }

        private void rbtnCategory_CheckedChanged(object sender, EventArgs e)
        {
            tables.DataSource = dbManager.GetFullList("Category");
        }

        private void rbtnRecipe_CheckedChanged(object sender, EventArgs e)
        {
            tables.DataSource = dbManager.GetFullList("Recipe");
        }

        private void UpdateTables()
        {
            if (rbtnUser.Checked == true)
                tables.DataSource = dbManager.GetFullList("User");
            if (rbtnCategory.Checked == true)
                tables.DataSource = dbManager.GetFullList("Category");
            if (rbtnRecipe.Checked == true)
                tables.DataSource = dbManager.GetFullList("Recipe");
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
            else
            {
                MessageBox.Show("Выберите таблицу");
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
                    f.Close();
                    if (rbtnUser.Checked == true)
                        insert = new ServiceForm("User");
                    if (rbtnCategory.Checked == true)
                        insert = new ServiceForm("Category");
                    if (rbtnRecipe.Checked == true)
                        insert = new ServiceForm("Recipe");
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
                    if (rbtnUser.Checked == true)
                        dbManager.Delete("User", "Login='" + id+"'");
                    if (rbtnCategory.Checked == true)
                        dbManager.Delete("Category", "id=" + id);
                    if (rbtnRecipe.Checked == true)
                        dbManager.Delete("Recipe", "id=" + id);
                }
            }
            catch
            {
                MessageBox.Show("Записи не найдено");
            }
            UpdateTables();
        }
    }
}
