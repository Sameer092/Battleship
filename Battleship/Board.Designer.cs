namespace Battleship
{
    partial class SetupBoard
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
            this.horizontal = new System.Windows.Forms.RadioButton();
            this.vertical = new System.Windows.Forms.RadioButton();
            this.radioGroup = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.remaining = new System.Windows.Forms.Label();
            this.radioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // horizontal
            // 
            this.horizontal.AutoSize = true;
            this.horizontal.Checked = true;
            this.horizontal.Location = new System.Drawing.Point(18, 30);
            this.horizontal.Name = "horizontal";
            this.horizontal.Size = new System.Drawing.Size(72, 17);
            this.horizontal.TabIndex = 0;
            this.horizontal.TabStop = true;
            this.horizontal.Text = "Horizontal";
            this.horizontal.UseVisualStyleBackColor = true;
            // 
            // vertical
            // 
            this.vertical.AutoSize = true;
            this.vertical.Location = new System.Drawing.Point(18, 53);
            this.vertical.Name = "vertical";
            this.vertical.Size = new System.Drawing.Size(60, 17);
            this.vertical.TabIndex = 1;
            this.vertical.Text = "Vertical";
            this.vertical.UseVisualStyleBackColor = true;
            // 
            // radioGroup
            // 
            this.radioGroup.Controls.Add(this.vertical);
            this.radioGroup.Controls.Add(this.horizontal);
            this.radioGroup.Location = new System.Drawing.Point(497, 403);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Size = new System.Drawing.Size(110, 84);
            this.radioGroup.TabIndex = 2;
            this.radioGroup.TabStop = false;
            this.radioGroup.Text = "Shape";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(511, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 100);
            this.panel1.TabIndex = 3;
            // 
            // remaining
            // 
            this.remaining.AutoSize = true;
            this.remaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remaining.Location = new System.Drawing.Point(494, 279);
            this.remaining.Name = "remaining";
            this.remaining.Size = new System.Drawing.Size(87, 18);
            this.remaining.TabIndex = 4;
            this.remaining.Text = "Remaining";
            // 
            // SetupBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 510);
            this.Controls.Add(this.remaining);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioGroup);
            this.Name = "SetupBoard";
            this.Text = "Setup Board";
            this.radioGroup.ResumeLayout(false);
            this.radioGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton horizontal;
        private System.Windows.Forms.RadioButton vertical;
        private System.Windows.Forms.GroupBox radioGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label remaining;

    }
}