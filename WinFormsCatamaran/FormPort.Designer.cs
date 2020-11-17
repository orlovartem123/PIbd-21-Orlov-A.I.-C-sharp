namespace WinFormsCatamaran
{
    partial class FormPort
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
            this.pictureBoxPort = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTakeBoat = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPorts = new System.Windows.Forms.ListBox();
            this.buttonDelPort = new System.Windows.Forms.Button();
            this.buttonAddPort = new System.Windows.Forms.Button();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddBoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPort
            // 
            this.pictureBoxPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxPort.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPort.Name = "pictureBoxPort";
            this.pictureBoxPort.Size = new System.Drawing.Size(895, 523);
            this.pictureBoxPort.TabIndex = 0;
            this.pictureBoxPort.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTakeBoat);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(907, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать транспорт";
            // 
            // buttonTakeBoat
            // 
            this.buttonTakeBoat.Location = new System.Drawing.Point(24, 71);
            this.buttonTakeBoat.Name = "buttonTakeBoat";
            this.buttonTakeBoat.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeBoat.TabIndex = 2;
            this.buttonTakeBoat.Text = "Забрать";
            this.buttonTakeBoat.UseVisualStyleBackColor = true;
            this.buttonTakeBoat.Click += new System.EventHandler(this.buttonTakeBoat_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(65, 34);
            this.maskedTextBox.Mask = "00";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(34, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место";
            // 
            // listBoxPorts
            // 
            this.listBoxPorts.FormattingEnabled = true;
            this.listBoxPorts.Location = new System.Drawing.Point(907, 84);
            this.listBoxPorts.Name = "listBoxPorts";
            this.listBoxPorts.Size = new System.Drawing.Size(115, 95);
            this.listBoxPorts.TabIndex = 4;
            this.listBoxPorts.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // buttonDelPort
            // 
            this.buttonDelPort.Location = new System.Drawing.Point(907, 185);
            this.buttonDelPort.Name = "buttonDelPort";
            this.buttonDelPort.Size = new System.Drawing.Size(115, 27);
            this.buttonDelPort.TabIndex = 5;
            this.buttonDelPort.Text = "Удалить порт";
            this.buttonDelPort.UseVisualStyleBackColor = true;
            this.buttonDelPort.Click += new System.EventHandler(this.ButtonDelParking_Click);
            // 
            // buttonAddPort
            // 
            this.buttonAddPort.Location = new System.Drawing.Point(907, 51);
            this.buttonAddPort.Name = "buttonAddPort";
            this.buttonAddPort.Size = new System.Drawing.Size(115, 27);
            this.buttonAddPort.TabIndex = 6;
            this.buttonAddPort.Text = "Добавить порт";
            this.buttonAddPort.UseVisualStyleBackColor = true;
            this.buttonAddPort.Click += new System.EventHandler(this.ButtonAddParking_Click);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(909, 25);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(113, 20);
            this.textBoxNewLevelName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(938, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Порты";
            // 
            // buttonAddBoat
            // 
            this.buttonAddBoat.Location = new System.Drawing.Point(907, 251);
            this.buttonAddBoat.Name = "buttonAddBoat";
            this.buttonAddBoat.Size = new System.Drawing.Size(115, 44);
            this.buttonAddBoat.TabIndex = 9;
            this.buttonAddBoat.Text = "Добавить транспорт";
            this.buttonAddBoat.UseVisualStyleBackColor = true;
            this.buttonAddBoat.Click += new System.EventHandler(this.ButtonAddBoat_Click);
            // 
            // FormPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 523);
            this.Controls.Add(this.buttonAddBoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.buttonAddPort);
            this.Controls.Add(this.buttonDelPort);
            this.Controls.Add(this.listBoxPorts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxPort);
            this.Name = "FormPort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Порт";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTakeBoat;
        private System.Windows.Forms.ListBox listBoxPorts;
        private System.Windows.Forms.Button buttonDelPort;
        private System.Windows.Forms.Button buttonAddPort;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddBoat;
    }
}