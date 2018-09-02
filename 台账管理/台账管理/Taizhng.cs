using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 台账管理
{
    public partial class Taizhng : Form
    {

        public string username;
        private string select_ID;
        public string[] list_ID;

        public Taizhng()
        {
            InitializeComponent();
        }

        private void Taizhng_Load(object sender, EventArgs e)
        {
            try
            {
                //size_this();

                if (username == null || username == "")
                {
                    this.Close();
                }
                else
                {
                    tree();
                    listview();
                    shai_load();
                    tree_afterselect();
                    listView1.ContextMenuStrip = youjicaidan_list;
                    Text = "远望谷—铁路台账管理系统！" + username + "，欢迎您！";
                }

            }
            catch
            {
                erro er = new erro();
                er.erro1();
                this.Close();
            }

        }
        void size_this()
        {
            this.Size = new Size(1222, 731);
            this.Location = new Point(0, 0);

            select_btn.Location = new Point(1070, 622);
            select_btn.Size = new Size(112, 34);

            this.del_btn.Location = new Point(682, 622);
            this.del_btn.Size = new Size(112, 34);

            this.updata_btn.Location = new System.Drawing.Point(486, 622);
            this.updata_btn.Size = new System.Drawing.Size(112, 34);

            this.new_btn.Location = new System.Drawing.Point(292, 622);
            this.new_btn.Size = new System.Drawing.Size(112, 34);

            this.listView1.Location = new System.Drawing.Point(292, 40);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Size = new System.Drawing.Size(890, 345);

            this.treeView1.Location = new System.Drawing.Point(18, 40);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Size = new System.Drawing.Size(248, 617);

            this.new_jilu.Location = new System.Drawing.Point(866, 622);
            this.new_jilu.Size = new System.Drawing.Size(138, 34);

            this.ClientSize = new System.Drawing.Size(1200, 675);

            yulan1.Size = new Size(890, 208);
            yulan1.Location = new Point(292, 392);
        }
        private void shai_load()
        {
            sql_sel s2 = new sql_sel();
            string[] xh = s2.select_dataread_all_zu_where("B设备型号", "R型号", "R名称", "主机");
            xinhao_shai.Items.Add("全部");
            xinhao_shai.Items.AddRange(xh);
            xinhao_shai.SelectedIndex = 0;
            string[] yt1 = s2.select_dataread_all_zu("B用途", "R用途");
            yongtu_shai.Items.Add("全部");
            yongtu_shai.Items.AddRange(yt1);
            yongtu_shai.SelectedIndex = 0;
            string[] zt1 = s2.select_dataread_all_zu("B安装状态", "R安装状态");
            zhuangtai_shai.Items.Add("全部");
            zhuangtai_shai.Items.AddRange(zt1);
            zhuangtai_shai.SelectedIndex = 0;
        }
        void listview()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("编号", 40, HorizontalAlignment.Left);
            listView1.Columns.Add("项目名称", 170, HorizontalAlignment.Left);
            listView1.Columns.Add("型号", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("安装地址", 170, HorizontalAlignment.Left);
            listView1.Columns.Add("安装时间", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("安装人", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("企业/国铁", 80, HorizontalAlignment.Center);
            listView1.FullRowSelect = true;//选择某一项后单击某项是否选择其所有子项。
            listView1.GridLines = true;//在包含控件中项及其子项的行和列之间是否显示网格线。

        }
        private void tree()
        {
            treeView1.ContextMenuStrip = contextMenuStrip1;
            TreeNode topNode = treeView1.Nodes.Add("所有台账");
            sql_sel s1 = new sql_sel();
            string[] readfzx = s1.select_dataread_all_zu("B分中心", "R分中心");
            TreeNode[] fzx = new TreeNode[readfzx.Length];
            for (int i = 0; i < readfzx.Length; i++)
            {
                fzx[i] = new TreeNode(readfzx[i].ToString());
                topNode.Nodes.Add(fzx[i]);
                string[] readfz = s1.select_dataread_all_zu_where("B铁路局", "R铁路局", "R所属分中心", readfzx[i]);
                TreeNode[] fz = new TreeNode[readfzx.Length];
                for (int j = 0; j < readfz.Length; j++)
                {
                    fz[j] = new TreeNode(readfz[j].ToString());
                    fzx[i].Nodes.Add(fz[j]);
                    string[] qiyeguotie = { "国铁", "企业" };
                    for (int iii = 0; iii < qiyeguotie.Length; iii++)
                    {
                        TreeNode iiii = new TreeNode(qiyeguotie[iii]);
                        fz[j].Nodes.Add(iiii);
                    }
                }
            }
            topNode.Expand();
            treeView1.SelectedNode = topNode;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tree_afterselect();
        }
        private void tree_afterselect()
        {
            listView1.Items.Clear();
            sql_sel s3 = new sql_sel();

            if (treeView1.SelectedNode.Text == "所有台账")
            {
                list_ID = s3.select_dataread_all_zu("B台账", "R序号");
            }
            else
            {
                if (treeView1.SelectedNode.Text == "国铁" || treeView1.SelectedNode.Text == "企业")
                {
                    string sql_xx = " R所属铁路局 = '" + treeView1.SelectedNode.Parent.Text + "' and R是否企业= '" + treeView1.SelectedNode.Text + "'";
                    list_ID = s3.select_string_where_t("B台账", "R序号", sql_xx);
                }
                else
                {
                    string sql_xx = " R所属铁路局 = '" + treeView1.SelectedNode.Text + " ' or R所属分中心= '" + treeView1.SelectedNode.Text + "'";
                    list_ID = s3.select_string_where_t("B台账", "R序号", sql_xx);
                }
            }
            tree_id(list_ID);
            select_ID = null;
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            new_Taizhang new_tz = new new_Taizhang();
            new_tz.StartPosition = FormStartPosition.CenterScreen;
            new_tz.username = username;
            new_tz.Show();
        }

        private void 全部展开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void 全部关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_ID = null;
            ListView.SelectedIndexCollection indexes = listView1.SelectedIndices;

            foreach (int index in indexes)
            {
                select_ID = list_ID[index];
            }
            yulan1.ID = select_ID;
            yulan1.shuju();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            taizhangxiangxi tzxx = new taizhangxiangxi();
            tzxx.ID1 = select_ID;

            tzxx.ids = list_ID;
            tzxx.username = username;
            tzxx.StartPosition = FormStartPosition.CenterScreen;

            tzxx.Show();
        }

        private void updata_btn_Click(object sender, EventArgs e)
        {
            if (select_ID != null)
            {
                updata_taizhang up = new updata_taizhang();
                up.ID1 = select_ID;
                up.StartPosition = FormStartPosition.CenterScreen;
                up.username = username;
                up.Show();
            }
            else
            {
                MessageBox.Show("未选择台账！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            del_taizhang del = new del_taizhang();
            del.username = username;
            if (del.del(select_ID))
            {
                array_jian ajian = new array_jian();
                list_ID = ajian.jian(select_ID, list_ID);
                tree_id(list_ID);
                select_ID = null;
            }
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            select_taizhang stz1 = new select_taizhang();
            stz1.username = username;
            stz1.setIDvlues += new id_cd(stz1_idcd);
            stz1.StartPosition = FormStartPosition.CenterParent;
            object obj = stz1.ShowDialog();
            list_ID = stz1.ID;
            tree_id(list_ID);

        }

        //这里是数据方法
        private void tree_id(string[] chazhao_ID)
        {

            listView1.Items.Clear();
            if (chazhao_ID.Length != 0)
            {

                chazhao_ID = shaixuan(chazhao_ID);
                list_ID = chazhao_ID;
                if (chazhao_ID.Length != 0)
                {
                    sql_sel s3 = new sql_sel();
                    string Lvo = "R序号,R名称,R型号,R安装地址,R安装时间,R安装人员,R是否企业";
                    string tiaojian = "";
                    for (int i = 0; i < chazhao_ID.Length; i++)
                    {
                        tiaojian = tiaojian + " R序号 = '" + chazhao_ID[i] + "' ";
                        if (i < chazhao_ID.Length - 1)
                        {
                            tiaojian = tiaojian + " or ";
                        }
                    }
                    ArrayList ar1 = s3.select_array_most("B台账", Lvo, tiaojian);
                    for (int i1 = 0; i1 < ar1.Count; i1++)
                    {
                        string[] aa = (string[])ar1[i1];
                        string[] ab = new string[aa.Length];
                        ab[0] = (i1 + 1).ToString();
                        for(int jjj = 1; jjj< aa.Length; jjj++)
                        {
                            ab[jjj] = aa[jjj];
                        }
                        ListViewItem subitem = new ListViewItem (ab);
                        listView1.Items.Add(subitem);
                    }
                }
            }
            jishu.Text = "该条件下共有 " + list_ID.Length + " 个台账！";
        }
        string[] shaixuan(string[] sid)
        {
            if (sid.Length != 0)
            {
                sql_sel s3 = new sql_sel();
                string date_shai = " R安装时间 >= '" + date_min.Text + "' and R安装时间 <= '" + date_max.Text + "' and (";
                for (int i = 0; i < sid.Length; i++)
                {
                    date_shai = date_shai + "R序号='" + sid[i] + "' ";
                    if (i != sid.Length - 1)
                    {
                        date_shai = date_shai + " or ";
                    }
                    else
                    {
                        date_shai = date_shai + ")";
                    }
                }
                sid = s3.select_string_where_t("B台账", "R序号", date_shai);

                if (sid.Length != 0)
                {
                    if (xinhao_shai.Text != "全部")
                    {
                        string xhs = " R型号= '" + xinhao_shai.Text + "' and (";
                        for (int i = 0; i < sid.Length; i++)
                        {
                            xhs = xhs + "R序号 = '" + sid[i] + "' ";
                            if (i != sid.Length - 1)
                            {
                                xhs = xhs + " or ";
                            }
                            else
                            {
                                xhs = xhs + ")";
                            }

                        }
                        sid = s3.select_string_where_t("B台账", "R序号", xhs);
                    }
                }

                if (sid.Length != 0)
                {
                    if (yongtu_shai.Text != "全部")
                    {

                        string xhs = " R用途= '" + yongtu_shai.Text + "' and (";
                        for (int i = 0; i < sid.Length; i++)
                        {
                            xhs = xhs + "R序号 = '" + sid[i] + "' ";
                            if (i != sid.Length - 1)
                            {
                                xhs = xhs + " or ";
                            }
                            else
                            {
                                xhs = xhs + ")";
                            }

                        }
                        sid = s3.select_string_where_t("B台账", "R序号", xhs);
                    }
                }
                if (sid.Length != 0)
                {
                    if (zhuangtai_shai.Text != "全部")
                    {
                        string xhs = " R安装状态= '" + zhuangtai_shai.Text + "' and (";
                        for (int i = 0; i < sid.Length; i++)
                        {
                            xhs = xhs + "R序号 = '" + sid[i] + "' ";
                            if (i != sid.Length - 1)
                            {
                                xhs = xhs + " or ";
                            }
                            else
                            {
                                xhs = xhs + ")";
                            }

                        }
                        sid = s3.select_string_where_t("B台账", "R序号", xhs);
                    }
                }

            }
            return sid;
        }

        void stz1_idcd(string[] Value)
        {
            //具体实现。
            this.list_ID = Value;
        }

        private void new_jilu_Click(object sender, EventArgs e)
        {
            add_weihujilu whjl = new add_weihujilu();
            whjl.username = username;
            whjl.StartPosition = FormStartPosition.CenterScreen;
            whjl.ID1 = select_ID;
            whjl.Show();
        }

        private void 新增台账ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_Taizhang new_tz = new new_Taizhang();
            new_tz.StartPosition = FormStartPosition.CenterScreen;
            new_tz.username = username;
            new_tz.Show();
        }

        private void 新增维护记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_weihujilu whjl = new add_weihujilu();
            whjl.username = username;
            whjl.StartPosition = FormStartPosition.CenterScreen;
            whjl.ID1 = select_ID;
            whjl.Show();
        }

        private void 删除台账ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            del_taizhang del = new del_taizhang();
            del.username = username;
            if (del.del(select_ID))
            {
                array_jian ajian = new array_jian();
                list_ID = ajian.jian(select_ID, list_ID);
                tree_id(list_ID);
                select_ID = null;
            }
        }

        private void 查看详细ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            taizhangxiangxi tzxx = new taizhangxiangxi();
            tzxx.ID1 = select_ID;
            tzxx.StartPosition = FormStartPosition.CenterScreen;
            tzxx.ids = list_ID;
            tzxx.username = username;
            tzxx.Show();
        }

        private void 修改台账ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (select_ID != null)
            {
                updata_taizhang up = new updata_taizhang();
                up.ID1 = select_ID;
                up.StartPosition = FormStartPosition.CenterScreen;
                up.username = username;
                up.Show();
            }
            else
            {
                MessageBox.Show("未选择台账！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void my_info_Click(object sender, EventArgs e)
        {
            my_info my_Info1 = new my_info();
            my_Info1.username = username;
            my_Info1.StartPosition = FormStartPosition.CenterScreen;

            my_Info1.ShowDialog();
        }

        private void my_creat_Click(object sender, EventArgs e)
        {
            sql_sel s3 = new sql_sel();

            list_ID = s3.select_dataread_all_zu_where("B台账", "R序号", "R创建人", username);
            tree_id(list_ID);
        }

        private void my_anzhuan_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            sql_sel s3 = new sql_sel();

            list_ID = s3.select_string_where_t("B台账", "R序号", "R安装人员 like '%" + username + "%'");
            tree_id(list_ID);
        }

        private void my_whsb_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            sql_sel s3 = new sql_sel();
            array_jian arqc = new array_jian();
            list_ID = arqc.quchong(s3.select_string_where_t("B维护记录", "R所属台账编号", "R维护人 like '%" + username + "%'"));
            tree_id(list_ID);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            tree_afterselect();
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            tree_afterselect();
        }

        private void xinhao_shai_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            tree_afterselect();
        }

        private void xinhao_shai_Click(object sender, EventArgs e)
        {
           
            tree_afterselect();
        }

        private void yongtu_shai_Click(object sender, EventArgs e)
        {
            
            tree_afterselect();
        }

        private void yongtu_shai_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            tree_afterselect();
        }

        private void zhuangtai_shai_Click(object sender, EventArgs e)
        {
          
            tree_afterselect();
        }

        private void date_min_ValueChanged(object sender, EventArgs e)
        {
           
            tree_afterselect();
        }

        private void date_max_ValueChanged(object sender, EventArgs e)
        {
           
            tree_afterselect();
        }

        private void zhuangtai_shai_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            tree_afterselect();
        }

        private void date_min_CloseUp(object sender, EventArgs e)
        {
            tree_afterselect();
        }

        private void date_max_CloseUp(object sender, EventArgs e)
        {
            tree_afterselect();
        }
    }
}
