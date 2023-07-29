namespace Battleship
{
    partial class Difficulty
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
            this.ezBtn = new System.Windows.Forms.Button();
            this.mdBtn = new System.Windows.Forms.Button();
            this.hdBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ezBtn
            // 
            this.ezBtn.Location = new System.Drawing.Point(22, 34);
            this.ezBtn.Name = "ezBtn";
            this.ezBtn.Size = new System.Drawing.Size(284, 38);
            this.ezBtn.TabIndex = 1;
            this.ezBtn.Text = "Easy";
            this.ezBtn.UseVisualStyleBackColor = true;
            this.ezBtn.Click += new System.EventHandler(this.ezBtn_Click);
            // 
            // mdBtn
            // 
            this.mdBtn.Location = new System.Drawing.Point(22, 100);
            this.mdBtn.Name = "mdBtn";
            this.mdBtn.Size = new System.Drawing.Size(284, 38);
            this.mdBtn.TabIndex = 1;
            this.mdBtn.Text = "Medium";
            this.mdBtn.UseVisualStyleBackColor = true;
            this.mdBtn.Click += new System.EventHandler(this.mdBtn_Click);
            // 
            // hdBtn
            // 
            this.hdBtn.Location = new System.Drawing.Point(22, 171);
            this.hdBtn.Name = "hdBtn";
            this.hdBtn.Size = new System.Drawing.Size(284, 38);
            this.hdBtn.TabIndex = 1;
            this.hdBtn.Text = "Hard";
            this.hdBtn.UseVisualStyleBackColor = true;
            this.hdBtn.Click += new System.EventHandler(this.hdBtn_Click);
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 249);
            this.Controls.Add(this.hdBtn);
            this.Controls.Add(this.mdBtn);
            this.Controls.Add(this.ezBtn);
            this.Name = "Difficulty";
            this.Text = "Difficulty";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ezBtn;
        private System.Windows.Forms.Button mdBtn;
        private System.Windows.Forms.Button hdBtn;
    }
}