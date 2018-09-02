using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 台账管理
{
    class del_taizhang
    {
        public string username;
        public bool del(string ID1)
        {
            bool a=false;
            if (ID1 != null & ID1 != "")
            {
                user_x ux1 = new user_x(username, "删除", "台账");                
                if (ux1.sy() > 0)
                {
                    sql_sel sqq1 = new sql_sel();
                    DialogResult dr;
                    dr = MessageBox.Show(username + "您好！您确定要删除台账： " + sqq1.select_only("B台账","R名称","R序号",ID1) + " 吗？删除后不可恢复！！！", "警告！！！", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        ux1.insert_log(ux1.TZ_name(ID1));
                        MessageBox.Show("删除了编号为：" + ID1 + "的" + sqq1.delete_only("B台账", "R序号", ID1) + "个台账，台账的" + sqq1.delete_only("B示意图", "R所属台账编号", ID1) + "张示意图和" + sqq1.delete_only("B图片", "R所属台账序号", ID1) + "张图片也被同时删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sqq1.delete_only("B维护记录", "R所属台账编号", ID1);
                        a = true;
                    }
                }
                else
                {
                    ux1.cw_message();
                }               
            }
            else
            {
                MessageBox.Show("未选择台账！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                a = false;
            }
            return a;
        }
    }
}
