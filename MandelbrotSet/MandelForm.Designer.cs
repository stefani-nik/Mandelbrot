﻿namespace MandelbrotSet
{
    partial class MandelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MandelForm));
            this.btnRender = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.iterationsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimerText = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRender
            // 
            this.btnRender.BackColor = System.Drawing.Color.White;
            this.btnRender.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRender.BackgroundImage")));
            this.btnRender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRender.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRender.FlatAppearance.BorderSize = 0;
            this.btnRender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRender.Location = new System.Drawing.Point(492, 376);
            this.btnRender.Margin = new System.Windows.Forms.Padding(0);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(140, 55);
            this.btnRender.TabIndex = 1;
            this.btnRender.UseVisualStyleBackColor = false;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox.BackgroundImage")));
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(28, 31);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(400, 400);
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            this.picBox.UseWaitCursor = true;
            this.picBox.WaitOnLoad = true;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // iterationsUpDown
            // 
            this.iterationsUpDown.BackColor = System.Drawing.SystemColors.MenuBar;
            this.iterationsUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iterationsUpDown.Location = new System.Drawing.Point(492, 90);
            this.iterationsUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.iterationsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterationsUpDown.Name = "iterationsUpDown";
            this.iterationsUpDown.Size = new System.Drawing.Size(140, 20);
            this.iterationsUpDown.TabIndex = 3;
            this.iterationsUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.iterationsUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(488, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of iterations";
            // 
            // lblTimerText
            // 
            this.lblTimerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimerText.Location = new System.Drawing.Point(493, 139);
            this.lblTimerText.Name = "lblTimerText";
            this.lblTimerText.Size = new System.Drawing.Size(140, 20);
            this.lblTimerText.TabIndex = 5;
            this.lblTimerText.Text = "Rendering time";
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimer.Location = new System.Drawing.Point(491, 188);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(134, 44);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.Text = "00:00:00";
            // 
            // MandelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblTimerText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iterationsUpDown);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnRender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "MandelForm";
            this.Text = "Mandelbrot";
            this.Load += new System.EventHandler(this.Mandelbrot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.NumericUpDown iterationsUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimerText;
        private System.Windows.Forms.Label lblTimer;
    }
}

