namespace MandebrotTest1
{
    partial class Mandelbrot
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CaontainerPanel = new System.Windows.Forms.Panel();
            this.ZoomInButton = new System.Windows.Forms.Button();
            this.ZoomOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CaontainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2160, 2160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CaontainerPanel
            // 
            this.CaontainerPanel.AutoScroll = true;
            this.CaontainerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CaontainerPanel.Controls.Add(this.pictureBox1);
            this.CaontainerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaontainerPanel.Location = new System.Drawing.Point(0, 0);
            this.CaontainerPanel.Name = "CaontainerPanel";
            this.CaontainerPanel.Size = new System.Drawing.Size(1312, 621);
            this.CaontainerPanel.TabIndex = 1;
            // 
            // ZoomInButton
            // 
            this.ZoomInButton.Location = new System.Drawing.Point(12, 627);
            this.ZoomInButton.Name = "ZoomInButton";
            this.ZoomInButton.Size = new System.Drawing.Size(467, 58);
            this.ZoomInButton.TabIndex = 2;
            this.ZoomInButton.Text = "Zoom in";
            this.ZoomInButton.UseVisualStyleBackColor = true;
            this.ZoomInButton.Click += new System.EventHandler(this.ZoomInButton_Click);
            // 
            // ZoomOutButton
            // 
            this.ZoomOutButton.Location = new System.Drawing.Point(833, 627);
            this.ZoomOutButton.Name = "ZoomOutButton";
            this.ZoomOutButton.Size = new System.Drawing.Size(467, 58);
            this.ZoomOutButton.TabIndex = 3;
            this.ZoomOutButton.Text = "Zoom out";
            this.ZoomOutButton.UseVisualStyleBackColor = true;
            this.ZoomOutButton.Click += new System.EventHandler(this.ZoomOutButton_Click);
            // 
            // Mandelbrot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 691);
            this.Controls.Add(this.ZoomOutButton);
            this.Controls.Add(this.ZoomInButton);
            this.Controls.Add(this.CaontainerPanel);
            this.Name = "Mandelbrot";
            this.ShowIcon = false;
            this.Text = "Mandelbrot Set";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CaontainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel CaontainerPanel;
        private Button ZoomInButton;
        private Button ZoomOutButton;
    }
}