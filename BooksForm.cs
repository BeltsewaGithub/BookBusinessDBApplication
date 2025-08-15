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
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookBusinessDatabaseDataSet.Publishing_house". При необходимости она может быть перемещена или удалена.
            this.publishing_houseTableAdapter.Fill(this.bookBusinessDatabaseDataSet.Publishing_house);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookBusinessDatabaseDataSet.Authors". При необходимости она может быть перемещена или удалена.
            this.authorsTableAdapter.Fill(this.bookBusinessDatabaseDataSet.Authors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookBusinessDatabaseDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.bookBusinessDatabaseDataSet.Books);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.booksTableAdapter.Update
            (this.bookBusinessDatabaseDataSet.Books);
        }

        private void buttonFilterPages_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            booksBindingSource.Filter = "Pages = " +
            dataGridView1[3, bb].Value;
        }

        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            booksBindingSource.Filter = "";
        }

        private void buttonFilterAuthor_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            booksBindingSource.Filter = "Code_Author = " +
            dataGridView1[2, bb].Value;
        }

        private void buttonFilterName_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            booksBindingSource.Filter = "Title_book = " + "'" +
            dataGridView1[1, bb].Value + "'";
        }

        private void buttonPublishHouseFilter_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            booksBindingSource.Filter = "Code_Publish = " +
            dataGridView1[4, bb].Value;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProgramClass.SimbolsOnlyCheck(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProgramClass.IntNumbersCheck(e);
        }
    }
}
