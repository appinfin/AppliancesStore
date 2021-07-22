
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip_SellForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 347);
            this.dataGridView1.TabIndex = 2;
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(392, 372);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip_SellForm);
            this.Name = "SellForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "SellForm";
            this.Load += new System.EventHandler(this.SellForm_Load);
            this.toolStrip_SellForm.ResumeLayout(false);
            this.toolStrip_SellForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip_SellForm;
        private System.Windows.Forms.ToolStripDropDownButton tStrip_SellForm_Actions;
        private System.Windows.Forms.ToolStripMenuItem tStrip_SellForm_Action_CreateSell;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}