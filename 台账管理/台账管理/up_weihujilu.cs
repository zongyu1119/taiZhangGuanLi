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
    public partial class up_weihujilu : Form
    {
        public string username;
        public string tz_id;
        public string wh_id;
        public bool b1=false;
        public up_weihujilu()
        {
            InitializeComponent();
        }

        private void up_weihujilu_Load(object sender, EventArgs e)
        {
            if (wh_id != null)
            {
                csh(tz_id);
                csz(wh_id);
                b1 = false;
            }
            else
            {
                MessageBox.Show("没有选择维护记录！", username + "，无法打开页面！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        private void csh(string ID1)
        {
            sql_sel s1 = new sql_sel();
            string r = "R名称,R型号";
            string[] tzxinxi = s1.select_dataread_only_zu_where("B台账", r, "R序号", ID1);
            mincheng.Text = tzxinxi[0];
            xinhao.Text = tzxinxi[1];
            ID.Text = ID1;
            Text = "远望谷—铁路车号识别—查看维护记录：" + tz_id + "!" + username + ",欢迎您！";
        }
        private void csz(string wid)
        {
            sql_sel s1 = new sql_sel();
            string r = "";
            for (int j = 0; j < lie().Length; j++)
            {
                r = r + lie()[j];
                if (j < lie().Length - 1)
                {
                    r = r + ",";
                }
            }
            string[] wh_xx = s1.select_dataread_only_zu_where("B维护记录", r, "R序号", wh_id);
            whxm.Text = wh_xx[0];
            gzxx.Text = wh_xx[1];
            fssj.Text = wh_xx[2];
            whsj.Text = wh_xx[3];
            jjbf.Text = wh_xx[4];
            whjg.Text = wh_xx[5];
            whr.Text = wh_xx[6];
            lxr.Text = wh_xx[7];
            lxdh.Text = wh_xx[8];
            tz_id = wh_xx[9];
        }
        private string[] lie()
        {
            string[] l = new string[12];
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
            z[9] = tz_id;
            z[10] = DateTime.Now.ToString();
            z[11] = username;

            return z;
        }

        private void tjwhjl_Click(object sender, EventArgs e)
        {
            sql_sel s2 = new sql_sel();
            if (wh_id != null)
            {
                user_x ux1 = new user_x(username, "修改", "维护记录");
                if (ux1.sy() > 0)
                {
                    ux1.insert_log(mincheng.Text);
                    MessageBox.Show("修改了台账" + mincheng.Text + "的" + s2.update_only("B维护记录", lie(), zhi(), "R序号", wh_id) + "条维护记录！", username + "，维护记录修改成功！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    b1 = true;
                }
                else
                {
                    ux1.cw_message();
                }
            }
            else
            {
                MessageBox.Show("没有选择需要修改的维护记录！", username + "，维护记录修改失败！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void del_whjl_Click(object sender, EventArgs e)
        {
            if (wh_id != null)
            {
                user_x ux1 = new user_x(username, "删除", "维护记录");
                if (ux1.sy() > 0)
                {
                    DialogResult dr;
                    dr = MessageBox.Show(username + "您好！您确定要删除台账 " + mincheng.Text + " 的维护记录" + whxm.Text + "吗？删除后不可恢复！！！", "警告！！！", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        sql_sel sqq1 = new sql_sel();
                        ux1.insert_log(mincheng.Text);
                        MessageBox.Show("删除了台账 " + mincheng.Text + " 的" + sqq1.delete_only("B维护记录", "R序号", wh_id) + "条维护记录" + whxm.Text + " !", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        b1 = true;
                        Close();
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
            }
        }
    }
}
