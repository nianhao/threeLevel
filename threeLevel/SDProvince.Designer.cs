namespace threeLevel
{
    partial class SDProvince
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_YanTaiCity = new System.Windows.Forms.Button();
            this.button_ZiBoCity = new System.Windows.Forms.Button();
            this.button_QingDaoCity = new System.Windows.Forms.Button();
            this.button_JiNanCity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "---->山东省";
            // 
            // button_YanTaiCity
            // 
            this.button_YanTaiCity.Location = new System.Drawing.Point(120, 109);
            this.button_YanTaiCity.Name = "button_YanTaiCity";
            this.button_YanTaiCity.Size = new System.Drawing.Size(75, 23);
            this.button_YanTaiCity.TabIndex = 8;
            this.button_YanTaiCity.Text = "烟台市";
            this.button_YanTaiCity.UseVisualStyleBackColor = true;
            this.button_YanTaiCity.Click += new System.EventHandler(this.button_YanTaiCity_Click);
            // 
            // button_ZiBoCity
            // 
            this.button_ZiBoCity.Location = new System.Drawing.Point(23, 109);
            this.button_ZiBoCity.Name = "button_ZiBoCity";
            this.button_ZiBoCity.Size = new System.Drawing.Size(75, 23);
            this.button_ZiBoCity.TabIndex = 7;
            this.button_ZiBoCity.Text = "淄博市";
            this.button_ZiBoCity.UseVisualStyleBackColor = true;
            this.button_ZiBoCity.Click += new System.EventHandler(this.button_ZiBoCity_Click);
            // 
            // button_QingDaoCity
            // 
            this.button_QingDaoCity.Location = new System.Drawing.Point(120, 60);
            this.button_QingDaoCity.Name = "button_QingDaoCity";
            this.button_QingDaoCity.Size = new System.Drawing.Size(75, 23);
            this.button_QingDaoCity.TabIndex = 6;
            this.button_QingDaoCity.Text = "青岛市";
            this.button_QingDaoCity.UseVisualStyleBackColor = true;
            this.button_QingDaoCity.Click += new System.EventHandler(this.button_QingDaoCity_Click);
            // 
            // button_JiNanCity
            // 
            this.button_JiNanCity.Location = new System.Drawing.Point(23, 60);
            this.button_JiNanCity.Name = "button_JiNanCity";
            this.button_JiNanCity.Size = new System.Drawing.Size(75, 23);
            this.button_JiNanCity.TabIndex = 5;
            this.button_JiNanCity.Text = "济南市";
            this.button_JiNanCity.UseVisualStyleBackColor = true;
            this.button_JiNanCity.Click += new System.EventHandler(this.button_JiNanCity_Click);
            // 
            // SDProvince
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_YanTaiCity);
            this.Controls.Add(this.button_ZiBoCity);
            this.Controls.Add(this.button_QingDaoCity);
            this.Controls.Add(this.button_JiNanCity);
            this.Name = "SDProvince";
            this.Text = "山东省";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_YanTaiCity;
        private System.Windows.Forms.Button button_ZiBoCity;
        private System.Windows.Forms.Button button_QingDaoCity;
        private System.Windows.Forms.Button button_JiNanCity;
    }
}