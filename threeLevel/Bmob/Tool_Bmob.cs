using cn.bmob.api;
using cn.bmob.tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeLevel.Bmob
{
    class Tool_Bmob
    {
        public static BmobWindows getBmobWindows()
        {

            BmobWindows Bmob = new BmobWindows();
            Bmob.initialize(Gloable.appkey, Gloable.RestKey); // 替换成你的appkey/RestKey
            BmobDebug.Register(msg => { Debug.WriteLine(msg); }); // 用于调试输出请求参数
            return Bmob;
        }

    }

}
