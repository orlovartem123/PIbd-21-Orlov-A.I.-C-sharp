namespace WinFormsCatamaran
{
    partial class FormCatamaran
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
            this.pictureBoxCatamaran = new System.Windows.Forms.PictureBox();
            this.buttonCreateBoat = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonCreateCatamaran = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatamaran)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCatamaran
            // 
            this.pictureBoxCatamaran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCatamaran.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCatamaran.Name = "pictureBoxCatamaran";
            this.pictureBoxCatamaran.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxCatamaran.TabIndex = 0;
            this.pictureBoxCatamaran.TabStop = false;
            // 
            // buttonCreateBoat
            // 
            this.buttonCreateBoat.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateBoat.Name = "buttonCreateBoat";
            this.buttonCreateBoat.Size = new System.Drawing.Size(138, 34);
            this.buttonCreateBoat.TabIndex = 1;
            this.buttonCreateBoat.Text = "Создать лодку";
            this.buttonCreateBoat.UseVisualStyleBackColor = true;
            this.buttonCreateBoat.Click += new System.EventHandler(this.ButtonCreateBoat_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::WinFormsCatamaran.Properties.Resources.UpArrow;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(806, 383);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::WinFormsCatamaran.Properties.Resources.LeftArrow;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(770, 419);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::WinFormsCatamaran.Properties.Resources.RightArrow;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(842, 419);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::WinFormsCatamaran.Properties.Resources.DownArrow;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(806, 419);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateCatamaran
            // 
            this.buttonCreateCatamaran.Location = new System.Drawing.Point(156, 12);
            this.buttonCreateCatamaran.Name = "buttonCreateCatamaran";
            this.buttonCreateCatamaran.Size = new System.Drawing.Size(138, 34);
            this.buttonCreateCatamaran.TabIndex = 6;
            this.buttonCreateCatamaran.Text = "Создать катамаран";
            this.buttonCreateCatamaran.UseVisualStyleBackColor = true;
            this.buttonCreateCatamaran.Click += new System.EventHandler(this.ButtonCreateCatamaran_Click);
            // 
            // FormCatamaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonCreateCatamaran);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreateBoat);
            this.Controls.Add(this.pictureBoxCatamaran);
            this.Name = "FormCatamaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Катамаран";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatamaran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCatamaran;
        private System.Windows.Forms.Button buttonCreateBoat;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonCreateCatamaran;
    }
}

