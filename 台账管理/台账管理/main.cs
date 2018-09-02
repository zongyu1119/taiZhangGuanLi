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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        public string username;
        private void main_Load(object sender, EventArgs e)
        {
            login1();
            Text = "远望谷—客服中心管理平台。" + username + ",欢迎您！";
            caozuo_list();
            time();
            user_x ux = new user_x(username);
            mean.Visible = false;
            if (int.Parse(ux.dengji()) > 1)
            {
                mean.Visible = true;
            }
        }
        void login1()
        {
            login login1 = new login();
            login1.StartPosition = FormStartPosition.CenterScreen;
            object obj = login1.ShowDialog();//实现登录
            username = login1.username;
        }
        void timer()
        {
            caozuo_list();
            time();
        }
        private void caozuo_list()
        {
            caozuojilu.Items.Clear();
            sql_sel s1 = new sql_sel();
           ArrayList list= s1.select_array_all_order("B操作记录", "*","R序号","desc");
            foreach(string[] i in list)
            {
                caozuojilu.Items.Add(i[5]+"   "+i[4] +"  "+ i[3] + "了" + i[2] + "  " + i[1] );
            }
        }
        private void time()
        {
            DateTime date = DateTime.Now;
            time_now.Text ="当前时间："+ date.ToShortDateString()+"   "+date.ToShortTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer();
        }

        private void xinhao_Click(object sender, EventArgs e)
        {
            xinhao xh = new xinhao();
            xh.username = username;
            xh.StartPosition = FormStartPosition.CenterScreen;
            xh.Show();
        }

        private void taizhangguanli_Click(object sender, EventArgs e)
        {
            Taizhng t1 = new Taizhng();
            t1.username = username;
            t1.StartPosition = FormStartPosition.CenterScreen;
            t1.Show();
        }
    }
}
