namespace Battleship
{
    partial class Game
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
            this.switchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // switchBtn
            // 
            this.switchBtn.Location = new System.Drawing.Point(413, 508);
            this.switchBtn.Name = "switchBtn";
            this.switchBtn.Size = new System.Drawing.Size(80, 31);
            this.switchBtn.TabIndex = 0;
            this.switchBtn.Text = "Switch";
            this.switchBtn.UseVisualStyleBackColor = true;
            this.switchBtn.Visible = false;
            this.switchBtn.Click += new System.EventHandler(this.switchBtn_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 551);
            this.Controls.Add(this.switchBtn);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button switchBtn;
    }
}