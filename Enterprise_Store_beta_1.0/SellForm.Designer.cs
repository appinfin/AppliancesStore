
namespace Enterprise_Store_beta_1._0
{
    partial class SellForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip_SellForm = new System.Windows.Forms.ToolStrip();
            this.tStrip_SellForm_Actions = new System.Windows.Forms.ToolStripDropDownButton();
            this.tStrip_SellForm_Action_CreateSell = new System.Windows.Forms.ToolStripMenuItem();
            this.bind_DGV_SellForm = new System.Windows.Forms.BindingSource(this.components);
            this.DGV_SellForm = new System.Windows.Forms.DataGridView();
            this.tStrip_SellForm_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ctxtMenu_SellForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tStrip_ctxMenu_BuyForm_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.tStrip_ctxtMenu_BuyForm_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tStrip_ctxMenu_BuyForm_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_SellForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bind_DGV_SellForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SellForm)).BeginInit();
            this.ctxtMenu_SellForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_SellForm
            // 
            this.toolStrip_SellForm.AllowMerge = false;
            this.toolStrip_SellForm.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_SellForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStrip_SellForm_Actions,
            this.tStrip_SellForm_Refresh});
            this.toolStrip_SellForm.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_SellForm.Name = "toolStrip_SellForm";
            this.toolStrip_SellForm.Size = new System.Drawing.Size(792, 25);
            this.toolStrip_SellForm.TabIndex = 1;
            this.toolStrip_SellForm.Text = "toolStrip_SellForm";
            // 
            // tStrip_SellForm_Actions
            // 
            this.tStrip_SellForm_Actions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStrip_SellForm_Action_CreateSell});
            this.tStrip_SellForm_Actions.Image = ((System.Drawing.Image)(resources.GetObject("tStrip_SellForm_Actions.Image")));
            this.tStrip_SellForm_Actions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStrip_SellForm_Actions.Name = "tStrip_SellForm_Actions";
            this.tStrip_SellForm_Actions.Size = new System.Drawing.Size(85, 22);
            this.tStrip_SellForm_Actions.Text = "Действия";
            // 
            // tStrip_SellForm_Action_CreateSell
            // 
            this.tStrip_SellForm_Action_CreateSell.Name = "tStrip_SellForm_Action_CreateSell";
            this.tStrip_SellForm_Action_CreateSell.Size = new System.Drawing.Size(165, 22);
            this.tStrip_SellForm_Action_CreateSell.Text = "Создать продажа";
            this.tStrip_SellForm_Action_CreateSell.Click += new System.EventHandler(this.ToolStrip_SellForm_Action_CreateSell_Click);
            // 
            // DGV_SellForm
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_SellForm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_SellForm.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_SellForm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_SellForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_SellForm.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_SellForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_SellForm.Location = new System.Drawing.Point(0, 25);
            this.DGV_SellForm.Name = "DGV_SellForm";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_SellForm.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_SellForm.RowTemplate.Height = 23;
            this.DGV_SellForm.Size = new System.Drawing.Size(792, 547);
            this.DGV_SellForm.TabIndex = 2;
            // 
            // tStrip_SellForm_Refresh
            // 
            this.tStrip_SellForm_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStrip_SellForm_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("tStrip_SellForm_Refresh.Image")));
            this.tStrip_SellForm_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStrip_SellForm_Refresh.Name = "tStrip_SellForm_Refresh";
            this.tStrip_SellForm_Refresh.Size = new System.Drawing.Size(61, 22);
            this.tStrip_SellForm_Refresh.Text = "Обновить";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 60;
            this.toolTip1.ToolTipTitle = "Открытие документа";
            // 
            // ctxtMenu_SellForm
            // 
            this.ctxtMenu_SellForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStrip_ctxMenu_BuyForm_Open,
            this.tStrip_ctxtMenu_BuyForm_Delete,
            this.tStrip_ctxMenu_BuyForm_Edit});
            this.ctxtMenu_SellForm.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.ctxtMenu_SellForm.Name = "contextMenuStrip1";
            this.ctxtMenu_SellForm.Size = new System.Drawing.Size(162, 70);
            // 
            // tStrip_ctxMenu_BuyForm_Open
            // 
            this.tStrip_ctxMenu_BuyForm_Open.Name = "tStrip_ctxMenu_BuyForm_Open";
            this.tStrip_ctxMenu_BuyForm_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tStrip_ctxMenu_BuyForm_Open.Size = new System.Drawing.Size(161, 22);
            this.tStrip_ctxMenu_BuyForm_Open.Text = "Открыть";
            // 
            // tStrip_ctxtMenu_BuyForm_Delete
            // 
            this.tStrip_ctxtMenu_BuyForm_Delete.Name = "tStrip_ctxtMenu_BuyForm_Delete";
            this.tStrip_ctxtMenu_BuyForm_Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tStrip_ctxtMenu_BuyForm_Delete.Size = new System.Drawing.Size(161, 22);
            this.tStrip_ctxtMenu_BuyForm_Delete.Text = "Удалить";
            // 
            // tStrip_ctxMenu_BuyForm_Edit
            // 
            this.tStrip_ctxMenu_BuyForm_Edit.Name = "tStrip_ctxMenu_BuyForm_Edit";
            this.tStrip_ctxMenu_BuyForm_Edit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tStrip_ctxMenu_BuyForm_Edit.Size = new System.Drawing.Size(161, 22);
            this.tStrip_ctxMenu_BuyForm_Edit.Text = "Изменить";
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(792, 572);
            this.Controls.Add(this.DGV_SellForm);
            this.Controls.Add(this.toolStrip_SellForm);
            this.Name = "SellForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Реализация/заказы";
            this.Load += new System.EventHandler(this.SellForm_Load);
            this.toolStrip_SellForm.ResumeLayout(false);
            this.toolStrip_SellForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bind_DGV_SellForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SellForm)).EndInit();
            this.ctxtMenu_SellForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip_SellForm;
        private System.Windows.Forms.ToolStripDropDownButton tStrip_SellForm_Actions;
        private System.Windows.Forms.ToolStripMenuItem tStrip_SellForm_Action_CreateSell;
        internal System.Windows.Forms.BindingSource bind_DGV_SellForm;
        private System.Windows.Forms.DataGridView DGV_SellForm;
        private System.Windows.Forms.ToolStripButton tStrip_SellForm_Refresh;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip ctxtMenu_SellForm;
        private System.Windows.Forms.ToolStripMenuItem tStrip_ctxMenu_BuyForm_Open;
        private System.Windows.Forms.ToolStripMenuItem tStrip_ctxtMenu_BuyForm_Delete;
        private System.Windows.Forms.ToolStripMenuItem tStrip_ctxMenu_BuyForm_Edit;
    }
}