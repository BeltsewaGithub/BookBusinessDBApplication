namespace PublishingHouseClient2
{
    partial class BooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
            this.label7 = new System.Windows.Forms.Label();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBusinessDatabaseDataSet = new PublishingHouseClient2.BookBusinessDatabaseDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            this.buttonFilterPages = new System.Windows.Forms.Button();
            this.buttonFilterAuthor = new System.Windows.Forms.Button();
            this.buttonFilterName = new System.Windows.Forms.Button();
            this.buttonPublishHouseFilter = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.publishinghouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codebookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titlebookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codepublishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksTableAdapter = new PublishingHouseClient2.BookBusinessDatabaseDataSetTableAdapters.BooksTableAdapter();
            this.authorsTableAdapter = new PublishingHouseClient2.BookBusinessDatabaseDataSetTableAdapters.AuthorsTableAdapter();
            this.publishing_houseTableAdapter = new PublishingHouseClient2.BookBusinessDatabaseDataSetTableAdapters.Publishing_houseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBusinessDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishinghouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Code_book", true));
            this.label7.Location = new System.Drawing.Point(597, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "default";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.bookBusinessDatabaseDataSet;
            // 
            // bookBusinessDatabaseDataSet
            // 
            this.bookBusinessDatabaseDataSet.DataSetName = "BookBusinessDatabaseDataSet";
            this.bookBusinessDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Код издательства";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Количество страниц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Код автора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Название книги";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Код книги";
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.Location = new System.Drawing.Point(65, 187);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(322, 32);
            this.buttonClearFilter.TabIndex = 28;
            this.buttonClearFilter.Text = "Снять фильтр";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
            // 
            // buttonFilterPages
            // 
            this.buttonFilterPages.Location = new System.Drawing.Point(65, 131);
            this.buttonFilterPages.Name = "buttonFilterPages";
            this.buttonFilterPages.Size = new System.Drawing.Size(322, 32);
            this.buttonFilterPages.TabIndex = 29;
            this.buttonFilterPages.Text = "Фильтр по количеству страниц";
            this.buttonFilterPages.UseVisualStyleBackColor = true;
            this.buttonFilterPages.Click += new System.EventHandler(this.buttonFilterPages_Click);
            // 
            // buttonFilterAuthor
            // 
            this.buttonFilterAuthor.Location = new System.Drawing.Point(65, 93);
            this.buttonFilterAuthor.Name = "buttonFilterAuthor";
            this.buttonFilterAuthor.Size = new System.Drawing.Size(322, 32);
            this.buttonFilterAuthor.TabIndex = 27;
            this.buttonFilterAuthor.Text = "Фильтр по текущему автору";
            this.buttonFilterAuthor.UseVisualStyleBackColor = true;
            this.buttonFilterAuthor.Click += new System.EventHandler(this.buttonFilterAuthor_Click);
            // 
            // buttonFilterName
            // 
            this.buttonFilterName.Location = new System.Drawing.Point(65, 55);
            this.buttonFilterName.Name = "buttonFilterName";
            this.buttonFilterName.Size = new System.Drawing.Size(322, 32);
            this.buttonFilterName.TabIndex = 26;
            this.buttonFilterName.Text = "Фильтр по текущему названию книги";
            this.buttonFilterName.UseVisualStyleBackColor = true;
            this.buttonFilterName.Click += new System.EventHandler(this.buttonFilterName_Click);
            // 
            // buttonPublishHouseFilter
            // 
            this.buttonPublishHouseFilter.Location = new System.Drawing.Point(65, 17);
            this.buttonPublishHouseFilter.Name = "buttonPublishHouseFilter";
            this.buttonPublishHouseFilter.Size = new System.Drawing.Size(322, 32);
            this.buttonPublishHouseFilter.TabIndex = 25;
            this.buttonPublishHouseFilter.Text = "Фильтр по текущему издательству";
            this.buttonPublishHouseFilter.UseVisualStyleBackColor = true;
            this.buttonPublishHouseFilter.Click += new System.EventHandler(this.buttonPublishHouseFilter_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(418, 190);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(337, 29);
            this.buttonUpdate.TabIndex = 24;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.booksBindingSource, "Code_publish", true));
            this.comboBox2.DataSource = this.publishinghouseBindingSource;
            this.comboBox2.DisplayMember = "Publish";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(601, 147);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 28);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.ValueMember = "Code_publish";
            // 
            // publishinghouseBindingSource
            // 
            this.publishinghouseBindingSource.DataMember = "Publishing_house";
            this.publishinghouseBindingSource.DataSource = this.bookBusinessDatabaseDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.booksBindingSource, "Code_author", true));
            this.comboBox1.DataSource = this.authorsBindingSource;
            this.comboBox1.DisplayMember = "Name_author";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(601, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 28);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.ValueMember = "Code_author";
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.bookBusinessDatabaseDataSet;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Pages", true));
            this.textBox3.Location = new System.Drawing.Point(601, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 26);
            this.textBox3.TabIndex = 21;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Title_book", true));
            this.textBox2.Location = new System.Drawing.Point(601, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 26);
            this.textBox2.TabIndex = 20;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.booksBindingSource;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(836, 38);
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 52);
            this.bindingNavigatorCountItem.Text = "of {0}";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codebookDataGridViewTextBoxColumn,
            this.titlebookDataGridViewTextBoxColumn,
            this.codeauthorDataGridViewTextBoxColumn,
            this.pagesDataGridViewTextBoxColumn,
            this.codepublishDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(836, 178);
            this.dataGridView1.TabIndex = 18;
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
            // titlebookDataGridViewTextBoxColumn
            // 
            this.titlebookDataGridViewTextBoxColumn.DataPropertyName = "Title_book";
            this.titlebookDataGridViewTextBoxColumn.HeaderText = "Title_book";
            this.titlebookDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titlebookDataGridViewTextBoxColumn.Name = "titlebookDataGridViewTextBoxColumn";
            this.titlebookDataGridViewTextBoxColumn.ReadOnly = true;
            this.titlebookDataGridViewTextBoxColumn.Width = 150;
            // 
            // codeauthorDataGridViewTextBoxColumn
            // 
            this.codeauthorDataGridViewTextBoxColumn.DataPropertyName = "Code_author";
            this.codeauthorDataGridViewTextBoxColumn.HeaderText = "Code_author";
            this.codeauthorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codeauthorDataGridViewTextBoxColumn.Name = "codeauthorDataGridViewTextBoxColumn";
            this.codeauthorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeauthorDataGridViewTextBoxColumn.Width = 150;
            // 
            // pagesDataGridViewTextBoxColumn
            // 
            this.pagesDataGridViewTextBoxColumn.DataPropertyName = "Pages";
            this.pagesDataGridViewTextBoxColumn.HeaderText = "Pages";
            this.pagesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pagesDataGridViewTextBoxColumn.Name = "pagesDataGridViewTextBoxColumn";
            this.pagesDataGridViewTextBoxColumn.ReadOnly = true;
            this.pagesDataGridViewTextBoxColumn.Width = 150;
            // 
            // codepublishDataGridViewTextBoxColumn
            // 
            this.codepublishDataGridViewTextBoxColumn.DataPropertyName = "Code_publish";
            this.codepublishDataGridViewTextBoxColumn.HeaderText = "Code_publish";
            this.codepublishDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codepublishDataGridViewTextBoxColumn.Name = "codepublishDataGridViewTextBoxColumn";
            this.codepublishDataGridViewTextBoxColumn.ReadOnly = true;
            this.codepublishDataGridViewTextBoxColumn.Width = 150;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // publishing_houseTableAdapter
            // 
            this.publishing_houseTableAdapter.ClearBeforeFill = true;
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClearFilter);
            this.Controls.Add(this.buttonFilterPages);
            this.Controls.Add(this.buttonFilterAuthor);
            this.Controls.Add(this.buttonFilterName);
            this.Controls.Add(this.buttonPublishHouseFilter);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBusinessDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishinghouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClearFilter;
        private System.Windows.Forms.Button buttonFilterPages;
        private System.Windows.Forms.Button buttonFilterAuthor;
        private System.Windows.Forms.Button buttonFilterName;
        private System.Windows.Forms.Button buttonPublishHouseFilter;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private BookBusinessDatabaseDataSet bookBusinessDatabaseDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private BookBusinessDatabaseDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codebookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titlebookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepublishDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private BookBusinessDatabaseDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.BindingSource publishinghouseBindingSource;
        private BookBusinessDatabaseDataSetTableAdapters.Publishing_houseTableAdapter publishing_houseTableAdapter;
    }
}