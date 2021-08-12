
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
            this.toolStrip_SellForm = new System.Windows.Forms.ToolStrip();
            this.tStrip_SellForm_Actions = new System.Windows.Forms.ToolStripDropDownButton();
            this.tStrip_SellForm_Action_CreateSell = new System.Windows.Forms.ToolStripMenuItem();
            this.bind_DGV_SellForm = new System.Windows.Forms.BindingSource(this.components);
            this.DGV_SellForm = new System.Windows.Forms.DataGridView();
            this.toolStrip_SellForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bind_DGV_SellForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SellForm)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip_SellForm
            // 
            this.toolStrip_SellForm.AllowMerge = false;
            this.toolStrip_SellForm.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_SellForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStrip_SellForm_Actions});
            this.toolStrip_SellForm.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_SellForm.Name = "toolStrip_SellForm";
            this.toolStrip_SellForm.Size = new System.Drawing.Size(392, 25);
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
            this.DGV_SellForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SellForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_SellForm.Location = new System.Drawing.Point(0, 25);
            this.DGV_SellForm.Name = "DGV_SellForm";
            this.DGV_SellForm.RowTemplate.Height = 23;
            this.DGV_SellForm.Size = new System.Drawing.Size(392, 347);
            this.DGV_SellForm.TabIndex = 2;
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(392, 372);
            this.Controls.Add(this.DGV_SellForm);
            this.Controls.Add(this.toolStrip_SellForm);
            this.Name = "SellForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "SellForm";
            this.Load += new System.EventHandler(this.SellForm_Load);
            this.toolStrip_SellForm.ResumeLayout(false);
            this.toolStrip_SellForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bind_DGV_SellForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SellForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip_SellForm;
        private System.Windows.Forms.ToolStripDropDownButton tStrip_SellForm_Actions;
        private System.Windows.Forms.ToolStripMenuItem tStrip_SellForm_Action_CreateSell;
        internal System.Windows.Forms.BindingSource bind_DGV_SellForm;
        private System.Windows.Forms.DataGridView DGV_SellForm;
    }
}