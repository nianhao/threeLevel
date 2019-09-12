namespace threeLevel
{
    partial class JLProvince
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
            this.button_JLLiaoYuan = new System.Windows.Forms.Button();
            this.button_JLSiPing = new System.Windows.Forms.Button();
            this.button_JLJiLin = new System.Windows.Forms.Button();
            this.button_JLChangChun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "---->吉林省";
            // 
            // button_JLLiaoYuan
            // 
            this.button_JLLiaoYuan.Location = new System.Drawing.Point(120, 109);
            this.button_JLLiaoYuan.Name = "button_JLLiaoYuan";
            this.button_JLLiaoYuan.Size = new System.Drawing.Size(75, 23);
            this.button_JLLiaoYuan.TabIndex = 8;
            this.button_JLLiaoYuan.Text = "辽源市";
            this.button_JLLiaoYuan.UseVisualStyleBackColor = true;
            this.button_JLLiaoYuan.Click += new System.EventHandler(this.button_JLLiaoYuan_Click);
            // 
            // button_JLSiPing
            // 
            this.button_JLSiPing.Location = new System.Drawing.Point(23, 109);
            this.button_JLSiPing.Name = "button_JLSiPing";
            this.button_JLSiPing.Size = new System.Drawing.Size(75, 23);
            this.button_JLSiPing.TabIndex = 7;
            this.button_JLSiPing.Text = "四平市";
            this.button_JLSiPing.UseVisualStyleBackColor = true;
            this.button_JLSiPing.Click += new System.EventHandler(this.button_JLSiPing_Click);
            // 
            // button_JLJiLin
            // 
            this.button_JLJiLin.Location = new System.Drawing.Point(120, 60);
            this.button_JLJiLin.Name = "button_JLJiLin";
            this.button_JLJiLin.Size = new System.Drawing.Size(75, 23);
            this.button_JLJiLin.TabIndex = 6;
            this.button_JLJiLin.Text = "吉林市";
            this.button_JLJiLin.UseVisualStyleBackColor = true;
            this.button_JLJiLin.Click += new System.EventHandler(this.button_JLJiLin_Click);
            // 
            // button_JLChangChun
            // 
            this.button_JLChangChun.Location = new System.Drawing.Point(23, 60);
            this.button_JLChangChun.Name = "button_JLChangChun";
            this.button_JLChangChun.Size = new System.Drawing.Size(75, 23);
            this.button_JLChangChun.TabIndex = 5;
            this.button_JLChangChun.Text = "长春市";
            this.button_JLChangChun.UseVisualStyleBackColor = true;
            this.button_JLChangChun.Click += new System.EventHandler(this.button_GuiYangCity_Click);
            // 
            // JLProvince
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_JLLiaoYuan);
            this.Controls.Add(this.button_JLSiPing);
            this.Controls.Add(this.button_JLJiLin);
            this.Controls.Add(this.button_JLChangChun);
            this.Name = "JLProvince";
            this.Text = "JLProvince";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_JLLiaoYuan;
        private System.Windows.Forms.Button button_JLSiPing;
        private System.Windows.Forms.Button button_JLJiLin;
        private System.Windows.Forms.Button button_JLChangChun;
    }
}