namespace Battleship
{
    partial class BattleShip
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
            this.pvcBtn = new System.Windows.Forms.Button();
            this.pvpBtn = new System.Windows.Forms.Button();
            this.creditBtn = new System.Windows.Forms.Button();
            this.rulesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pvcBtn
            // 
            this.pvcBtn.Location = new System.Drawing.Point(23, 72);
            this.pvcBtn.Name = "pvcBtn";
            this.pvcBtn.Size = new System.Drawing.Size(284, 38);
            this.pvcBtn.TabIndex = 0;
            this.pvcBtn.Text = "Player vs Computer";
            this.pvcBtn.UseVisualStyleBackColor = true;
            this.pvcBtn.Click += new System.EventHandler(this.pvcBtn_Click);
            // 
            // pvpBtn
            // 
            this.pvpBtn.Location = new System.Drawing.Point(23, 14);
            this.pvpBtn.Name = "pvpBtn";
            this.pvpBtn.Size = new System.Drawing.Size(284, 38);
            this.pvpBtn.TabIndex = 0;
            this.pvpBtn.Text = "Player vs Player";
            this.pvpBtn.UseVisualStyleBackColor = true;
            this.pvpBtn.Click += new System.EventHandler(this.pvpBtn_Click);
            // 
            // creditBtn
            // 
            this.creditBtn.Location = new System.Drawing.Point(232, 135);
            this.creditBtn.Name = "creditBtn";
            this.creditBtn.Size = new System.Drawing.Size(75, 23);
            this.creditBtn.TabIndex = 1;
            this.creditBtn.Text = "Credits";
            this.creditBtn.UseVisualStyleBackColor = true;
            this.creditBtn.Click += new System.EventHandler(this.creditBtn_Click);
            // 
            // rulesBtn
            // 
            this.rulesBtn.Location = new System.Drawing.Point(23, 135);
            this.rulesBtn.Name = "rulesBtn";
            this.rulesBtn.Size = new System.Drawing.Size(75, 23);
            this.rulesBtn.TabIndex = 1;
            this.rulesBtn.Text = "Rules";
            this.rulesBtn.UseVisualStyleBackColor = true;
            this.rulesBtn.Click += new System.EventHandler(this.rulesBtn_Click);
            // 
            // BattleShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 170);
            this.Controls.Add(this.rulesBtn);
            this.Controls.Add(this.creditBtn);
            this.Controls.Add(this.pvpBtn);
            this.Controls.Add(this.pvcBtn);
            this.Name = "BattleShip";
            this.Text = "BattleShip";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pvcBtn;
        private System.Windows.Forms.Button pvpBtn;
        private System.Windows.Forms.Button creditBtn;
        private System.Windows.Forms.Button rulesBtn;

    }
}

