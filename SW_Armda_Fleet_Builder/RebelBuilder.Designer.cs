﻿namespace SW_Armda_Fleet_Builder
{
    partial class RebelBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RebelBuilder));
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PointsInputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NotesBox = new System.Windows.Forms.RichTextBox();
            this.RfrshPoints = new System.Windows.Forms.Button();
            this.assaultPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addShip = new System.Windows.Forms.Button();
            this.navigationPicBox = new System.Windows.Forms.PictureBox();
            this.defencePicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.assaultPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defencePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(32, 77);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(280, 21);
            this.TitleBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // PointsInputBox
            // 
            this.PointsInputBox.Location = new System.Drawing.Point(344, 77);
            this.PointsInputBox.Name = "PointsInputBox";
            this.PointsInputBox.Size = new System.Drawing.Size(100, 21);
            this.PointsInputBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(341, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Очки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(29, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Заметки";
            // 
            // NotesBox
            // 
            this.NotesBox.Location = new System.Drawing.Point(32, 158);
            this.NotesBox.Name = "NotesBox";
            this.NotesBox.Size = new System.Drawing.Size(429, 78);
            this.NotesBox.TabIndex = 5;
            this.NotesBox.Text = "";
            // 
            // RfrshPoints
            // 
            this.RfrshPoints.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RfrshPoints.BackgroundImage")));
            this.RfrshPoints.Location = new System.Drawing.Point(450, 74);
            this.RfrshPoints.Name = "RfrshPoints";
            this.RfrshPoints.Size = new System.Drawing.Size(23, 23);
            this.RfrshPoints.TabIndex = 6;
            this.RfrshPoints.UseVisualStyleBackColor = true;
            // 
            // assaultPicBox
            // 
            this.assaultPicBox.Image = ((System.Drawing.Image)(resources.GetObject("assaultPicBox.Image")));
            this.assaultPicBox.Location = new System.Drawing.Point(32, 296);
            this.assaultPicBox.Name = "assaultPicBox";
            this.assaultPicBox.Size = new System.Drawing.Size(240, 335);
            this.assaultPicBox.TabIndex = 7;
            this.assaultPicBox.TabStop = false;
            this.assaultPicBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(809, 296);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(194, 300);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addShip);
            this.panel1.Controls.Add(this.navigationPicBox);
            this.panel1.Controls.Add(this.defencePicBox);
            this.panel1.Controls.Add(this.TitleBox);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.PointsInputBox);
            this.panel1.Controls.Add(this.RfrshPoints);
            this.panel1.Controls.Add(this.NotesBox);
            this.panel1.Controls.Add(this.assaultPicBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 3000);
            this.panel1.TabIndex = 11;
            // 
            // addShip
            // 
            this.addShip.Location = new System.Drawing.Point(32, 717);
            this.addShip.Name = "addShip";
            this.addShip.Size = new System.Drawing.Size(75, 46);
            this.addShip.TabIndex = 13;
            this.addShip.Text = "Добавить корабль";
            this.addShip.UseVisualStyleBackColor = true;
            // 
            // navigationPicBox
            // 
            this.navigationPicBox.Image = ((System.Drawing.Image)(resources.GetObject("navigationPicBox.Image")));
            this.navigationPicBox.Location = new System.Drawing.Point(547, 296);
            this.navigationPicBox.Name = "navigationPicBox";
            this.navigationPicBox.Size = new System.Drawing.Size(240, 335);
            this.navigationPicBox.TabIndex = 12;
            this.navigationPicBox.TabStop = false;
            this.navigationPicBox.Click += new System.EventHandler(this.navigationPicBox_Click);
            // 
            // defencePicBox
            // 
            this.defencePicBox.Image = ((System.Drawing.Image)(resources.GetObject("defencePicBox.Image")));
            this.defencePicBox.Location = new System.Drawing.Point(289, 296);
            this.defencePicBox.Name = "defencePicBox";
            this.defencePicBox.Size = new System.Drawing.Size(240, 335);
            this.defencePicBox.TabIndex = 12;
            this.defencePicBox.TabStop = false;
            this.defencePicBox.Click += new System.EventHandler(this.defencePicBox_Click);
            // 
            // RebelBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1051, 620);
            this.Controls.Add(this.panel1);
            this.Name = "RebelBuilder";
            this.Text = "RebelBuilder";
            ((System.ComponentModel.ISupportInitialize)(this.assaultPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defencePicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PointsInputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox NotesBox;
        private System.Windows.Forms.Button RfrshPoints;
        private System.Windows.Forms.PictureBox assaultPicBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox navigationPicBox;
        private System.Windows.Forms.PictureBox defencePicBox;
        private System.Windows.Forms.Button addShip;
    }
}