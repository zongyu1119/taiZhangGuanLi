using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 台账管理
{
    public delegate void id_cd(string[] id1);

    public partial class select_taizhang : Form
    {
        public select_taizhang()
        {
            InitializeComponent();
        }
        public string[] ID;
        public event id_cd setIDvlues;
        public string username;

        private void button1_Click(object sender, EventArgs e)
        {
            sql_sel s1 = new sql_sel();
            string str =" '%"+text.Text+"%' ";
            string[] d1 = dbo();
            string sw="";
            for (int i = 1; i < d1.Length; i++)
            {
                sw = sw + d1[i] + " like " + str;
                if (i < d1.Length - 1)
                {
                    sw = sw + " or ";
                }
            }
            ID= s1.select_string_where_t("B台账", "R序号", sw);
            setIDvlues(this.ID);
            this.Close();
        }
        private string[] dbo()
        {
            string[] db = new string[33];
            db[0] = "R序号";
            db[1] = "R名称";
            db[2] = "R是否企业";
            db[3] = "R单位";
            db[4] = "R部门";
            db[5] = "R联系人";
            db[6] = "R联系电话";
            db[7] = "R安装人员";
            db[8] = "R安装地址";
            db[9] = "R安装时间";
            db[10] = "R型号";
            db[11] = "R主板型号";
            db[12] = "R联网方式";
            db[13] = "R接车方向";
            db[14] = "RRF功率";
            db[15] = "R防雷组件";
            db[16] = "R天线型号";
            db[17] = "R磁钢型号";
            db[18] = "RAEI编号";
            db[19] = "R射频缆长度";
            db[20] = "R序列号";
            db[21] = "R程序版本";
            db[22] = "RIP地址";
            db[23] = "RRadmin账号";
            db[24] = "RRadmin密码";
            db[25] = "RCPSIP";
            db[26] = "RCPSRadmin账号";
            db[27] = "RCPSRadmin密码";
            db[28] = "R所属分中心";
            db[29] = "R所属铁路局";
            db[30] = "R备注";
            db[31] = "R创建时间";
            db[32] = "R创建人";
            return db;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void select_taizhang_Load(object sender, EventArgs e)
        {
            AcceptButton = button1;
            ID = new string[0];
            Text = "远望谷—铁路车号识别—台账搜索。" + username + ",欢迎您！";

        }
    }
}
