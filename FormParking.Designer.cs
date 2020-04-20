namespace WindowsFormsTrac
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
            this.NomerMesta = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxTractAfterZabrat = new System.Windows.Forms.PictureBox();
            this.Mesto = new System.Windows.Forms.Label();
            this.ZabratTract = new System.Windows.Forms.Label();
            this.buttonTake = new System.Windows.Forms.Button();
            this.listBoxLVL = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrac1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTractAfterZabrat)).BeginInit();
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
            // NomerMesta
            // 
            this.NomerMesta.Location = new System.Drawing.Point(731, 305);
            this.NomerMesta.Name = "NomerMesta";
            this.NomerMesta.Size = new System.Drawing.Size(19, 20);
            this.NomerMesta.TabIndex = 3;
            // 
            // pictureBoxTractAfterZabrat
            // 
            this.pictureBoxTractAfterZabrat.Location = new System.Drawing.Point(668, 361);
            this.pictureBoxTractAfterZabrat.Name = "pictureBoxTractAfterZabrat";
            this.pictureBoxTractAfterZabrat.Size = new System.Drawing.Size(118, 77);
            this.pictureBoxTractAfterZabrat.TabIndex = 4;
            this.pictureBoxTractAfterZabrat.TabStop = false;
            // 
            // Mesto
            // 
            this.Mesto.AutoSize = true;
            this.Mesto.Location = new System.Drawing.Point(680, 308);
            this.Mesto.Name = "Mesto";
            this.Mesto.Size = new System.Drawing.Size(45, 13);
            this.Mesto.TabIndex = 5;
            this.Mesto.Text = "Место -";
            // 
            // ZabratTract
            // 
            this.ZabratTract.AutoSize = true;
            this.ZabratTract.Location = new System.Drawing.Point(673, 289);
            this.ZabratTract.Name = "ZabratTract";
            this.ZabratTract.Size = new System.Drawing.Size(92, 13);
            this.ZabratTract.TabIndex = 6;
            this.ZabratTract.Text = "Забрать трактор";
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
            // listBoxLVL
            // 
            this.listBoxLVL.FormattingEnabled = true;
            this.listBoxLVL.Location = new System.Drawing.Point(666, 12);
            this.listBoxLVL.Name = "listBoxLVL";
            this.listBoxLVL.Size = new System.Drawing.Size(120, 95);
            this.listBoxLVL.TabIndex = 5;
            this.listBoxLVL.SelectedIndexChanged += new System.EventHandler(this.listBoxLVL_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(666, 133);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 51);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxLVL);
            this.Controls.Add(this.buttonTake);
            this.Controls.Add(this.ZabratTract);
            this.Controls.Add(this.Mesto);
            this.Controls.Add(this.pictureBoxTractAfterZabrat);
            this.Controls.Add(this.NomerMesta);
            this.Controls.Add(this.pictureBoxTrac1);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrac1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTractAfterZabrat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTrac1;
        private System.Windows.Forms.MaskedTextBox NomerMesta;
        private System.Windows.Forms.PictureBox pictureBoxTractAfterZabrat;
        private System.Windows.Forms.Label Mesto;
        private System.Windows.Forms.Label ZabratTract;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.ListBox listBoxLVL;
        private System.Windows.Forms.Button buttonAdd;
    }
}