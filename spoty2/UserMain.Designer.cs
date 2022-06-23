
namespace spoty2
{
    partial class UserMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SpotyLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TrackNameLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SingerNameLabel = new System.Windows.Forms.Label();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tracks = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracks)).BeginInit();
            this.SuspendLayout();
            // 
            // SpotyLabel
            // 
            this.SpotyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(6)))), ((int)(((byte)(46)))));
            this.SpotyLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SpotyLabel.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpotyLabel.ForeColor = System.Drawing.Color.Pink;
            this.SpotyLabel.Location = new System.Drawing.Point(0, 0);
            this.SpotyLabel.Name = "SpotyLabel";
            this.SpotyLabel.Size = new System.Drawing.Size(738, 80);
            this.SpotyLabel.TabIndex = 1;
            this.SpotyLabel.Text = "Spoty";
            this.SpotyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.tracks);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 377);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(6)))), ((int)(((byte)(46)))));
            this.panel3.Controls.Add(this.TrackNameLabel);
            this.panel3.Controls.Add(this.InfoLabel);
            this.panel3.Controls.Add(this.SingerNameLabel);
            this.panel3.Controls.Add(this.ForwardButton);
            this.panel3.Controls.Add(this.BackButton);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 279);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 98);
            this.panel3.TabIndex = 2;
            // 
            // TrackNameLabel
            // 
            this.TrackNameLabel.AutoSize = true;
            this.TrackNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.TrackNameLabel.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackNameLabel.ForeColor = System.Drawing.Color.Pink;
            this.TrackNameLabel.Location = new System.Drawing.Point(28, 29);
            this.TrackNameLabel.Name = "TrackNameLabel";
            this.TrackNameLabel.Size = new System.Drawing.Size(138, 25);
            this.TrackNameLabel.TabIndex = 3;
            this.TrackNameLabel.Text = "TrackName";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoLabel.Font = new System.Drawing.Font("Niagara Engraved", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.ForeColor = System.Drawing.Color.Pink;
            this.InfoLabel.Location = new System.Drawing.Point(3, 6);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(30, 33);
            this.InfoLabel.TabIndex = 7;
            this.InfoLabel.Text = "...";
            this.InfoLabel.Click += new System.EventHandler(this.InfoLabel_Click);
            this.InfoLabel.MouseEnter += new System.EventHandler(this.InfoLabel_MouseEnter);
            this.InfoLabel.MouseLeave += new System.EventHandler(this.InfoLabel_MouseLeave);
            // 
            // SingerNameLabel
            // 
            this.SingerNameLabel.AutoSize = true;
            this.SingerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.SingerNameLabel.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingerNameLabel.ForeColor = System.Drawing.Color.Pink;
            this.SingerNameLabel.Location = new System.Drawing.Point(30, 55);
            this.SingerNameLabel.Name = "SingerNameLabel";
            this.SingerNameLabel.Size = new System.Drawing.Size(98, 17);
            this.SingerNameLabel.TabIndex = 6;
            this.SingerNameLabel.Text = "SingerName";
            // 
            // ForwardButton
            // 
            this.ForwardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForwardButton.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForwardButton.Location = new System.Drawing.Point(685, 32);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(41, 37);
            this.ForwardButton.TabIndex = 5;
            this.ForwardButton.Text = ">";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click_1);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(587, 32);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(41, 37);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "<";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(634, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "II";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(172)))), ((int)(((byte)(231)))));
            this.panel2.Controls.Add(this.SpotyLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 78);
            this.panel2.TabIndex = 0;
            // 
            // tracks
            // 
            this.tracks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(10)))), ((int)(((byte)(43)))));
            this.tracks.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.tracks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tracks.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(10)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tracks.DefaultCellStyle = dataGridViewCellStyle6;
            this.tracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tracks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(10)))), ((int)(((byte)(43)))));
            this.tracks.Location = new System.Drawing.Point(0, 78);
            this.tracks.Name = "tracks";
            this.tracks.ReadOnly = true;
            this.tracks.RowHeadersVisible = false;
            this.tracks.RowHeadersWidth = 51;
            this.tracks.RowTemplate.Height = 24;
            this.tracks.Size = new System.Drawing.Size(738, 201);
            this.tracks.TabIndex = 9;
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 377);
            this.Controls.Add(this.panel1);
            this.Name = "UserMain";
            this.Text = "UserMain";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tracks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SpotyLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TrackNameLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label SingerNameLabel;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tracks;
    }
}