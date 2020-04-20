namespace WindowsFormsTrac
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
            this.groupBoxTTT = new System.Windows.Forms.GroupBox();
            this.labelHigh = new System.Windows.Forms.Label();
            this.labelLight = new System.Windows.Forms.Label();
            this.pictureBoxTTT = new System.Windows.Forms.PictureBox();
            this.panelTTT = new System.Windows.Forms.Panel();
            this.labelDop = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelPurpule = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelLime = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonTake = new System.Windows.Forms.Button();
            this.groupBoxTTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTTT)).BeginInit();
            this.panelTTT.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.panelRed);
            this.groupBox1.Controls.Add(this.panelWhite);
            this.groupBox1.Controls.Add(this.panelPurpule);
            this.groupBox1.Controls.Add(this.panelBlack);
            this.groupBox1.Controls.Add(this.panelOrange);
            this.groupBox1.Controls.Add(this.panelLime);
            this.groupBox1.Controls.Add(this.panelBlue);
            this.groupBox1.Controls.Add(this.panelYellow);
            this.groupBox1.Location = new System.Drawing.Point(366, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 218);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цвета";
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(96, 154);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(35, 35);
            this.panelRed.TabIndex = 7;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(17, 154);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(35, 35);
            this.panelWhite.TabIndex = 6;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelPurpule
            // 
            this.panelPurpule.BackColor = System.Drawing.Color.Purple;
            this.panelPurpule.Location = new System.Drawing.Point(96, 113);
            this.panelPurpule.Name = "panelPurpule";
            this.panelPurpule.Size = new System.Drawing.Size(35, 35);
            this.panelPurpule.TabIndex = 5;
            this.panelPurpule.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(17, 113);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(35, 35);
            this.panelBlack.TabIndex = 4;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.Location = new System.Drawing.Point(96, 71);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(35, 35);
            this.panelOrange.TabIndex = 3;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelLime
            // 
            this.panelLime.BackColor = System.Drawing.Color.Lime;
            this.panelLime.Location = new System.Drawing.Point(17, 71);
            this.panelLime.Name = "panelLime";
            this.panelLime.Size = new System.Drawing.Size(35, 35);
            this.panelLime.TabIndex = 2;
            this.panelLime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(96, 30);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(35, 35);
            this.panelBlue.TabIndex = 1;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(17, 30);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(35, 35);
            this.panelYellow.TabIndex = 0;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(27, 136);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 4;
            this.buttonSet.Text = "Добавить";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(72, 177);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(75, 23);
            this.buttonTake.TabIndex = 5;
            this.buttonTake.Text = "Удалить";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // FormCarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 259);
            this.Controls.Add(this.buttonTake);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTTT);
            this.Controls.Add(this.groupBoxTTT);
            this.Name = "FormCarConfig";
            this.Text = "Выбор трактора";
            this.groupBoxTTT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTTT)).EndInit();
            this.panelTTT.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTTT;
        private System.Windows.Forms.Label labelHigh;
        private System.Windows.Forms.Label labelLight;
        private System.Windows.Forms.PictureBox pictureBoxTTT;
        private System.Windows.Forms.Panel panelTTT;
        private System.Windows.Forms.Label labelDop;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelPurpule;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelLime;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button buttonTake;
    }
}