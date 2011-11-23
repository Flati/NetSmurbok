namespace TicTacToe
{
    partial class StatisticsForm
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
            this.StatisticsMessage = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatisticsMessage
            // 
            this.StatisticsMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StatisticsMessage.AutoSize = true;
            this.StatisticsMessage.Location = new System.Drawing.Point(79, 39);
            this.StatisticsMessage.Name = "StatisticsMessage";
            this.StatisticsMessage.Size = new System.Drawing.Size(44, 13);
            this.StatisticsMessage.TabIndex = 0;
            this.StatisticsMessage.Text = "Nothing";
            this.StatisticsMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(69, 132);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(145, 48);
            this.returnButton.TabIndex = 1;
            this.returnButton.Text = "Great!";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 203);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.StatisticsMessage);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatisticsMessage;
        private System.Windows.Forms.Button returnButton;
    }
}