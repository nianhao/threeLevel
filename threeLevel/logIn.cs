using cn.bmob.api;
using cn.bmob.io;
using cn.bmob.tools;
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
using threeLevel.Bmob;
using threeLevel.DAO;

namespace threeLevel
{
    public partial class logIn : Form
    {
        private const string TABLENAME = "users";
        private delegate void closeFormDelegate (Form form);
        private closeFormDelegate closeCallBack;

        public logIn()
        {
            InitializeComponent();
            closeCallBack = new closeFormDelegate(closeForm);
        }
        private void closeForm(Form form)
        {
            form.Close();
        }
        private void logIn_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 点击登录按钮，进行登录验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_login_Click(object sender, EventArgs e)
        {
            string userName = this.textBox_UserName.Text;
            string userPwd = this.textBox_PassWord.Text;
            var Bmob = Tool_Bmob.getBmobWindows();
            //创建一个BmobQuery查询对象
            BmobQuery query = new BmobQuery();
            try
            {

                //查询playerName的值为bmob的记录
                query.WhereEqualTo("userName", userName);
                query.WhereEqualTo("password", userPwd);
                Bmob.Find<Table_users>(TABLENAME, query, (resp, exception) =>
                {
                    if (exception != null)
                    {
                        Logger.logWrite("查询失败, 失败原因为： " + exception.Message);
                        return;
                    }

                    //对返回结果进行处理
                    List<Table_users> list = resp.results;
                    foreach (var userEntity in list)
                    {
                        Logger.logWrite("获取的对象为： " + userEntity.ToString());
                    }
                    if(list.Count==1)
                    {
                        Program.mw.setUSER(list[0]);
                        MessageBox.Show("登录成功","登录状态");
                        this.Invoke(closeCallBack, this);
                    }
                });
            }
            catch (Exception ee)
            {

                //throw;
                Logger.logWrite(ee.Message);
                Logger.logWrite(ee.StackTrace);
            }

        }
    }
}
