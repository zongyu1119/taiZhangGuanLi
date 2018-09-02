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
    public partial class xinhao : Form
    {
        public xinhao()
        {
            InitializeComponent();
        }
        public string username;
        private void xinhao_Load(object sender, EventArgs e)
        {
            Text = "远望谷—铁路车号识别—设备型号管理！。" + username + ",欢迎您！";
            load();
            sql_sel s1 = new sql_sel();
             array_jian ar = new array_jian();
            string[] sbmc = ar.quchong(s1.select_dataread_all_zu("B设备型号", "R名称"));
            shebei.Items.AddRange(sbmc);
            shebei.SelectedIndex = 0;
        }
        private void load()
        {
            zj_list.Items.Clear();
            zb_list.Items.Clear();
            tx_list.Items.Clear();
            cg_list.Items.Clear();
            yt_list.Items.Clear();
            zt_list.Items.Clear();
            sql_sel s1 = new sql_sel();
            string[] zhuji = s1.select_dataread_all_zu_where("B设备型号", "R型号", "R名称", "主机");
            zj_list.Items.AddRange(zhuji);
            string[] zhuban = s1.select_dataread_all_zu_where("B设备型号", "R型号", "R名称", "主板");
            zb_list.Items.AddRange(zhuban);
            string[] tianxian = s1.select_dataread_all_zu_where("B设备型号", "R型号", "R名称", "天线");
            tx_list.Items.AddRange(tianxian);
            string[] cigang = s1.select_dataread_all_zu_where("B设备型号", "R型号", "R名称", "磁钢");
            cg_list.Items.AddRange(cigang);
            string[] yongtu = s1.select_dataread_all_zu("B用途", "R用途");
            yt_list.Items.AddRange(yongtu);
            string[] zhuangtai = s1.select_dataread_all_zu("B安装状态", "R安装状态");
            zt_list.Items.AddRange(zhuangtai);
        }

        private void del_zj_Click(object sender, EventArgs e)
        {
            try
            {
                sql_sel s1 = new sql_sel();
                MessageBox.Show("成功删除型号 " + zj_list.SelectedItem.ToString() + " " + s1.delete_only("B设备型号", "R型号", zj_list.SelectedItem.ToString()) + "个主机型号！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
            catch
            {
                MessageBox.Show("没有选择要删除的型号！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }

        private void del_zb_Click(object sender, EventArgs e)
        {
            try
            {
                sql_sel s1 = new sql_sel();
                MessageBox.Show("成功删除型号 " + zb_list.SelectedItem.ToString() + " " + s1.delete_only("B设备型号", "R型号", zb_list.SelectedItem.ToString()) + "个主板型号！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
            catch
            {
                MessageBox.Show("没有选择要删除的型号！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void del_tx_Click(object sender, EventArgs e)
        {
            try
            {
                sql_sel s1 = new sql_sel();
                MessageBox.Show("成功删除型号 " + tx_list.SelectedItem.ToString() + " " + s1.delete_only("B设备型号", "R型号", tx_list.SelectedItem.ToString()) + "个天线型号！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
            catch
            {
                MessageBox.Show("没有选择要删除的型号！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void del_cg_Click(object sender, EventArgs e)
        {
            try
            {
                sql_sel s1 = new sql_sel();
                MessageBox.Show("成功删除型号 " + cg_list.SelectedItem.ToString() + " " + s1.delete_only("B设备型号", "R型号", cg_list.SelectedItem.ToString()) + "个磁钢型号！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
            catch
            {
                MessageBox.Show("没有选择要删除的型号！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

          
        }
       
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                sql_sel s1 = new sql_sel();
                string[] r = { "R名称", "R型号" };
                string[] v = { shebei.Text, xh.Text };
                MessageBox.Show("成功为"+shebei.Text+"添加型号 " + xh.Text + " " + s1.insert_only("B设备型号", r, v) + "条！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
            catch
            {
                MessageBox.Show("添加失败，请重试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void yt_del_Click(object sender, EventArgs e)
        {
            try
            {
                sql_sel s1 = new sql_sel();
                MessageBox.Show("成功删除型号 " + yt_list.SelectedItem.ToString() + " " + s1.delete_only("B用途", "R用途", yt_list.SelectedItem.ToString()) + "个用途！", "删除成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
            catch
            {
                MessageBox.Show("没有选择要删除的项目！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void zt_del_Click(object sender, EventArgs e)
        {
            try
            {
                sql_sel s1 = new sql_sel();
                MessageBox.Show("成功删除型号 " + zt_list.SelectedItem.ToString() + " " + s1.delete_only("B安装状态", "R安装状态", zt_list.SelectedItem.ToString()) + "个安装状态型号！", "删除成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
            catch
            {
                MessageBox.Show("没有选择要删除的项目！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void add_yt_Click(object sender, EventArgs e)
        {
            try
            {
                sql_sel s1 = new sql_sel();
                string[] r = { "R用途" };
                string[] v = { yt.Text };
                MessageBox.Show("成功添加用途 " + yt.Text + " " + s1.insert_only("B用途", r, v) + "条！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
            catch
            {
                MessageBox.Show("添加失败，请重试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void add_zt_Click(object sender, EventArgs e)
        {
            try
            {
                sql_sel s1 = new sql_sel();
                string[] r = { "R安装状态" };
                string[] v = { zt.Text };
                MessageBox.Show("成功添加安装状态 " + zt.Text + " " + s1.insert_only("B安装状态", r, v) + "条！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
            catch
            {
                MessageBox.Show("添加失败，请重试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
