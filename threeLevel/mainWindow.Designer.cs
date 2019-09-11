namespace threeLevel
{
    partial class mainWindow
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
            this.panelSelect = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lastLevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelSelect
            // 
            this.panelSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSelect.Location = new System.Drawing.Point(13, 12);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(264, 342);
            this.panelSelect.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(340, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 426);
            this.panel2.TabIndex = 1;
            // 
            // lastLevel
            // 
            this.lastLevel.Location = new System.Drawing.Point(27, 381);
            this.lastLevel.Name = "lastLevel";
            this.lastLevel.Size = new System.Drawing.Size(75, 23);
            this.lastLevel.TabIndex = 2;
            this.lastLevel.Text = "上一级";
            this.lastLevel.UseVisualStyleBackColor = true;
            this.lastLevel.Click += new System.EventHandler(this.lastLevel_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lastLevel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSelect);
            this.Name = "mainWindow";
            this.Text = "省市县三级带宽调度系统";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSelect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button lastLevel;
    }
}