using cn.bmob.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeLevel.DAO
{
    class Table_level_forminit : BmobTable
    {
        private String fTable;
        //与数据库中表列相对应
        public string administrative_level { get; set; }
        public string initForm { get; set; }
        public string level {get;set;}

        //构造函数
        public Table_level_forminit() { }

        //构造函数
        public Table_level_forminit(String tableName)
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
            this.administrative_level = input.getString("administrative_level");
            this.initForm = input.getString("initForm");
            this.level = input.getString("level");

            
        }

        public override void write(BmobOutput output, bool all)
        {
            base.write(output, all);
            output.Put("administrative_level", this.administrative_level);
            output.Put("initForm", this.initForm);
            output.Put("level", this.level);
           
        }
    }

}
