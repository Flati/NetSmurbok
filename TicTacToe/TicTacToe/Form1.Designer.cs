namespace TicTacToe
{
    partial class TicTacToeApplicationWindow
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picHorizontalLine = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TopLeft = new System.Windows.Forms.Label();
            this.TopCenter = new System.Windows.Forms.Label();
            this.TopRight = new System.Windows.Forms.Label();
            this.MiddleLeft = new System.Windows.Forms.Label();
            this.MiddleCenter = new System.Windows.Forms.Label();
            this.MiddleRight = new System.Windows.Forms.Label();
            this.BottomLeft = new System.Windows.Forms.Label();
            this.BottomCenter = new System.Windows.Forms.Label();
            this.BottomRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHorizontalLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TicTacToe.Properties.Resources.vertical;
            this.pictureBox2.Location = new System.Drawing.Point(116, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 294);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicTacToe.Properties.Resources.horizontal;
            this.pictureBox1.Location = new System.Drawing.Point(13, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // picHorizontalLine
            // 
            this.picHorizontalLine.Image = global::TicTacToe.Properties.Resources.horizontal;
            this.picHorizontalLine.Location = new System.Drawing.Point(13, 101);
            this.picHorizontalLine.Name = "picHorizontalLine";
            this.picHorizontalLine.Size = new System.Drawing.Size(341, 10);
            this.picHorizontalLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHorizontalLine.TabIndex = 0;
            this.picHorizontalLine.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TicTacToe.Properties.Resources.vertical;
            this.pictureBox3.Location = new System.Drawing.Point(247, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 294);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // TopLeft
            // 
            this.TopLeft.AutoSize = true;
            this.TopLeft.Location = new System.Drawing.Point(44, 51);
            this.TopLeft.Name = "TopLeft";
            this.TopLeft.Size = new System.Drawing.Size(37, 13);
            this.TopLeft.TabIndex = 4;
            this.TopLeft.Text = "Select";
            this.TopLeft.Click += new System.EventHandler(this.TopLeft_Click);
            // 
            // TopCenter
            // 
            this.TopCenter.AutoSize = true;
            this.TopCenter.Location = new System.Drawing.Point(170, 51);
            this.TopCenter.Name = "TopCenter";
            this.TopCenter.Size = new System.Drawing.Size(37, 13);
            this.TopCenter.TabIndex = 5;
            this.TopCenter.Text = "Select";
            this.TopCenter.Click += new System.EventHandler(this.TopCenter_Click);
            // 
            // TopRight
            // 
            this.TopRight.AutoSize = true;
            this.TopRight.Location = new System.Drawing.Point(292, 51);
            this.TopRight.Name = "TopRight";
            this.TopRight.Size = new System.Drawing.Size(37, 13);
            this.TopRight.TabIndex = 6;
            this.TopRight.Text = "Select";
            this.TopRight.Click += new System.EventHandler(this.TopRight_Click);
            // 
            // MiddleLeft
            // 
            this.MiddleLeft.AutoSize = true;
            this.MiddleLeft.Location = new System.Drawing.Point(47, 158);
            this.MiddleLeft.Name = "MiddleLeft";
            this.MiddleLeft.Size = new System.Drawing.Size(37, 13);
            this.MiddleLeft.TabIndex = 7;
            this.MiddleLeft.Text = "Select";
            this.MiddleLeft.Click += new System.EventHandler(this.MiddleLeft_Click);
            // 
            // MiddleCenter
            // 
            this.MiddleCenter.AutoSize = true;
            this.MiddleCenter.Location = new System.Drawing.Point(173, 158);
            this.MiddleCenter.Name = "MiddleCenter";
            this.MiddleCenter.Size = new System.Drawing.Size(37, 13);
            this.MiddleCenter.TabIndex = 8;
            this.MiddleCenter.Text = "Select";
            this.MiddleCenter.Click += new System.EventHandler(this.MiddleCenter_Click);
            // 
            // MiddleRight
            // 
            this.MiddleRight.AutoSize = true;
            this.MiddleRight.Location = new System.Drawing.Point(295, 157);
            this.MiddleRight.Name = "MiddleRight";
            this.MiddleRight.Size = new System.Drawing.Size(37, 13);
            this.MiddleRight.TabIndex = 9;
            this.MiddleRight.Text = "Select";
            this.MiddleRight.Click += new System.EventHandler(this.MiddleRight_Click);
            // 
            // BottomLeft
            // 
            this.BottomLeft.AutoSize = true;
            this.BottomLeft.Location = new System.Drawing.Point(47, 259);
            this.BottomLeft.Name = "BottomLeft";
            this.BottomLeft.Size = new System.Drawing.Size(37, 13);
            this.BottomLeft.TabIndex = 10;
            this.BottomLeft.Text = "Select";
            this.BottomLeft.Click += new System.EventHandler(this.BottomLeft_Click);
            // 
            // BottomCenter
            // 
            this.BottomCenter.AutoSize = true;
            this.BottomCenter.Location = new System.Drawing.Point(173, 259);
            this.BottomCenter.Name = "BottomCenter";
            this.BottomCenter.Size = new System.Drawing.Size(37, 13);
            this.BottomCenter.TabIndex = 11;
            this.BottomCenter.Text = "Select";
            this.BottomCenter.Click += new System.EventHandler(this.BottomCenter_Click);
            // 
            // BottomRight
            // 
            this.BottomRight.AutoSize = true;
            this.BottomRight.Location = new System.Drawing.Point(295, 259);
            this.BottomRight.Name = "BottomRight";
            this.BottomRight.Size = new System.Drawing.Size(37, 13);
            this.BottomRight.TabIndex = 12;
            this.BottomRight.Text = "Select";
            this.BottomRight.Click += new System.EventHandler(this.BottomRight_Click);
            // 
            // TicTacToeApplicationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 334);
            this.Controls.Add(this.BottomRight);
            this.Controls.Add(this.BottomCenter);
            this.Controls.Add(this.BottomLeft);
            this.Controls.Add(this.MiddleRight);
            this.Controls.Add(this.MiddleCenter);
            this.Controls.Add(this.MiddleLeft);
            this.Controls.Add(this.TopRight);
            this.Controls.Add(this.TopCenter);
            this.Controls.Add(this.TopLeft);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picHorizontalLine);
            this.MaximumSize = new System.Drawing.Size(380, 372);
            this.MinimumSize = new System.Drawing.Size(380, 372);
            this.Name = "TicTacToeApplicationWindow";
            this.Text = "TicTacToe by !UsualSuspects";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHorizontalLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHorizontalLine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label TopLeft;
        private System.Windows.Forms.Label TopCenter;
        private System.Windows.Forms.Label TopRight;
        private System.Windows.Forms.Label MiddleLeft;
        private System.Windows.Forms.Label MiddleCenter;
        private System.Windows.Forms.Label MiddleRight;
        private System.Windows.Forms.Label BottomLeft;
        private System.Windows.Forms.Label BottomCenter;
        private System.Windows.Forms.Label BottomRight;
    }
}

