
namespace Enterprise_Store_beta_1._0
{
    partial class Test_Form
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
            this.tableLayoutPanel_AddProduct = new System.Windows.Forms.TableLayoutPanel();
            this.numSale_AddProduct = new System.Windows.Forms.NumericUpDown();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.comBoxBrand = new System.Windows.Forms.ComboBox();
            this.lblProductBrand = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductGroup = new System.Windows.Forms.Label();
            this.lblProductUnits = new System.Windows.Forms.Label();
            this.lblProductSale = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.comBoxProductGroup = new System.Windows.Forms.ComboBox();
            this.comBoxUnit = new System.Windows.Forms.ComboBox();
            this.bindComBox_Brand = new System.Windows.Forms.BindingSource(this.components);
            this.butSave_AddProduct = new System.Windows.Forms.Button();
            this.bindComBox_ProductGroup = new System.Windows.Forms.BindingSource(this.components);
            this.bindComBox_Unit = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel_AddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSale_AddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindComBox_Brand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindComBox_ProductGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindComBox_Unit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_AddProduct
            // 
            this.tableLayoutPanel_AddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_AddProduct.ColumnCount = 4;
            this.tableLayoutPanel_AddProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_AddProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_AddProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_AddProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_AddProduct.Controls.Add(this.numSale_AddProduct, 3, 2);
            this.tableLayoutPanel_AddProduct.Controls.Add(this.txtProductId, 1, 0);
            this.tableLayoutPanel_AddProduct.Controls.Add(this.comBoxBrand, 1, 2);
            this.tableLayoutPanel_AddProduct.Controls.Add(this.lblProductBrand, 0, 2);
            this.tableLayoutPanel_AddProduct.Controls.Add(this.lblProductId, 0, 0);
            this.tableLayoutPanel_AddProduct.Controls.Add(this.lblProductName, 0, 1);
            this.tableLayoutPanel_AddProduct.Controls.Add(this.lblProductGroup, 2, 0);
            this.tableLayoutPanel_AddProduct.Controls.Add(this.lblProductUnits, 2, 1);
            this.tableLayoutPanel_AddProduct.Controls.Add(this.lblProductSale, 2, 2);
            this.tableLayoutPanel_AddProduct.Controls.Add(this.txtProductName, 1, 1);
            this.tableLayoutPanel_AddProduct.Controls.Add(this.comBoxProductGroup, 3, 0);
            this.tableLayoutPanel_AddProduct.Controls.Add(this.comBoxUnit, 3, 1);
            this.tableLayoutPanel_AddProduct.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel_AddProduct.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel_AddProduct.Name = "tableLayoutPanel_AddProduct";
            this.tableLayoutPanel_AddProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel_AddProduct.RowCount = 3;
            this.tableLayoutPanel_AddProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_AddProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_AddProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_AddProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_AddProduct.Size = new System.Drawing.Size(600, 100);
            this.tableLayoutPanel_AddProduct.TabIndex = 3;
            // 
            // numSale_AddProduct
            // 
            this.numSale_AddProduct.DecimalPlaces = 2;
            this.numSale_AddProduct.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSale_AddProduct.Location = new System.Drawing.Point(401, 68);
            this.numSale_AddProduct.Name = "numSale_AddProduct";
            this.numSale_AddProduct.Size = new System.Drawing.Size(193, 21);
            this.numSale_AddProduct.TabIndex = 6;
            this.numSale_AddProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProductId
            // 
            this.txtProductId.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductId.Cursor = System.Windows.Forms.Cursors.No;
            this.txtProductId.Location = new System.Drawing.Point(144, 6);
            this.txtProductId.MaxLength = 16;
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(193, 21);
            this.txtProductId.TabIndex = 1;
            // 
            // comBoxBrand
            // 
            this.comBoxBrand.DisplayMember = "BrandName";
            this.comBoxBrand.Location = new System.Drawing.Point(144, 68);
            this.comBoxBrand.Name = "comBoxBrand";
            this.comBoxBrand.Size = new System.Drawing.Size(193, 21);
            this.comBoxBrand.TabIndex = 3;
            this.comBoxBrand.ValueMember = "BrandId";
            // 
            // lblProductBrand
            // 
            this.lblProductBrand.AutoSize = true;
            this.lblProductBrand.Location = new System.Drawing.Point(8, 70);
            this.lblProductBrand.Margin = new System.Windows.Forms.Padding(5);
            this.lblProductBrand.Name = "lblProductBrand";
            this.lblProductBrand.Size = new System.Drawing.Size(128, 13);
            this.lblProductBrand.TabIndex = 0;
            this.lblProductBrand.Text = "Производитель (бренд)";
            this.lblProductBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(8, 8);
            this.lblProductId.Margin = new System.Windows.Forms.Padding(5);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(27, 13);
            this.lblProductId.TabIndex = 0;
            this.lblProductId.Text = "Код";
            this.lblProductId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(8, 39);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(5);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(80, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Наименование";
            // 
            // lblProductGroup
            // 
            this.lblProductGroup.AutoSize = true;
            this.lblProductGroup.Location = new System.Drawing.Point(345, 8);
            this.lblProductGroup.Margin = new System.Windows.Forms.Padding(5);
            this.lblProductGroup.Name = "lblProductGroup";
            this.lblProductGroup.Size = new System.Drawing.Size(43, 13);
            this.lblProductGroup.TabIndex = 0;
            this.lblProductGroup.Text = "Группа";
            this.lblProductGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductUnits
            // 
            this.lblProductUnits.AutoSize = true;
            this.lblProductUnits.Location = new System.Drawing.Point(345, 39);
            this.lblProductUnits.Margin = new System.Windows.Forms.Padding(5);
            this.lblProductUnits.Name = "lblProductUnits";
            this.lblProductUnits.Size = new System.Drawing.Size(48, 13);
            this.lblProductUnits.TabIndex = 0;
            this.lblProductUnits.Text = "Ед. изм.";
            // 
            // lblProductSale
            // 
            this.lblProductSale.AutoSize = true;
            this.lblProductSale.Location = new System.Drawing.Point(345, 70);
            this.lblProductSale.Margin = new System.Windows.Forms.Padding(5);
            this.lblProductSale.Name = "lblProductSale";
            this.lblProductSale.Size = new System.Drawing.Size(45, 13);
            this.lblProductSale.TabIndex = 0;
            this.lblProductSale.Text = "Скидка";
            this.lblProductSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(144, 37);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PlaceholderText = "- наименование товара -";
            this.txtProductName.Size = new System.Drawing.Size(193, 21);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.Leave += new System.EventHandler(this.txtProductName_Leave);
            // 
            // comBoxProductGroup
            // 
            this.comBoxProductGroup.DisplayMember = "ProductGroupName";
            this.comBoxProductGroup.FormattingEnabled = true;
            this.comBoxProductGroup.Location = new System.Drawing.Point(401, 6);
            this.comBoxProductGroup.Name = "comBoxProductGroup";
            this.comBoxProductGroup.Size = new System.Drawing.Size(193, 21);
            this.comBoxProductGroup.TabIndex = 4;
            this.comBoxProductGroup.ValueMember = "ProductGroupId";
            // 
            // comBoxUnit
            // 
            this.comBoxUnit.DisplayMember = "UnitName";
            this.comBoxUnit.FormattingEnabled = true;
            this.comBoxUnit.Location = new System.Drawing.Point(401, 37);
            this.comBoxUnit.Name = "comBoxUnit";
            this.comBoxUnit.Size = new System.Drawing.Size(193, 21);
            this.comBoxUnit.TabIndex = 5;
            this.comBoxUnit.ValueMember = "IdUnit";
            // 
            // butSave_AddProduct
            // 
            this.butSave_AddProduct.Location = new System.Drawing.Point(532, 118);
            this.butSave_AddProduct.Name = "butSave_AddProduct";
            this.butSave_AddProduct.Size = new System.Drawing.Size(80, 25);
            this.butSave_AddProduct.TabIndex = 5;
            this.butSave_AddProduct.Text = "Сохранить";
            this.butSave_AddProduct.UseVisualStyleBackColor = true;
            this.butSave_AddProduct.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(600, 285);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Test_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butSave_AddProduct);
            this.Controls.Add(this.tableLayoutPanel_AddProduct);
            this.Name = "Test_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карточка товара";
            this.Load += new System.EventHandler(this.Test_Form_Load);
            this.tableLayoutPanel_AddProduct.ResumeLayout(false);
            this.tableLayoutPanel_AddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSale_AddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindComBox_Brand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindComBox_ProductGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindComBox_Unit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_AddProduct;

        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductBrand;
        private System.Windows.Forms.Label lblProductGroup;
        private System.Windows.Forms.Label lblProductUnits;
        private System.Windows.Forms.Label lblProductSale;

        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;


        private System.Windows.Forms.ComboBox comBoxBrand;
        private System.Windows.Forms.BindingSource bindComBox_Brand;
        private System.Windows.Forms.Button butSave_AddProduct;
        private System.Windows.Forms.ComboBox comBoxProductGroup;
        private System.Windows.Forms.ComboBox comBoxUnit;
        private System.Windows.Forms.BindingSource bindComBox_ProductGroup;
        private System.Windows.Forms.BindingSource bindComBox_Unit;
        private System.Windows.Forms.NumericUpDown numSale_AddProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}