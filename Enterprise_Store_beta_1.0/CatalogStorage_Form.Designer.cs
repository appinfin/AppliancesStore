
namespace Enterprise_Store_beta_1._0
{
    partial class CatalogStorage_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogStorage_Form));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.DGV_CatalogStorage_Form = new System.Windows.Forms.DataGridView();
            this.StorageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StorageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CatalogStorage_Form)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(492, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(61, 22);
            this.toolStripButton1.Text = "Добавить";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(59, 22);
            this.toolStripButton2.Text = "Изменить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(55, 22);
            this.toolStripButton3.Text = "Удалить";
            // 
            // DGV_CatalogStorage_Form
            // 
            this.DGV_CatalogStorage_Form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_CatalogStorage_Form.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CatalogStorage_Form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CatalogStorage_Form.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StorageId,
            this.StorageName});
            this.DGV_CatalogStorage_Form.Location = new System.Drawing.Point(0, 28);
            this.DGV_CatalogStorage_Form.Name = "DGV_CatalogStorage_Form";
            this.DGV_CatalogStorage_Form.RowTemplate.Height = 23;
            this.DGV_CatalogStorage_Form.Size = new System.Drawing.Size(492, 332);
            this.DGV_CatalogStorage_Form.TabIndex = 1;
            this.DGV_CatalogStorage_Form.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CatalogStorage_Form_CellDoubleClick);
            // 
            // StorageId
            // 
            this.StorageId.DataPropertyName = "StorageId";
            this.StorageId.FillWeight = 30F;
            this.StorageId.HeaderText = "Код";
            this.StorageId.MaxInputLength = 16;
            this.StorageId.Name = "StorageId";
            this.StorageId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StorageName
            // 
            this.StorageName.DataPropertyName = "StorageName";
            this.StorageName.HeaderText = "Наименование";
            this.StorageName.MaxInputLength = 128;
            this.StorageName.Name = "StorageName";
            // 
            // CatalogStorage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 372);
            this.Controls.Add(this.DGV_CatalogStorage_Form);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CatalogStorage_Form";
            this.Text = "CatalogStorage_Form";
            this.Load += new System.EventHandler(this.CatalogStorage_Form_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CatalogStorage_Form)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridView DGV_CatalogStorage_Form;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorageName;
    }
}