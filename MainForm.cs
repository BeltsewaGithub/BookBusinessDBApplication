using FastReport;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookBusinessDatabaseDataSet.Purchases". При необходимости она может быть перемещена или удалена.
            this.purchasesTableAdapter.Fill(this.bookBusinessDatabaseDataSet.Purchases);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookBusinessDatabaseDataSet.Publishing_house". При необходимости она может быть перемещена или удалена.
            this.publishing_houseTableAdapter.Fill(this.bookBusinessDatabaseDataSet.Publishing_house);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookBusinessDatabaseDataSet.Deliveries". При необходимости она может быть перемещена или удалена.
            this.deliveriesTableAdapter.Fill(this.bookBusinessDatabaseDataSet.Deliveries);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookBusinessDatabaseDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.bookBusinessDatabaseDataSet.Books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookBusinessDatabaseDataSet.Authors". При необходимости она может быть перемещена или удалена.
            this.authorsTableAdapter.Fill(this.bookBusinessDatabaseDataSet.Authors);

        }

        private void авторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorsForm myForm1 = new AuthorsForm();
            myForm1.Show();
        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooksForm myForm2 = new BooksForm();
            myForm2.Show();
        }

        private void издательстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublishingHousesForm myForm3 = new PublishingHousesForm();
            myForm3.Show();
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeliveriesForm myForm4 = new DeliveriesForm();
            myForm4.Show();
        }

        private void поставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchasesForm myForm5 = new PurchasesForm();
            myForm5.Show();
        }
       

        private void админToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin myForm7 = new FormAdmin();
            myForm7.Show();
        }

        private void количествоПокупокЗаУказанныйПериодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcedureForm myForm6 = new ProcedureForm();
            myForm6.Show();

        }

        private void отчётыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void отчётВТабличнойФормеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //using (Report report = new Report())
            //{
                report1.Load(@"C:\Users\Polina\source\repos\PublishingHouseClient2\PublishingHouseClient2\PublishingHouseClient2\sources\report1.frx");
            report1.Show();
            //}
            
        }

        private void отчётВСвободнойФормеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report2.Load(@"C:\Users\Polina\source\repos\PublishingHouseClient2\PublishingHouseClient2\PublishingHouseClient2\sources\report2.frx");
            report2.Show();
        }

        private void отчётСГруппировкойПоДвумТаблтцамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report3.Load(@"C:\Users\Polina\source\repos\PublishingHouseClient2\PublishingHouseClient2\PublishingHouseClient2\sources\report3.frx");
            report3.Show();
        }
    }
}
