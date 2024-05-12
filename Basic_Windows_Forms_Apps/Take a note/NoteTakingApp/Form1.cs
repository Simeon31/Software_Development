using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Title", typeof(String));
            dataTable.Columns.Add("Messages", typeof(String));

            dataGridView1.DataSource = dataTable;

            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 270;
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessages.Clear();
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Add(txtTitle.Text, txtMessages.Text);

            txtTitle.Clear();
            txtMessages.Clear();
        }

        private void bttRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                txtTitle.Text = dataTable.Rows[index].ItemArray[0].ToString();
                txtMessages.Text = dataTable.Rows[index].ItemArray[1].ToString();
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataTable.Rows[index].Delete();

            txtTitle.Clear();
            txtMessages.Clear();
        }
    }
}
