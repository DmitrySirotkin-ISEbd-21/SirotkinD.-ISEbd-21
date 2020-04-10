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
            this.pictureBoxParkovka = new System.Windows.Forms.PictureBox();
            this.pictureBoxTracSpawn = new System.Windows.Forms.PictureBox();
            this.buttonParkingTractBezKovshey = new System.Windows.Forms.Button();
            this.buttonParkingTractSKovshami = new System.Windows.Forms.Button();
            this.NomerMesta = new System.Windows.Forms.MaskedTextBox();
            this.pictureBoxTractAfterZabrat = new System.Windows.Forms.PictureBox();
            this.Mesto = new System.Windows.Forms.Label();
            this.ZabratTract = new System.Windows.Forms.Label();
            this.buttonZabratTract = new System.Windows.Forms.Button();
            this.listBoxLVL = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParkovka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTractAfterZabrat)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParkovka
            // 
            this.pictureBoxParkovka.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParkovka.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParkovka.Name = "pictureBoxParkovka";
            this.pictureBoxParkovka.Size = new System.Drawing.Size(639, 450);
            this.pictureBoxParkovka.TabIndex = 0;
            this.pictureBoxParkovka.TabStop = false;
            // 
            // buttonParkingTractBezKovshey
            // 
            this.buttonParkingTractBezKovshey.Location = new System.Drawing.Point(666, 129);
            this.buttonZabratTractor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTracSpawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTractAfterZabrat)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTracSpawn
            // 
            this.pictureBoxTracSpawn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxTracSpawn.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTracSpawn.Name = "pictureBoxTracSpawn";
            this.pictureBoxTracSpawn.Size = new System.Drawing.Size(639, 450);
            this.pictureBoxTracSpawn.TabIndex = 0;
            this.pictureBoxTracSpawn.TabStop = false;
            // 
            // buttonParkingTractBezKovshey
            // 
            this.buttonParkingTractBezKovshey.Location = new System.Drawing.Point(668, 12);
            this.buttonParkingTractBezKovshey.Name = "buttonParkingTractBezKovshey";
            this.buttonParkingTractBezKovshey.Size = new System.Drawing.Size(118, 44);
            this.buttonParkingTractBezKovshey.TabIndex = 1;
            this.buttonParkingTractBezKovshey.Text = "Припарковать обычный трактор";
            this.buttonParkingTractBezKovshey.UseVisualStyleBackColor = true;
            this.buttonParkingTractBezKovshey.Click += new System.EventHandler(this.buttonParkingTractBezKovshey_Click);
            // 
            // buttonParkingTractSKovshami
            // 
            this.buttonParkingTractSKovshami.Location = new System.Drawing.Point(666, 179);
            this.buttonParkingTractBezKovshey.Click += new System.EventHandler(this.buttonParkingTractBezKovshey_Clik);
            // 
            // buttonParkingTractSKovshami
            // 
            this.buttonParkingTractSKovshami.Location = new System.Drawing.Point(668, 62);
            this.buttonParkingTractSKovshami.Name = "buttonParkingTractSKovshami";
            this.buttonParkingTractSKovshami.Size = new System.Drawing.Size(118, 47);
            this.buttonParkingTractSKovshami.TabIndex = 2;
            this.buttonParkingTractSKovshami.Text = "Припарковать тяжёлый трактор";
            this.buttonParkingTractSKovshami.UseVisualStyleBackColor = true;
            this.buttonParkingTractSKovshami.Click += new System.EventHandler(this.buttonParkingTractSKovshami_Clik);
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
            // buttonZabratTract
            // 
            this.buttonZabratTract.Location = new System.Drawing.Point(690, 332);
            this.buttonZabratTract.Name = "buttonZabratTract";
            this.buttonZabratTract.Size = new System.Drawing.Size(75, 23);
            this.buttonZabratTract.TabIndex = 7;
            this.buttonZabratTract.Text = "Забрать";
            this.buttonZabratTract.UseVisualStyleBackColor = true;
            this.buttonZabratTract.Click += new System.EventHandler(this.buttonZabratTract_Click);
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
            // buttonZabratTractor
            // 
            this.buttonZabratTractor.Location = new System.Drawing.Point(690, 332);
            this.buttonZabratTractor.Name = "buttonZabratTractor";
            this.buttonZabratTractor.Size = new System.Drawing.Size(75, 23);
            this.buttonZabratTractor.TabIndex = 7;
            this.buttonZabratTractor.Text = "Забрать";
            this.buttonZabratTractor.UseVisualStyleBackColor = true;
            this.buttonZabratTractor.Click += new System.EventHandler(this.buttonZabratTractor_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);

            this.Controls.Add(this.listBoxLVL);
            this.Controls.Add(this.buttonZabratTract);
            this.Controls.Add(this.buttonZabratTractor);
            this.Controls.Add(this.ZabratTract);
            this.Controls.Add(this.Mesto);
            this.Controls.Add(this.pictureBoxTractAfterZabrat);
            this.Controls.Add(this.NomerMesta);
            this.Controls.Add(this.buttonParkingTractSKovshami);
            this.Controls.Add(this.buttonParkingTractBezKovshey);
            this.Controls.Add(this.pictureBoxParkovka);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParkovka)).EndInit();
            this.Controls.Add(this.pictureBoxTracSpawn);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTracSpawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTractAfterZabrat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParkovka;
        private System.Windows.Forms.PictureBox pictureBoxTracSpawn;
        private System.Windows.Forms.Button buttonParkingTractBezKovshey;
        private System.Windows.Forms.Button buttonParkingTractSKovshami;
        private System.Windows.Forms.MaskedTextBox NomerMesta;
        private System.Windows.Forms.PictureBox pictureBoxTractAfterZabrat;
        private System.Windows.Forms.Label Mesto;
        private System.Windows.Forms.Label ZabratTract;
        private System.Windows.Forms.Button buttonZabratTract;
        private System.Windows.Forms.ListBox listBoxLVL;
        private System.Windows.Forms.Button buttonZabratTractor;
    }
}