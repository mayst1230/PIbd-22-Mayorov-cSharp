namespace WindowsFormsBus
{
    partial class FormBusConfig
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
            this.groupBoxParametrs = new System.Windows.Forms.GroupBox();
            this.checkBoxBackWindows = new System.Windows.Forms.CheckBox();
            this.checkBoxBackDoors = new System.Windows.Forms.CheckBox();
            this.checkBoxAccordion = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.pictureBoxPresent = new System.Windows.Forms.PictureBox();
            this.groupBoxTypeBody = new System.Windows.Forms.GroupBox();
            this.labelTypeAccordionBus = new System.Windows.Forms.Label();
            this.labelTypeBus = new System.Windows.Forms.Label();
            this.panelPicBox = new System.Windows.Forms.Panel();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelOtherColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancelColor = new System.Windows.Forms.Button();
            this.groupBoxParametrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPresent)).BeginInit();
            this.groupBoxTypeBody.SuspendLayout();
            this.panelPicBox.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParametrs
            // 
            this.groupBoxParametrs.Controls.Add(this.checkBoxBackWindows);
            this.groupBoxParametrs.Controls.Add(this.checkBoxBackDoors);
            this.groupBoxParametrs.Controls.Add(this.checkBoxAccordion);
            this.groupBoxParametrs.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParametrs.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxParametrs.Controls.Add(this.labelWeight);
            this.groupBoxParametrs.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParametrs.Location = new System.Drawing.Point(12, 206);
            this.groupBoxParametrs.Name = "groupBoxParametrs";
            this.groupBoxParametrs.Size = new System.Drawing.Size(403, 171);
            this.groupBoxParametrs.TabIndex = 0;
            this.groupBoxParametrs.TabStop = false;
            this.groupBoxParametrs.Text = "Параметры";
            // 
            // checkBoxBackWindows
            // 
            this.checkBoxBackWindows.AutoSize = true;
            this.checkBoxBackWindows.Location = new System.Drawing.Point(252, 84);
            this.checkBoxBackWindows.Name = "checkBoxBackWindows";
            this.checkBoxBackWindows.Size = new System.Drawing.Size(64, 21);
            this.checkBoxBackWindows.TabIndex = 6;
            this.checkBoxBackWindows.Text = "Окна";
            this.checkBoxBackWindows.UseVisualStyleBackColor = true;
            // 
            // checkBoxBackDoors
            // 
            this.checkBoxBackDoors.AutoSize = true;
            this.checkBoxBackDoors.Location = new System.Drawing.Point(252, 57);
            this.checkBoxBackDoors.Name = "checkBoxBackDoors";
            this.checkBoxBackDoors.Size = new System.Drawing.Size(72, 21);
            this.checkBoxBackDoors.TabIndex = 5;
            this.checkBoxBackDoors.Text = "Двери";
            this.checkBoxBackDoors.UseVisualStyleBackColor = true;
            // 
            // checkBoxAccordion
            // 
            this.checkBoxAccordion.AutoSize = true;
            this.checkBoxAccordion.Location = new System.Drawing.Point(252, 27);
            this.checkBoxAccordion.Name = "checkBoxAccordion";
            this.checkBoxAccordion.Size = new System.Drawing.Size(97, 21);
            this.checkBoxAccordion.TabIndex = 4;
            this.checkBoxAccordion.Text = "Гармошка";
            this.checkBoxAccordion.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(77, 123);
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
            this.numericUpDownWeight.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(77, 56);
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
            this.numericUpDownSpeed.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownSpeed.TabIndex = 2;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(29, 91);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(70, 17);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес авто:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(29, 27);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(112, 17);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Макс. скорость:";
            // 
            // pictureBoxPresent
            // 
            this.pictureBoxPresent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPresent.Location = new System.Drawing.Point(16, 16);
            this.pictureBoxPresent.Name = "pictureBoxPresent";
            this.pictureBoxPresent.Size = new System.Drawing.Size(473, 86);
            this.pictureBoxPresent.TabIndex = 1;
            this.pictureBoxPresent.TabStop = false;
            // 
            // groupBoxTypeBody
            // 
            this.groupBoxTypeBody.Controls.Add(this.labelTypeAccordionBus);
            this.groupBoxTypeBody.Controls.Add(this.labelTypeBus);
            this.groupBoxTypeBody.Location = new System.Drawing.Point(12, 28);
            this.groupBoxTypeBody.Name = "groupBoxTypeBody";
            this.groupBoxTypeBody.Size = new System.Drawing.Size(168, 158);
            this.groupBoxTypeBody.TabIndex = 2;
            this.groupBoxTypeBody.TabStop = false;
            this.groupBoxTypeBody.Text = "Тип кузова";
            // 
            // labelTypeAccordionBus
            // 
            this.labelTypeAccordionBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTypeAccordionBus.Location = new System.Drawing.Point(7, 99);
            this.labelTypeAccordionBus.Name = "labelTypeAccordionBus";
            this.labelTypeAccordionBus.Size = new System.Drawing.Size(155, 40);
            this.labelTypeAccordionBus.TabIndex = 1;
            this.labelTypeAccordionBus.Text = "Автобус с гармошкой";
            this.labelTypeAccordionBus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTypeAccordionBus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTypeAccordionBus_MouseDown);
            // 
            // labelTypeBus
            // 
            this.labelTypeBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTypeBus.Location = new System.Drawing.Point(6, 36);
            this.labelTypeBus.Name = "labelTypeBus";
            this.labelTypeBus.Size = new System.Drawing.Size(156, 42);
            this.labelTypeBus.TabIndex = 0;
            this.labelTypeBus.Text = "Автобус";
            this.labelTypeBus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTypeBus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTypeBus_MouseDown);
            // 
            // panelPicBox
            // 
            this.panelPicBox.AllowDrop = true;
            this.panelPicBox.BackColor = System.Drawing.SystemColors.Control;
            this.panelPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicBox.Controls.Add(this.pictureBoxPresent);
            this.panelPicBox.Location = new System.Drawing.Point(186, 44);
            this.panelPicBox.Name = "panelPicBox";
            this.panelPicBox.Size = new System.Drawing.Size(506, 123);
            this.panelPicBox.TabIndex = 3;
            this.panelPicBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPicBox_DragDrop);
            this.panelPicBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPicBox_DragEnter);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelOrange);
            this.groupBoxColor.Controls.Add(this.panelGray);
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Controls.Add(this.labelOtherColor);
            this.groupBoxColor.Controls.Add(this.labelMainColor);
            this.groupBoxColor.Location = new System.Drawing.Point(437, 178);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(239, 187);
            this.groupBoxColor.TabIndex = 4;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(174, 129);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(43, 39);
            this.panelBlue.TabIndex = 9;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(122, 129);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(44, 39);
            this.panelGreen.TabIndex = 8;
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.Location = new System.Drawing.Point(72, 129);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(44, 38);
            this.panelOrange.TabIndex = 7;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(22, 129);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(44, 39);
            this.panelGray.TabIndex = 6;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(174, 84);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(43, 39);
            this.panelWhite.TabIndex = 5;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(122, 84);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(44, 39);
            this.panelBlack.TabIndex = 4;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(72, 84);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(44, 39);
            this.panelYellow.TabIndex = 3;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(22, 84);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(44, 39);
            this.panelRed.TabIndex = 2;
            // 
            // labelOtherColor
            // 
            this.labelOtherColor.AllowDrop = true;
            this.labelOtherColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOtherColor.Location = new System.Drawing.Point(133, 28);
            this.labelOtherColor.Name = "labelOtherColor";
            this.labelOtherColor.Size = new System.Drawing.Size(95, 39);
            this.labelOtherColor.TabIndex = 1;
            this.labelOtherColor.Text = "Доп. цвет";
            this.labelOtherColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOtherColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelOtherColor_DragDrop);
            this.labelOtherColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(6, 28);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(110, 39);
            this.labelMainColor.TabIndex = 0;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(443, 381);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(97, 31);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "Добавить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancelColor
            // 
            this.buttonCancelColor.Location = new System.Drawing.Point(568, 381);
            this.buttonCancelColor.Name = "buttonCancelColor";
            this.buttonCancelColor.Size = new System.Drawing.Size(97, 31);
            this.buttonCancelColor.TabIndex = 6;
            this.buttonCancelColor.Text = "Отмена";
            this.buttonCancelColor.UseVisualStyleBackColor = true;
            // 
            // FormBusConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.buttonCancelColor);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelPicBox);
            this.Controls.Add(this.groupBoxTypeBody);
            this.Controls.Add(this.groupBoxParametrs);
            this.Name = "FormBusConfig";
            this.Text = "Выбор автобуса";
            this.groupBoxParametrs.ResumeLayout(false);
            this.groupBoxParametrs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPresent)).EndInit();
            this.groupBoxTypeBody.ResumeLayout(false);
            this.panelPicBox.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParametrs;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxBackWindows;
        private System.Windows.Forms.CheckBox checkBoxBackDoors;
        private System.Windows.Forms.CheckBox checkBoxAccordion;
        private System.Windows.Forms.PictureBox pictureBoxPresent;
        private System.Windows.Forms.GroupBox groupBoxTypeBody;
        private System.Windows.Forms.Label labelTypeAccordionBus;
        private System.Windows.Forms.Label labelTypeBus;
        private System.Windows.Forms.Panel panelPicBox;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelOtherColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancelColor;
    }
}