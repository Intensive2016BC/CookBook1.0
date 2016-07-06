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
        public AdminForm(bool vol, string user)
        {
            InitializeComponent();
            volume = vol;
            UserName = user;
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
        string UserName;

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
                f = new ServiceForm("User", volume);
            else if (rbtnCategory.Checked == true)
                f = new ServiceForm("Category", volume);
            else if (rbtnRecipe.Checked == true)
                f = new ServiceForm("Recipe", volume);
            else if (rbtnIngreds.Checked == true)
                f = new ServiceForm("Ingredients", volume);
            else
            {
                InfoForm iform = new InfoForm("Выберите таблицу!", volume);
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
            ServiceForm insert = null;
            string id = "";
            id = tables.Rows[tables.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            if (rbtnUser.Checked == true)
                    {
                        insert = new ServiceForm("User", volume);
                    }
                    else if (rbtnCategory.Checked == true)
                    {
                        insert = new ServiceForm("Category", volume);
                    }
                    else if (rbtnRecipe.Checked == true)
                    {
                        insert = new ServiceForm("Recipe", volume);
                    }
                    else if (rbtnIngreds.Checked == true)
                    {
                        insert = new ServiceForm("Ingredients", volume);
                    }
                    else
                    {
                        InfoForm iform = new InfoForm("Выберите таблицу!", volume);
                        iform.Show();
                        return;
                    }
                    insert.recordId = id;
                    insert.mission = "edit";
                    insert.GetRecordData(id);
                    if (insert.ShowDialog() == DialogResult.OK)
                    {
                        insert.Close();
                    }
            UpdateTables();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = "";
            id = tables.Rows[tables.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            try
            {
                {
                    if (rbtnUser.Checked == true && id !="Admin" && id!=UserName)
                        dbManager.Delete("User", "Login='" + id+"'");
                    else if (rbtnCategory.Checked == true)
                        dbManager.Delete("Category", "id=" + id);
                    else if (rbtnRecipe.Checked == true)
                        dbManager.Delete("Recipe", "id=" + id);
                    else if (rbtnIngreds.Checked == true)
                        dbManager.Delete("Ingredients", "id="+id);
                    else
                    {
                        InfoForm iform = new InfoForm("Выберите таблицу!", volume);
                        iform.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                InfoForm iform = new InfoForm(ex.Message, volume);
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
