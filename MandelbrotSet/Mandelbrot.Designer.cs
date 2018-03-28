namespace MandelbrotSet
{
    partial class Mandelbrot
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
            this.lblMandelbrot = new System.Windows.Forms.Label();
            this.btnRender = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMandelbrot
            // 
            this.lblMandelbrot.BackColor = System.Drawing.Color.Bisque;
            this.lblMandelbrot.Font = new System.Drawing.Font("Adobe Fangsong Std R", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMandelbrot.Location = new System.Drawing.Point(12, 12);
            this.lblMandelbrot.Name = "lblMandelbrot";
            this.lblMandelbrot.Size = new System.Drawing.Size(695, 34);
            this.lblMandelbrot.TabIndex = 0;
            this.lblMandelbrot.Text = "Madelbrot Set";
            this.lblMandelbrot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMandelbrot.Click += new System.EventHandler(this.lblMandelbrot_Click);
            // 
            // btnRender
            // 
            this.btnRender.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRender.Location = new System.Drawing.Point(543, 405);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(134, 46);
            this.btnRender.TabIndex = 1;
            this.btnRender.Text = "Render";
            this.btnRender.UseVisualStyleBackColor = false;
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(30, 60);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(472, 391);
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            this.picBox.UseWaitCursor = true;
            this.picBox.WaitOnLoad = true;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // Mandelbrot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 467);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnRender);
            this.Controls.Add(this.lblMandelbrot);
            this.Name = "Mandelbrot";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMandelbrot;
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.PictureBox picBox;
    }
}

