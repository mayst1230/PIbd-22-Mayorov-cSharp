namespace WindowsFormsBus
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.parkingButtonBus = new System.Windows.Forms.Button();
            this.parkingButtonAccordionBus = new System.Windows.Forms.Button();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.pickUpBus = new System.Windows.Forms.Button();
            this.maskedTextBoxBus = new System.Windows.Forms.MaskedTextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.labelParkings = new System.Windows.Forms.Label();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.buttonDelParking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxParking.BackColor = System.Drawing.Color.White;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 1);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(679, 450);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // parkingButtonBus
            // 
            this.parkingButtonBus.Location = new System.Drawing.Point(685, 233);
            this.parkingButtonBus.Name = "parkingButtonBus";
            this.parkingButtonBus.Size = new System.Drawing.Size(110, 42);
            this.parkingButtonBus.TabIndex = 1;
            this.parkingButtonBus.Text = "Припарковать автобус";
            this.parkingButtonBus.UseVisualStyleBackColor = true;
            this.parkingButtonBus.Click += new System.EventHandler(this.parkingButtonBus_Click);
            // 
            // parkingButtonAccordionBus
            // 
            this.parkingButtonAccordionBus.Location = new System.Drawing.Point(685, 281);
            this.parkingButtonAccordionBus.Name = "parkingButtonAccordionBus";
            this.parkingButtonAccordionBus.Size = new System.Drawing.Size(110, 53);
            this.parkingButtonAccordionBus.TabIndex = 2;
            this.parkingButtonAccordionBus.Text = "Припарковать атобус с гормошкой";
            this.parkingButtonAccordionBus.UseVisualStyleBackColor = true;
            this.parkingButtonAccordionBus.Click += new System.EventHandler(this.parkingButtonAccordionBus_Click);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.pickUpBus);
            this.groupBoxSettings.Controls.Add(this.maskedTextBoxBus);
            this.groupBoxSettings.Controls.Add(this.labelPosition);
            this.groupBoxSettings.Location = new System.Drawing.Point(685, 340);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(110, 98);
            this.groupBoxSettings.TabIndex = 3;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Забрать автобус";
            // 
            // pickUpBus
            // 
            this.pickUpBus.Location = new System.Drawing.Point(9, 70);
            this.pickUpBus.Name = "pickUpBus";
            this.pickUpBus.Size = new System.Drawing.Size(91, 22);
            this.pickUpBus.TabIndex = 2;
            this.pickUpBus.Text = "Забрать";
            this.pickUpBus.UseVisualStyleBackColor = true;
            this.pickUpBus.Click += new System.EventHandler(this.pickUpBus_Click);
            // 
            // maskedTextBoxBus
            // 
            this.maskedTextBoxBus.Location = new System.Drawing.Point(54, 30);
            this.maskedTextBoxBus.Mask = "00000";
            this.maskedTextBoxBus.Name = "maskedTextBoxBus";
            this.maskedTextBoxBus.Size = new System.Drawing.Size(47, 20);
            this.maskedTextBoxBus.TabIndex = 1;
            this.maskedTextBoxBus.ValidatingType = typeof(int);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(6, 33);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(42, 13);
            this.labelPosition.TabIndex = 0;
            this.labelPosition.Text = "Место:";
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.Location = new System.Drawing.Point(685, 89);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(110, 95);
            this.listBoxParkings.TabIndex = 4;
            this.listBoxParkings.Click += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(685, 27);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(110, 20);
            this.textBoxNewLevelName.TabIndex = 5;
            // 
            // labelParkings
            // 
            this.labelParkings.AutoSize = true;
            this.labelParkings.Location = new System.Drawing.Point(708, 11);
            this.labelParkings.Name = "labelParkings";
            this.labelParkings.Size = new System.Drawing.Size(57, 13);
            this.labelParkings.TabIndex = 6;
            this.labelParkings.Text = "Парковки";
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Location = new System.Drawing.Point(685, 61);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(110, 22);
            this.buttonAddParking.TabIndex = 7;
            this.buttonAddParking.Text = "Создать парковку";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // buttonDelParking
            // 
            this.buttonDelParking.Location = new System.Drawing.Point(685, 196);
            this.buttonDelParking.Name = "buttonDelParking";
            this.buttonDelParking.Size = new System.Drawing.Size(110, 24);
            this.buttonDelParking.TabIndex = 8;
            this.buttonDelParking.Text = "Удалить парковку";
            this.buttonDelParking.UseVisualStyleBackColor = true;
            this.buttonDelParking.Click += new System.EventHandler(this.buttonDelParking_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelParking);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.labelParkings);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.parkingButtonAccordionBus);
            this.Controls.Add(this.parkingButtonBus);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button parkingButtonBus;
        private System.Windows.Forms.Button parkingButtonAccordionBus;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Button pickUpBus;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBus;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Label labelParkings;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.Button buttonDelParking;
    }
}