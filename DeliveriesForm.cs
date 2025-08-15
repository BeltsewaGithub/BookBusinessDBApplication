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
    public partial class DeliveriesForm : Form
    {
        public DeliveriesForm()
        {
            InitializeComponent();
        }

        private void DeliveriesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookBusinessDatabaseDataSet.Deliveries". При необходимости она может быть перемещена или удалена.
            this.deliveriesTableAdapter.Fill(this.bookBusinessDatabaseDataSet.Deliveries);

        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
                this.Validate();
                this.deliveriesBindingSource.EndEdit();
                this.deliveriesTableAdapter.Update
                (this.bookBusinessDatabaseDataSet.Deliveries);
        }

        private void buttonFilterName_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            deliveriesBindingSource.Filter = "Name_delivery = " + "'" +
            dataGridView1[1, bb].Value + "'";
        }

        private void buttonFilterCompany_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            deliveriesBindingSource.Filter = "Name_company = " + "'" +
            dataGridView1[2, bb].Value + "'";
        }

        private void buttonFilterAddress_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            deliveriesBindingSource.Filter = "Address = " + "'" +
            dataGridView1[3, bb].Value + "'";
        }

        private void buttonFilterPhone_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            deliveriesBindingSource.Filter = "Phone = " +
            dataGridView1[4, bb].Value;
        }

        private void buttonFilterINN_Click(object sender, EventArgs e)
        {
            int bb = dataGridView1.CurrentCell.RowIndex;
            deliveriesBindingSource.Filter = "INN = " +
            dataGridView1[5, bb].Value;
        }

        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            deliveriesBindingSource.Filter = "";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProgramClass.SimbolsOnlyCheck(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProgramClass.SimbolsOnlyCheck(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProgramClass.SimbolsOnlyCheck(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            ProgramClass.IntNumbersCheck(e);
            if (textBox5.Text.Length > 10 && number != 8) e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            ProgramClass.IntNumbersCheck(e);
            if (textBox6.Text.Length > 12 && number != 8) e.Handled = true;
        }
    }
}
