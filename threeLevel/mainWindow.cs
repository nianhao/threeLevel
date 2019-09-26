using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using threeLevel.DAO;

namespace threeLevel
{
    public delegate void GlobalMouseClickEventHander(object sender, MouseEventArgs e);
    public partial class mainWindow : Form
    {
        private Form nowLevel = null;
        public USER user = new USER();
        /// <summary>
        /// 设置label的委托
        /// </summary>
        /// <param name="labelT"></param>
        /// <param name="text"></param>
        private delegate void setTextDelegate(Label labelT, string text);
        /// <summary>
        /// 全局变量，触发后设置label的值
        /// </summary>
        private setTextDelegate setLabelTextCallBack;
        /// <summary>
        /// 设置向panel中添加From的委托
        /// </summary>
        /// <param name="form"></param>
        /// <param name="level"></param>
        private delegate void addFromDelegate(Form form, int level);
        /// <summary>
        /// 在panel中添加界面的触发函数
        /// </summary>
        private addFromDelegate panelSelect_addFormCallBack;
        private addFromDelegate panelControl_addFormCallBack;
        public mainWindow()
        {
            InitializeComponent();
            //Province p = new Province();
           // panelSelectAddForm(p);
            //绑定label的Text值修改的函数
            setLabelTextCallBack = new setTextDelegate(setlabelText);
            //绑定在panel中添加Form的函数
            panelSelect_addFormCallBack = new addFromDelegate(panelSelectAddForm);
            panelControl_addFormCallBack = new addFromDelegate(panel_ControlAddForm);
        }
        private void setlabelText(Label labelT,string text)
        {
            labelT.Text = text;
        }
        /// <summary>
        /// 向左边的panel上添加form
        /// level=-1 是向下一行政级进，需要保存上一个form用于后退
        /// </summary>
        /// <param name="form"></param>
        public void panelSelectAddForm(Form form, int level = -1)
        {
            if (level == -1)
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

            //清空之前的panel,并且把form添加上去
            this.panelSelect.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //设置窗体为非边框样式
            form.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel
            this.panelSelect.Controls.Add(form);        //添加窗体
            form.Show();
        }
        /// <summary>
        /// 登录成功后，设置登录用户信息，并且跳转到对应的行政等级
        /// </summary>
        /// <param name="table_users"></param>
        internal void setUSER(Table_users table_users)
        {
            //throw new NotImplementedException();
            user.setFromTableItem(table_users);
            //在界面设置用户信息
            this.label_userName.Invoke(setLabelTextCallBack, this.label_userName, user.UserName);
            this.label_level.Invoke(setLabelTextCallBack,this.label_level, user.Level);
            this.label_IP.Invoke(setLabelTextCallBack,this.label_IP, user.Ip);
            //因为是其他线程中新建的窗体，所以要用委托来跳转
            //获取数据库查询工具
            var daoTool = new level_forminitDAO();
            Table_level_forminit lf = daoTool.getInitFromByLevel(table_users.userLevel);
            // 获得Assembly
            Assembly assembly = Assembly.GetExecutingAssembly();
            // 实例化窗体
            try
            {
                Form form = assembly.CreateInstance(lf.initForm) as Form;
                this.Invoke(panelSelect_addFormCallBack, form, 1);
                if(lf.administrative_level=="区县")
                {
                    Form controlF = new control();
                    this.Invoke(panelControl_addFormCallBack, controlF, 1);
                }
            }
            catch (Exception ee)
            {

                //throw;
                Logger.logWrite(ee.Message);
                Logger.logWrite(ee.StackTrace);
            }
            
/*————————————————
版权声明：本文为CSDN博主「zhangjp」的原创文章，遵循 CC 4.0 BY - SA 版权协议，转载请附上原文出处链接及本声明。
原文链接：https://blog.csdn.net/zhangjp/article/details/2044386
*/

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
                this.panelSelectAddForm(lastForm, 1);
            }
            catch (Exception se)
            {
                Logger.logWrite(se.Message);

            }


        }

        private void mainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            Tool.checkLogin(user);
        }
        /// <summary>
        /// 注销按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_logout_Click(object sender, EventArgs e)
        {
            if(this.user.Login)
            {
                this.user.Clear();
                this.label_userName.Invoke(setLabelTextCallBack, this.label_userName, user.UserName);
                this.label_level.Invoke(setLabelTextCallBack, this.label_level, user.Level);
                this.label_IP.Invoke(setLabelTextCallBack, this.label_IP, user.Ip);

            }
        }
    }

}
