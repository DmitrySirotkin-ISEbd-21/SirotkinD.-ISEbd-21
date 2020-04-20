

﻿namespace WindowsFormsTrac
{
    partial class FormTract
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTract));
            this.pictureBoxTrac = new System.Windows.Forms.PictureBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonCreateSmall = new System.Windows.Forms.Button();
            this.buttonCreate1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrac)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTrac
            // 
            this.pictureBoxTrac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTrac.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTrac.Name = "pictureBoxTrac";
            this.pictureBoxTrac.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxTrac.TabIndex = 0;
            this.pictureBoxTrac.TabStop = false;
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(748, 358);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(701, 404);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(796, 404);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(748, 404);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateSmall
            // 
            this.buttonCreateSmall.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateSmall.Name = "buttonCreateSmall";
            this.buttonCreateSmall.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateSmall.TabIndex = 5;
            this.buttonCreateSmall.Text = "Создать";
            this.buttonCreateSmall.UseVisualStyleBackColor = true;
            this.buttonCreateSmall.Click += new System.EventHandler(this.buttonCreateSmall_Click);
            // 
            // buttonCreate1
            // 
            this.buttonCreate1.Location = new System.Drawing.Point(121, 12);
            this.buttonCreate1.Name = "buttonCreate1";
            this.buttonCreate1.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate1.TabIndex = 6;
            this.buttonCreate1.Text = "Создать1";
            this.buttonCreate1.UseVisualStyleBackColor = true;
            this.buttonCreate1.Click += new System.EventHandler(this.buttonCreateHigh_Click);
            // 
            // FormTract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonCreate1);
            this.Controls.Add(this.buttonCreateSmall);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.pictureBoxTrac);
            this.Name = "FormTract";
            this.Text = "Трактор";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTrac;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonCreateSmall;
        private System.Windows.Forms.Button buttonCreate1;
    }
}
