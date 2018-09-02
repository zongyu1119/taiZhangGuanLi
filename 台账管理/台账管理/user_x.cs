using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 台账管理
{
    class user_x
    {
        string user;
        string cz;
        string dx;
        public user_x(string username)
        {
            user = username;
        }
        public user_x(string username,string caozuo)
        {
            user = username;
            cz = caozuo;
        }
        public user_x(string username, string caozuo,string duixiang)
        {
            user = username;
            cz = caozuo;
            dx = duixiang;
        }
       
        sql_sel s1 = new sql_sel();
        public string zhiw()
        {
            string zw = s1.select_only("B用户", "R职位", "R姓名", user).ToString();
            return zw;
        }
        public string dengji()
        {
            string deng = s1.select_only("B职位", "R等级", "R职位", zhiw()).ToString();
            return deng;
        }

        public int sy()
        {
            int a= int.Parse(s1.select_only("B职位", "R删除权限", "R职位", zhiw()).ToString());
            string x = "R操作类型='" + cz + "' and R操作人='" + user + "' and R操作日='"+DateTime.Now.ToShortDateString()+"'";
            int b= int.Parse(s1.select_only2("B操作记录", "count(*)", x).ToString());
           
            return a - b;
        }
      
        public void cw_message()
        {
            MessageBox.Show("您已经使用完您当日的"+cz+"权限！请联系领导或明日再试！", cz+"失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public string TZ_name(string tz_id)
        {
            return s1.select_only("B台账", "R名称", "R序号", tz_id).ToString();
        }
        public void insert_log(string tz)
        {
            DateTime dt = DateTime.Now;
            
            string[] r = { "R操作记录","R操作对象", "R操作类型", "R操作人", "R操作时间" ,"R操作日"};
            string[] v = { "台账名称：" + tz, dx, cz, user, dt.ToString(), dt.ToShortDateString() };
            s1.insert_only("B操作记录", r, v);
        }
    }
}
