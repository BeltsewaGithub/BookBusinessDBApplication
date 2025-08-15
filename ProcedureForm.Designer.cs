namespace PublishingHouseClient2
{
    partial class ProcedureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Введите дату конца периода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите дату начала периода";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Количество покупок за указанный период";
            // 
            // buttonRequest
            // 
            this.buttonRequest.Location = new System.Drawing.Point(184, 301);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(436, 33);
            this.buttonRequest.TabIndex = 10;
            this.buttonRequest.Text = "Выполнить запрос";
            this.buttonRequest.UseVisualStyleBackColor = true;
            this.buttonRequest.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(520, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(520, 216);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "0";
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "count_purchases";
            this.sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@d1", System.Data.SqlDbType.SmallDateTime),
            new System.Data.SqlClient.SqlParameter("@d2", System.Data.SqlDbType.SmallDateTime),
            new System.Data.SqlClient.SqlParameter("@c", System.Data.SqlDbType.Int, 3, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "Int"),
            new System.Data.SqlClient.SqlParameter("@ReturnValue", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=localhost;Initial Catalog=BookBusinessDatabase;Persist Security Info=" +
    "True;User ID=sa;Password=73590332417PoL;Encrypt=True;TrustServerCertificate=True" +
    "";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            this.sqlConnection1.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlConnection1_InfoMessage);
            // 
            // ProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRequest);
            this.Name = "ProcedureForm";
            this.Text = "ProcedureForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
    }
}