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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimerText = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.posXUpDown = new System.Windows.Forms.NumericUpDown();
            this.posYUpDown = new System.Windows.Forms.NumericUpDown();
            this.dXUpDown = new System.Windows.Forms.NumericUpDown();
            this.dYUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblPosX = new System.Windows.Forms.Label();
            this.lblPosY = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dXUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dYUpDown)).BeginInit();
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
            this.picBox.Location = new System.Drawing.Point(28, 31);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(400, 400);
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            this.picBox.WaitOnLoad = true;
            // 
            // iterationsUpDown
            // 
            this.iterationsUpDown.BackColor = System.Drawing.SystemColors.MenuBar;
            this.iterationsUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iterationsUpDown.Location = new System.Drawing.Point(492, 71);
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
            128,
            0,
            0,
            0});
            this.iterationsUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(488, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of iterations";
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
            // posXUpDown
            // 
            this.posXUpDown.Location = new System.Drawing.Point(575, 123);
            this.posXUpDown.Name = "posXUpDown";
            this.posXUpDown.Size = new System.Drawing.Size(50, 20);
            this.posXUpDown.TabIndex = 7;
            // 
            // posYUpDown
            // 
            this.posYUpDown.Location = new System.Drawing.Point(575, 171);
            this.posYUpDown.Name = "posYUpDown";
            this.posYUpDown.Size = new System.Drawing.Size(50, 20);
            this.posYUpDown.TabIndex = 8;
            // 
            // dXUpDown
            // 
            this.dXUpDown.Location = new System.Drawing.Point(575, 214);
            this.dXUpDown.Name = "dXUpDown";
            this.dXUpDown.Size = new System.Drawing.Size(50, 20);
            this.dXUpDown.TabIndex = 9;
            // 
            // dYUpDown
            // 
            this.dYUpDown.Location = new System.Drawing.Point(575, 264);
            this.dYUpDown.Name = "dYUpDown";
            this.dYUpDown.Size = new System.Drawing.Size(50, 20);
            this.dYUpDown.TabIndex = 10;
            // 
            // lblPosX
            // 
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
            this.lblPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPosY.Location = new System.Drawing.Point(488, 171);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(80, 20);
            this.lblPosY.TabIndex = 12;
            this.lblPosY.Text = "Position Y";
            this.lblPosY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(488, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "DX";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(488, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "DY";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MandelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPosY);
            this.Controls.Add(this.lblPosX);
            this.Controls.Add(this.dYUpDown);
            this.Controls.Add(this.dXUpDown);
            this.Controls.Add(this.posYUpDown);
            this.Controls.Add(this.posXUpDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dXUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dYUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.NumericUpDown iterationsUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimerText;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.NumericUpDown posXUpDown;
        private System.Windows.Forms.NumericUpDown posYUpDown;
        private System.Windows.Forms.NumericUpDown dXUpDown;
        private System.Windows.Forms.NumericUpDown dYUpDown;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.Label lblPosY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

