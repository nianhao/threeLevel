namespace threeLevel
{
    partial class Province
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.GZ = new System.Windows.Forms.Button();
            this.JL = new System.Windows.Forms.Button();
            this.SD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GZ
            // 
            this.GZ.Location = new System.Drawing.Point(21, 25);
            this.GZ.Name = "GZ";
            this.GZ.Size = new System.Drawing.Size(75, 23);
            this.GZ.TabIndex = 0;
            this.GZ.Text = "贵州省";
            this.GZ.UseVisualStyleBackColor = true;
            this.GZ.Click += new System.EventHandler(this.button_GZProvince_Click);
            // 
            // JL
            // 
            this.JL.Location = new System.Drawing.Point(21, 111);
            this.JL.Name = "JL";
            this.JL.Size = new System.Drawing.Size(75, 23);
            this.JL.TabIndex = 1;
            this.JL.Text = "吉林省";
            this.JL.UseVisualStyleBackColor = true;
            this.JL.Click += new System.EventHandler(this.JL_Click);
            // 
            // SD
            // 
            this.SD.Location = new System.Drawing.Point(21, 68);
            this.SD.Name = "SD";
            this.SD.Size = new System.Drawing.Size(75, 23);
            this.SD.TabIndex = 2;
            this.SD.Text = "山东省";
            this.SD.UseVisualStyleBackColor = true;
            this.SD.Click += new System.EventHandler(this.SD_Click);
            // 
            // Province
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 450);
            this.Controls.Add(this.SD);
            this.Controls.Add(this.JL);
            this.Controls.Add(this.GZ);
            this.Name = "Province";
            this.Text = "省份";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Province_FormClosing);
            this.Load += new System.EventHandler(this.Province_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GZ;
        private System.Windows.Forms.Button JL;
        private System.Windows.Forms.Button SD;
    }
}

