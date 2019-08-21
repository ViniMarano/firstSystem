namespace System_Um
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPanel = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnLinks = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(18)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 15);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.btnAbout);
            this.panel2.Controls.Add(this.btnLinks);
            this.panel2.Controls.Add(this.btnTasks);
            this.panel2.Controls.Add(this.btnPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 666);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnPanel
            // 
            this.btnPanel.FlatAppearance.BorderSize = 0;
            this.btnPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanel.ForeColor = System.Drawing.Color.White;
            this.btnPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnPanel.Image")));
            this.btnPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPanel.Location = new System.Drawing.Point(32, 31);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(205, 60);
            this.btnPanel.TabIndex = 3;
            this.btnPanel.Text = "Panel";
            this.btnPanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPanel.UseVisualStyleBackColor = true;
            // 
            // btnTasks
            // 
            this.btnTasks.FlatAppearance.BorderSize = 0;
            this.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasks.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasks.ForeColor = System.Drawing.Color.White;
            this.btnTasks.Image = ((System.Drawing.Image)(resources.GetObject("btnTasks.Image")));
            this.btnTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.Location = new System.Drawing.Point(32, 147);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(205, 60);
            this.btnTasks.TabIndex = 4;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTasks.UseVisualStyleBackColor = true;
            // 
            // btnLinks
            // 
            this.btnLinks.FlatAppearance.BorderSize = 0;
            this.btnLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinks.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinks.ForeColor = System.Drawing.Color.White;
            this.btnLinks.Image = ((System.Drawing.Image)(resources.GetObject("btnLinks.Image")));
            this.btnLinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLinks.Location = new System.Drawing.Point(32, 263);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Size = new System.Drawing.Size(205, 60);
            this.btnLinks.TabIndex = 5;
            this.btnLinks.Text = "Links";
            this.btnLinks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLinks.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(32, 594);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(205, 60);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1189, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnLinks;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
    }
}

