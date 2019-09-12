using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace threeLevel
{
    
    public partial class mainWindow : Form
    {
        private Form nowLevel=null;
        public mainWindow()
        {
            InitializeComponent();
            Province p = new Province();
            panelSelectAddForm(p);
        }
        /// <summary>
        /// 向左边的panel上添加form
        /// </summary>
        /// <param name="form"></param>
        public  void panelSelectAddForm(Form form,int level =-1)
        {
            if(level==-1)
            {
                if (nowLevel == null)
                {
                    nowLevel = form;
                }
                else
                {
                    try
                    {
                        //最开始的时候或者某个时刻，栈被清空，会报错
                        if (nowLevel != Program.tlevelsForm.Peek())
                        {
                            Program.tlevelsForm.Push(nowLevel);
                            nowLevel = form;
                        }
                    }
                    catch (Exception ee)
                    {
                        Program.tlevelsForm.Push(nowLevel);
                        nowLevel = form;
                        Logger.logWrite(ee.Message);
                        //throw;
                    }

                    
                }
            }
            else
            {
                nowLevel = form;
                this.panel_Control.Controls.Clear();
            }

            //清空之前的panel
            this.panelSelect.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //设置窗体为非边框样式
            form.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel
            this.panelSelect.Controls.Add(form);        //添加窗体
            form.Show();
        }
        /// <summary>
        /// 向右边的panel上添加form
        /// </summary>
        /// <param name="form"></param>
        public void panel_ControlAddForm(Form form, int level = -1)
        {
            //清空之前的panel
            this.panel_Control.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //设置窗体为非边框样式
            form.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel
            this.panel_Control.Controls.Add(form);        //添加窗体
            form.Show();
        }
        private void lastLevel_Click(object sender, EventArgs e)
        {
            try
            {
                Form lastForm = Program.tlevelsForm.Pop();
                this.panelSelectAddForm(lastForm,1);
            }
            catch (Exception se)
            {
                Logger.logWrite(se.Message);
                
            }
            

        }
    }
}
