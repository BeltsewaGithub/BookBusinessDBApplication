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
    public partial class PurchasesForm : Form
    {
        public PurchasesForm()
        {
            InitializeComponent();
        }

        private void PurchasesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookBusinessDatabaseDataSet.Deliveries". При необходимости она может быть перемещена или удалена.
            this.deliveriesTableAdapter.Fill(this.bookBusinessDatabaseDataSet.Deliveries);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookBusinessDatabaseDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.bookBusinessDatabaseDataSet.Books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookBusinessDatabaseDataSet.Purchases". При необходимости она может быть перемещена или удалена.
            this.purchasesTableAdapter.Fill(this.bookBusinessDatabaseDataSet.Purchases);

        }

        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            purchasesBindingSource.Filter = "";
        }

        private void buttonFilterDate_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            purchasesBindingSource.Filter = "Date_order = " + "'" +
            dataGridView1[1, bb].Value + "'";
        }

        private void buttonFilterBookCode_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            purchasesBindingSource.Filter = "Code_book = " +
            dataGridView1[0, bb].Value;
        }

        private void buttonFilterDelivery_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            purchasesBindingSource.Filter = "Code_delivery = " +
            dataGridView1[2, bb].Value;
        }

        private void buttonFilterAmount_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            purchasesBindingSource.Filter = "Amount = " +
            dataGridView1[5, bb].Value;
        }

        private void buttonFilterCost_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            purchasesBindingSource.Filter = "Cost = " +
            dataGridView1[4, bb].Value;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchasesBindingSource.EndEdit();
            this.purchasesTableAdapter.Update
            (this.bookBusinessDatabaseDataSet.Purchases);
        }
    }
}
