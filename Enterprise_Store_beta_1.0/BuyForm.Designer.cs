
namespace Enterprise_Store_beta_1._0
{
    partial class BuyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip_BuyForm = new System.Windows.Forms.ToolStrip();
            this.tStrip_BuyForm_Actions = new System.Windows.Forms.ToolStripDropDownButton();
            this.tStrip_BuyForm_Action_CreateBuy = new System.Windows.Forms.ToolStripMenuItem();
            this.tStrip_BuyForm_Refresh = new System.Windows.Forms.ToolStripButton();
            this.bind_DGV_BuyForm = new System.Windows.Forms.BindingSource(this.components);
            this.DGV_BuyForm = new System.Windows.Forms.DataGridView();
            this.ctxtMenu_BuyForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tStrip_ctxMenu_BuyForm_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.tStrip_ctxtMenu_BuyForm_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tStrip_ctxMenu_BuyForm_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip_BuyForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bind_DGV_BuyForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BuyForm)).BeginInit();
            this.ctxtMenu_BuyForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_BuyForm
            // 
            this.toolStrip_BuyForm.AllowMerge = false;
            this.toolStrip_BuyForm.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_BuyForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStrip_BuyForm_Actions,
            this.tStrip_BuyForm_Refresh});
            this.toolStrip_BuyForm.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_BuyForm.Name = "toolStrip_BuyForm";
            this.toolStrip_BuyForm.Size = new System.Drawing.Size(792, 25);
            this.toolStrip_BuyForm.TabIndex = 1;
            this.toolStrip_BuyForm.Text = "toolStrip_BuyForm";
            // 
            // tStrip_BuyForm_Actions
            // 
            this.tStrip_BuyForm_Actions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStrip_BuyForm_Action_CreateBuy});
            this.tStrip_BuyForm_Actions.Image = ((System.Drawing.Image)(resources.GetObject("tStrip_BuyForm_Actions.Image")));
            this.tStrip_BuyForm_Actions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStrip_BuyForm_Actions.Name = "tStrip_BuyForm_Actions";
            this.tStrip_BuyForm_Actions.Size = new System.Drawing.Size(85, 22);
            this.tStrip_BuyForm_Actions.Text = "Действия";
            // 
            // tStrip_BuyForm_Action_CreateBuy
            // 
            this.tStrip_BuyForm_Action_CreateBuy.Name = "tStrip_BuyForm_Action_CreateBuy";
            this.tStrip_BuyForm_Action_CreateBuy.Size = new System.Drawing.Size(212, 22);
            this.tStrip_BuyForm_Action_CreateBuy.Text = "Создать покупка/комиссия";
            this.tStrip_BuyForm_Action_CreateBuy.Click += new System.EventHandler(this.ToolStrip_BuyForm_Action_CreateBuy_Click);
            // 
            // tStrip_BuyForm_Refresh
            // 
            this.tStrip_BuyForm_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStrip_BuyForm_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("tStrip_BuyForm_Refresh.Image")));
            this.tStrip_BuyForm_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStrip_BuyForm_Refresh.Name = "tStrip_BuyForm_Refresh";
            this.tStrip_BuyForm_Refresh.Size = new System.Drawing.Size(61, 22);
            this.tStrip_BuyForm_Refresh.Text = "Обновить";
            this.tStrip_BuyForm_Refresh.Click += new System.EventHandler(this.TStrip_BuyForm_Refresh_Click);
            // 
            // DGV_BuyForm
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_BuyForm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_BuyForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_BuyForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_BuyForm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DGV_BuyForm.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_BuyForm.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_BuyForm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_BuyForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_BuyForm.ContextMenuStrip = this.ctxtMenu_BuyForm;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_BuyForm.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_BuyForm.Location = new System.Drawing.Point(0, 25);
            this.DGV_BuyForm.MultiSelect = false;
            this.DGV_BuyForm.Name = "DGV_BuyForm";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_BuyForm.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_BuyForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_BuyForm.Size = new System.Drawing.Size(792, 547);
            this.DGV_BuyForm.TabIndex = 2;
            this.toolTip1.SetToolTip(this.DGV_BuyForm, "ДВОЙНОЙ КЛИК левой кнопкой мыши\r\nОТКРЫТЬ документ");
            this.DGV_BuyForm.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_BuyForm_CellDoubleClick);
            // 
            // ctxtMenu_BuyForm
            // 
            this.ctxtMenu_BuyForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStrip_ctxMenu_BuyForm_Open,
            this.tStrip_ctxtMenu_BuyForm_Delete,
            this.tStrip_ctxMenu_BuyForm_Edit});
            this.ctxtMenu_BuyForm.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.ctxtMenu_BuyForm.Name = "contextMenuStrip1";
            this.ctxtMenu_BuyForm.Size = new System.Drawing.Size(162, 70);
            // 
            // tStrip_ctxMenu_BuyForm_Open
            // 
            this.tStrip_ctxMenu_BuyForm_Open.Name = "tStrip_ctxMenu_BuyForm_Open";
            this.tStrip_ctxMenu_BuyForm_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tStrip_ctxMenu_BuyForm_Open.Size = new System.Drawing.Size(161, 22);
            this.tStrip_ctxMenu_BuyForm_Open.Text = "Открыть";
            this.tStrip_ctxMenu_BuyForm_Open.Click += new System.EventHandler(this.tStrip_ctxMenu_BuyForm_Open_Click);
            // 
            // tStrip_ctxtMenu_BuyForm_Delete
            // 
            this.tStrip_ctxtMenu_BuyForm_Delete.Name = "tStrip_ctxtMenu_BuyForm_Delete";
            this.tStrip_ctxtMenu_BuyForm_Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tStrip_ctxtMenu_BuyForm_Delete.Size = new System.Drawing.Size(161, 22);
            this.tStrip_ctxtMenu_BuyForm_Delete.Text = "Удалить";
            this.tStrip_ctxtMenu_BuyForm_Delete.Click += new System.EventHandler(this.ToolStrip_ctxtMenu_BuyForm_Delete_Click);
            // 
            // tStrip_ctxMenu_BuyForm_Edit
            // 
            this.tStrip_ctxMenu_BuyForm_Edit.Name = "tStrip_ctxMenu_BuyForm_Edit";
            this.tStrip_ctxMenu_BuyForm_Edit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tStrip_ctxMenu_BuyForm_Edit.Size = new System.Drawing.Size(161, 22);
            this.tStrip_ctxMenu_BuyForm_Edit.Text = "Изменить";
            this.tStrip_ctxMenu_BuyForm_Edit.Click += new System.EventHandler(this.tStrip_ctxMenu_BuyForm_Open_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 60;
            this.toolTip1.ToolTipTitle = "Открытие документа";
            // 
            // BuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(792, 572);
            this.Controls.Add(this.DGV_BuyForm);
            this.Controls.Add(this.toolStrip_BuyForm);
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "BuyForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Покупка/Комиссия";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BuyForm_Load);
            this.toolStrip_BuyForm.ResumeLayout(false);
            this.toolStrip_BuyForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bind_DGV_BuyForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BuyForm)).EndInit();
            this.ctxtMenu_BuyForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip_BuyForm;
        private System.Windows.Forms.ToolStripDropDownButton tStrip_BuyForm_Actions;
        private System.Windows.Forms.ToolStripMenuItem tStrip_BuyForm_Action_CreateBuy;
        internal System.Windows.Forms.BindingSource bind_DGV_BuyForm;
        internal System.Windows.Forms.DataGridView DGV_BuyForm;
        private System.Windows.Forms.ContextMenuStrip ctxtMenu_BuyForm;
        private System.Windows.Forms.ToolStripMenuItem tStrip_ctxtMenu_BuyForm_Delete;
        private System.Windows.Forms.ToolStripMenuItem tStrip_ctxMenu_BuyForm_Open;
        private System.Windows.Forms.ToolStripMenuItem tStrip_ctxMenu_BuyForm_Edit;
        private System.Windows.Forms.ToolStripButton tStrip_BuyForm_Refresh;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}