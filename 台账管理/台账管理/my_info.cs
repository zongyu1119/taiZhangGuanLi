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
    public partial class my_info : Form
    {
        public string username;
        public my_info()
        {
            InitializeComponent();
        }

        private void my_info_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            Text = "远望谷—客服中心— " + username + " 用户信息";
            sql_sel s1 = new sql_sel();
            name.Text = username;
            pw.Text = (string)s1.select_only("B用户", "R密码", "R姓名", username);
            bumen.Text= (string)s1.select_only("B用户", "R分中心", "R姓名", username);
            zw.Text= (string)s1.select_only("B用户", "R职位", "R姓名", username);
            phone.Text = (string)s1.select_only("B用户", "R电话", "R姓名", username);

        }

        private void up_mima_Click(object sender, EventArgs e)
        {
            sql_sel s1 = new sql_sel();
            string[] r = { "R密码"};
            string[] v = { pw.Text };
            if(s1.update_only("B用户", r, v, "R姓名", username) == 1)
            {
                MessageBox.Show(username + "，恭喜您，密码修改成功！", "密码修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(username + "，遗憾，密码修改失败！", "密码修改失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void quxiao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void change_p_Click(object sender, EventArgs e)
        {
            sql_sel s1 = new sql_sel();
            string[] r = { "R电话" };
            string[] v = { phone.Text };
            if (s1.update_only("B用户", r, v, "R姓名", username) == 1)
            {
                MessageBox.Show(username + "，恭喜您，新电话为"+phone.Text+"！", "电话修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(username + "，遗憾，电话修改失败！", "电话修改失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
