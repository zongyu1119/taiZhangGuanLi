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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public string username;

        private void login_btn_Click(object sender, EventArgs e)
        {
            UserName.Text = "1";
            Password.Text = "1";
            username = UserName.Text;
            try
            {
                if (username == null || username == "")
                {
                    MessageBox.Show("用户名不能为空，请重试", "错误", MessageBoxButtons.OK);
                    username = null;
                }
                else
                {
                    if (Password.Text == null || Password.Text == "")
                    {
                        MessageBox.Show("密码不能为空，请重试", "错误", MessageBoxButtons.OK);
                        username = null;
                    }
                    else
                    {

                        sql_sel sq1 = new sql_sel();
                        string mima = sq1.select_only("B用户", "R密码", "R姓名", username).ToString();
                        mima = mima.Replace(" ", "");//替换空格
                        if (Password.Text == mima)
                        {
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("密码错误，请重试", "错误", MessageBoxButtons.OK);
                            username = null;
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("该用户不存在，请重试", "错误", MessageBoxButtons.OK);
                username = null;
            }
           
        }

        private void qx_Click(object sender, EventArgs e)
        {
            username = null;
            this.Close();
            
        }

        private void login_Load(object sender, EventArgs e)
        {
            AcceptButton = login_btn;
        }
    }
}
