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
    public partial class new_Taizhang : Form
    {
        
        public string username;
        public byte[] shiyitu;
        public ArrayList samons=new ArrayList();
        public string[] leixin;
        public string[] name;
        public new_Taizhang()
        {
            InitializeComponent();
        }

        private void new_Taizhang_Load(object sender, EventArgs e)
        {
            AcceptButton = save;

            Text = "远望谷—铁路—新建台账。" + username + ",欢迎您！";
            csz();
            xuanzetupian1.AfterSelectEvent += new Action<string[], string[], ArrayList>(xuanzetupian_AfterSelectEvent);
            //  im1.Show();
        }
        private void xuanzetupian_AfterSelectEvent(string[] lx, string[] nm, ArrayList sa)
        {
            leixin = lx;
            name = nm;
            samons = sa;
        }
        void img_ccz(ArrayList sa, string[] leixin1, string[] name1)
        { 
            samons = sa;
            leixin = leixin1;
            name = name1;
        }
        private void shiyitu_btn_Click(object sender, EventArgs e)
        {
            shiyitu syt1 = new shiyitu();
            syt1.StartPosition = FormStartPosition.CenterScreen;
            syt1.setbytevlues += new syt_cd(syt_sytcd);
            syt1.Show();
        }
        void syt_sytcd(byte[] Value)
        {
            //具体实现。
            this.shiyitu = Value;
        }
        private void save_Click(object sender, EventArgs e)
        {
            user_x ux1 = new user_x(username, "添加", "台账");
            sql_sel s1 = new sql_sel();
            ux1.insert_log(mincheng.Text);
            MessageBox.Show("添加了" + s1.insert_only("B台账", dbo(), values()) + "条数据！台账里有"+img_add()+"张图片,"+shiyitu_add()+"示意图！", "提示", MessageBoxButtons.OK);
            ID.Text = Convert.ToString(int.Parse(ID.Text) + 1);
        }
        private string  shiyitu_add()
        {
            sql_sel s1 = new sql_sel();
            string  sytx="没有";
            string[] r1 = { "R示意图", "R所属台账编号" };
            try
            {
                string[] v = { ID.Text };
                if (s1.insert_img("B示意图", r1, shiyitu, v) == 1)
                    sytx = "有";
            }
            catch
            {
                sytx = "没有";
            }
            return sytx;
        }
        private int img_add()
        {
            
            sql_sel s1 = new sql_sel();
            int xxx = 0;
            string[] r = { "R图片", "R图片名称", "R图片类型", "R所属台账序号" };
             try
             {
               for (int j = 0; j < samons.Count; j++)
                {
                    string[] v = { name[j], leixin[j], ID.Text };
                    xxx = s1.insert_img("B图片", r, (byte[])samons[j], v) + xxx;
                }
             }
            catch
            {
                xxx = 0;
            }
            return xxx;
        }
        private void csz()
        {
            sql_sel s2 = new sql_sel();

            ID.Text=Convert.ToString(int.Parse(s2.select_last("B台账","R序号"))+1);
            mincheng.Text="AEI设备台账";
            string[] qg = { "国铁", "企业" };
            qiyeguotie.Items.AddRange(qg);
            qiyeguotie.SelectedIndex = 0;
            string[] yt1 = s2.select_dataread_all_zu("B用途", "R用途");
            yongtu.Items.AddRange(yt1);
            yongtu.SelectedIndex = 0;
            danwei.Text=" ";
            bumen.Text=" ";
            lianxiren.Text=" ";
            dianhua.Text=" ";
            anzhuangren.Text=" ";
            anzhuangdidian.Text=" ";
            string[] read = s2.select_dataread_all_zu_where("B设备型号", "R型号", "R名称", "主机");
            xinhao.Items.AddRange(read);
            xinhao.SelectedIndex = 0;
            string[] read1 = s2.select_dataread_all_zu_where("B设备型号", "R型号", "R名称", "主板");
            ZBxinhao.Items.AddRange(read1);
            ZBxinhao.SelectedIndex = 0;
            string[] lw = { "网络", "串口" };
            lianwang.Items.AddRange(lw);
            lianwang.SelectedIndex = 0;
            string[] fx = { "上行", "下行", "入场", "出场" };
            fangxiang.Items.AddRange(fx);
            fangxiang.SelectedIndex = 0;
            string[] gl = { "28", "29", "30", "31", "32" };
            gonglv.Items.AddRange(gl);
            gonglv.SelectedIndex = 4;
            string[] fl = { "有防雷", "无防雷" };
            fanglei.Items.AddRange(fl);
            fanglei.SelectedIndex = 0;
            string[] readtx = s2.select_dataread_all_zu_where("B设备型号", "R型号", "R名称", "天线");
            TXxinhao.Items.AddRange(readtx);
            TXxinhao.SelectedIndex = 0;
            string[] readcg = s2.select_dataread_all_zu_where("B设备型号", "R型号", "R名称", "磁钢");
            CGxinhao.Items.AddRange(readcg);
            CGxinhao.SelectedIndex = 0;
            string[] zh = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" };
            zhanhao.Items.AddRange(zh);
            zhanhao.SelectedIndex = 0;
            string[] cd = { "15", "20", "25", "30", "40" };
            SPchangdu.Items.AddRange(cd);
            SPchangdu.SelectedIndex = 3;
            xuliehao.Text="AEI-";
            ruanjian.Text=" ";
            ip.Text="10.";
            radminid.Text="admin";
            radminpw.Text="000000";
            cpsip.Text="10.";
            cpsid.Text="admin";
            cpspw.Text="000000";
            string[] readfzx = s2.select_dataread_all_zu("B分中心", "R分中心");
            fengzhongxin.Items.AddRange(readfzx);
            fengzhongxin.SelectedIndex = 0;
            
            string[] readtlu = s2.select_dataread_all_zu_where("B铁路局", "R铁路局","R所属分中心", fengzhongxin.Text);//这个方法调用是SB
            tieluju.Items.AddRange(readtlu);
            tieluju.SelectedIndex = 0;
            beizhu.Text=" ";

            string[] zt1 = s2.select_dataread_all_zu("B安装状态", "R安装状态");
            zhuangtai.Items.AddRange(zt1);
            zhuangtai.SelectedIndex = 0;
        }
        private string [] dbo()
        {
            string[] db=new string[37];
            db[0] = "R序号";
            db[1] = "R名称";
            db[2] = "R是否企业";
            db[3] = "R用途";
            db[4] = "R单位";
            db[5] = "R部门";
            db[6] = "R联系人";
            db[7] = "R联系电话";
            db[8] = "R安装人员";
            db[9] = "R安装地址";
            db[10] = "R安装时间";
            db[11] = "R型号";
            db[12] = "R主板型号";
            db[13] = "R联网方式";
            db[14] = "R接车方向";
            db[15] = "RRF功率";
            db[16] = "R防雷组件";
            db[17] = "R天线型号";
            db[18] = "R磁钢型号";
            db[19] = "RAEI编号";
            db[20] = "R射频缆长度";
            db[21] = "R序列号";
            db[22] = "R程序版本";
            db[23] = "RIP地址";
            db[24] = "R子网掩码";
            db[25] = "R默认网关";
            db[26] = "RRadmin账号";
            db[27] = "RRadmin密码";
            db[28] = "RCPSIP";
            db[29] = "RCPSRadmin账号"; 
            db[30] = "RCPSRadmin密码";
            db[31] = "R所属分中心"; 
            db[32] = "R所属铁路局";
            db[33] = "R备注";
            db[34] = "R创建时间";
            db[35] = "R创建人";
            db[36] = "R安装状态";

            return db;
        }
        private string[] values()
        {
            string[] vl = new string[37];
            vl[0] = ID.Text;
            vl[1] = mincheng.Text;
            vl[2] = qiyeguotie.Text;
            vl[3] = yongtu.Text;
            vl[4] = danwei.Text;
            vl[5] = bumen.Text;
            vl[6] = lianxiren.Text;
            vl[7] = dianhua.Text;
            vl[8] = anzhuangren.Text;
            vl[9] = anzhuangdidian.Text;
            vl[10] = anzhuangshijian.Value.ToString();
            vl[11] = xinhao.Text;
            vl[12] = ZBxinhao.Text;
            vl[13] = lianwang.Text;
            vl[14] = fangxiang.Text;           
            vl[15] = gonglv.Text;
            vl[16] = fanglei.Text;
            vl[17] = TXxinhao.Text;
            vl[18] = CGxinhao.Text;
            vl[19] = zhanhao.Text;
            vl[20] = SPchangdu.Text;
            vl[21] = xuliehao.Text;
            vl[22] = ruanjian.Text;
            vl[23] = ip.Text;
            vl[24] = zwym.Text;
            vl[25] = mrwg.Text;
            vl[26] = radminid.Text;
            vl[27] = radminpw.Text;
            vl[28] = cpsip.Text;
            vl[29] = cpsid.Text;
            vl[30] = cpspw.Text;
            vl[31] = fengzhongxin.Text;
            vl[32] = tieluju.Text;
            vl[33] = beizhu.Text;
            vl[34] = DateTime.Now.ToString();
            vl[35] = username;
            vl[36] = zhuangtai.Text;
            return vl;
        }

        private void fengzhongxin_SelectedIndexChanged(object sender, EventArgs e)
        {
            tieluju.Items.Clear();
            try
            {
                sql_sel s2 = new sql_sel();
                string[] readtlu = s2.select_dataread_all_zu_where("B铁路局", "R铁路局", "R所属分中心", fengzhongxin.Text);
                tieluju.Items.AddRange(readtlu);
                tieluju.SelectedIndex = 0;
            }
            catch
            {
                tieluju.Items.Add(" ");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
