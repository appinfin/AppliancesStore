
namespace Enterprise_Store_beta_1._0
{
    partial class CatalogPersonnels_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogPersonnels_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tStripMenu_CatalogPersonnels = new System.Windows.Forms.ToolStrip();
            this.tStripMenu_CatalogPersonnels_Add = new System.Windows.Forms.ToolStripButton();
            this.tStripMenu_CatalogPersonnels_Edit = new System.Windows.Forms.ToolStripButton();
            this.tStripMenu_CatalogPersonnels_Delete = new System.Windows.Forms.ToolStripButton();
            this.DGV_CatalogPersonnels_Form = new System.Windows.Forms.DataGridView();
            this.PersonnelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonnelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ctxMenu_CatalogPersonnels = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxMenu_CatalogStorage_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripMenu_CatalogPersonnels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CatalogPersonnels_Form)).BeginInit();
            this.ctxMenu_CatalogPersonnels.SuspendLayout();
            this.SuspendLayout();
            // 
            // tStripMenu_CatalogPersonnels
            // 
            this.tStripMenu_CatalogPersonnels.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tStripMenu_CatalogPersonnels.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripMenu_CatalogPersonnels_Add,
            this.tStripMenu_CatalogPersonnels_Edit,
            this.tStripMenu_CatalogPersonnels_Delete});
            this.tStripMenu_CatalogPersonnels.Location = new System.Drawing.Point(0, 0);
            this.tStripMenu_CatalogPersonnels.Name = "tStripMenu_CatalogPersonnels";
            this.tStripMenu_CatalogPersonnels.Size = new System.Drawing.Size(492, 25);
            this.tStripMenu_CatalogPersonnels.TabIndex = 1;
            this.tStripMenu_CatalogPersonnels.Text = "toolStrip1";
            // 
            // tStripMenu_CatalogPersonnels_Add
            // 
            this.tStripMenu_CatalogPersonnels_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStripMenu_CatalogPersonnels_Add.Image = ((System.Drawing.Image)(resources.GetObject("tStripMenu_CatalogPersonnels_Add.Image")));
            this.tStripMenu_CatalogPersonnels_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripMenu_CatalogPersonnels_Add.Name = "tStripMenu_CatalogPersonnels_Add";
            this.tStripMenu_CatalogPersonnels_Add.Size = new System.Drawing.Size(61, 22);
            this.tStripMenu_CatalogPersonnels_Add.Text = "Добавить";
            // 
            // tStripMenu_CatalogPersonnels_Edit
            // 
            this.tStripMenu_CatalogPersonnels_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStripMenu_CatalogPersonnels_Edit.Image = ((System.Drawing.Image)(resources.GetObject("tStripMenu_CatalogPersonnels_Edit.Image")));
            this.tStripMenu_CatalogPersonnels_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripMenu_CatalogPersonnels_Edit.Name = "tStripMenu_CatalogPersonnels_Edit";
            this.tStripMenu_CatalogPersonnels_Edit.Size = new System.Drawing.Size(59, 22);
            this.tStripMenu_CatalogPersonnels_Edit.Text = "Изменить";
            // 
            // tStripMenu_CatalogPersonnels_Delete
            // 
            this.tStripMenu_CatalogPersonnels_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStripMenu_CatalogPersonnels_Delete.Image = ((System.Drawing.Image)(resources.GetObject("tStripMenu_CatalogPersonnels_Delete.Image")));
            this.tStripMenu_CatalogPersonnels_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripMenu_CatalogPersonnels_Delete.Name = "tStripMenu_CatalogPersonnels_Delete";
            this.tStripMenu_CatalogPersonnels_Delete.Size = new System.Drawing.Size(55, 22);
            this.tStripMenu_CatalogPersonnels_Delete.Text = "Удалить";
            this.tStripMenu_CatalogPersonnels_Delete.Click += new System.EventHandler(this.TStripMenu_CatalogPersonnels_Delete_Click);
            // 
            // DGV_CatalogPersonnels_Form
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.DGV_CatalogPersonnels_Form.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_CatalogPersonnels_Form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_CatalogPersonnels_Form.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_CatalogPersonnels_Form.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_CatalogPersonnels_Form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CatalogPersonnels_Form.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonnelId,
            this.PersonnelName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_CatalogPersonnels_Form.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_CatalogPersonnels_Form.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DGV_CatalogPersonnels_Form.Location = new System.Drawing.Point(0, 28);
            this.DGV_CatalogPersonnels_Form.Name = "DGV_CatalogPersonnels_Form";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.DGV_CatalogPersonnels_Form.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.DGV_CatalogPersonnels_Form.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_CatalogPersonnels_Form.RowTemplate.Height = 23;
            this.DGV_CatalogPersonnels_Form.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_CatalogPersonnels_Form.Size = new System.Drawing.Size(492, 332);
            this.DGV_CatalogPersonnels_Form.TabIndex = 2;
            this.toolTip1.SetToolTip(this.DGV_CatalogPersonnels_Form, "\r\nнажмите F2\r\nили\r\nдвойной клик ЛКМ");
            this.DGV_CatalogPersonnels_Form.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CatalogPersonnels_Form_CellDoubleClick);
            this.DGV_CatalogPersonnels_Form.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DGV_CatalogPersonnels_Form_CellValidating);
            // 
            // PersonnelId
            // 
            this.PersonnelId.DataPropertyName = "PersonnelId";
            this.PersonnelId.FillWeight = 30F;
            this.PersonnelId.HeaderText = "Код";
            this.PersonnelId.MaxInputLength = 16;
            this.PersonnelId.Name = "PersonnelId";
            this.PersonnelId.ReadOnly = true;
            this.PersonnelId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PersonnelName
            // 
            this.PersonnelName.DataPropertyName = "PersonnelName";
            this.PersonnelName.HeaderText = "Наименование";
            this.PersonnelName.MaxInputLength = 128;
            this.PersonnelName.Name = "PersonnelName";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Редактирование";
            // 
            // ctxMenu_CatalogPersonnels
            // 
            this.ctxMenu_CatalogPersonnels.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenu_CatalogStorage_Delete});
            this.ctxMenu_CatalogPersonnels.Name = "ctxMenu_CatalogStorage";
            this.ctxMenu_CatalogPersonnels.Size = new System.Drawing.Size(162, 26);
            // 
            // ctxMenu_CatalogStorage_Delete
            // 
            this.ctxMenu_CatalogStorage_Delete.Name = "ctxMenu_CatalogStorage_Delete";
            this.ctxMenu_CatalogStorage_Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.ctxMenu_CatalogStorage_Delete.Size = new System.Drawing.Size(161, 22);
            this.ctxMenu_CatalogStorage_Delete.Text = "Удалить";
            this.ctxMenu_CatalogStorage_Delete.Click += new System.EventHandler(this.CtxMenu_CatalogStorage_Delete_Click);
            // 
            // CatalogPersonnels_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 372);
            this.Controls.Add(this.DGV_CatalogPersonnels_Form);
            this.Controls.Add(this.tStripMenu_CatalogPersonnels);
            this.Name = "CatalogPersonnels_Form";
            this.Text = "Каталог сотрудников";
            this.Load += new System.EventHandler(this.CatalogPersonnels_Form_Load);
            this.tStripMenu_CatalogPersonnels.ResumeLayout(false);
            this.tStripMenu_CatalogPersonnels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CatalogPersonnels_Form)).EndInit();
            this.ctxMenu_CatalogPersonnels.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tStripMenu_CatalogPersonnels;
        private System.Windows.Forms.ToolStripButton tStripMenu_CatalogPersonnels_Add;
        private System.Windows.Forms.ToolStripButton tStripMenu_CatalogPersonnels_Edit;
        private System.Windows.Forms.ToolStripButton tStripMenu_CatalogPersonnels_Delete;
        private System.Windows.Forms.DataGridView DGV_CatalogPersonnels_Form;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip ctxMenu_CatalogPersonnels;
        private System.Windows.Forms.ToolStripMenuItem ctxMenu_CatalogStorage_Delete;
    }
}