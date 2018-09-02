using System;
using System.Collections;
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
    public partial class user_and_zhiwei : Form
    {
        public string username;
        public user_and_zhiwei()
        {
            InitializeComponent();
        }
        string[] us_name;
        string select_name;
        string select_zhiwei;
        string[] list_zhiwei;
        private void user_load()
        {
            user_list.Items.Clear();
            sql_sel s1 = new sql_sel();
            us_name = s1.select_dataread_all_zu("B用户", "R姓名");
            us_name = names_shai();
            if (us_name.Length != 0)
            {
                string tiaojian ="";
                for (int i = 0; i < us_name.Length; i++)
                {
                    tiaojian = tiaojian + " R姓名 = '" + us_name[i] + "' ";
                    if (i < us_name.Length - 1)
                    {
                        tiaojian = tiaojian + " or ";
                    }
                }
                ArrayList ar= s1.select_array_most("B用户", "R姓名,R分中心,R职位,R电话", tiaojian);
                for (int i1 = 0; i1 < ar.Count; i1++)
                {
                    string[] aa = (string[])ar[i1];
                    string[] ab = new string[aa.Length+1];
                    ab[0] = (i1 + 1).ToString();
                    for (int jjj = 1; jjj < ab.Length; jjj++)
                    {
                        ab[jjj] = aa[jjj-1];
                    }
                    ListViewItem subitem = new ListViewItem(ab);
                    user_list.Items.Add(subitem);
                }
            }
            select_name = null;
        }
        private string[] names_shai()
        {
            sql_sel s1 = new sql_sel();
            if (us_name.Length != 0)
            {
                if (fzx_s.SelectedIndex != 0)
                {
                    string tiaojian = "R分中心='" + fzx_s.Text + "' and (";
                    for (int i = 0; i < us_name.Length; i++)
                    {
                        tiaojian = tiaojian + " R姓名 = '" + us_name[i] + "' ";
                        if (i != us_name.Length - 1)
                        {
                            tiaojian = tiaojian + " or ";
                        }
                        else
                        {
                            tiaojian = tiaojian + " )";
                        }
                    }
                    us_name = s1.select_string_where_t("B用户", "R姓名", tiaojian);
                }
                if (us_name.Length != 0)
                {
                    if (zw_s.SelectedIndex != 0)
                    {
                        string tiaojian = "R职位='" + zw_s.Text + "' and ( ";
                        for (int i = 0; i < us_name.Length; i++)
                        {
                            tiaojian = tiaojian + " R姓名 = '" + us_name[i] + "' ";
                           
                            if (i != us_name.Length - 1)
                            {
                                tiaojian = tiaojian + " or ";
                            }
                            else
                            {
                                tiaojian = tiaojian + " ) ";
                            }
                        }
                        us_name = s1.select_string_where_t("B用户", "R姓名", tiaojian);
                    }
                }
            }
            return us_name;
        }
        private void user_and_zhiwei_Load(object sender, EventArgs e)
        {
            load_com();
            load_width();
            user_load();
            zhiwei_load();
        }
        void load_width()
        {
            double[] cw = { 0.1, 0.2, 0.3, 0.1, 0.3 };
            for(int i = 0; i < cw.Length; i++)
            {
                double a = cw[i] * user_list.Width;
                user_list.Columns[i].Width = (int)a;
            }
            double[] zww = { 0.39,0.2,0.2,0.2 };
            for (int i = 0; i < zww.Length; i++)
            {
                double a = zww[i] * zhiwei_list.Width;
                zhiwei_list.Columns[i].Width = (int)a;
            }
        }
        private void load_com()
        {
            fzx_s.Items.Add("所有分中心");

            sql_sel s1 = new sql_sel();
            fzx_s.Items.AddRange(s1.select_dataread_all_zu("B分中心", "R分中心"));
            fzx_s.SelectedIndex = 0;
            zw_s.Items.Add("所有职位");
            zw_s.Items.AddRange(s1.select_dataread_all_zu("B职位", "R职位"));
            zw_s.SelectedIndex = 0;
            fzx_yl.Items.AddRange(s1.select_dataread_all_zu("B分中心", "R分中心"));
            zw_yl.Items.AddRange(s1.select_dataread_all_zu("B职位", "R职位"));
            fzx_add.Items.AddRange(s1.select_dataread_all_zu("B分中心", "R分中心"));
            fzx_add.SelectedIndex = 0;
            zhiwei_add.Items.AddRange(s1.select_dataread_all_zu("B职位", "R职位"));
            zhiwei_add.SelectedIndex = 0;
            string[] lv1 = { "1", "2", "3", "4", "5" };
            lv.Items.AddRange(lv1);
            lv.SelectedIndex = 0;
        }

        private void fzx_s_SelectedIndexChanged(object sender, EventArgs e)
        {
            user_load();
        }

        private void zw_s_SelectedIndexChanged(object sender, EventArgs e)
        {
            user_load();
        }

        private void user_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection index = user_list.SelectedIndices;
            foreach(int a in index)
            {
                select_name = us_name[a];
            }
            yl(select_name);
        }
        void  yl(string select_name)
        {
            if (select_name != null & select_name != "")
            {
                sql_sel s1 = new sql_sel();
                string[] yulan = s1.select_dataread_only_zu_where("B用户", "*", "R姓名", select_name);

                name_yl.Text = yulan[0];
                pw_yl.Text = yulan[1];
                fzx_yl.Text = yulan[2];
                zw_yl.Text = yulan[3];
                phone_yl.Text = yulan[4];


            }
            else
            {
                name_yl.Text = "";
                pw_yl.Text = "";
                fzx_yl.Text = "";
                zw_yl.Text = "";
                phone_yl.Text = "";
            }
        }

        private void del_user_btn_Click(object sender, EventArgs e)
        {
            del(select_name);
        }
        void del(string select_name)
        {
            if (select_name == username)
            {
                MessageBox.Show("你不能删除自己!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dr;
                dr = MessageBox.Show(username + "您好！您确定要删除用户： " + select_name + " 吗？删除后不可恢复！！！", "警告！！！", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if (select_name != null & select_name != "")
                    {
                        sql_sel s1 = new sql_sel();
                        if (s1.delete_only("B用户", "R姓名", select_name) == 1)
                        {
                            MessageBox.Show("删除" + select_name + "成功！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            user_load();
                        }
                        else
                        {

                            MessageBox.Show("删除" + select_name + "失败，请重试！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        MessageBox.Show("未选择要删除的用户！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }
        void updata(string select_name)
        {
            if (select_name != null & select_name != "")
            {
                DialogResult dr;
                dr = MessageBox.Show(username + "您确定要修改用户： " + select_name + " 的信息吗？", "警告！！！", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    sql_sel s1 = new sql_sel();
                    string[] r=new string[5];
                    r[0] = "R姓名";
                    r[1] = "R密码";
                    r[2] = "R分中心";
                    r[3] = "R职位";
                    r[4] = "R电话";

                    string[] v = new string[5];
                    v[0] = name_yl.Text;
                    v[1] = pw_yl.Text;
                    v[2] = fzx_yl.Text;
                    v[3] = zw_yl.Text;
                    v[4] = phone_yl.Text;


                    if (s1.update_only("B用户",r,v, "R姓名", select_name) == 1)
                    {
                        MessageBox.Show("修改" + select_name + " 的信息成功！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("修改" + select_name + " 的信息失败，请重试！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                
                }
                else
                {
                    MessageBox.Show("未选择要修改的用户！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }
        void insert()
        {
            if (name_add.Text == "")
            {
                MessageBox.Show("用户名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {                
                DialogResult dr;
                dr = MessageBox.Show(username + "您确定要添加用户： " + name_add.Text + " 的信息吗？", "警告！！！", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    sql_sel s1 = new sql_sel();
                    string[] r = new string[5];
                    r[0] = "R姓名";
                    r[1] = "R密码";
                    r[2] = "R分中心";
                    r[3] = "R职位";
                    r[4] = "R电话";

                    string[] v = new string[5];
                    v[0] = name_add.Text;
                    v[1] = pw_add.Text;
                    v[2] = fzx_add.Text;
                    v[3] = zhiwei_add.Text;
                    v[4] = phone_add.Text;

                    if (s1.insert_only("B用户", r, v) == 1)
                    {
                        MessageBox.Show("添加用户 " + name_add.Text + " 的成功！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        user_load();
                    }
                    else
                    {

                        MessageBox.Show("添加用户失败，请重试！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }

        }

        private void add_user_btn_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void up_user_btn_Click(object sender, EventArgs e)
        {
            updata(select_name);

        }

        private void zhiwei_load()
        {
            sql_sel s1 = new sql_sel();
            ArrayList list = new ArrayList();
            list = s1.select_array_all("B职位", "*");
            list_zhiwei = new string[list.Count];
            foreach(string[] x in list)
            {
                ListViewItem sub = new ListViewItem(x);
                zhiwei_list.Items.Add(sub);
            }
            for(int i = 0; i < list.Count; i++)
            {
                string[] z = (string[])list[i];
                list_zhiwei[i] = z[0];
            }
        }
        private void zhiwei_del(string select_zhiwei)
        {
                DialogResult dr;
                dr = MessageBox.Show(username + "您好！您确定要删除职位： " + select_zhiwei + " 吗？", "警告！！！", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if (select_zhiwei != null & select_zhiwei != "")
                    {
                        sql_sel s1 = new sql_sel();
                        if (s1.delete_only("B职位", "R职位", select_zhiwei) == 1)
                        {
                            MessageBox.Show("删除" + select_zhiwei + "成功！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            zhiwei_load();
                        }
                        else
                        {

                            MessageBox.Show("删除" + select_zhiwei + "失败，请重试！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        MessageBox.Show("未选择要删除的职位！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            

        }

        private void zhiwei_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection index = zhiwei_list.SelectedIndices;
            foreach (int a in index)
            {
                select_zhiwei = list_zhiwei[a];
            }
        }

        private void del_zw_btn_Click(object sender, EventArgs e)
        {
            zhiwei_del(select_zhiwei);   
        }
        private void insert_zhiwei()
        {
            string[] r = new string[4];
            r[0] = "R职位";
            r[1] = "R删除权限";
            r[2] = "R修改权限";
            r[3] = "R等级";
            string[] v = new string[4];
            v[0] = add_zhiwei.Text;
            v[1] = del_num.Text;
            v[2] = up_num.Text;
            v[3] = lv.Text;

            if (add_zhiwei.Text == "")
            {
                MessageBox.Show("职位名不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dr;
                dr = MessageBox.Show(username + "您确定要添加职位： " + v[0] + " 吗？", "提示", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    sql_sel s1 = new sql_sel();
                    if (s1.insert_only("B职位", r, v) == 1)
                    {
                        MessageBox.Show("添加职位 " + v[0] + " 成功！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        zhiwei_load();
                    }
                    else
                    {

                        MessageBox.Show("添加职位失败，请重试！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }

        private void add_zw_btn_Click(object sender, EventArgs e)
        {
            insert_zhiwei();
        }
    }
}
