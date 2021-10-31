
namespace Train_project
{
    partial class FormDepot
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
            this.pictureBoxDepot = new System.Windows.Forms.PictureBox();
            this.ButtonSetTrain = new System.Windows.Forms.Button();
            this.GroupTakeTrain = new System.Windows.Forms.GroupBox();
            this.ButtonTakeTrain = new System.Windows.Forms.Button();
            this.LabelPlace = new System.Windows.Forms.Label();
            this.maskedTextBoxPlaceNumb = new System.Windows.Forms.MaskedTextBox();
            this.LabelTakeTrain = new System.Windows.Forms.Label();
            this.LabelDepot = new System.Windows.Forms.Label();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonAddDepot = new System.Windows.Forms.Button();
            this.listBoxDepot = new System.Windows.Forms.ListBox();
            this.buttonDelDepot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).BeginInit();
            this.GroupTakeTrain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDepot
            // 
            this.pictureBoxDepot.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxDepot.Name = "pictureBoxDepot";
            this.pictureBoxDepot.Size = new System.Drawing.Size(1200, 565);
            this.pictureBoxDepot.TabIndex = 0;
            this.pictureBoxDepot.TabStop = false;
            // 
            // ButtonSetTrain
            // 
            this.ButtonSetTrain.Location = new System.Drawing.Point(1219, 346);
            this.ButtonSetTrain.Name = "ButtonSetTrain";
            this.ButtonSetTrain.Size = new System.Drawing.Size(118, 55);
            this.ButtonSetTrain.TabIndex = 1;
            this.ButtonSetTrain.Text = "Добавить поезд";
            this.ButtonSetTrain.UseVisualStyleBackColor = true;
            this.ButtonSetTrain.Click += new System.EventHandler(this.ButtonSetTrain_Click);
            // 
            // GroupTakeTrain
            // 
            this.GroupTakeTrain.Controls.Add(this.ButtonTakeTrain);
            this.GroupTakeTrain.Controls.Add(this.LabelPlace);
            this.GroupTakeTrain.Controls.Add(this.maskedTextBoxPlaceNumb);
            this.GroupTakeTrain.Controls.Add(this.LabelTakeTrain);
            this.GroupTakeTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupTakeTrain.Location = new System.Drawing.Point(1220, 407);
            this.GroupTakeTrain.Name = "GroupTakeTrain";
            this.GroupTakeTrain.Size = new System.Drawing.Size(118, 95);
            this.GroupTakeTrain.TabIndex = 3;
            this.GroupTakeTrain.TabStop = false;
            // 
            // ButtonTakeTrain
            // 
            this.ButtonTakeTrain.Location = new System.Drawing.Point(12, 66);
            this.ButtonTakeTrain.Name = "ButtonTakeTrain";
            this.ButtonTakeTrain.Size = new System.Drawing.Size(88, 23);
            this.ButtonTakeTrain.TabIndex = 7;
            this.ButtonTakeTrain.Text = "Забрать";
            this.ButtonTakeTrain.UseVisualStyleBackColor = true;
            this.ButtonTakeTrain.Click += new System.EventHandler(this.ButtonTakeTrain_Click);
            // 
            // LabelPlace
            // 
            this.LabelPlace.AutoSize = true;
            this.LabelPlace.Location = new System.Drawing.Point(9, 32);
            this.LabelPlace.Name = "LabelPlace";
            this.LabelPlace.Size = new System.Drawing.Size(53, 17);
            this.LabelPlace.TabIndex = 6;
            this.LabelPlace.Text = "Место:";
            // 
            // maskedTextBoxPlaceNumb
            // 
            this.maskedTextBoxPlaceNumb.Location = new System.Drawing.Point(68, 29);
            this.maskedTextBoxPlaceNumb.Mask = "00";
            this.maskedTextBoxPlaceNumb.Name = "maskedTextBoxPlaceNumb";
            this.maskedTextBoxPlaceNumb.Size = new System.Drawing.Size(32, 22);
            this.maskedTextBoxPlaceNumb.TabIndex = 5;
            // 
            // LabelTakeTrain
            // 
            this.LabelTakeTrain.AutoSize = true;
            this.LabelTakeTrain.Location = new System.Drawing.Point(6, -3);
            this.LabelTakeTrain.Name = "LabelTakeTrain";
            this.LabelTakeTrain.Size = new System.Drawing.Size(106, 17);
            this.LabelTakeTrain.TabIndex = 4;
            this.LabelTakeTrain.Text = "Забрать поезд";
            // 
            // LabelDepot
            // 
            this.LabelDepot.AutoSize = true;
            this.LabelDepot.Location = new System.Drawing.Point(1260, 13);
            this.LabelDepot.Name = "LabelDepot";
            this.LabelDepot.Size = new System.Drawing.Size(43, 17);
            this.LabelDepot.TabIndex = 4;
            this.LabelDepot.Text = "Депо";
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(1220, 35);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(117, 22);
            this.textBoxNewLevelName.TabIndex = 5;
            // 
            // buttonAddDepot
            // 
            this.buttonAddDepot.Location = new System.Drawing.Point(1220, 64);
            this.buttonAddDepot.Name = "buttonAddDepot";
            this.buttonAddDepot.Size = new System.Drawing.Size(117, 23);
            this.buttonAddDepot.TabIndex = 6;
            this.buttonAddDepot.Text = "Добавить депо";
            this.buttonAddDepot.UseVisualStyleBackColor = true;
            this.buttonAddDepot.Click += new System.EventHandler(this.buttonAddDepot_Click);
            // 
            // listBoxDepot
            // 
            this.listBoxDepot.FormattingEnabled = true;
            this.listBoxDepot.ItemHeight = 16;
            this.listBoxDepot.Location = new System.Drawing.Point(1220, 94);
            this.listBoxDepot.Name = "listBoxDepot";
            this.listBoxDepot.Size = new System.Drawing.Size(117, 148);
            this.listBoxDepot.TabIndex = 7;
            this.listBoxDepot.SelectedIndexChanged += new System.EventHandler(this.listBoxDepot_SelectedIndexChanged);
            // 
            // buttonDelDepot
            // 
            this.buttonDelDepot.Location = new System.Drawing.Point(1220, 249);
            this.buttonDelDepot.Name = "buttonDelDepot";
            this.buttonDelDepot.Size = new System.Drawing.Size(117, 23);
            this.buttonDelDepot.TabIndex = 8;
            this.buttonDelDepot.Text = "Удалить депо";
            this.buttonDelDepot.UseVisualStyleBackColor = true;
            this.buttonDelDepot.Click += new System.EventHandler(this.buttonDelDepot_Click);
            // 
            // FormDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 588);
            this.Controls.Add(this.buttonDelDepot);
            this.Controls.Add(this.listBoxDepot);
            this.Controls.Add(this.buttonAddDepot);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.LabelDepot);
            this.Controls.Add(this.GroupTakeTrain);
            this.Controls.Add(this.ButtonSetTrain);
            this.Controls.Add(this.pictureBoxDepot);
            this.Name = "FormDepot";
            this.Text = "Депо";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).EndInit();
            this.GroupTakeTrain.ResumeLayout(false);
            this.GroupTakeTrain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDepot;
        private System.Windows.Forms.Button ButtonSetTrain;
        private System.Windows.Forms.GroupBox GroupTakeTrain;
        private System.Windows.Forms.Button ButtonTakeTrain;
        private System.Windows.Forms.Label LabelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlaceNumb;
        private System.Windows.Forms.Label LabelTakeTrain;
        private System.Windows.Forms.Label LabelDepot;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonAddDepot;
        private System.Windows.Forms.ListBox listBoxDepot;
        private System.Windows.Forms.Button buttonDelDepot;
    }
}