﻿namespace SecurePNG
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keyTextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.keyTextBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageFilePathLabel1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imageFilePathLabel2 = new System.Windows.Forms.Label();
            this.imageFilePathLabel3 = new System.Windows.Forms.Label();
            this.imageFilePathLabel4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(382, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(400, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 460);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Writer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(408, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reader";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keyTextBox1
            // 
            this.keyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyTextBox1.Location = new System.Drawing.Point(40, 59);
            this.keyTextBox1.Name = "keyTextBox1";
            this.keyTextBox1.Size = new System.Drawing.Size(354, 20);
            this.keyTextBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Key:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Key:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // keyTextBox2
            // 
            this.keyTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyTextBox2.Location = new System.Drawing.Point(439, 59);
            this.keyTextBox2.Name = "keyTextBox2";
            this.keyTextBox2.Size = new System.Drawing.Size(333, 20);
            this.keyTextBox2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(361, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Open file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // imageFilePathLabel1
            // 
            this.imageFilePathLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageFilePathLabel1.Location = new System.Drawing.Point(12, 85);
            this.imageFilePathLabel1.Name = "imageFilePathLabel1";
            this.imageFilePathLabel1.Size = new System.Drawing.Size(382, 20);
            this.imageFilePathLabel1.TabIndex = 10;
            this.imageFilePathLabel1.Text = "C:\\";
            this.imageFilePathLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(411, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(361, 315);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // imageFilePathLabel2
            // 
            this.imageFilePathLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageFilePathLabel2.Location = new System.Drawing.Point(411, 85);
            this.imageFilePathLabel2.Name = "imageFilePathLabel2";
            this.imageFilePathLabel2.Size = new System.Drawing.Size(361, 20);
            this.imageFilePathLabel2.TabIndex = 12;
            this.imageFilePathLabel2.Text = "C:\\";
            this.imageFilePathLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageFilePathLabel3
            // 
            this.imageFilePathLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageFilePathLabel3.Location = new System.Drawing.Point(411, 111);
            this.imageFilePathLabel3.Name = "imageFilePathLabel3";
            this.imageFilePathLabel3.Size = new System.Drawing.Size(361, 20);
            this.imageFilePathLabel3.TabIndex = 13;
            this.imageFilePathLabel3.Text = "C:\\";
            this.imageFilePathLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageFilePathLabel4
            // 
            this.imageFilePathLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageFilePathLabel4.Location = new System.Drawing.Point(12, 111);
            this.imageFilePathLabel4.Name = "imageFilePathLabel4";
            this.imageFilePathLabel4.Size = new System.Drawing.Size(382, 20);
            this.imageFilePathLabel4.TabIndex = 14;
            this.imageFilePathLabel4.Text = "C:\\";
            this.imageFilePathLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.imageFilePathLabel4);
            this.Controls.Add(this.imageFilePathLabel3);
            this.Controls.Add(this.imageFilePathLabel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.imageFilePathLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.keyTextBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keyTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "SecurePNG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox keyTextBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label imageFilePathLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label imageFilePathLabel2;
        private System.Windows.Forms.Label imageFilePathLabel3;
        private System.Windows.Forms.Label imageFilePathLabel4;
    }
}

