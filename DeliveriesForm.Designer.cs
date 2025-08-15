namespace PublishingHouseClient2
{
    partial class DeliveriesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveriesForm));
            this.label7 = new System.Windows.Forms.Label();
            this.deliveriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBusinessDatabaseDataSet = new PublishingHouseClient2.BookBusinessDatabaseDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codedeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namedeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.deliveriesTableAdapter = new PublishingHouseClient2.BookBusinessDatabaseDataSetTableAdapters.DeliveriesTableAdapter();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.buttonFilterPhone = new System.Windows.Forms.Button();
            this.buttonFilterAddress = new System.Windows.Forms.Button();
            this.buttonFilterCompany = new System.Windows.Forms.Button();
            this.buttonFilterName = new System.Windows.Forms.Button();
            this.buttonFilterINN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBusinessDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveriesBindingSource, "Code_delivery", true));
            this.label7.Location = new System.Drawing.Point(621, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "default";
            // 
            // deliveriesBindingSource
            // 
            this.deliveriesBindingSource.DataMember = "Deliveries";
            this.deliveriesBindingSource.DataSource = this.bookBusinessDatabaseDataSet;
            // 
            // bookBusinessDatabaseDataSet
            // 
            this.bookBusinessDatabaseDataSet.DataSetName = "BookBusinessDatabaseDataSet";
            this.bookBusinessDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "ИНН";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Телефон контактный";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Юридический адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Название компании-поставщика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "ФИО ответственного лица";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Код поставщика";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveriesBindingSource, "INN", true));
            this.textBox6.Location = new System.Drawing.Point(621, 169);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(154, 26);
            this.textBox6.TabIndex = 26;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveriesBindingSource, "Phone", true));
            this.textBox5.Location = new System.Drawing.Point(621, 137);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(154, 26);
            this.textBox5.TabIndex = 25;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveriesBindingSource, "Address", true));
            this.textBox4.Location = new System.Drawing.Point(621, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(154, 26);
            this.textBox4.TabIndex = 24;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(349, 203);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(426, 29);
            this.buttonUpdate.TabIndex = 23;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveriesBindingSource, "Name_company", true));
            this.textBox3.Location = new System.Drawing.Point(621, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 26);
            this.textBox3.TabIndex = 22;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveriesBindingSource, "Name_delivery", true));
            this.textBox2.Location = new System.Drawing.Point(621, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 26);
            this.textBox2.TabIndex = 21;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codedeliveryDataGridViewTextBoxColumn,
            this.namedeliveryDataGridViewTextBoxColumn,
            this.namecompanyDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.iNNDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deliveriesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(800, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // codedeliveryDataGridViewTextBoxColumn
            // 
            this.codedeliveryDataGridViewTextBoxColumn.DataPropertyName = "Code_delivery";
            this.codedeliveryDataGridViewTextBoxColumn.HeaderText = "Code_delivery";
            this.codedeliveryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codedeliveryDataGridViewTextBoxColumn.Name = "codedeliveryDataGridViewTextBoxColumn";
            this.codedeliveryDataGridViewTextBoxColumn.ReadOnly = true;
            this.codedeliveryDataGridViewTextBoxColumn.Width = 150;
            // 
            // namedeliveryDataGridViewTextBoxColumn
            // 
            this.namedeliveryDataGridViewTextBoxColumn.DataPropertyName = "Name_delivery";
            this.namedeliveryDataGridViewTextBoxColumn.HeaderText = "Name_delivery";
            this.namedeliveryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namedeliveryDataGridViewTextBoxColumn.Name = "namedeliveryDataGridViewTextBoxColumn";
            this.namedeliveryDataGridViewTextBoxColumn.ReadOnly = true;
            this.namedeliveryDataGridViewTextBoxColumn.Width = 150;
            // 
            // namecompanyDataGridViewTextBoxColumn
            // 
            this.namecompanyDataGridViewTextBoxColumn.DataPropertyName = "Name_company";
            this.namecompanyDataGridViewTextBoxColumn.HeaderText = "Name_company";
            this.namecompanyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namecompanyDataGridViewTextBoxColumn.Name = "namecompanyDataGridViewTextBoxColumn";
            this.namecompanyDataGridViewTextBoxColumn.ReadOnly = true;
            this.namecompanyDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // iNNDataGridViewTextBoxColumn
            // 
            this.iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
            this.iNNDataGridViewTextBoxColumn.HeaderText = "INN";
            this.iNNDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
            this.iNNDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNNDataGridViewTextBoxColumn.Width = 150;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.deliveriesBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 412);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 38);
            this.bindingNavigator1.TabIndex = 19;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 52);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 52);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 52);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 52);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 57);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 52);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 52);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 52);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // deliveriesTableAdapter
            // 
            this.deliveriesTableAdapter.ClearBeforeFill = true;
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.Location = new System.Drawing.Point(28, 201);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(291, 32);
            this.buttonClearFilter.TabIndex = 37;
            this.buttonClearFilter.Text = "Снять фильтр";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
            // 
            // buttonFilterPhone
            // 
            this.buttonFilterPhone.Location = new System.Drawing.Point(28, 128);
            this.buttonFilterPhone.Name = "buttonFilterPhone";
            this.buttonFilterPhone.Size = new System.Drawing.Size(291, 32);
            this.buttonFilterPhone.TabIndex = 38;
            this.buttonFilterPhone.Text = "Фильтр по контактному телефону";
            this.buttonFilterPhone.UseVisualStyleBackColor = true;
            this.buttonFilterPhone.Click += new System.EventHandler(this.buttonFilterPhone_Click);
            // 
            // buttonFilterAddress
            // 
            this.buttonFilterAddress.Location = new System.Drawing.Point(28, 96);
            this.buttonFilterAddress.Name = "buttonFilterAddress";
            this.buttonFilterAddress.Size = new System.Drawing.Size(291, 32);
            this.buttonFilterAddress.TabIndex = 36;
            this.buttonFilterAddress.Text = "Фильтр по текущему адресу";
            this.buttonFilterAddress.UseVisualStyleBackColor = true;
            this.buttonFilterAddress.Click += new System.EventHandler(this.buttonFilterAddress_Click);
            // 
            // buttonFilterCompany
            // 
            this.buttonFilterCompany.Location = new System.Drawing.Point(28, 64);
            this.buttonFilterCompany.Name = "buttonFilterCompany";
            this.buttonFilterCompany.Size = new System.Drawing.Size(291, 32);
            this.buttonFilterCompany.TabIndex = 35;
            this.buttonFilterCompany.Text = "Фильтр по текущей компании";
            this.buttonFilterCompany.UseVisualStyleBackColor = true;
            this.buttonFilterCompany.Click += new System.EventHandler(this.buttonFilterCompany_Click);
            // 
            // buttonFilterName
            // 
            this.buttonFilterName.Location = new System.Drawing.Point(28, 12);
            this.buttonFilterName.Name = "buttonFilterName";
            this.buttonFilterName.Size = new System.Drawing.Size(291, 54);
            this.buttonFilterName.TabIndex = 34;
            this.buttonFilterName.Text = "Фильтр по текущему ответственному лицу";
            this.buttonFilterName.UseVisualStyleBackColor = true;
            this.buttonFilterName.Click += new System.EventHandler(this.buttonFilterName_Click);
            // 
            // buttonFilterINN
            // 
            this.buttonFilterINN.Location = new System.Drawing.Point(28, 160);
            this.buttonFilterINN.Name = "buttonFilterINN";
            this.buttonFilterINN.Size = new System.Drawing.Size(291, 32);
            this.buttonFilterINN.TabIndex = 38;
            this.buttonFilterINN.Text = "Фильтр по текущему ИНН";
            this.buttonFilterINN.UseVisualStyleBackColor = true;
            this.buttonFilterINN.Click += new System.EventHandler(this.buttonFilterINN_Click);
            // 
            // DeliveriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClearFilter);
            this.Controls.Add(this.buttonFilterINN);
            this.Controls.Add(this.buttonFilterPhone);
            this.Controls.Add(this.buttonFilterAddress);
            this.Controls.Add(this.buttonFilterCompany);
            this.Controls.Add(this.buttonFilterName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "DeliveriesForm";
            this.Text = "DeliveriesForm";
            this.Load += new System.EventHandler(this.DeliveriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBusinessDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private BookBusinessDatabaseDataSet bookBusinessDatabaseDataSet;
        private System.Windows.Forms.BindingSource deliveriesBindingSource;
        private BookBusinessDatabaseDataSetTableAdapters.DeliveriesTableAdapter deliveriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codedeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namedeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonClearFilter;
        private System.Windows.Forms.Button buttonFilterPhone;
        private System.Windows.Forms.Button buttonFilterAddress;
        private System.Windows.Forms.Button buttonFilterCompany;
        private System.Windows.Forms.Button buttonFilterName;
        private System.Windows.Forms.Button buttonFilterINN;
    }
}