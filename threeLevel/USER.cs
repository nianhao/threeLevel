using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using threeLevel.DAO;

namespace threeLevel
{
    public class USER
    {
        public USER()
        {
            login = false;
        }
        string userName;
        string userPWD;
        string ip;
        string level;
        bool login;

        public string UserName { get => userName; set => userName = value; }
        public string UserPWD { get => userPWD; set => userPWD = value; }
        public string Ip { get => ip; set => ip = value; }
        public bool Login { get => login; set => login = value; }
        public string Level { get => level; set => level = value; }
        /// <summary>
        /// 从查询的数据表中向USER中填充数据
        /// </summary>
        /// <param name="table_users"></param>
        internal void setFromTableItem(Table_users table_users)
        {
            //throw new NotImplementedException();
            this.userName = table_users.userName;
            this.userPWD = table_users.password;
            this.level = table_users.userLevel;
            this.login = true;
            this.ip = GlobalConfig.LocalIP;
        }
        /// <summary>
        /// 用户注销
        /// </summary>
        internal void Clear()
        {
            // throw new NotImplementedException();
            this.Login = false;
            this.UserName = "未登录";
            this.Level = "未登录";
            this.Ip = "0.0.0.0";
        }
    }
}
