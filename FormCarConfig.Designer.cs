namespace WindowsFormsLab2
{
    partial class FormCarConfig
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
            this.pictureBoxTR = new System.Windows.Forms.PictureBox();
            this.groupBoxTTT = new System.Windows.Forms.GroupBox();
            this.labelHigh = new System.Windows.Forms.Label();
            this.labelLight = new System.Windows.Forms.Label();
            this.pictureBoxTTT = new System.Windows.Forms.PictureBox();
            this.panelTTT = new System.Windows.Forms.Panel();
            this.labelDop = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTractorOBV = new System.Windows.Forms.Label();
            this.labelDrawTract2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lableDopColor = new System.Windows.Forms.Label();
            this.lableMainColor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelGold = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTR
            // 
            this.pictureBoxTR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTR.Location = new System.Drawing.Point(28, 12);
            this.pictureBoxTR.Name = "pictureBoxTR";
            this.pictureBoxTR.Size = new System.Drawing.Size(141, 76);
            this.pictureBoxTR.TabIndex = 0;
            this.pictureBoxTR.TabStop = false;
            //
            // groupBoxTTT
            // 
            this.groupBoxTTT.Controls.Add(this.labelHigh);
            this.groupBoxTTT.Controls.Add(this.labelLight);
            this.groupBoxTTT.Location = new System.Drawing.Point(12, 22);
            this.groupBoxTTT.Name = "groupBoxTTT";
            this.groupBoxTTT.Size = new System.Drawing.Size(132, 100);
            this.groupBoxTTT.TabIndex = 0;
            this.groupBoxTTT.TabStop = false;
            this.groupBoxTTT.Text = "Типы тракторов";
            // 
            // labelHigh
            // 
            this.labelHigh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHigh.Location = new System.Drawing.Point(15, 61);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(100, 23);
            this.labelHigh.TabIndex = 1;
            this.labelHigh.Text = "Тяжёлый";
            this.labelHigh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lableHigh_MouseDown);
            // 
            // labelLight
            // 
            this.labelLight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLight.Location = new System.Drawing.Point(15, 27);
            this.labelLight.Name = "labelLight";
            this.labelLight.Size = new System.Drawing.Size(100, 23);
            this.labelLight.TabIndex = 0;
            this.labelLight.Text = "Лёгкий";
            this.labelLight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lableLight_MouseDown);
            // 
            // pictureBoxTTT
            // 
            this.pictureBoxTTT.Location = new System.Drawing.Point(21, 7);
            this.pictureBoxTTT.Name = "pictureBoxTTT";
            this.pictureBoxTTT.Size = new System.Drawing.Size(136, 100);
            this.pictureBoxTTT.TabIndex = 1;
            this.pictureBoxTTT.TabStop = false;
            // 
            // panelTTT
            // 
            this.panelTTT.AllowDrop = true;
            this.panelTTT.Controls.Add(this.labelDop);
            this.panelTTT.Controls.Add(this.labelMain);
            this.panelTTT.Controls.Add(this.pictureBoxTTT);
            this.panelTTT.Location = new System.Drawing.Point(166, 22);
            this.panelTTT.Name = "panelTTT";
            this.panelTTT.Size = new System.Drawing.Size(176, 208);
            this.panelTTT.TabIndex = 2;
            this.panelTTT.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTTT_DragDrop);
            this.panelTTT.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTTT_DragEnter);
            // 
            // labelDop
            // 
            this.labelDop.AllowDrop = true;
            this.labelDop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDop.Location = new System.Drawing.Point(35, 156);
            this.labelDop.Name = "labelDop";
            this.labelDop.Size = new System.Drawing.Size(100, 23);
            this.labelDop.TabIndex = 3;
            this.labelDop.Text = "Дополнительный";
            this.labelDop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lableDop_DragDrop);
            this.labelDop.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDop_DragEnter);
            // 
            // labelMain
            // 
            this.labelMain.AllowDrop = true;
            this.labelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMain.Location = new System.Drawing.Point(35, 124);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(100, 23);
            this.labelMain.TabIndex = 2;
            this.labelMain.Text = "Основной";
            this.labelMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.lableMain_DragDrop);
            this.labelMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.lableMain_DragEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTractorOBV);
            this.groupBox1.Controls.Add(this.labelDrawTract2);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип кузова";
            // 
            // labelTractorOBV
            // 
            this.labelTractorOBV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTractorOBV.Location = new System.Drawing.Point(6, 55);
            this.labelTractorOBV.Name = "labelTractorOBV";
            this.labelTractorOBV.Size = new System.Drawing.Size(113, 23);
            this.labelTractorOBV.TabIndex = 1;
            this.labelTractorOBV.Text = "С ковшами";
            this.labelTractorOBV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lableTractorOBV_MouseDown);
            // 
            // labelDrawTract2
            // 
            this.labelDrawTract2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDrawTract2.Location = new System.Drawing.Point(6, 16);
            this.labelDrawTract2.Name = "labelDrawTract2";
            this.labelDrawTract2.Size = new System.Drawing.Size(114, 23);
            this.labelDrawTract2.TabIndex = 0;
            this.labelDrawTract2.Text = "Без ковшей";
            this.labelDrawTract2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDrawTract2_MouseDown);
            // 
            // panelMain
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.lableDopColor);
            this.panel1.Controls.Add(this.lableMainColor);
            this.panel1.Controls.Add(this.pictureBoxTR);
            this.panel1.Location = new System.Drawing.Point(168, 12);
            this.panel1.Name = "panelMain";
            this.panel1.Size = new System.Drawing.Size(200, 183);
            this.panel1.TabIndex = 2;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelMain_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelMain_DragEnter);
            // 
            // lableDopColor
            // 
            this.lableDopColor.AllowDrop = true;
            this.lableDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lableDopColor.Location = new System.Drawing.Point(45, 135);
            this.lableDopColor.Name = "lableDopColor";
            this.lableDopColor.Size = new System.Drawing.Size(100, 23);
            this.lableDopColor.TabIndex = 2;
            this.lableDopColor.Text = "Доп. цвет";
            this.lableDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.lableDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
            // 
            // lableMainColor
            // 
            this.lableMainColor.AllowDrop = true;
            this.lableMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lableMainColor.Location = new System.Drawing.Point(45, 97);
            this.lableMainColor.Name = "lableMainColor";
            this.lableMainColor.Size = new System.Drawing.Size(100, 23);
            this.lableMainColor.TabIndex = 1;
            this.lableMainColor.Text = "Осн. цвет";
            this.lableMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.lableMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelGold);
            this.groupBox2.Controls.Add(this.panelYellow);
            this.groupBox2.Controls.Add(this.panelBlue);
            this.groupBox2.Controls.Add(this.panelWhite);
            this.groupBox2.Controls.Add(this.panelGray);
            this.groupBox2.Controls.Add(this.panelRed);
            this.groupBox2.Controls.Add(this.panelGreen);
            this.groupBox2.Controls.Add(this.panelBlack);
            this.groupBox2.Location = new System.Drawing.Point(404, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 183);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panelGold
            // 
            this.panelGold.BackColor = System.Drawing.Color.Orange;
            this.panelGold.Location = new System.Drawing.Point(60, 135);
            this.panelGold.Name = "panelGold";
            this.panelGold.Size = new System.Drawing.Size(30, 30);
            this.panelGold.TabIndex = 7;
            this.panelGold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(60, 97);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(30, 30);
            this.panelYellow.TabIndex = 6;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(60, 58);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(30, 30);
            this.panelBlue.TabIndex = 5;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(60, 20);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(30, 30);
            this.panelWhite.TabIndex = 4;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Silver;
            this.panelGray.Location = new System.Drawing.Point(7, 135);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(30, 30);
            this.panelGray.TabIndex = 3;
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(7, 97);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(30, 30);
            this.panelRed.TabIndex = 2;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(7, 58);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(30, 30);
            this.panelGreen.TabIndex = 1;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(7, 20);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(30, 30);
            this.panelBlack.TabIndex = 0;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 131);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(55, 161);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormCarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 207);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCarConfig";
            this.Text = "FormTractConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTR;
        private System.Windows.Forms.GroupBox groupBoxTTT;
        private System.Windows.Forms.Label labelHigh;
        private System.Windows.Forms.Label labelLight;
        private System.Windows.Forms.PictureBox pictureBoxTTT;
        private System.Windows.Forms.Panel panelTTT;
        private System.Windows.Forms.Label labelDop;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTractorOBV;
        private System.Windows.Forms.Label labelDrawTract2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lableDopColor;
        private System.Windows.Forms.Label lableMainColor;
        private System.Windows.Forms.Panel panelGold;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}