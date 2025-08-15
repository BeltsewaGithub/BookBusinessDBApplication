namespace PublishingHouseClient2
{
    partial class PurchasesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasesForm));
            this.label7 = new System.Windows.Forms.Label();
            this.purchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBusinessDatabaseDataSet = new PublishingHouseClient2.BookBusinessDatabaseDataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.deliveriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codebookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codedeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typepurchaseDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codepurchaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.purchasesTableAdapter = new PublishingHouseClient2.BookBusinessDatabaseDataSetTableAdapters.PurchasesTableAdapter();
            this.booksTableAdapter = new PublishingHouseClient2.BookBusinessDatabaseDataSetTableAdapters.BooksTableAdapter();
            this.deliveriesTableAdapter = new PublishingHouseClient2.BookBusinessDatabaseDataSetTableAdapters.DeliveriesTableAdapter();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.buttonFilterAmount = new System.Windows.Forms.Button();
            this.buttonFilterDate = new System.Windows.Forms.Button();
            this.buttonFilterBookCode = new System.Windows.Forms.Button();
            this.buttonFilterDelivery = new System.Windows.Forms.Button();
            this.buttonFilterCost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBusinessDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchasesBindingSource, "Code_purchase", true));
            this.label7.Location = new System.Drawing.Point(794, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "default";
            // 
            // purchasesBindingSource
            // 
            this.purchasesBindingSource.DataMember = "Purchases";
            this.purchasesBindingSource.DataSource = this.bookBusinessDatabaseDataSet;
            // 
            // bookBusinessDatabaseDataSet
            // 
            this.bookBusinessDatabaseDataSet.DataSetName = "BookBusinessDatabaseDataSet";
            this.bookBusinessDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchasesBindingSource, "Date_order", true));
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchasesBindingSource, "Date_order", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(794, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 26);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.purchasesBindingSource, "Type_purchase", true));
            this.checkBox1.Location = new System.Drawing.Point(803, 224);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 24);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "Опт";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Код покупки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Количество экземпляров";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Код поставщика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Дата заказа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Код книги";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchasesBindingSource, "Amount", true));
            this.textBox1.Location = new System.Drawing.Point(794, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 26);
            this.textBox1.TabIndex = 26;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(587, 254);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(381, 29);
            this.buttonUpdate.TabIndex = 25;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purchasesBindingSource, "Code_delivery", true));
            this.comboBox2.DataSource = this.deliveriesBindingSource;
            this.comboBox2.DisplayMember = "Name_company";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(794, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(174, 28);
            this.comboBox2.TabIndex = 24;
            this.comboBox2.ValueMember = "Code_delivery";
            // 
            // deliveriesBindingSource
            // 
            this.deliveriesBindingSource.DataMember = "Deliveries";
            this.deliveriesBindingSource.DataSource = this.bookBusinessDatabaseDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purchasesBindingSource, "Code_book", true));
            this.comboBox1.DataSource = this.booksBindingSource;
            this.comboBox1.DisplayMember = "Title_book";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(794, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 28);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.ValueMember = "Code_book";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.bookBusinessDatabaseDataSet;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchasesBindingSource, "Cost", true));
            this.textBox3.Location = new System.Drawing.Point(794, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 26);
            this.textBox3.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codebookDataGridViewTextBoxColumn,
            this.dateorderDataGridViewTextBoxColumn,
            this.codedeliveryDataGridViewTextBoxColumn,
            this.typepurchaseDataGridViewCheckBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.codepurchaseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.purchasesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1127, 99);
            this.dataGridView1.TabIndex = 21;
            // 
            // codebookDataGridViewTextBoxColumn
            // 
            this.codebookDataGridViewTextBoxColumn.DataPropertyName = "Code_book";
            this.codebookDataGridViewTextBoxColumn.HeaderText = "Code_book";
            this.codebookDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codebookDataGridViewTextBoxColumn.Name = "codebookDataGridViewTextBoxColumn";
            this.codebookDataGridViewTextBoxColumn.ReadOnly = true;
            this.codebookDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateorderDataGridViewTextBoxColumn
            // 
            this.dateorderDataGridViewTextBoxColumn.DataPropertyName = "Date_order";
            this.dateorderDataGridViewTextBoxColumn.HeaderText = "Date_order";
            this.dateorderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateorderDataGridViewTextBoxColumn.Name = "dateorderDataGridViewTextBoxColumn";
            this.dateorderDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateorderDataGridViewTextBoxColumn.Width = 150;
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
            // typepurchaseDataGridViewCheckBoxColumn
            // 
            this.typepurchaseDataGridViewCheckBoxColumn.DataPropertyName = "Type_purchase";
            this.typepurchaseDataGridViewCheckBoxColumn.HeaderText = "Type_purchase";
            this.typepurchaseDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.typepurchaseDataGridViewCheckBoxColumn.Name = "typepurchaseDataGridViewCheckBoxColumn";
            this.typepurchaseDataGridViewCheckBoxColumn.ReadOnly = true;
            this.typepurchaseDataGridViewCheckBoxColumn.Width = 150;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 150;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 150;
            // 
            // codepurchaseDataGridViewTextBoxColumn
            // 
            this.codepurchaseDataGridViewTextBoxColumn.DataPropertyName = "Code_purchase";
            this.codepurchaseDataGridViewTextBoxColumn.HeaderText = "Code_purchase";
            this.codepurchaseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codepurchaseDataGridViewTextBoxColumn.Name = "codepurchaseDataGridViewTextBoxColumn";
            this.codepurchaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.codepurchaseDataGridViewTextBoxColumn.Width = 150;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.purchasesBindingSource;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 417);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1104, 33);
            this.bindingNavigator1.TabIndex = 20;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // purchasesTableAdapter
            // 
            this.purchasesTableAdapter.ClearBeforeFill = true;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // deliveriesTableAdapter
            // 
            this.deliveriesTableAdapter.ClearBeforeFill = true;
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.Location = new System.Drawing.Point(205, 252);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(291, 32);
            this.buttonClearFilter.TabIndex = 39;
            this.buttonClearFilter.Text = "Снять фильтр";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
            // 
            // buttonFilterAmount
            // 
            this.buttonFilterAmount.Location = new System.Drawing.Point(205, 151);
            this.buttonFilterAmount.Name = "buttonFilterAmount";
            this.buttonFilterAmount.Size = new System.Drawing.Size(291, 32);
            this.buttonFilterAmount.TabIndex = 40;
            this.buttonFilterAmount.Text = "Фильтр по количеству книг";
            this.buttonFilterAmount.UseVisualStyleBackColor = true;
            this.buttonFilterAmount.Click += new System.EventHandler(this.buttonFilterAmount_Click);
            // 
            // buttonFilterDate
            // 
            this.buttonFilterDate.Location = new System.Drawing.Point(205, 113);
            this.buttonFilterDate.Name = "buttonFilterDate";
            this.buttonFilterDate.Size = new System.Drawing.Size(291, 32);
            this.buttonFilterDate.TabIndex = 38;
            this.buttonFilterDate.Text = "Фильтр по текущей дате";
            this.buttonFilterDate.UseVisualStyleBackColor = true;
            this.buttonFilterDate.Click += new System.EventHandler(this.buttonFilterDate_Click);
            // 
            // buttonFilterBookCode
            // 
            this.buttonFilterBookCode.Location = new System.Drawing.Point(205, 75);
            this.buttonFilterBookCode.Name = "buttonFilterBookCode";
            this.buttonFilterBookCode.Size = new System.Drawing.Size(291, 32);
            this.buttonFilterBookCode.TabIndex = 37;
            this.buttonFilterBookCode.Text = "Фильтр по текущей книге";
            this.buttonFilterBookCode.UseVisualStyleBackColor = true;
            this.buttonFilterBookCode.Click += new System.EventHandler(this.buttonFilterBookCode_Click);
            // 
            // buttonFilterDelivery
            // 
            this.buttonFilterDelivery.Location = new System.Drawing.Point(205, 37);
            this.buttonFilterDelivery.Name = "buttonFilterDelivery";
            this.buttonFilterDelivery.Size = new System.Drawing.Size(291, 32);
            this.buttonFilterDelivery.TabIndex = 36;
            this.buttonFilterDelivery.Text = "Фильтр по текущему поставщику";
            this.buttonFilterDelivery.UseVisualStyleBackColor = true;
            this.buttonFilterDelivery.Click += new System.EventHandler(this.buttonFilterDelivery_Click);
            // 
            // buttonFilterCost
            // 
            this.buttonFilterCost.Location = new System.Drawing.Point(205, 189);
            this.buttonFilterCost.Name = "buttonFilterCost";
            this.buttonFilterCost.Size = new System.Drawing.Size(291, 32);
            this.buttonFilterCost.TabIndex = 40;
            this.buttonFilterCost.Text = "Фильтр по цене";
            this.buttonFilterCost.UseVisualStyleBackColor = true;
            this.buttonFilterCost.Click += new System.EventHandler(this.buttonFilterCost_Click);
            // 
            // PurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1104, 450);
            this.Controls.Add(this.buttonClearFilter);
            this.Controls.Add(this.buttonFilterCost);
            this.Controls.Add(this.buttonFilterAmount);
            this.Controls.Add(this.buttonFilterDate);
            this.Controls.Add(this.buttonFilterBookCode);
            this.Controls.Add(this.buttonFilterDelivery);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "PurchasesForm";
            this.Text = "PurchasesForm";
            this.Load += new System.EventHandler(this.PurchasesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBusinessDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
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
        private System.Windows.Forms.BindingSource purchasesBindingSource;
        private BookBusinessDatabaseDataSetTableAdapters.PurchasesTableAdapter purchasesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codebookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codedeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typepurchaseDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepurchaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private BookBusinessDatabaseDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource deliveriesBindingSource;
        private BookBusinessDatabaseDataSetTableAdapters.DeliveriesTableAdapter deliveriesTableAdapter;
        private System.Windows.Forms.Button buttonClearFilter;
        private System.Windows.Forms.Button buttonFilterAmount;
        private System.Windows.Forms.Button buttonFilterDate;
        private System.Windows.Forms.Button buttonFilterBookCode;
        private System.Windows.Forms.Button buttonFilterDelivery;
        private System.Windows.Forms.Button buttonFilterCost;
    }
}