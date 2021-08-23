
namespace Enterprise_Store_beta_1._0
{
    partial class Test_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test_form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PreviewPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.PageSetupDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PreviewPrint,
            this.PrintDoc,
            this.PrintDialog,
            this.PageSetupDialog});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PreviewPrint
            // 
            this.PreviewPrint.Name = "PreviewPrint";
            this.PreviewPrint.Size = new System.Drawing.Size(57, 20);
            this.PreviewPrint.Text = "preview";
            this.PreviewPrint.Click += new System.EventHandler(this.PreviewPrint_Click);
            // 
            // PrintDoc
            // 
            this.PrintDoc.Name = "PrintDoc";
            this.PrintDoc.Size = new System.Drawing.Size(41, 20);
            this.PrintDoc.Text = "print";
            this.PrintDoc.Click += new System.EventHandler(this.PrintDoc_Click);
            // 
            // PrintDialog
            // 
            this.PrintDialog.Name = "PrintDialog";
            this.PrintDialog.Size = new System.Drawing.Size(70, 20);
            this.PrintDialog.Text = "PrintDialog";
            this.PrintDialog.Click += new System.EventHandler(this.PrintDialog_Click);
            // 
            // PageSetupDialog
            // 
            this.PageSetupDialog.Name = "PageSetupDialog";
            this.PageSetupDialog.Size = new System.Drawing.Size(100, 20);
            this.PageSetupDialog.Text = "PageSetupDialog";
            this.PageSetupDialog.Click += new System.EventHandler(this.PageSetupDialog_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "test_print";
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintDocument1_BeginPrint);
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            this.printDocument1.QueryPageSettings += new System.Drawing.Printing.QueryPageSettingsEventHandler(this.PrintDocument1_QueryPageSettings);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(1600, 852);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.MainMenuStrip = this.menuStrip1;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 118);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(20);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(696, 1080);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(696, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(696, 425);
            this.dataGridView1.TabIndex = 2;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            this.pageSetupDialog1.EnableMetric = true;
            // 
            // Test_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 572);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(760, 28);
            this.Name = "Test_form";
            this.Text = "Test_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Test_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem PreviewPrint;
        private System.Windows.Forms.ToolStripMenuItem PrintDoc;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem PrintDialog;
        private System.Windows.Forms.ToolStripMenuItem PageSetupDialog;
    }
}