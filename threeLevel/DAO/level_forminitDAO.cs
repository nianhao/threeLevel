using cn.bmob.api;
using cn.bmob.io;
using cn.bmob.json;
using cn.bmob.response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using threeLevel.Bmob;

namespace threeLevel.DAO
{
    class level_forminitDAO
    {
        //操作的表名
        private const string TABLENAME = "level_formInit";
        BmobWindows bmobWin = Tool_Bmob.getBmobWindows();
        

        public Table_level_forminit getInitFromByLevel(string level)
        {
            //返回的窗体的名字
            string formName = "";
            //创建一个BmobQuery查询对象
            BmobQuery query = new BmobQuery();
            query.WhereEqualTo("level", level);


                //根据level查询应该实例化的窗体
            var x = bmobWin.FindTaskAsync<Table_level_forminit>(TABLENAME,query);

  /*              {
                    if (exception != null)
                    {
                        Logger.logWrite("查询失败, 失败原因为： " + exception.Message);
                        formName = "error";
                        return ;
                    }

                    //对返回结果进行处理
                    List<Table_level_forminit> list = resp.results;
                    foreach (var userEntity in list)
                    {
                        Logger.logWrite("获取的对象为： " + userEntity.ToString());
                    }
                    if (list.Count == 1)
                    {
                        formName = list[0].initForm;
                    }
                });*/
            try
            {

                var res = FinishedCallback(x.Result);
                if(res.Count==1)
                {
                    return res[0];
                }
                else
                {
                    Logger.logWrite("查询到多个数据，返回错误");
                    return null;
                }
            }
            catch (Exception ee)
            {

                //throw;
                Logger.logWrite(ee.Message);
                Logger.logWrite(ee.StackTrace);
                return null;
            }

        }
        //对返回结果进行显示处理
        private List<Table_level_forminit> FinishedCallback<T>(T data)
        {
            string text = JsonAdapter.JSON.ToDebugJsonString(data);

            Logger.logWrite(text);
            // Table_level_forminit [] levelForms = JsonConvert.DeserializeObject<Table_level_forminit>(text);
            //生成Jobject
            JObject o = JObject.Parse(text);
            //把数组解析出来
            JArray ja = JArray.Parse(o["results"].ToString());

            var res = new List<Table_level_forminit>();
            for(int i=0;i<ja.Count;i++)
            {
                var tem = new Table_level_forminit();
                var temObj = JObject.Parse(ja[i].ToString());
                //进行赋值
                tem.initForm = temObj["initForm"].ToString();
                tem.level = temObj["level"].ToString();
                tem.administrative_level = temObj["administrative_level"].ToString();
                res.Add(tem);

            }
            return res;



        }
    }
}
