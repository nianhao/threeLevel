using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace threeLevel
{
    internal class Tool
    {
        /// <summary>
        /// 检查用户是否登录
        /// </summary>
        public static bool checkLogin(USER user)
        {
            // throw new NotImplementedException();
            if (user.Login)
            {
                //根据用户的等级，跳转到响应的界面
                switch (user.Level)
                {

                }
                return true;
            }
            else
            {
                logIn loginF = new logIn();
                loginF.TopLevel = true;
                loginF.TopMost = true;
                loginF.ShowDialog();
                return false;
            }
        }
        /// <summary>
        /// 在用户登录之后，根据用户的level（行政等级）值，在mainWindow中加载对应的
        /// 行政级的界面。
        /// 比如说，如果用户的行政等级是 贵州省，则在数据库的对应的表中，查询贵州省对应的
        /// 窗口名称 GZProvince
        /// 然后利用反射，新建这样的一个窗体，把它添加到对应的panel中去，同时根据是否是
        /// 最后一级，加载congtrol窗体（带宽控制窗体）
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public static string getLevelFormName(string level)
        {
            string formName = "";

            //这里如果查询错误，应该返回一个错误的窗口
            //时间限制先不添加这个功能了，反正我的数据库都是我添加的
            //不会出现查询错误和错误的窗口名字的情况
            return formName;
        }
    }
}
