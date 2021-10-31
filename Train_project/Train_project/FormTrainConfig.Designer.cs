
namespace Train_project
{
    partial class FormTrainConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelElTrain = new System.Windows.Forms.Label();
            this.labelTrain = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxBattery = new System.Windows.Forms.CheckBox();
            this.checkBoxCollector = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxTrain = new System.Windows.Forms.PictureBox();
            this.panelTrain = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelLightBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseUpColor = new System.Windows.Forms.Label();
            this.labelBaseDownColor = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrain)).BeginInit();
            this.panelTrain.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelElTrain);
            this.groupBox1.Controls.Add(this.labelTrain);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип поезда";
            // 
            // labelElTrain
            // 
            this.labelElTrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelElTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelElTrain.Location = new System.Drawing.Point(15, 86);
            this.labelElTrain.Name = "labelElTrain";
            this.labelElTrain.Size = new System.Drawing.Size(120, 40);
            this.labelElTrain.TabIndex = 2;
            this.labelElTrain.Text = "Электровоз";
            this.labelElTrain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelElTrain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelElTrain_MouseDown);
            // 
            // labelTrain
            // 
            this.labelTrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrain.Location = new System.Drawing.Point(15, 28);
            this.labelTrain.Name = "labelTrain";
            this.labelTrain.Size = new System.Drawing.Size(120, 40);
            this.labelTrain.TabIndex = 1;
            this.labelTrain.Text = "Тепловоз";
            this.labelTrain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTrain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTrain_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxBattery);
            this.groupBox2.Controls.Add(this.checkBoxCollector);
            this.groupBox2.Controls.Add(this.numericUpDownWeight);
            this.groupBox2.Controls.Add(this.numericUpDownSpeed);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры";
            // 
            // checkBoxBattery
            // 
            this.checkBoxBattery.AutoSize = true;
            this.checkBoxBattery.Location = new System.Drawing.Point(192, 67);
            this.checkBoxBattery.Name = "checkBoxBattery";
            this.checkBoxBattery.Size = new System.Drawing.Size(115, 21);
            this.checkBoxBattery.TabIndex = 5;
            this.checkBoxBattery.Text = "Аккумулятор";
            this.checkBoxBattery.UseVisualStyleBackColor = true;
            // 
            // checkBoxCollector
            // 
            this.checkBoxCollector.AutoSize = true;
            this.checkBoxCollector.Location = new System.Drawing.Point(192, 40);
            this.checkBoxCollector.Name = "checkBoxCollector";
            this.checkBoxCollector.Size = new System.Drawing.Size(126, 21);
            this.checkBoxCollector.TabIndex = 4;
            this.checkBoxCollector.Text = "Токоприёмник";
            this.checkBoxCollector.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(91, 87);
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
            this.numericUpDownWeight.Size = new System.Drawing.Size(60, 22);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(91, 42);
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
            this.numericUpDownSpeed.Size = new System.Drawing.Size(60, 22);
            this.numericUpDownSpeed.TabIndex = 2;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Вес поезда:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Макс. скорость:";
            // 
            // pictureBoxTrain
            // 
            this.pictureBoxTrain.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxTrain.Name = "pictureBoxTrain";
            this.pictureBoxTrain.Size = new System.Drawing.Size(287, 155);
            this.pictureBoxTrain.TabIndex = 2;
            this.pictureBoxTrain.TabStop = false;
            // 
            // panelTrain
            // 
            this.panelTrain.AllowDrop = true;
            this.panelTrain.Controls.Add(this.pictureBoxTrain);
            this.panelTrain.Location = new System.Drawing.Point(170, 12);
            this.panelTrain.Name = "panelTrain";
            this.panelTrain.Size = new System.Drawing.Size(293, 161);
            this.panelTrain.TabIndex = 4;
            this.panelTrain.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTrain_DragDrop);
            this.panelTrain.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTrain_DragEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panelPurple);
            this.groupBox3.Controls.Add(this.panelBlack);
            this.groupBox3.Controls.Add(this.panelBlue);
            this.groupBox3.Controls.Add(this.panelLightBlue);
            this.groupBox3.Controls.Add(this.panelGreen);
            this.groupBox3.Controls.Add(this.panelYellow);
            this.groupBox3.Controls.Add(this.panelOrange);
            this.groupBox3.Controls.Add(this.panelRed);
            this.groupBox3.Controls.Add(this.labelDopColor);
            this.groupBox3.Controls.Add(this.labelBaseUpColor);
            this.groupBox3.Controls.Add(this.labelBaseDownColor);
            this.groupBox3.Location = new System.Drawing.Point(478, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 158);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Цвета";
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelPurple.Location = new System.Drawing.Point(303, 95);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(41, 40);
            this.panelPurple.TabIndex = 6;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(352, 95);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(41, 40);
            this.panelBlack.TabIndex = 6;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(256, 95);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(41, 40);
            this.panelBlue.TabIndex = 9;
            // 
            // panelLightBlue
            // 
            this.panelLightBlue.BackColor = System.Drawing.Color.Aqua;
            this.panelLightBlue.Location = new System.Drawing.Point(209, 95);
            this.panelLightBlue.Name = "panelLightBlue";
            this.panelLightBlue.Size = new System.Drawing.Size(41, 40);
            this.panelLightBlue.TabIndex = 8;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Location = new System.Drawing.Point(162, 95);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(41, 40);
            this.panelGreen.TabIndex = 6;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(115, 95);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(41, 40);
            this.panelYellow.TabIndex = 7;
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.Location = new System.Drawing.Point(68, 95);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(41, 40);
            this.panelOrange.TabIndex = 6;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(21, 95);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(41, 40);
            this.panelRed.TabIndex = 5;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDopColor.Location = new System.Drawing.Point(273, 25);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(120, 50);
            this.labelDopColor.TabIndex = 4;
            this.labelDopColor.Text = "Цвет доп. деталей";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
            // 
            // labelBaseUpColor
            // 
            this.labelBaseUpColor.AllowDrop = true;
            this.labelBaseUpColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseUpColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBaseUpColor.Location = new System.Drawing.Point(147, 25);
            this.labelBaseUpColor.Name = "labelBaseUpColor";
            this.labelBaseUpColor.Size = new System.Drawing.Size(120, 50);
            this.labelBaseUpColor.TabIndex = 3;
            this.labelBaseUpColor.Text = "Цвет верхнего кузова";
            this.labelBaseUpColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseUpColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseUpColor_DragDrop);
            this.labelBaseUpColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseUpColor_DragEnter);
            // 
            // labelBaseDownColor
            // 
            this.labelBaseDownColor.AllowDrop = true;
            this.labelBaseDownColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseDownColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBaseDownColor.Location = new System.Drawing.Point(21, 25);
            this.labelBaseDownColor.Name = "labelBaseDownColor";
            this.labelBaseDownColor.Size = new System.Drawing.Size(120, 50);
            this.labelBaseDownColor.TabIndex = 2;
            this.labelBaseDownColor.Text = "Цвет нижнего кузова";
            this.labelBaseDownColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseDownColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseDownColor_DragDrop);
            this.labelBaseDownColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseDownColor_DragEnter);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(713, 218);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(93, 33);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(812, 218);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 33);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormTrainConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 292);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.panelTrain);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTrainConfig";
            this.Text = "Выбор поезда";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrain)).EndInit();
            this.panelTrain.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelElTrain;
        private System.Windows.Forms.Label labelTrain;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxBattery;
        private System.Windows.Forms.CheckBox checkBoxCollector;
        private System.Windows.Forms.PictureBox pictureBoxTrain;
        private System.Windows.Forms.Panel panelTrain;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panelPurple;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelLightBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseUpColor;
        private System.Windows.Forms.Label labelBaseDownColor;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}