using cn.bmob.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeLevel.DAO
{
    class Table_users : BmobTable
    {
        private String fTable;
        //与云端的user表相对应
        public string userLevel { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string login_IP { get; set; }
        public string login_PORT { get; set; }

        //构造函数
        public Table_users() { }

        //构造函数
        public Table_users(String tableName)
        {
            this.fTable = tableName;
        }

        public override string table
        {
            get
            {
                if (fTable != null)
                {
                    return fTable;
                }
                return base.table;
            }
        }

        public override void readFields(BmobInput input)
        {
            base.readFields(input);
            this.userLevel= input.getString("userLevel");
            this.userName = input.getString("userName");
            this.password = input.getString("password");
            this.login_IP = input.getString("login_IP");
            this.login_PORT = input.getString("login_PORT");
        }

        public override void write(BmobOutput output, bool all)
        {
            base.write(output, all);
            output.Put("userLevel", this.userLevel);
            output.Put("userName",this.userName);
            output.Put("password",this.password);
            output.Put("login_IP",this.login_IP);
            output.Put("login_PORT",this.login_PORT);
        }
    }
}
