using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CookBook
{
    public partial class ResultForm : Form
    {
        public ResultForm(List<string> results, double points)
        {
            InitializeComponent();
            double UserPoints = 0;
            resultsTable.RowCount = results.Count;
            resultsTable.ColumnCount = 2;
            resultsTable.Columns[0].HeaderText = "Рецепт";
            resultsTable.Columns[0].Width = 320;
            resultsTable.Columns[1].HeaderText = "Набранные баллы";
            resultsTable.Columns[1].Width = 135;
            for (int i = 0; i < results.Count; i++)
            {
                resultsTable.Rows[i].Cells[0].Value = results[i].Split(',')[0];
                resultsTable.Rows[i].Cells[1].Value = results[i].Split(',')[1];
                resultsTable.Rows[i].Height = 30;
                UserPoints += Convert.ToDouble(results[i].Split(',')[1]);
            }
            if (UserPoints == points && UserPoints != 0)
            {
                label1.Text = "Молодец, так держать!";
            }
            else if ((UserPoints/points) > 0.7)
            {
                label1.Text = "Хорошо, но вы можете лучше!";
            }
            else if ((UserPoints/points) > 0.4)
            {
                label1.Text = "У вас почти получилось";
            }
            else
            {
                label1.Text = "К сожалению, вы пока не достигли \nхороших результатов";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
