using MandelbrotSet.Common;

namespace MandelbrotSet
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
            this.lblNumIterations = new System.Windows.Forms.Label();
            this.lblTimerText = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblPosX = new System.Windows.Forms.Label();
            this.lblPosY = new System.Windows.Forms.Label();
            this.lblDx = new System.Windows.Forms.Label();
            this.lblDy = new System.Windows.Forms.Label();
            this.txtBoxPosX = new System.Windows.Forms.TextBox();
            this.txtBoxPosY = new System.Windows.Forms.TextBox();
            this.txtBoxDx = new System.Windows.Forms.TextBox();
            this.txtBoxDy = new System.Windows.Forms.TextBox();
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
            this.picBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picBox.Location = new System.Drawing.Point(30, 30);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(400, 400);
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            this.picBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseDown);
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            this.picBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseUp);
            // 
            // iterationsUpDown
            // 
            this.iterationsUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.iterationsUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iterationsUpDown.Location = new System.Drawing.Point(484, 71);
            this.iterationsUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.iterationsUpDown.Name = "iterationsUpDown";
            this.iterationsUpDown.Size = new System.Drawing.Size(174, 20);
            this.iterationsUpDown.TabIndex = 3;
            this.iterationsUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // lblNumIterations
            // 
            this.lblNumIterations.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblNumIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumIterations.Location = new System.Drawing.Point(488, 31);
            this.lblNumIterations.Name = "lblNumIterations";
            this.lblNumIterations.Size = new System.Drawing.Size(170, 20);
            this.lblNumIterations.TabIndex = 4;
            this.lblNumIterations.Text = "Number of iterations";
            // 
            // lblTimerText
            // 
            this.lblTimerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimerText.Location = new System.Drawing.Point(493, 300);
            this.lblTimerText.Name = "lblTimerText";
            this.lblTimerText.Size = new System.Drawing.Size(140, 20);
            this.lblTimerText.TabIndex = 5;
            this.lblTimerText.Text = "Rendering time";
            this.lblTimerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimer.Location = new System.Drawing.Point(491, 320);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(134, 44);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.Text = "00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPosX
            // 
            this.lblPosX.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPosX.Location = new System.Drawing.Point(488, 123);
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(80, 20);
            this.lblPosX.TabIndex = 11;
            this.lblPosX.Text = "Position X";
            this.lblPosX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPosY
            // 
            this.lblPosY.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPosY.Location = new System.Drawing.Point(488, 171);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(80, 20);
            this.lblPosY.TabIndex = 12;
            this.lblPosY.Text = "Position Y";
            this.lblPosY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDx
            // 
            this.lblDx.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDx.Location = new System.Drawing.Point(488, 214);
            this.lblDx.Name = "lblDx";
            this.lblDx.Size = new System.Drawing.Size(80, 20);
            this.lblDx.TabIndex = 13;
            this.lblDx.Text = "From";
            this.lblDx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDy
            // 
            this.lblDy.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDy.Location = new System.Drawing.Point(488, 264);
            this.lblDy.Name = "lblDy";
            this.lblDy.Size = new System.Drawing.Size(80, 20);
            this.lblDy.TabIndex = 14;
            this.lblDy.Text = "To";
            this.lblDy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxPosX
            // 
            this.txtBoxPosX.Enabled = false;
            this.txtBoxPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPosX.Location = new System.Drawing.Point(575, 123);
            this.txtBoxPosX.Name = "txtBoxPosX";
            this.txtBoxPosX.Size = new System.Drawing.Size(56, 20);
            this.txtBoxPosX.TabIndex = 15;
            this.txtBoxPosX.Text = "0.0";
            // 
            // txtBoxPosY
            // 
            this.txtBoxPosY.Enabled = false;
            this.txtBoxPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPosY.Location = new System.Drawing.Point(575, 173);
            this.txtBoxPosY.Name = "txtBoxPosY";
            this.txtBoxPosY.Size = new System.Drawing.Size(56, 20);
            this.txtBoxPosY.TabIndex = 16;
            this.txtBoxPosY.Text = "0.0";
            // 
            // txtBoxDx
            // 
            this.txtBoxDx.Enabled = false;
            this.txtBoxDx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxDx.Location = new System.Drawing.Point(575, 216);
            this.txtBoxDx.Name = "txtBoxDx";
            this.txtBoxDx.Size = new System.Drawing.Size(56, 20);
            this.txtBoxDx.TabIndex = 17;
            this.txtBoxDx.Text = "-2.0";
            // 
            // txtBoxDy
            // 
            this.txtBoxDy.Enabled = false;
            this.txtBoxDy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxDy.Location = new System.Drawing.Point(575, 264);
            this.txtBoxDy.Name = "txtBoxDy";
            this.txtBoxDy.Size = new System.Drawing.Size(56, 20);
            this.txtBoxDy.TabIndex = 18;
            this.txtBoxDy.Text = "2.0";
            // 
            // MandelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.txtBoxDy);
            this.Controls.Add(this.txtBoxDx);
            this.Controls.Add(this.txtBoxPosY);
            this.Controls.Add(this.txtBoxPosX);
            this.Controls.Add(this.lblDy);
            this.Controls.Add(this.lblDx);
            this.Controls.Add(this.lblPosY);
            this.Controls.Add(this.lblPosX);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblTimerText);
            this.Controls.Add(this.lblNumIterations);
            this.Controls.Add(this.iterationsUpDown);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnRender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "MandelForm";
            this.Text = "Mandelbrot";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.NumericUpDown iterationsUpDown;
        private System.Windows.Forms.Label lblNumIterations;
        private System.Windows.Forms.Label lblTimerText;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.Label lblPosY;
        private System.Windows.Forms.Label lblDx;
        private System.Windows.Forms.Label lblDy;
        private System.Windows.Forms.TextBox txtBoxPosX;
        private System.Windows.Forms.TextBox txtBoxPosY;
        private System.Windows.Forms.TextBox txtBoxDx;
        private System.Windows.Forms.TextBox txtBoxDy;
    }
}

