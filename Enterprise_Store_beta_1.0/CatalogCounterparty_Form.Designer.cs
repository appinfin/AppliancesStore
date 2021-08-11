
namespace Enterprise_Store_beta_1._0
{
    partial class CatalogCounterparty_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogCounterparty_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tStrip_CatalogCounterparty = new System.Windows.Forms.ToolStrip();
            this.tStrip_CatalogCounterparty_Add = new System.Windows.Forms.ToolStripButton();
            this.tStrip_CatalogCounterparty_Edit = new System.Windows.Forms.ToolStripButton();
            this.tStrip_CatalogCounterparty_Delete = new System.Windows.Forms.ToolStripButton();
            this.DGV_CatalogCounterparty_Form = new System.Windows.Forms.DataGridView();
            this.CounterpartyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CounterpartyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InnOgrnKpp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxMenuStrip_CataloCounterparty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tStrip_ctxMenu_CataloCounterparty_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip_CatalogCounterparty = new System.Windows.Forms.ToolTip(this.components);
            this.tStrip_CatalogCounterparty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CatalogCounterparty_Form)).BeginInit();
            this.ctxMenuStrip_CataloCounterparty.SuspendLayout();
            this.SuspendLayout();
            // 
            // tStrip_CatalogCounterparty
            // 
            this.tStrip_CatalogCounterparty.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tStrip_CatalogCounterparty.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStrip_CatalogCounterparty_Add,
            this.tStrip_CatalogCounterparty_Edit,
            this.tStrip_CatalogCounterparty_Delete});
            this.tStrip_CatalogCounterparty.Location = new System.Drawing.Point(0, 0);
            this.tStrip_CatalogCounterparty.Name = "tStrip_CatalogCounterparty";
            this.tStrip_CatalogCounterparty.Size = new System.Drawing.Size(500, 25);
            this.tStrip_CatalogCounterparty.TabIndex = 0;
            this.tStrip_CatalogCounterparty.Text = "Действие";
            // 
            // tStrip_CatalogCounterparty_Add
            // 
            this.tStrip_CatalogCounterparty_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStrip_CatalogCounterparty_Add.Image = ((System.Drawing.Image)(resources.GetObject("tStrip_CatalogCounterparty_Add.Image")));
            this.tStrip_CatalogCounterparty_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStrip_CatalogCounterparty_Add.Name = "tStrip_CatalogCounterparty_Add";
            this.tStrip_CatalogCounterparty_Add.Size = new System.Drawing.Size(61, 22);
            this.tStrip_CatalogCounterparty_Add.Text = "Добавить";
            // 
            // tStrip_CatalogCounterparty_Edit
            // 
            this.tStrip_CatalogCounterparty_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStrip_CatalogCounterparty_Edit.Image = ((System.Drawing.Image)(resources.GetObject("tStrip_CatalogCounterparty_Edit.Image")));
            this.tStrip_CatalogCounterparty_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStrip_CatalogCounterparty_Edit.Name = "tStrip_CatalogCounterparty_Edit";
            this.tStrip_CatalogCounterparty_Edit.Size = new System.Drawing.Size(59, 22);
            this.tStrip_CatalogCounterparty_Edit.Text = "Изменить";
            // 
            // tStrip_CatalogCounterparty_Delete
            // 
            this.tStrip_CatalogCounterparty_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStrip_CatalogCounterparty_Delete.Image = ((System.Drawing.Image)(resources.GetObject("tStrip_CatalogCounterparty_Delete.Image")));
            this.tStrip_CatalogCounterparty_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStrip_CatalogCounterparty_Delete.Name = "tStrip_CatalogCounterparty_Delete";
            this.tStrip_CatalogCounterparty_Delete.Size = new System.Drawing.Size(55, 22);
            this.tStrip_CatalogCounterparty_Delete.Text = "Удалить";
            this.tStrip_CatalogCounterparty_Delete.Click += new System.EventHandler(this.TStrip_CatalogCounterparty_Delete_Click);
            // 
            // DGV_CatalogCounterparty_Form
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.DGV_CatalogCounterparty_Form.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_CatalogCounterparty_Form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_CatalogCounterparty_Form.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_CatalogCounterparty_Form.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGV_CatalogCounterparty_Form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CatalogCounterparty_Form.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CounterpartyId,
            this.CounterpartyName,
            this.InnOgrnKpp});
            this.DGV_CatalogCounterparty_Form.ContextMenuStrip = this.ctxMenuStrip_CataloCounterparty;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_CatalogCounterparty_Form.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGV_CatalogCounterparty_Form.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DGV_CatalogCounterparty_Form.Location = new System.Drawing.Point(0, 28);
            this.DGV_CatalogCounterparty_Form.Name = "DGV_CatalogCounterparty_Form";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_CatalogCounterparty_Form.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.DGV_CatalogCounterparty_Form.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGV_CatalogCounterparty_Form.RowTemplate.Height = 23;
            this.DGV_CatalogCounterparty_Form.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_CatalogCounterparty_Form.Size = new System.Drawing.Size(492, 332);
            this.DGV_CatalogCounterparty_Form.TabIndex = 1;
            this.toolTip_CatalogCounterparty.SetToolTip(this.DGV_CatalogCounterparty_Form, "\r\nнажмите клавишу F2\r\nили\r\nдвойной клик ЛКМ");
            this.DGV_CatalogCounterparty_Form.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CatalogCounterparty_Form_CellDoubleClick);
            this.DGV_CatalogCounterparty_Form.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DGV_CatalogCounterparty_Form_CellValidating);
            this.DGV_CatalogCounterparty_Form.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DGV_CatalogCounterparty_Form_DataError);
            // 
            // CounterpartyId
            // 
            this.CounterpartyId.DataPropertyName = "CounterpartyId";
            this.CounterpartyId.FillWeight = 20F;
            this.CounterpartyId.HeaderText = "Код";
            this.CounterpartyId.MaxInputLength = 16;
            this.CounterpartyId.Name = "CounterpartyId";
            this.CounterpartyId.ReadOnly = true;
            this.CounterpartyId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CounterpartyName
            // 
            this.CounterpartyName.DataPropertyName = "CounterpartyName";
            this.CounterpartyName.HeaderText = "Наименование";
            this.CounterpartyName.MaxInputLength = 128;
            this.CounterpartyName.Name = "CounterpartyName";
            // 
            // InnOgrnKpp
            // 
            this.InnOgrnKpp.DataPropertyName = "InnOgrnKpp";
            this.InnOgrnKpp.FillWeight = 30F;
            this.InnOgrnKpp.HeaderText = "ИНН/ОГРН/КПП";
            this.InnOgrnKpp.MaxInputLength = 64;
            this.InnOgrnKpp.Name = "InnOgrnKpp";
            this.InnOgrnKpp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ctxMenuStrip_CataloCounterparty
            // 
            this.ctxMenuStrip_CataloCounterparty.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStrip_ctxMenu_CataloCounterparty_Delete});
            this.ctxMenuStrip_CataloCounterparty.Name = "ctxMenuStrip_CataloCounterparty";
            this.ctxMenuStrip_CataloCounterparty.Size = new System.Drawing.Size(181, 48);
            // 
            // tStrip_ctxMenu_CataloCounterparty_Delete
            // 
            this.tStrip_ctxMenu_CataloCounterparty_Delete.Name = "tStrip_ctxMenu_CataloCounterparty_Delete";
            this.tStrip_ctxMenu_CataloCounterparty_Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tStrip_ctxMenu_CataloCounterparty_Delete.Size = new System.Drawing.Size(180, 22);
            this.tStrip_ctxMenu_CataloCounterparty_Delete.Text = "Удалить";
            this.tStrip_ctxMenu_CataloCounterparty_Delete.Click += new System.EventHandler(this.tStrip_ctxMenu_CataloCounterparty_Delete_Click);
            // 
            // toolTip_CatalogCounterparty
            // 
            this.toolTip_CatalogCounterparty.ToolTipTitle = "Редактирование";
            // 
            // CatalogCounterparty_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.DGV_CatalogCounterparty_Form);
            this.Controls.Add(this.tStrip_CatalogCounterparty);
            this.Name = "CatalogCounterparty_Form";
            this.Text = "Каталог контрагентов";
            this.Load += new System.EventHandler(this.CatalogCounterparty_Load);
            this.tStrip_CatalogCounterparty.ResumeLayout(false);
            this.tStrip_CatalogCounterparty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CatalogCounterparty_Form)).EndInit();
            this.ctxMenuStrip_CataloCounterparty.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tStrip_CatalogCounterparty;
        private System.Windows.Forms.ToolStripButton tStrip_CatalogCounterparty_Add;
        private System.Windows.Forms.ToolStripButton tStrip_CatalogCounterparty_Edit;
        private System.Windows.Forms.ToolStripButton tStrip_CatalogCounterparty_Delete;
        private System.Windows.Forms.DataGridView DGV_CatalogCounterparty_Form;
        private System.Windows.Forms.ContextMenuStrip ctxMenuStrip_CataloCounterparty;
        private System.Windows.Forms.ToolStripMenuItem tStrip_ctxMenu_CataloCounterparty_Delete;
        private System.Windows.Forms.ToolTip toolTip_CatalogCounterparty;
        private System.Windows.Forms.DataGridViewTextBoxColumn CounterpartyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CounterpartyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InnOgrnKpp;
    }
}