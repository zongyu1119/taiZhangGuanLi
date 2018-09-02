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
    public partial class add_weihujilu : Form
    {
        public string ID1;
        public string username;
        public add_weihujilu()
        {
            InitializeComponent();
        }

        private void add_weihujilu_Load(object sender, EventArgs e)
        {
            if (ID1 == null||ID1=="")
            {
                MessageBox.Show("没有选择需要添加维护记录的台账！", username + "，无法打开页面！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                csh(ID1);
            }
        }
        private void csh(string id1)
        {
            sql_sel s1 = new sql_sel();
            string r = "R名称,R型号";
            string[] tzxinxi= s1.select_dataread_only_zu_where("B台账", r, "R序号", ID1);
            mincheng.Text = tzxinxi[0];
            xinhao.Text = tzxinxi[1];
            ID.Text = ID1;
            Text = "远望谷—铁路车号识别—添加维护记录：" + ID1 + "!" + username + ",欢迎您！";
        }
        private void tjwhjl_Click(object sender, EventArgs e)
        {

            sql_sel s2 = new sql_sel();
            if (ID1 != null)
            {
                user_x ux1 = new user_x(username, "添加", "维护记录");
                ux1.insert_log(mincheng.Text);
                MessageBox.Show("向" + ID1 + "号台账" + mincheng.Text + "添加了" + s2.insert_only("B维护记录", lie(), zhi())+"条维护记录！",username+"，维护记录添加成功！",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("没有选择需要添加维护记录的台账！", username + "，维护记录添加失败！", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        private string[] lie()
        {
            string[] l=new string [12];
            l[0] = "R维护项目";
            l[1] = "R故障现象";
            l[2] = "R发生时间";
            l[3] = "R维护时间";
            l[4] = "R解决办法";
            l[5] = "R维护结果";
            l[6] = "R维护人";
            l[7] = "R联系人";
            l[8] = "R联系电话";
            l[9] = "R所属台账编号";
            l[10] = "R创建时间";
            l[11] = "R创建人";
            return l;
        }
        private string[] zhi()
        {
            string[] z = new string[12];
            z[0] = whxm.Text;
            z[1] = gzxx.Text;
            z[2] = fssj.Text;
            z[3] = whsj.Text;
            z[4] = jjbf.Text;
            z[5] = whjg.Text;
            z[6] = whr.Text;
            z[7] = lxr.Text;
            z[8] = lxdh.Text;
            z[9] = ID1;
            z[10] = DateTime.Now.ToString();
            z[11] = username;

            return z;
        }

        private void quxiao_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
