using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PublishingHouseClient2
{

    public partial class ProcedureForm : Form
    {
        public ProcedureForm()
        {
            InitializeComponent();
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            int count_save;

            sqlCommand1.Parameters["@d1"].Value =
            Convert.ToDateTime(dateTimePicker1.Value);
            sqlCommand1.Parameters["@d2"].Value =
            Convert.ToDateTime(dateTimePicker2.Value);
            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            count_save = (int)sqlCommand1.Parameters["@c"].Value;
            label4.Text = Convert.ToString(count_save);
        }

        private void sqlConnection1_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {

        }
    }
}
