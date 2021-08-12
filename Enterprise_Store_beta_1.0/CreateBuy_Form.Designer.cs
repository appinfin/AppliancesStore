using System;

namespace Enterprise_Store_beta_1._0
{
    public partial class CreateBuy_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.butSelectStorage_CreateBuy = new System.Windows.Forms.Button();
            this.butSelectCounterparty_CreateBuy = new System.Windows.Forms.Button();
            this.butOK_CreateBuy = new System.Windows.Forms.Button();
            this.butDisplayDGVcatalog_CreateBuy = new System.Windows.Forms.Button();
            this.splitContainer_CreateBuy = new System.Windows.Forms.SplitContainer();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.butClearList_CreateBuy = new System.Windows.Forms.Button();
            this.lblSumma = new System.Windows.Forms.Label();
            this.tabLayoutPanel_CreateBuy = new System.Windows.Forms.TableLayoutPanel();
            this.butSelectDate_CreateBuy = new System.Windows.Forms.Button();
            this.lblDate_CreateBuy = new System.Windows.Forms.Label();
            this.lblStorage_CreateBuy = new System.Windows.Forms.Label();
            this.lblProvider_CreateBuy = new System.Windows.Forms.Label();
            this.txtDate_CreateBuy = new System.Windows.Forms.TextBox();
            this.txtCounterparty_CreateBuy = new System.Windows.Forms.TextBox();
            this.txtStorage_CreateBuy = new System.Windows.Forms.TextBox();
            this.DGV_CreateBuy = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete_row = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSearch_CreateBuy = new System.Windows.Forms.TextBox();
            this.butCatalogProduct_Delete = new System.Windows.Forms.Button();
            this.butCatalogProduct_Edit = new System.Windows.Forms.Button();
            this.butAddProduct_CreateBuy = new System.Windows.Forms.Button();
            this.DGVcatalog_CreateBuy = new System.Windows.Forms.DataGridView();
            this.contextMenuStripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bind_DGV_CreateBuy = new System.Windows.Forms.BindingSource(this.components);
            this.bind_DGVcatalog_CreateBuy = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip_selectProduct_CreateBuy_Form = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_CreateBuy)).BeginInit();
            this.splitContainer_CreateBuy.Panel1.SuspendLayout();
            this.splitContainer_CreateBuy.Panel2.SuspendLayout();
            this.splitContainer_CreateBuy.SuspendLayout();
            this.tabLayoutPanel_CreateBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CreateBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcatalog_CreateBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bind_DGV_CreateBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bind_DGVcatalog_CreateBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // butSelectStorage_CreateBuy
            // 
            this.butSelectStorage_CreateBuy.Location = new System.Drawing.Point(341, 57);
            this.butSelectStorage_CreateBuy.Name = "butSelectStorage_CreateBuy";
            this.butSelectStorage_CreateBuy.Size = new System.Drawing.Size(32, 21);
            this.butSelectStorage_CreateBuy.TabIndex = 3;
            this.butSelectStorage_CreateBuy.Text = "...";
            this.butSelectStorage_CreateBuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butSelectStorage_CreateBuy.UseVisualStyleBackColor = true;
            this.butSelectStorage_CreateBuy.Click += new System.EventHandler(this.ButSelectStorage_CreateBuy_Click);
            // 
            // butSelectCounterparty_CreateBuy
            // 
            this.butSelectCounterparty_CreateBuy.Location = new System.Drawing.Point(341, 30);
            this.butSelectCounterparty_CreateBuy.Name = "butSelectCounterparty_CreateBuy";
            this.butSelectCounterparty_CreateBuy.Size = new System.Drawing.Size(32, 21);
            this.butSelectCounterparty_CreateBuy.TabIndex = 2;
            this.butSelectCounterparty_CreateBuy.Text = "...";
            this.butSelectCounterparty_CreateBuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butSelectCounterparty_CreateBuy.UseVisualStyleBackColor = true;
            this.butSelectCounterparty_CreateBuy.Click += new System.EventHandler(this.ButSelectCounterparty_CreateBuy_Click);
            // 
            // butOK_CreateBuy
            // 
            this.butOK_CreateBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butOK_CreateBuy.Location = new System.Drawing.Point(353, 411);
            this.butOK_CreateBuy.Name = "butOK_CreateBuy";
            this.butOK_CreateBuy.Size = new System.Drawing.Size(111, 28);
            this.butOK_CreateBuy.TabIndex = 3;
            this.butOK_CreateBuy.Text = "Провести";
            this.butOK_CreateBuy.UseVisualStyleBackColor = true;
            this.butOK_CreateBuy.Click += new System.EventHandler(this.ButOK_CreateBuy_Click);
            // 
            // butDisplayDGVcatalog_CreateBuy
            // 
            this.butDisplayDGVcatalog_CreateBuy.Location = new System.Drawing.Point(12, 99);
            this.butDisplayDGVcatalog_CreateBuy.Name = "butDisplayDGVcatalog_CreateBuy";
            this.butDisplayDGVcatalog_CreateBuy.Size = new System.Drawing.Size(111, 28);
            this.butDisplayDGVcatalog_CreateBuy.TabIndex = 4;
            this.butDisplayDGVcatalog_CreateBuy.Text = "Подобрать товар";
            this.butDisplayDGVcatalog_CreateBuy.UseVisualStyleBackColor = true;
            this.butDisplayDGVcatalog_CreateBuy.Click += new System.EventHandler(this.ButDisplayDGVcatalog_CreateBuy_Click);
            // 
            // splitContainer_CreateBuy
            // 
            this.splitContainer_CreateBuy.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer_CreateBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_CreateBuy.IsSplitterFixed = true;
            this.splitContainer_CreateBuy.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_CreateBuy.Name = "splitContainer_CreateBuy";
            // 
            // splitContainer_CreateBuy.Panel1
            // 
            this.splitContainer_CreateBuy.Panel1.AllowDrop = true;
            this.splitContainer_CreateBuy.Panel1.Controls.Add(this.monthCalendar1);
            this.splitContainer_CreateBuy.Panel1.Controls.Add(this.butClearList_CreateBuy);
            this.splitContainer_CreateBuy.Panel1.Controls.Add(this.lblSumma);
            this.splitContainer_CreateBuy.Panel1.Controls.Add(this.tabLayoutPanel_CreateBuy);
            this.splitContainer_CreateBuy.Panel1.Controls.Add(this.butDisplayDGVcatalog_CreateBuy);
            this.splitContainer_CreateBuy.Panel1.Controls.Add(this.butOK_CreateBuy);
            this.splitContainer_CreateBuy.Panel1.Controls.Add(this.DGV_CreateBuy);
            // 
            // splitContainer_CreateBuy.Panel2
            // 
            this.splitContainer_CreateBuy.Panel2.AutoScroll = true;
            this.splitContainer_CreateBuy.Panel2.Controls.Add(this.txtSearch_CreateBuy);
            this.splitContainer_CreateBuy.Panel2.Controls.Add(this.butCatalogProduct_Delete);
            this.splitContainer_CreateBuy.Panel2.Controls.Add(this.butCatalogProduct_Edit);
            this.splitContainer_CreateBuy.Panel2.Controls.Add(this.butAddProduct_CreateBuy);
            this.splitContainer_CreateBuy.Panel2.Controls.Add(this.DGVcatalog_CreateBuy);
            this.splitContainer_CreateBuy.Size = new System.Drawing.Size(892, 465);
            this.splitContainer_CreateBuy.SplitterDistance = 500;
            this.splitContainer_CreateBuy.SplitterIncrement = 10;
            this.splitContainer_CreateBuy.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(252, 99);
            this.monthCalendar1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ScrollChange = 1;
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateSelected);
            // 
            // butClearList_CreateBuy
            // 
            this.butClearList_CreateBuy.Location = new System.Drawing.Point(129, 99);
            this.butClearList_CreateBuy.Name = "butClearList_CreateBuy";
            this.butClearList_CreateBuy.Size = new System.Drawing.Size(111, 28);
            this.butClearList_CreateBuy.TabIndex = 8;
            this.butClearList_CreateBuy.Text = "Очистить список";
            this.butClearList_CreateBuy.UseVisualStyleBackColor = true;
            this.butClearList_CreateBuy.Click += new System.EventHandler(this.ButClearList_CreateBuy_Click);
            // 
            // lblSumma
            // 
            this.lblSumma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSumma.AutoSize = true;
            this.lblSumma.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSumma.Location = new System.Drawing.Point(17, 411);
            this.lblSumma.Name = "lblSumma";
            this.lblSumma.Size = new System.Drawing.Size(126, 21);
            this.lblSumma.TabIndex = 7;
            this.lblSumma.Text = "Сумма 0,00 ₽";
            // 
            // tabLayoutPanel_CreateBuy
            // 
            this.tabLayoutPanel_CreateBuy.ColumnCount = 3;
            this.tabLayoutPanel_CreateBuy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabLayoutPanel_CreateBuy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayoutPanel_CreateBuy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tabLayoutPanel_CreateBuy.Controls.Add(this.butSelectDate_CreateBuy, 2, 0);
            this.tabLayoutPanel_CreateBuy.Controls.Add(this.butSelectStorage_CreateBuy, 2, 2);
            this.tabLayoutPanel_CreateBuy.Controls.Add(this.lblDate_CreateBuy, 0, 0);
            this.tabLayoutPanel_CreateBuy.Controls.Add(this.lblStorage_CreateBuy, 0, 2);
            this.tabLayoutPanel_CreateBuy.Controls.Add(this.lblProvider_CreateBuy, 0, 1);
            this.tabLayoutPanel_CreateBuy.Controls.Add(this.txtDate_CreateBuy, 1, 0);
            this.tabLayoutPanel_CreateBuy.Controls.Add(this.txtCounterparty_CreateBuy, 1, 1);
            this.tabLayoutPanel_CreateBuy.Controls.Add(this.txtStorage_CreateBuy, 1, 2);
            this.tabLayoutPanel_CreateBuy.Controls.Add(this.butSelectCounterparty_CreateBuy, 2, 1);
            this.tabLayoutPanel_CreateBuy.Location = new System.Drawing.Point(12, 12);
            this.tabLayoutPanel_CreateBuy.Name = "tabLayoutPanel_CreateBuy";
            this.tabLayoutPanel_CreateBuy.RowCount = 4;
            this.tabLayoutPanel_CreateBuy.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutPanel_CreateBuy.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutPanel_CreateBuy.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayoutPanel_CreateBuy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayoutPanel_CreateBuy.Size = new System.Drawing.Size(376, 81);
            this.tabLayoutPanel_CreateBuy.TabIndex = 5;
            // 
            // butSelectDate_CreateBuy
            // 
            this.butSelectDate_CreateBuy.Location = new System.Drawing.Point(341, 3);
            this.butSelectDate_CreateBuy.Name = "butSelectDate_CreateBuy";
            this.butSelectDate_CreateBuy.Size = new System.Drawing.Size(32, 21);
            this.butSelectDate_CreateBuy.TabIndex = 10;
            this.butSelectDate_CreateBuy.Text = "...";
            this.butSelectDate_CreateBuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butSelectDate_CreateBuy.UseVisualStyleBackColor = true;
            this.butSelectDate_CreateBuy.Click += new System.EventHandler(this.ButSelectDate_CreateBuy_Click);
            // 
            // lblDate_CreateBuy
            // 
            this.lblDate_CreateBuy.AutoSize = true;
            this.lblDate_CreateBuy.Location = new System.Drawing.Point(5, 5);
            this.lblDate_CreateBuy.Margin = new System.Windows.Forms.Padding(5);
            this.lblDate_CreateBuy.Name = "lblDate_CreateBuy";
            this.lblDate_CreateBuy.Size = new System.Drawing.Size(40, 13);
            this.lblDate_CreateBuy.TabIndex = 0;
            this.lblDate_CreateBuy.Text = "Дата: ";
            this.lblDate_CreateBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStorage_CreateBuy
            // 
            this.lblStorage_CreateBuy.AutoSize = true;
            this.lblStorage_CreateBuy.Location = new System.Drawing.Point(5, 59);
            this.lblStorage_CreateBuy.Margin = new System.Windows.Forms.Padding(5);
            this.lblStorage_CreateBuy.Name = "lblStorage_CreateBuy";
            this.lblStorage_CreateBuy.Size = new System.Drawing.Size(46, 13);
            this.lblStorage_CreateBuy.TabIndex = 2;
            this.lblStorage_CreateBuy.Text = "Склад: ";
            // 
            // lblProvider_CreateBuy
            // 
            this.lblProvider_CreateBuy.AutoSize = true;
            this.lblProvider_CreateBuy.Location = new System.Drawing.Point(5, 32);
            this.lblProvider_CreateBuy.Margin = new System.Windows.Forms.Padding(5);
            this.lblProvider_CreateBuy.Name = "lblProvider_CreateBuy";
            this.lblProvider_CreateBuy.Size = new System.Drawing.Size(71, 13);
            this.lblProvider_CreateBuy.TabIndex = 1;
            this.lblProvider_CreateBuy.Text = "Поставщик: ";
            this.lblProvider_CreateBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDate_CreateBuy
            // 
            this.txtDate_CreateBuy.Location = new System.Drawing.Point(84, 3);
            this.txtDate_CreateBuy.MaxLength = 32;
            this.txtDate_CreateBuy.Name = "txtDate_CreateBuy";
            this.txtDate_CreateBuy.ReadOnly = true;
            this.txtDate_CreateBuy.Size = new System.Drawing.Size(251, 21);
            this.txtDate_CreateBuy.TabIndex = 4;
            this.txtDate_CreateBuy.Tag = "";
            this.txtDate_CreateBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCounterparty_CreateBuy
            // 
            this.txtCounterparty_CreateBuy.Location = new System.Drawing.Point(84, 30);
            this.txtCounterparty_CreateBuy.MaxLength = 128;
            this.txtCounterparty_CreateBuy.Name = "txtCounterparty_CreateBuy";
            this.txtCounterparty_CreateBuy.ReadOnly = true;
            this.txtCounterparty_CreateBuy.Size = new System.Drawing.Size(251, 21);
            this.txtCounterparty_CreateBuy.TabIndex = 5;
            this.txtCounterparty_CreateBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtStorage_CreateBuy
            // 
            this.txtStorage_CreateBuy.Location = new System.Drawing.Point(84, 57);
            this.txtStorage_CreateBuy.MaxLength = 64;
            this.txtStorage_CreateBuy.Name = "txtStorage_CreateBuy";
            this.txtStorage_CreateBuy.ReadOnly = true;
            this.txtStorage_CreateBuy.Size = new System.Drawing.Size(251, 21);
            this.txtStorage_CreateBuy.TabIndex = 6;
            this.txtStorage_CreateBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DGV_CreateBuy
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.DGV_CreateBuy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_CreateBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_CreateBuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CreateBuy.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_CreateBuy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_CreateBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CreateBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.Product_Name,
            this.Quantity,
            this.PricePurchase,
            this.Summa,
            this.Delete_row});
            this.DGV_CreateBuy.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_CreateBuy.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_CreateBuy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGV_CreateBuy.Location = new System.Drawing.Point(12, 133);
            this.DGV_CreateBuy.Name = "DGV_CreateBuy";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_CreateBuy.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGV_CreateBuy.RowHeadersVisible = false;
            this.DGV_CreateBuy.RowTemplate.Height = 23;
            this.DGV_CreateBuy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGV_CreateBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_CreateBuy.Size = new System.Drawing.Size(485, 270);
            this.DGV_CreateBuy.TabIndex = 6;
            this.DGV_CreateBuy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CreateBuy_CellClick);
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.FillWeight = 25F;
            this.ProductId.HeaderText = "Код";
            this.ProductId.MaxInputLength = 16;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Product_Name
            // 
            this.Product_Name.DataPropertyName = "ProductName";
            this.Product_Name.HeaderText = "Наименование";
            this.Product_Name.MaxInputLength = 128;
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            this.Product_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 25F;
            this.Quantity.HeaderText = "Количество";
            this.Quantity.MaxInputLength = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PricePurchase
            // 
            this.PricePurchase.DataPropertyName = "PricePurchase";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.PricePurchase.DefaultCellStyle = dataGridViewCellStyle3;
            this.PricePurchase.FillWeight = 30F;
            this.PricePurchase.HeaderText = "Цена";
            this.PricePurchase.MaxInputLength = 16;
            this.PricePurchase.Name = "PricePurchase";
            this.PricePurchase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Summa
            // 
            this.Summa.DataPropertyName = "Summa";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Summa.DefaultCellStyle = dataGridViewCellStyle4;
            this.Summa.FillWeight = 30F;
            this.Summa.HeaderText = "Сумма";
            this.Summa.MaxInputLength = 16;
            this.Summa.Name = "Summa";
            this.Summa.ReadOnly = true;
            this.Summa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Delete_row
            // 
            this.Delete_row.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete_row.DataPropertyName = "textButton";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            this.Delete_row.DefaultCellStyle = dataGridViewCellStyle5;
            this.Delete_row.FillWeight = 5F;
            this.Delete_row.HeaderText = "";
            this.Delete_row.MinimumWidth = 25;
            this.Delete_row.Name = "Delete_row";
            this.Delete_row.ReadOnly = true;
            this.Delete_row.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete_row.Text = "X";
            this.Delete_row.UseColumnTextForButtonValue = true;
            this.Delete_row.Width = 25;
            // 
            // txtSearch_CreateBuy
            // 
            this.txtSearch_CreateBuy.Location = new System.Drawing.Point(16, 72);
            this.txtSearch_CreateBuy.Name = "txtSearch_CreateBuy";
            this.txtSearch_CreateBuy.PlaceholderText = "- наименование товара для поиска -";
            this.txtSearch_CreateBuy.Size = new System.Drawing.Size(237, 21);
            this.txtSearch_CreateBuy.TabIndex = 2;
            this.toolTip_selectProduct_CreateBuy_Form.SetToolTip(this.txtSearch_CreateBuy, "Введите не менее 3-х символов.\r\nПробелы тоже учитываются.");
            this.txtSearch_CreateBuy.TextChanged += new System.EventHandler(this.txtSearch_CreateBuy_TextChanged);
            // 
            // butCatalogProduct_Delete
            // 
            this.butCatalogProduct_Delete.Location = new System.Drawing.Point(178, 99);
            this.butCatalogProduct_Delete.Name = "butCatalogProduct_Delete";
            this.butCatalogProduct_Delete.Size = new System.Drawing.Size(75, 28);
            this.butCatalogProduct_Delete.TabIndex = 1;
            this.butCatalogProduct_Delete.Text = "Удалить";
            this.butCatalogProduct_Delete.UseVisualStyleBackColor = true;
            this.butCatalogProduct_Delete.Click += new System.EventHandler(this.ButCatalogProduct_Delete_Click);
            // 
            // butCatalogProduct_Edit
            // 
            this.butCatalogProduct_Edit.Location = new System.Drawing.Point(97, 99);
            this.butCatalogProduct_Edit.Name = "butCatalogProduct_Edit";
            this.butCatalogProduct_Edit.Size = new System.Drawing.Size(75, 28);
            this.butCatalogProduct_Edit.TabIndex = 1;
            this.butCatalogProduct_Edit.Text = "Изменить";
            this.butCatalogProduct_Edit.UseVisualStyleBackColor = true;
            this.butCatalogProduct_Edit.Click += new System.EventHandler(this.ButCatalogProduct_Edit_Click);
            // 
            // butAddProduct_CreateBuy
            // 
            this.butAddProduct_CreateBuy.Location = new System.Drawing.Point(16, 99);
            this.butAddProduct_CreateBuy.Name = "butAddProduct_CreateBuy";
            this.butAddProduct_CreateBuy.Size = new System.Drawing.Size(75, 28);
            this.butAddProduct_CreateBuy.TabIndex = 1;
            this.butAddProduct_CreateBuy.Text = "Добавить";
            this.butAddProduct_CreateBuy.UseVisualStyleBackColor = true;
            this.butAddProduct_CreateBuy.Click += new System.EventHandler(this.ButAddProduct_CreateBuy_Click);
            // 
            // DGVcatalog_CreateBuy
            // 
            this.DGVcatalog_CreateBuy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVcatalog_CreateBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVcatalog_CreateBuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVcatalog_CreateBuy.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DGVcatalog_CreateBuy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVcatalog_CreateBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcatalog_CreateBuy.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVcatalog_CreateBuy.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGVcatalog_CreateBuy.Location = new System.Drawing.Point(3, 133);
            this.DGVcatalog_CreateBuy.MultiSelect = false;
            this.DGVcatalog_CreateBuy.Name = "DGVcatalog_CreateBuy";
            this.DGVcatalog_CreateBuy.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVcatalog_CreateBuy.RowHeadersVisible = false;
            this.DGVcatalog_CreateBuy.RowTemplate.Height = 23;
            this.DGVcatalog_CreateBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVcatalog_CreateBuy.Size = new System.Drawing.Size(382, 271);
            this.DGVcatalog_CreateBuy.TabIndex = 0;
            this.toolTip_selectProduct_CreateBuy_Form.SetToolTip(this.DGVcatalog_CreateBuy, "ДВОЙНОЙ КЛИК для\r\nДОБАВЛЕНИЯ в список товаров");
            this.DGVcatalog_CreateBuy.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVcatalog_CreateBuy_CellDoubleClick);
            // 
            // contextMenuStripDataGridViewTextBoxColumn
            // 
            this.contextMenuStripDataGridViewTextBoxColumn.DataPropertyName = "ContextMenuStrip";
            this.contextMenuStripDataGridViewTextBoxColumn.HeaderText = "ContextMenuStrip";
            this.contextMenuStripDataGridViewTextBoxColumn.Name = "contextMenuStripDataGridViewTextBoxColumn";
            // 
            // CreateBuy_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 465);
            this.Controls.Add(this.splitContainer_CreateBuy);
            this.Name = "CreateBuy_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateBuy_Form_FormClosed);
            this.splitContainer_CreateBuy.Panel1.ResumeLayout(false);
            this.splitContainer_CreateBuy.Panel1.PerformLayout();
            this.splitContainer_CreateBuy.Panel2.ResumeLayout(false);
            this.splitContainer_CreateBuy.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_CreateBuy)).EndInit();
            this.splitContainer_CreateBuy.ResumeLayout(false);
            this.tabLayoutPanel_CreateBuy.ResumeLayout(false);
            this.tabLayoutPanel_CreateBuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CreateBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcatalog_CreateBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bind_DGV_CreateBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bind_DGVcatalog_CreateBuy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butOK_CreateBuy;
        private System.Windows.Forms.Button butDisplayDGVcatalog_CreateBuy;
        private System.Windows.Forms.SplitContainer splitContainer_CreateBuy;
        private System.Windows.Forms.TableLayoutPanel tabLayoutPanel_CreateBuy;
        private System.Windows.Forms.Button butSelectStorage_CreateBuy;
        private System.Windows.Forms.Button butSelectDate_CreateBuy;
        internal System.Windows.Forms.Label lblDate_CreateBuy;
        internal System.Windows.Forms.Label lblStorage_CreateBuy;
        internal System.Windows.Forms.Label lblProvider_CreateBuy;
        internal System.Windows.Forms.TextBox txtDate_CreateBuy;
        internal System.Windows.Forms.TextBox txtCounterparty_CreateBuy;
        internal System.Windows.Forms.TextBox txtStorage_CreateBuy;
        private System.Windows.Forms.Button butSelectCounterparty_CreateBuy;
        private System.Windows.Forms.DataGridView DGVcatalog_CreateBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn contextMenuStripDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bind_DGV_CreateBuy;
        internal System.Windows.Forms.DataGridView DGV_CreateBuy;
        private System.Windows.Forms.BindingSource bind_DGVcatalog_CreateBuy;
        internal System.Windows.Forms.Label lblSumma;
        private System.Windows.Forms.Button butClearList_CreateBuy;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button butCatalogProduct_Delete;
        private System.Windows.Forms.Button butCatalogProduct_Edit;
        private System.Windows.Forms.Button butAddProduct_CreateBuy;
        private System.Windows.Forms.ToolTip toolTip_selectProduct_CreateBuy_Form;
        private System.Windows.Forms.TextBox txtSearch_CreateBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summa;
        private System.Windows.Forms.DataGridViewButtonColumn Delete_row;
    }
}