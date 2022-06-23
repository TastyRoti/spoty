
namespace spoty2
{
    partial class RegistrationForm
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
            this.passlabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.RegButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlabel.ForeColor = System.Drawing.Color.Pink;
            this.passlabel.Location = new System.Drawing.Point(51, 236);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(88, 17);
            this.passlabel.TabIndex = 14;
            this.passlabel.Text = "Password";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.ForeColor = System.Drawing.Color.Pink;
            this.usernamelabel.Location = new System.Drawing.Point(81, 191);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(58, 17);
            this.usernamelabel.TabIndex = 13;
            this.usernamelabel.Text = "Login";
            // 
            // PassBox
            // 
            this.PassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(6)))), ((int)(((byte)(46)))));
            this.PassBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassBox.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassBox.ForeColor = System.Drawing.Color.Yellow;
            this.PassBox.Location = new System.Drawing.Point(145, 236);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(100, 21);
            this.PassBox.TabIndex = 12;
            this.PassBox.UseSystemPasswordChar = true;
            this.PassBox.TextChanged += new System.EventHandler(this.PassBox_TextChanged);
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(6)))), ((int)(((byte)(46)))));
            this.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogBox.ForeColor = System.Drawing.Color.Pink;
            this.LogBox.Location = new System.Drawing.Point(145, 191);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(100, 22);
            this.LogBox.TabIndex = 11;
            this.LogBox.TextChanged += new System.EventHandler(this.LogBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Pink;
            this.label1.Location = new System.Drawing.Point(85, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Choose user type";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(172)))), ((int)(((byte)(231)))));
            this.panel2.Controls.Add(this.WelcomeLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 114);
            this.panel2.TabIndex = 9;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(6)))), ((int)(((byte)(46)))));
            this.WelcomeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WelcomeLabel.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.Pink;
            this.WelcomeLabel.Location = new System.Drawing.Point(0, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(366, 114);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Welcome";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBox1
            // 
            this.ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(6)))), ((int)(((byte)(46)))));
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox1.ForeColor = System.Drawing.Color.Pink;
            this.ComboBox1.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.ComboBox1.Location = new System.Drawing.Point(113, 330);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(116, 25);
            this.ComboBox1.Sorted = true;
            this.ComboBox1.TabIndex = 15;
            this.ComboBox1.Tag = "";
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(6)))), ((int)(((byte)(46)))));
            this.RegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegButton.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegButton.ForeColor = System.Drawing.Color.Pink;
            this.RegButton.Location = new System.Drawing.Point(88, 375);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(157, 31);
            this.RegButton.TabIndex = 16;
            this.RegButton.Text = "Registration";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(10)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(366, 437);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.Button RegButton;
    }
}