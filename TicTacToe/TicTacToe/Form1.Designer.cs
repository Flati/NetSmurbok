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
            this.Background = new System.Windows.Forms.PictureBox();
            this.BottomCenter = new System.Windows.Forms.Button();
            this.TopLeft = new System.Windows.Forms.Button();
            this.MiddleRight = new System.Windows.Forms.Button();
            this.MiddleCenter = new System.Windows.Forms.Button();
            this.TopCenter = new System.Windows.Forms.Button();
            this.TopRight = new System.Windows.Forms.Button();
            this.MiddleLeft = new System.Windows.Forms.Button();
            this.BottomLeft = new System.Windows.Forms.Button();
            this.BottomRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Image = global::TicTacToe.Properties.Resources.bord;
            this.Background.InitialImage = global::TicTacToe.Properties.Resources.bord;
            this.Background.Location = new System.Drawing.Point(-3, -8);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(450, 507);
            this.Background.TabIndex = 13;
            this.Background.TabStop = false;
            // 
            // BottomCenter
            // 
            this.BottomCenter.Image = global::TicTacToe.Properties.Resources.empty;
            this.BottomCenter.Location = new System.Drawing.Point(150, 295);
            this.BottomCenter.Name = "BottomCenter";
            this.BottomCenter.Size = new System.Drawing.Size(145, 145);
            this.BottomCenter.TabIndex = 16;
            this.BottomCenter.UseVisualStyleBackColor = true;
            this.BottomCenter.Click += new System.EventHandler(this.BottomCenter_Click);
            // 
            // TopLeft
            // 
            this.TopLeft.Image = global::TicTacToe.Properties.Resources.empty;
            this.TopLeft.Location = new System.Drawing.Point(-3, -8);
            this.TopLeft.Name = "TopLeft";
            this.TopLeft.Size = new System.Drawing.Size(145, 145);
            this.TopLeft.TabIndex = 17;
            this.TopLeft.UseVisualStyleBackColor = true;
            this.TopLeft.Click += new System.EventHandler(this.TopLeft_Click);
            // 
            // MiddleRight
            // 
            this.MiddleRight.Image = global::TicTacToe.Properties.Resources.empty;
            this.MiddleRight.Location = new System.Drawing.Point(302, 143);
            this.MiddleRight.Name = "MiddleRight";
            this.MiddleRight.Size = new System.Drawing.Size(145, 145);
            this.MiddleRight.TabIndex = 18;
            this.MiddleRight.UseVisualStyleBackColor = true;
            this.MiddleRight.Click += new System.EventHandler(this.MiddleRight_Click);
            // 
            // MiddleCenter
            // 
            this.MiddleCenter.Image = global::TicTacToe.Properties.Resources.empty;
            this.MiddleCenter.Location = new System.Drawing.Point(150, 144);
            this.MiddleCenter.Name = "MiddleCenter";
            this.MiddleCenter.Size = new System.Drawing.Size(145, 145);
            this.MiddleCenter.TabIndex = 19;
            this.MiddleCenter.UseVisualStyleBackColor = true;
            this.MiddleCenter.Click += new System.EventHandler(this.MiddleCenter_Click);
            // 
            // TopCenter
            // 
            this.TopCenter.Image = global::TicTacToe.Properties.Resources.empty;
            this.TopCenter.Location = new System.Drawing.Point(150, -7);
            this.TopCenter.Name = "TopCenter";
            this.TopCenter.Size = new System.Drawing.Size(145, 145);
            this.TopCenter.TabIndex = 20;
            this.TopCenter.UseVisualStyleBackColor = true;
            this.TopCenter.Click += new System.EventHandler(this.TopCenter_Click);
            // 
            // TopRight
            // 
            this.TopRight.Image = global::TicTacToe.Properties.Resources.empty;
            this.TopRight.Location = new System.Drawing.Point(301, -7);
            this.TopRight.Name = "TopRight";
            this.TopRight.Size = new System.Drawing.Size(145, 145);
            this.TopRight.TabIndex = 21;
            this.TopRight.UseVisualStyleBackColor = true;
            this.TopRight.Click += new System.EventHandler(this.TopRight_Click);
            // 
            // MiddleLeft
            // 
            this.MiddleLeft.Image = global::TicTacToe.Properties.Resources.empty;
            this.MiddleLeft.Location = new System.Drawing.Point(-1, 143);
            this.MiddleLeft.Name = "MiddleLeft";
            this.MiddleLeft.Size = new System.Drawing.Size(145, 145);
            this.MiddleLeft.TabIndex = 22;
            this.MiddleLeft.UseVisualStyleBackColor = true;
            this.MiddleLeft.Click += new System.EventHandler(this.MiddleLeft_Click);
            // 
            // BottomLeft
            // 
            this.BottomLeft.Image = global::TicTacToe.Properties.Resources.empty;
            this.BottomLeft.Location = new System.Drawing.Point(-1, 295);
            this.BottomLeft.Name = "BottomLeft";
            this.BottomLeft.Size = new System.Drawing.Size(145, 145);
            this.BottomLeft.TabIndex = 23;
            this.BottomLeft.UseVisualStyleBackColor = true;
            this.BottomLeft.Click += new System.EventHandler(this.BottomLeft_Click);
            // 
            // BottomRight
            // 
            this.BottomRight.Image = global::TicTacToe.Properties.Resources.empty;
            this.BottomRight.Location = new System.Drawing.Point(302, 295);
            this.BottomRight.Name = "BottomRight";
            this.BottomRight.Size = new System.Drawing.Size(145, 145);
            this.BottomRight.TabIndex = 24;
            this.BottomRight.UseVisualStyleBackColor = true;
            this.BottomRight.Click += new System.EventHandler(this.BottomRight_Click);
            // 
            // TicTacToeApplicationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 432);
            this.Controls.Add(this.BottomRight);
            this.Controls.Add(this.BottomLeft);
            this.Controls.Add(this.MiddleLeft);
            this.Controls.Add(this.TopRight);
            this.Controls.Add(this.TopCenter);
            this.Controls.Add(this.MiddleCenter);
            this.Controls.Add(this.MiddleRight);
            this.Controls.Add(this.TopLeft);
            this.Controls.Add(this.BottomCenter);
            this.Controls.Add(this.Background);
            this.MaximumSize = new System.Drawing.Size(460, 470);
            this.MinimumSize = new System.Drawing.Size(460, 470);
            this.Name = "TicTacToeApplicationWindow";
            this.Text = "TicTacToe by !UsualSuspects";
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.Button BottomCenter;
        private System.Windows.Forms.Button TopLeft;
        private System.Windows.Forms.Button MiddleRight;
        private System.Windows.Forms.Button MiddleCenter;
        private System.Windows.Forms.Button TopCenter;
        private System.Windows.Forms.Button TopRight;
        private System.Windows.Forms.Button MiddleLeft;
        private System.Windows.Forms.Button BottomLeft;
        private System.Windows.Forms.Button BottomRight;
    }
}

