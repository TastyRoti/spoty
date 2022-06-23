
namespace spoty2
{
    partial class WelcomeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.newlabel = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.passbox = new System.Windows.Forms.TextBox();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(10)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.newlabel);
            this.panel1.Controls.Add(this.passlabel);
            this.panel1.Controls.Add(this.usernamelabel);
            this.panel1.Controls.Add(this.passbox);
            this.panel1.Controls.Add(this.usernamebox);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 392);
            this.panel1.TabIndex = 0;
            // 
            // newlabel
            // 
            this.newlabel.AutoSize = true;
            this.newlabel.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newlabel.ForeColor = System.Drawing.Color.Pink;
            this.newlabel.Location = new System.Drawing.Point(208, 357);
            this.newlabel.Name = "newlabel";
            this.newlabel.Size = new System.Drawing.Size(118, 17);
            this.newlabel.TabIndex = 9;
            this.newlabel.Text = "New Account";
            this.newlabel.Click += new System.EventHandler(this.newlabel_Click);
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlabel.ForeColor = System.Drawing.Color.Pink;
            this.passlabel.Location = new System.Drawing.Point(29, 243);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(88, 17);
            this.passlabel.TabIndex = 8;
            this.passlabel.Text = "Password";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.ForeColor = System.Drawing.Color.Pink;
            this.usernamelabel.Location = new System.Drawing.Point(59, 194);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(58, 17);
            this.usernamelabel.TabIndex = 7;
            this.usernamelabel.Text = "Login";
            // 
            // passbox
            // 
            this.passbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(6)))), ((int)(((byte)(46)))));
            this.passbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passbox.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passbox.ForeColor = System.Drawing.Color.Yellow;
            this.passbox.Location = new System.Drawing.Point(135, 239);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(100, 21);
            this.passbox.TabIndex = 6;
            this.passbox.UseSystemPasswordChar = true;
            // 
            // usernamebox
            // 
            this.usernamebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(6)))), ((int)(((byte)(46)))));
            this.usernamebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernamebox.ForeColor = System.Drawing.Color.Pink;
            this.usernamebox.Location = new System.Drawing.Point(135, 195);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(100, 21);
            this.usernamebox.TabIndex = 5;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(6)))), ((int)(((byte)(46)))));
            this.loginButton.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Pink;
            this.loginButton.Location = new System.Drawing.Point(26, 345);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(116, 29);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "log in";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(172)))), ((int)(((byte)(231)))));
            this.panel2.Controls.Add(this.WelcomeLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 114);
            this.panel2.TabIndex = 0;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(6)))), ((int)(((byte)(46)))));
            this.WelcomeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WelcomeLabel.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.Pink;
            this.WelcomeLabel.Location = new System.Drawing.Point(0, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(338, 114);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Welcome";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 392);
            this.Controls.Add(this.panel1);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label newlabel;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.TextBox usernamebox;
    }
}