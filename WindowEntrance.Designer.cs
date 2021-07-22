namespace AppliancesStore
{
    partial class WindowEntrance
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
            this.Entrance = new System.Windows.Forms.Label();
            this.buttonEntrance = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Entrance
            // 
            this.Entrance.Dock = System.Windows.Forms.DockStyle.Top;
            this.Entrance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Entrance.Location = new System.Drawing.Point(0, 0);
            this.Entrance.Name = "Entrance";
            this.Entrance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Entrance.Size = new System.Drawing.Size(300, 60);
            this.Entrance.TabIndex = 0;
            this.Entrance.Text = "Вход в систему";
            this.Entrance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEntrance
            // 
            this.buttonEntrance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEntrance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEntrance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonEntrance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEntrance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEntrance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonEntrance.Location = new System.Drawing.Point(60, 143);
            this.buttonEntrance.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.buttonEntrance.Name = "buttonEntrance";
            this.buttonEntrance.Size = new System.Drawing.Size(180, 44);
            this.buttonEntrance.TabIndex = 1;
            this.buttonEntrance.Text = "ВХОД";
            this.buttonEntrance.UseVisualStyleBackColor = false;
            this.buttonEntrance.Click += new System.EventHandler(this.entUser_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(140, 63);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 21);
            this.username.TabIndex = 2;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(140, 101);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 21);
            this.pass.TabIndex = 3;
            this.pass.UseSystemPasswordChar = true;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(73, 63);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(54, 13);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "username";
            this.label_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(73, 101);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(53, 13);
            this.label_pass.TabIndex = 4;
            this.label_pass.Text = "password";
            this.label_pass.Click += new System.EventHandler(this.label1_Click);
            // 
            // WindowEntrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(300, 294);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.buttonEntrance);
            this.Controls.Add(this.Entrance);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WindowEntrance";
            this.Load += new System.EventHandler(this.WindowEntrance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Entrance;
        private System.Windows.Forms.Button buttonEntrance;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_pass;
    }
}

