﻿namespace WindowsFormsTrac
{
    partial class FormParking
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
            this.pictureBoxTrac1 = new System.Windows.Forms.PictureBox();
            this.buttonSetLightTr = new System.Windows.Forms.Button();
            this.buttonSetHighTr = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTake = new System.Windows.Forms.Button();
            this.listBox123 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrac1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTrac1
            // 
            this.pictureBoxTrac1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxTrac1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTrac1.Name = "pictureBoxTrac1";
            this.pictureBoxTrac1.Size = new System.Drawing.Size(639, 450);
            this.pictureBoxTrac1.TabIndex = 0;
            this.pictureBoxTrac1.TabStop = false;
            // 
            // buttonSetLightTr
            // 
            this.buttonSetLightTr.Location = new System.Drawing.Point(666, 129);
            this.buttonSetLightTr.Name = "buttonSetLightTr";
            this.buttonSetLightTr.Size = new System.Drawing.Size(118, 44);
            this.buttonSetLightTr.TabIndex = 1;
            this.buttonSetLightTr.Text = "Припарковать обычный трактор";
            this.buttonSetLightTr.UseVisualStyleBackColor = true;
            this.buttonSetLightTr.Click += new System.EventHandler(this.buttonSetL_Click);
            // 
            // buttonSetHighTr
            // 
            this.buttonSetHighTr.Location = new System.Drawing.Point(666, 179);
            this.buttonSetHighTr.Name = "buttonSetHighTr";
            this.buttonSetHighTr.Size = new System.Drawing.Size(118, 47);
            this.buttonSetHighTr.TabIndex = 2;
            this.buttonSetHighTr.Text = "Припарковать тяжёлый трактор";
            this.buttonSetHighTr.UseVisualStyleBackColor = true;
            this.buttonSetHighTr.Click += new System.EventHandler(this.buttonSetH_Clik);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(731, 305);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(19, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(668, 361);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 77);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Место -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(673, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Забрать трактор";
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(690, 332);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(75, 23);
            this.buttonTake.TabIndex = 7;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // listBox123
            // 
            this.listBox123.FormattingEnabled = true;
            this.listBox123.Location = new System.Drawing.Point(666, 12);
            this.listBox123.Name = "listBox123";
            this.listBox123.Size = new System.Drawing.Size(120, 95);
            this.listBox123.TabIndex = 5;
            this.listBox123.SelectedIndexChanged += new System.EventHandler(this.listBox123_SelectedIndexChanged);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox123);
            this.Controls.Add(this.buttonTake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.buttonSetHighTr);
            this.Controls.Add(this.buttonSetLightTr);
            this.Controls.Add(this.pictureBoxTrac1);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrac1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTrac1;
        private System.Windows.Forms.Button buttonSetLightTr;
        private System.Windows.Forms.Button buttonSetHighTr;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.ListBox listBox123;
    }
}