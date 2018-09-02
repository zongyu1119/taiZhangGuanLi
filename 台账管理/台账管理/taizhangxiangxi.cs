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
    public partial class taizhangxiangxi : Form
    {
        public string ID1;
        public string[] ids;
        public string username;
        int i = 0;
        public taizhangxiangxi()
        {
            InitializeComponent();
        }

        private void taizhangxiangxi_Load(object sender, EventArgs e)
        {
           
            if (ID1 == null)
            {
                MessageBox.Show("没有选择台账！", username + "，无法打开页面！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                try
                {
                    Text = "远望谷—铁路车号识别—台账详情：" + ID1 + "。" + username + ",欢迎您！";
                    clear();
                    //enable();
                    i_chushi();
                    select_zhi(ID1);
                    whjlcsh();
                }
                catch
                {
                    MessageBox.Show("没有选择台账！", username + "，无法打开页面！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
               
            }

        }
        private void clear()
        {
            int i = pictureBox1.Width;
            int j = pictureBox1.Height;
            Bitmap b1 = new Bitmap(i, j); //新建位图b1
            Graphics g2 = Graphics.FromImage(b1); //创建b1的Graphics
            g2.FillRectangle(Brushes.White, new Rectangle(0, 0, i, j)); //把b1涂成白色
            pictureBox1.Image = b1;
        }
        private void i_chushi()
        {
            while (ids[i] != ID1)
            {
                i++;
            }
        }
        private void select_zhi(string tzid)
        {
            sql_sel s1 = new sql_sel();
            string[] zhi1 = s1.select_dataread_only_zu_where("B台账", "*", "R序号", tzid);
            ArrayList imglist = s1.select_array_byte_little("B图片", "R图片", "R所属台账序号", tzid);
            longbotu1.arry = imglist;
            longbotu1.leixin = s1.select_dataread_all_zu_where("B图片", "R图片类型", "R所属台账序号", tzid);
            longbotu1.load();
            try
            {
                byte[] syt_bytes = (byte[])s1.select_only("B示意图", "R示意图", "R所属台账编号", tzid);
                string_to_img sti1 = new string_to_img();
                img_width_change iwc1 = new img_width_change();
                pictureBox1.Image = iwc1.change(sti1.byte_img(syt_bytes, "jpg"), pictureBox1.Width, pictureBox1.Height);
            }
            catch
            {
                Graphics g1 = Graphics.FromImage(pictureBox1.Image);
                g1.FillRectangle(Brushes.White, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height)); //涂成白色
                Font font = new Font("黑体", 20, FontStyle.Bold);
                Brush sb1 = new SolidBrush(Color.Yellow);
                g1.DrawString("这个台账没有示意图！", font, sb1, 20, 20);
                pictureBox1.Image = pictureBox1.Image;
            }
            wenzi_fuzhi(zhi1);
            Text = "远望谷—铁路车号识别—台账详情：" + ID1 + "。" + username + ",欢迎您！";
            whjlb(ID1);
        }
        private void whjlb(string tz_id)
        {
            listView1.Items.Clear();
            sql_sel s3 = new sql_sel();
            ArrayList ar = new ArrayList();
            ar = s3.select_array_little("B维护记录", "R序号,R维护项目,R故障现象,R维护时间,R维护人", "R所属台账编号", ID1);
            for (int i1 = 0; i1 < ar.Count; i1++)
            {
                string[] aa = (string[])ar[i1];
                string[] ab = new string[aa.Length];
                ab[0] = (i1 + 1).ToString();
                for (int jjj = 1; jjj < aa.Length; jjj++)
                {
                    ab[jjj] = aa[jjj];
                }
                ListViewItem subitem = new ListViewItem(ab);
                listView1.Items.Add(subitem);
            }
        }
        private void whjlcsh()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("序号", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("维护项目", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("故障现象", 380, HorizontalAlignment.Left);
            listView1.Columns.Add("维护时间", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("维护人", 80, HorizontalAlignment.Left);
            listView1.FullRowSelect = true;//选择某一项后单击某项是否选择其所有子项。
            listView1.GridLines = true;//在包含控件中项及其子项的行和列之间是否显示网格线。
        }
        private void wenzi_fuzhi(string[] zhi2)
        {
            ID.Text = zhi2[0];
            mincheng.Text = zhi2[1];
            qiyeguotie.Text = zhi2[2];
            yongtu.Text = zhi2[3];
            danwei.Text = zhi2[4];
            bumen.Text = zhi2[5];
            lianxiren.Text = zhi2[6];
            dianhua.Text = zhi2[7];
            anzhuangren.Text = zhi2[8];
            anzhuangdidian.Text = zhi2[9];
            anzhuangshijian.Text = zhi2[10];
            xinhao.Text = zhi2[11];
            ZBxinhao.Text = zhi2[12];
            lianwang.Text = zhi2[13];
            fangxiang.Text = zhi2[14];
            gonglv.Text = zhi2[15];
            fanglei.Text = zhi2[16];
            TXxinhao.Text = zhi2[17];
            CGxinhao.Text = zhi2[18];
            zhanhao.Text = zhi2[19];
            SPchangdu.Text = zhi2[20];
            xuliehao.Text = zhi2[21];
            ruanjian.Text = zhi2[22];
            ip.Text = zhi2[23];
            zwym.Text = zhi2[24];
            mrwg.Text = zhi2[25];
            radminid.Text = zhi2[26];
            radminpw.Text = zhi2[27];
            cpsip.Text = zhi2[28];
            cpsid.Text = zhi2[29];
            cpspw.Text = zhi2[30];
            fengzhongxin.Text = zhi2[31];

            tieluju.Text = zhi2[32];
            beizhu.Text = zhi2[33];
            chuangjianshijian.Text = zhi2[34];
            chuangjianren.Text = zhi2[35];
            zhuangtai.Text = zhi2[36];
          
        }
        private void enable()
        {
            ID.Enabled = false;
            mincheng.Enabled = false;
            qiyeguotie.Enabled = false;
            danwei.Enabled = false;
            bumen.Enabled = false;
            lianxiren.Enabled = false;
            dianhua.Enabled = false;
            anzhuangren.Enabled = false;
            anzhuangdidian.Enabled = false;
            anzhuangshijian.Enabled = false;
            xinhao.Enabled = false;
            ZBxinhao.Enabled = false;
            lianwang.Enabled = false;
            fangxiang.Enabled = false;
            gonglv.Enabled = false;
            fanglei.Enabled = false;
            TXxinhao.Enabled = false;
            CGxinhao.Enabled = false;

            zhanhao.Enabled = false;

            SPchangdu.Enabled = false;
            xuliehao.Enabled = false;
            ruanjian.Enabled = false;
            ip.Enabled = false;
            radminid.Enabled = false;
            radminpw.Enabled = false;
            cpsip.Enabled = false;
            cpsid.Enabled = false;
            cpspw.Enabled = false;
            fengzhongxin.Enabled = false;

            tieluju.Enabled = false;
            beizhu.Enabled = false;
            chuangjianren.Enabled = false;
            chuangjianshijian.Enabled = false;
        }

        private void longbotu1_Load(object sender, EventArgs e)
        {
  
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            i = 0;
            ID1 = ids[i];
            select_zhi(ID1);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            i = ids.Length - 1;
            ID1 = ids[i];

            select_zhi(ID1);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                i = ids.Length - 1;
            }
            else
            {
                i--;
            }
            ID1 = ids[i];

            select_zhi(ID1);

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            xiayitiao();
        }
        private void xiayitiao()
        {
            if (i == ids.Length - 1)
            {
                i = 0;
            }
            else
            {
                i++;
            }
            ID1 = ids[i];

            select_zhi(ID1);

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            updata_taizhang up = new updata_taizhang();
            up.ID1 = ID1;
            up.username = username;
            up.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            del_taizhang del = new del_taizhang();
            del.username = username;
            if(del.del(ID1))
            {
                xiayitiao();
            }
        }

        private void whjl_Click(object sender, EventArgs e)
        {
            add_weihujilu whjl = new add_weihujilu();
            whjl.username = username;
            whjl.ID1 = ID1;
            whjl.StartPosition = FormStartPosition.CenterScreen;
            whjl.Show();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            sql_sel s1 = new sql_sel();
            ListView.SelectedIndexCollection indexes = listView1.SelectedIndices;
            string price = "";
            foreach (int index in indexes)
            {
                price = s1.select_dataread_all_zu_where("B维护记录", "R序号", "R所属台账编号", ID1)[index];
            }
            up_weihujilu up_wh = new up_weihujilu();
            up_wh.tz_id = ID1;
            up_wh.wh_id = price;
            up_wh.username = username;
            up_wh.Show();
           
        }

        private void shuaxin_Click(object sender, EventArgs e)
        {
            if (ID1 == null)
            {
                MessageBox.Show("没有台账！", username + "，无法打开页面！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                Text = "远望谷—铁路车号识别—台账详情：" + ID1 + "。" + username + ",欢迎您！";
                clear();
                //enable();
                i_chushi();
                select_zhi(ID1);
                whjlcsh();
            }
        }

        private void dianhua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
