﻿using System.Threading.Tasks;
namespace Enterprise_Store_beta_1._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFileForm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.create_form = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuBuy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSell = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuWindowsForm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuWindowsHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuWindowsVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuWindowsCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuWindowsArrangeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileForm1,
            this.MenuWindowsForm1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.MenuWindowsForm1;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(392, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFileForm1
            // 
            this.MenuFileForm1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.create_form});
            this.MenuFileForm1.Name = "MenuFileForm1";
            this.MenuFileForm1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.MenuFileForm1.Size = new System.Drawing.Size(45, 20);
            this.MenuFileForm1.Text = "Файл";
            // 
            // create_form
            // 
            this.create_form.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuBuy,
            this.toolStripMenuSell});
            this.create_form.Name = "create_form";
            this.create_form.Size = new System.Drawing.Size(117, 22);
            this.create_form.Text = "Создать";
            // 
            // toolStripMenuBuy
            // 
            this.toolStripMenuBuy.Name = "toolStripMenuBuy";
            this.toolStripMenuBuy.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuBuy.Text = "Покупка";
            this.toolStripMenuBuy.Click += new System.EventHandler(this.toolStripMenuBuy_Click);
            // 
            // toolStripMenuSell
            // 
            this.toolStripMenuSell.Name = "toolStripMenuSell";
            this.toolStripMenuSell.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuSell.Text = "Продажа";
            this.toolStripMenuSell.Click += new System.EventHandler(this.toolStripMenuSell_Click);
            // 
            // MenuWindowsForm1
            // 
            this.MenuWindowsForm1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuWindowsHorizontal,
            this.MenuWindowsVertical,
            this.MenuWindowsCascade,
            this.MenuWindowsArrangeIcons});
            this.MenuWindowsForm1.Name = "MenuWindowsForm1";
            this.MenuWindowsForm1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.MenuWindowsForm1.Size = new System.Drawing.Size(45, 20);
            this.MenuWindowsForm1.Text = "Окна";
            // 
            // MenuWindowsHorizontal
            // 
            this.MenuWindowsHorizontal.Name = "MenuWindowsHorizontal";
            this.MenuWindowsHorizontal.Size = new System.Drawing.Size(151, 22);
            this.MenuWindowsHorizontal.Text = "Горизонтально";
            this.MenuWindowsHorizontal.Click += new System.EventHandler(this.HorizontallyTileMyWindows);
            // 
            // MenuWindowsVertical
            // 
            this.MenuWindowsVertical.Name = "MenuWindowsVertical";
            this.MenuWindowsVertical.Size = new System.Drawing.Size(151, 22);
            this.MenuWindowsVertical.Text = "Вертикально";
            this.MenuWindowsVertical.Click += new System.EventHandler(this.VerticallyTileMyWindows);
            // 
            // MenuWindowsCascade
            // 
            this.MenuWindowsCascade.Name = "MenuWindowsCascade";
            this.MenuWindowsCascade.Size = new System.Drawing.Size(151, 22);
            this.MenuWindowsCascade.Text = "Каскадно";
            this.MenuWindowsCascade.Click += new System.EventHandler(this.CascadeMyWindows);
            // 
            // MenuWindowsArrangeIcons
            // 
            this.MenuWindowsArrangeIcons.Name = "MenuWindowsArrangeIcons";
            this.MenuWindowsArrangeIcons.Size = new System.Drawing.Size(151, 22);
            this.MenuWindowsArrangeIcons.Text = "Все внутри";
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 372);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Enterprise Store beta 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFileForm1;
        private System.Windows.Forms.ToolStripMenuItem create_form;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuBuy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSell;
        private System.Windows.Forms.ToolStripMenuItem MenuWindowsForm1;
        private System.Windows.Forms.ToolStripMenuItem MenuWindowsHorizontal;
        private System.Windows.Forms.ToolStripMenuItem MenuWindowsVertical;
        private System.Windows.Forms.ToolStripMenuItem MenuWindowsCascade;
        private System.Windows.Forms.ToolStripMenuItem MenuWindowsArrangeIcons;
    }
}

