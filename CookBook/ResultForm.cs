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
        public ResultForm(List<string> results)
        {
            InitializeComponent();
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
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
