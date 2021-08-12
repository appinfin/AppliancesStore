
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogStorage_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tStripMenu_CatalogStorage = new System.Windows.Forms.ToolStrip();
            this.tStripMenu_CatalogStorage_Add = new System.Windows.Forms.ToolStripButton();
            this.tStripMenu_CatalogStorage_Edit = new System.Windows.Forms.ToolStripButton();
            this.tStripMenu_CatalogStorage_Delete = new System.Windows.Forms.ToolStripButton();
            this.DGV_CatalogStorage_Form = new System.Windows.Forms.DataGridView();
            this.StorageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StorageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxMenu_CatalogStorage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxMenu_CatalogStorage_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tStripMenu_CatalogStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CatalogStorage_Form)).BeginInit();
            this.ctxMenu_CatalogStorage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tStripMenu_CatalogStorage
            // 
            this.tStripMenu_CatalogStorage.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tStripMenu_CatalogStorage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripMenu_CatalogStorage_Add,
            this.tStripMenu_CatalogStorage_Edit,
            this.tStripMenu_CatalogStorage_Delete});
            this.tStripMenu_CatalogStorage.Location = new System.Drawing.Point(0, 0);
            this.tStripMenu_CatalogStorage.Name = "tStripMenu_CatalogStorage";
            this.tStripMenu_CatalogStorage.Size = new System.Drawing.Size(492, 25);
            this.tStripMenu_CatalogStorage.TabIndex = 0;
            this.tStripMenu_CatalogStorage.Text = "toolStrip1";
            // 
            // tStripMenu_CatalogStorage_Add
            // 
            this.tStripMenu_CatalogStorage_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStripMenu_CatalogStorage_Add.Image = ((System.Drawing.Image)(resources.GetObject("tStripMenu_CatalogStorage_Add.Image")));
            this.tStripMenu_CatalogStorage_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripMenu_CatalogStorage_Add.Name = "tStripMenu_CatalogStorage_Add";
            this.tStripMenu_CatalogStorage_Add.Size = new System.Drawing.Size(61, 22);
            this.tStripMenu_CatalogStorage_Add.Text = "Добавить";
            // 
            // tStripMenu_CatalogStorage_Edit
            // 
            this.tStripMenu_CatalogStorage_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStripMenu_CatalogStorage_Edit.Image = ((System.Drawing.Image)(resources.GetObject("tStripMenu_CatalogStorage_Edit.Image")));
            this.tStripMenu_CatalogStorage_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripMenu_CatalogStorage_Edit.Name = "tStripMenu_CatalogStorage_Edit";
            this.tStripMenu_CatalogStorage_Edit.Size = new System.Drawing.Size(59, 22);
            this.tStripMenu_CatalogStorage_Edit.Text = "Изменить";
            // 
            // tStripMenu_CatalogStorage_Delete
            // 
            this.tStripMenu_CatalogStorage_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStripMenu_CatalogStorage_Delete.Image = ((System.Drawing.Image)(resources.GetObject("tStripMenu_CatalogStorage_Delete.Image")));
            this.tStripMenu_CatalogStorage_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripMenu_CatalogStorage_Delete.Name = "tStripMenu_CatalogStorage_Delete";
            this.tStripMenu_CatalogStorage_Delete.Size = new System.Drawing.Size(55, 22);
            this.tStripMenu_CatalogStorage_Delete.Text = "Удалить";
            this.tStripMenu_CatalogStorage_Delete.Click += new System.EventHandler(this.TStripMenu_CatalogStorage_Delete_Click);
            // 
            // DGV_CatalogStorage_Form
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.DGV_CatalogStorage_Form.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_CatalogStorage_Form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_CatalogStorage_Form.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_CatalogStorage_Form.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_CatalogStorage_Form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CatalogStorage_Form.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StorageId,
            this.StorageName});
            this.DGV_CatalogStorage_Form.ContextMenuStrip = this.ctxMenu_CatalogStorage;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_CatalogStorage_Form.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_CatalogStorage_Form.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DGV_CatalogStorage_Form.Location = new System.Drawing.Point(0, 28);
            this.DGV_CatalogStorage_Form.Name = "DGV_CatalogStorage_Form";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.DGV_CatalogStorage_Form.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.DGV_CatalogStorage_Form.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_CatalogStorage_Form.RowTemplate.Height = 23;
            this.DGV_CatalogStorage_Form.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_CatalogStorage_Form.Size = new System.Drawing.Size(492, 332);
            this.DGV_CatalogStorage_Form.TabIndex = 1;
            this.toolTip1.SetToolTip(this.DGV_CatalogStorage_Form, "\r\nнажмите F2\r\nили\r\nдвойной клик ЛКМ");
            this.DGV_CatalogStorage_Form.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CatalogStorage_Form_CellDoubleClick);
            this.DGV_CatalogStorage_Form.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DGV_CatalogStorage_Form_CellValidating);
            // 
            // StorageId
            // 
            this.StorageId.DataPropertyName = "StorageId";
            this.StorageId.FillWeight = 30F;
            this.StorageId.HeaderText = "Код";
            this.StorageId.MaxInputLength = 16;
            this.StorageId.Name = "StorageId";
            this.StorageId.ReadOnly = true;
            this.StorageId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StorageName
            // 
            this.StorageName.DataPropertyName = "StorageName";
            this.StorageName.HeaderText = "Наименование";
            this.StorageName.MaxInputLength = 128;
            this.StorageName.Name = "StorageName";
            // 
            // ctxMenu_CatalogStorage
            // 
            this.ctxMenu_CatalogStorage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenu_CatalogStorage_Delete});
            this.ctxMenu_CatalogStorage.Name = "ctxMenu_CatalogStorage";
            this.ctxMenu_CatalogStorage.Size = new System.Drawing.Size(162, 26);
            // 
            // ctxMenu_CatalogStorage_Delete
            // 
            this.ctxMenu_CatalogStorage_Delete.Name = "ctxMenu_CatalogStorage_Delete";
            this.ctxMenu_CatalogStorage_Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.ctxMenu_CatalogStorage_Delete.Size = new System.Drawing.Size(161, 22);
            this.ctxMenu_CatalogStorage_Delete.Text = "Удалить";
            this.ctxMenu_CatalogStorage_Delete.Click += new System.EventHandler(this.CtxMenu_CatalogStorage_Delete_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Редактирование";
            // 
            // CatalogStorage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 372);
            this.Controls.Add(this.DGV_CatalogStorage_Form);
            this.Controls.Add(this.tStripMenu_CatalogStorage);
            this.Name = "CatalogStorage_Form";
            this.Text = "CatalogStorage_Form";
            this.Load += new System.EventHandler(this.CatalogStorage_Form_Load);
            this.tStripMenu_CatalogStorage.ResumeLayout(false);
            this.tStripMenu_CatalogStorage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CatalogStorage_Form)).EndInit();
            this.ctxMenu_CatalogStorage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tStripMenu_CatalogStorage;
        private System.Windows.Forms.ToolStripButton tStripMenu_CatalogStorage_Add;
        private System.Windows.Forms.ToolStripButton tStripMenu_CatalogStorage_Edit;
        private System.Windows.Forms.ToolStripButton tStripMenu_CatalogStorage_Delete;
        private System.Windows.Forms.DataGridView DGV_CatalogStorage_Form;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorageName;
        private System.Windows.Forms.ContextMenuStrip ctxMenu_CatalogStorage;
        private System.Windows.Forms.ToolStripMenuItem ctxMenu_CatalogStorage_Delete;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}