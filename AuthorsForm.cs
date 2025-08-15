using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PublishingHouseClient2
{
    public partial class AuthorsForm : Form
    {
        public AuthorsForm()
        {
            InitializeComponent();
        }

        private void AuthorsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookBusinessDatabaseDataSet.Authors". При необходимости она может быть перемещена или удалена.
            this.authorsTableAdapter.Fill(this.bookBusinessDatabaseDataSet.Authors);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorsBindingSource.EndEdit();
            this.authorsTableAdapter.Update
            (this.bookBusinessDatabaseDataSet.Authors);
        }

        private void buttonFilterAuthor_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            authorsBindingSource.Filter = "Name_author = " + "'" +
            dataGridView1[1, bb].Value + "'";
        }

        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            authorsBindingSource.Filter = "";
        }

        private void buttonFilterDate_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            authorsBindingSource.Filter = "Birthday = " + "'" +
            dataGridView1[2, bb].Value + "'";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProgramClass.SimbolsOnlyCheck(e);
        }
    }
}
