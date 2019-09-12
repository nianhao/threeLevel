namespace threeLevel
{
    partial class GZProvince
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
            this.button_GuiYangCity = new System.Windows.Forms.Button();
            this.button_GZBiJie = new System.Windows.Forms.Button();
            this.button_GZZunYi = new System.Windows.Forms.Button();
            this.button_GZLiuPanShui = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_GuiYangCity
            // 
            this.button_GuiYangCity.Location = new System.Drawing.Point(23, 60);
            this.button_GuiYangCity.Name = "button_GuiYangCity";
            this.button_GuiYangCity.Size = new System.Drawing.Size(75, 23);
            this.button_GuiYangCity.TabIndex = 0;
            this.button_GuiYangCity.Text = "贵阳市";
            this.button_GuiYangCity.UseVisualStyleBackColor = true;
            this.button_GuiYangCity.Click += new System.EventHandler(this.GuiYangCity_Click);
            // 
            // button_GZBiJie
            // 
            this.button_GZBiJie.Location = new System.Drawing.Point(120, 60);
            this.button_GZBiJie.Name = "button_GZBiJie";
            this.button_GZBiJie.Size = new System.Drawing.Size(75, 23);
            this.button_GZBiJie.TabIndex = 1;
            this.button_GZBiJie.Text = "毕节市";
            this.button_GZBiJie.UseVisualStyleBackColor = true;
            this.button_GZBiJie.Click += new System.EventHandler(this.button_GZBiJie_Click);
            // 
            // button_GZZunYi
            // 
            this.button_GZZunYi.Location = new System.Drawing.Point(23, 109);
            this.button_GZZunYi.Name = "button_GZZunYi";
            this.button_GZZunYi.Size = new System.Drawing.Size(75, 23);
            this.button_GZZunYi.TabIndex = 2;
            this.button_GZZunYi.Text = "遵义市";
            this.button_GZZunYi.UseVisualStyleBackColor = true;
            this.button_GZZunYi.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_GZLiuPanShui
            // 
            this.button_GZLiuPanShui.Location = new System.Drawing.Point(120, 109);
            this.button_GZLiuPanShui.Name = "button_GZLiuPanShui";
            this.button_GZLiuPanShui.Size = new System.Drawing.Size(75, 23);
            this.button_GZLiuPanShui.TabIndex = 3;
            this.button_GZLiuPanShui.Text = "六盘水";
            this.button_GZLiuPanShui.UseVisualStyleBackColor = true;
            this.button_GZLiuPanShui.Click += new System.EventHandler(this.button_GZLiuPanShui_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "---->贵州省";
            // 
            // GZProvince
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_GZLiuPanShui);
            this.Controls.Add(this.button_GZZunYi);
            this.Controls.Add(this.button_GZBiJie);
            this.Controls.Add(this.button_GuiYangCity);
            this.Name = "GZProvince";
            this.Text = "贵州省";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_GuiYangCity;
        private System.Windows.Forms.Button button_GZBiJie;
        private System.Windows.Forms.Button button_GZZunYi;
        private System.Windows.Forms.Button button_GZLiuPanShui;
        private System.Windows.Forms.Label label1;
    }
}