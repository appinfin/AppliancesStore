
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.comBoxBrand = new System.Windows.Forms.ComboBox();
            this.lblProductBrand = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductGroup = new System.Windows.Forms.Label();
            this.lblProductUnits = new System.Windows.Forms.Label();
            this.lblProductSale = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtGroupProduct = new System.Windows.Forms.TextBox();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtProductId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comBoxBrand, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblProductBrand, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblProductId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProductName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblProductGroup, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProductUnits, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblProductSale, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtProductName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtGroupProduct, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUnits, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 100);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txtProductId
            // 
            this.txtProductId.BackColor = System.Drawing.Color.White;
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
            this.comBoxBrand.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.comBoxBrand.Enter += new System.EventHandler(this.ComboBox1_Enter);
            this.comBoxBrand.Leave += new System.EventHandler(this.ComboBox1_Leave);
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
            this.txtProductName.Size = new System.Drawing.Size(193, 21);
            this.txtProductName.TabIndex = 2;
            // 
            // txtGroupProduct
            // 
            this.txtGroupProduct.Location = new System.Drawing.Point(401, 6);
            this.txtGroupProduct.Name = "txtGroupProduct";
            this.txtGroupProduct.Size = new System.Drawing.Size(193, 21);
            this.txtGroupProduct.TabIndex = 4;
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(401, 37);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(193, 21);
            this.txtUnits.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(401, 68);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(193, 21);
            this.textBox7.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Test_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Test_Form";
            this.Text = "Test_Form";
            this.Load += new System.EventHandler(this.Test_Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductBrand;
        private System.Windows.Forms.Label lblProductGroup;
        private System.Windows.Forms.Label lblProductUnits;
        private System.Windows.Forms.Label lblProductSale;

        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;

        private System.Windows.Forms.TextBox txtGroupProduct;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.TextBox textBox7;


        private System.Windows.Forms.ComboBox comBoxBrand;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
    }
}