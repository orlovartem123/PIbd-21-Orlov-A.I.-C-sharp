namespace WinFormsCatamaran
{
    partial class FormBoatConfig
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
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.checkBoxPasSeats = new System.Windows.Forms.CheckBox();
            this.checkBoxBobs = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.labelCatamaran = new System.Windows.Forms.Label();
            this.labelBoat = new System.Windows.Forms.Label();
            this.pictureBoxBoat = new System.Windows.Forms.PictureBox();
            this.panelBoat = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelFuchsia = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.panelLime = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.groupBoxType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).BeginInit();
            this.panelBoat.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.checkBoxPasSeats);
            this.groupBoxParams.Controls.Add(this.checkBoxBobs);
            this.groupBoxParams.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParams.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxParams.Controls.Add(this.label2);
            this.groupBoxParams.Controls.Add(this.label1);
            this.groupBoxParams.Location = new System.Drawing.Point(12, 174);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(352, 133);
            this.groupBoxParams.TabIndex = 0;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Параметры";
            // 
            // checkBoxPasSeats
            // 
            this.checkBoxPasSeats.AutoSize = true;
            this.checkBoxPasSeats.Checked = true;
            this.checkBoxPasSeats.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPasSeats.Location = new System.Drawing.Point(188, 52);
            this.checkBoxPasSeats.Name = "checkBoxPasSeats";
            this.checkBoxPasSeats.Size = new System.Drawing.Size(136, 17);
            this.checkBoxPasSeats.TabIndex = 5;
            this.checkBoxPasSeats.Text = "Пассажирские места";
            this.checkBoxPasSeats.UseVisualStyleBackColor = true;
            // 
            // checkBoxBobs
            // 
            this.checkBoxBobs.AutoSize = true;
            this.checkBoxBobs.Checked = true;
            this.checkBoxBobs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBobs.Location = new System.Drawing.Point(188, 29);
            this.checkBoxBobs.Name = "checkBoxBobs";
            this.checkBoxBobs.Size = new System.Drawing.Size(76, 17);
            this.checkBoxBobs.TabIndex = 4;
            this.checkBoxBobs.Text = "Поплавки";
            this.checkBoxBobs.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(75, 93);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(75, 45);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownSpeed.TabIndex = 2;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес транспорта:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Макс. скорость:";
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.labelCatamaran);
            this.groupBoxType.Controls.Add(this.labelBoat);
            this.groupBoxType.Location = new System.Drawing.Point(12, 12);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(159, 156);
            this.groupBoxType.TabIndex = 1;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Тип";
            // 
            // labelCatamaran
            // 
            this.labelCatamaran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCatamaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCatamaran.Location = new System.Drawing.Point(25, 89);
            this.labelCatamaran.Name = "labelCatamaran";
            this.labelCatamaran.Size = new System.Drawing.Size(103, 35);
            this.labelCatamaran.TabIndex = 1;
            this.labelCatamaran.Text = "Катамаран";
            this.labelCatamaran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCatamaran.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCatamaran_MouseDown);
            // 
            // labelBoat
            // 
            this.labelBoat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBoat.Location = new System.Drawing.Point(25, 35);
            this.labelBoat.Name = "labelBoat";
            this.labelBoat.Size = new System.Drawing.Size(103, 35);
            this.labelBoat.TabIndex = 0;
            this.labelBoat.Text = "Лодка";
            this.labelBoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBoat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBoat_MouseDown);
            // 
            // pictureBoxBoat
            // 
            this.pictureBoxBoat.Location = new System.Drawing.Point(14, 15);
            this.pictureBoxBoat.Name = "pictureBoxBoat";
            this.pictureBoxBoat.Size = new System.Drawing.Size(151, 119);
            this.pictureBoxBoat.TabIndex = 2;
            this.pictureBoxBoat.TabStop = false;
            // 
            // panelBoat
            // 
            this.panelBoat.AllowDrop = true;
            this.panelBoat.Controls.Add(this.pictureBoxBoat);
            this.panelBoat.Location = new System.Drawing.Point(186, 17);
            this.panelBoat.Name = "panelBoat";
            this.panelBoat.Size = new System.Drawing.Size(178, 151);
            this.panelBoat.TabIndex = 3;
            this.panelBoat.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelBoat_DragDrop);
            this.panelBoat.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelBoat_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelFuchsia);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelGray);
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.panelLime);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Location = new System.Drawing.Point(393, 17);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(260, 151);
            this.groupBoxColors.TabIndex = 4;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelWhite
            // 
            this.panelWhite.AllowDrop = true;
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(198, 99);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(37, 35);
            this.panelWhite.TabIndex = 5;
            // 
            // panelBlack
            // 
            this.panelBlack.AllowDrop = true;
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(144, 99);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(37, 35);
            this.panelBlack.TabIndex = 5;
            // 
            // panelFuchsia
            // 
            this.panelFuchsia.AllowDrop = true;
            this.panelFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.panelFuchsia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFuchsia.Location = new System.Drawing.Point(198, 54);
            this.panelFuchsia.Name = "panelFuchsia";
            this.panelFuchsia.Size = new System.Drawing.Size(37, 35);
            this.panelFuchsia.TabIndex = 5;
            // 
            // panelBlue
            // 
            this.panelBlue.AllowDrop = true;
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(144, 54);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(37, 35);
            this.panelBlue.TabIndex = 5;
            // 
            // panelYellow
            // 
            this.panelYellow.AllowDrop = true;
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(80, 99);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(37, 35);
            this.panelYellow.TabIndex = 5;
            // 
            // panelGray
            // 
            this.panelGray.AllowDrop = true;
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGray.Location = new System.Drawing.Point(26, 99);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(37, 35);
            this.panelGray.TabIndex = 5;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDopColor.Location = new System.Drawing.Point(144, 15);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(91, 35);
            this.labelDopColor.TabIndex = 3;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // panelLime
            // 
            this.panelLime.AllowDrop = true;
            this.panelLime.BackColor = System.Drawing.Color.Lime;
            this.panelLime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLime.Location = new System.Drawing.Point(80, 54);
            this.panelLime.Name = "panelLime";
            this.panelLime.Size = new System.Drawing.Size(37, 35);
            this.panelLime.TabIndex = 5;
            // 
            // panelRed
            // 
            this.panelRed.AllowDrop = true;
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(26, 54);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(37, 35);
            this.panelRed.TabIndex = 4;
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainColor.Location = new System.Drawing.Point(26, 16);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(91, 35);
            this.labelMainColor.TabIndex = 2;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(568, 226);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 27);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(568, 270);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 27);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormBoatConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 319);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelBoat);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.groupBoxParams);
            this.Name = "FormBoatConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор транспорта";
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.groupBoxType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).EndInit();
            this.panelBoat.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.PictureBox pictureBoxBoat;
        private System.Windows.Forms.CheckBox checkBoxPasSeats;
        private System.Windows.Forms.CheckBox checkBoxBobs;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCatamaran;
        private System.Windows.Forms.Label labelBoat;
        private System.Windows.Forms.Panel panelBoat;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelFuchsia;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Panel panelLime;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}