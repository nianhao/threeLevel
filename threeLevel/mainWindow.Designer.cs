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
            this.panel_Control = new System.Windows.Forms.Panel();
            this.lastLevel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_userName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_level = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_IP = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSelect
            // 
            this.panelSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSelect.Location = new System.Drawing.Point(155, 12);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(264, 342);
            this.panelSelect.TabIndex = 0;
            // 
            // panel_Control
            // 
            this.panel_Control.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Control.Location = new System.Drawing.Point(444, 12);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(359, 426);
            this.panel_Control.TabIndex = 1;
            // 
            // lastLevel
            // 
            this.lastLevel.Location = new System.Drawing.Point(155, 386);
            this.lastLevel.Name = "lastLevel";
            this.lastLevel.Size = new System.Drawing.Size(75, 23);
            this.lastLevel.TabIndex = 2;
            this.lastLevel.Text = "上一级";
            this.lastLevel.UseVisualStyleBackColor = true;
            this.lastLevel.Click += new System.EventHandler(this.lastLevel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::threeLevel.Properties.Resources.head;
            this.pictureBox1.Location = new System.Drawing.Point(21, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "用户名：";
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Location = new System.Drawing.Point(79, 152);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(41, 12);
            this.label_userName.TabIndex = 5;
            this.label_userName.Text = "未登录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "行政区：";
            // 
            // label_level
            // 
            this.label_level.AutoSize = true;
            this.label_level.Location = new System.Drawing.Point(81, 180);
            this.label_level.Name = "label_level";
            this.label_level.Size = new System.Drawing.Size(41, 12);
            this.label_level.TabIndex = 7;
            this.label_level.Text = "未登录";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "本机IP：";
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Location = new System.Drawing.Point(51, 231);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(47, 12);
            this.label_IP.TabIndex = 9;
            this.label_IP.Text = "0.0.0.0";
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(23, 284);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 23);
            this.button_logout.TabIndex = 10;
            this.button_logout.Text = "注销";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.label_IP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_level);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lastLevel);
            this.Controls.Add(this.panel_Control);
            this.Controls.Add(this.panelSelect);
            this.Name = "mainWindow";
            this.Text = "省市县三级带宽调度系统";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainWindow_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSelect;
        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Button lastLevel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_level;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.Button button_logout;
    }
}