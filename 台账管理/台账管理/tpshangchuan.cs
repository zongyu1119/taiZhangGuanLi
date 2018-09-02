using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 台账管理
{
    public partial class tpshangchuan : Form
    {
        public tpshangchuan()
        {
            InitializeComponent();
        }
        byte[] byte1;
        private void from_file_Click(object sender, EventArgs e)
        {

            OpenFileDialog fdl1 = new OpenFileDialog();
            fdl1.Title = "选择图片";
            fdl1.Filter = "图像文件(*.jpeg/jpg;*.bmp;*.png;*.gif)|*.jpeg;*.jpg;*.bmp;*.png;*.gif";
            fdl1.InitialDirectory = "D:\\";
            fdl1.Multiselect = false;
            fdl1.ShowDialog();
            Image imgs = Image.FromFile(fdl1.FileName);
            img_width_change a = new img_width_change();
            imgs = a.change(imgs, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = imgs;
            byte1 = File.ReadAllBytes(@fdl1.FileName);
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string teshuleixin = "@image";
            sql_sel s1 = new sql_sel();
            s1.conn();
            string sql = "insert into dbo.pic(image) values ("+teshuleixin+")";
            s1.sql_insert(sql,byte1,teshuleixin);
            s1.close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql_sel s1 = new sql_sel();
            s1.conn();
            string sql = "select image From dbo.pic where ID='" + textBox1.Text + "'";
            byte[] b= (byte[])s1.select(sql);
            File.WriteAllBytes(@"D:\read.gif", b);
            s1.close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql_sel s1 = new sql_sel();
            s1.conn();
            string sql = "select R示意图 From dbo.B示意图 where R所属台账编号='" + textBox1.Text+"'";
            byte[] b = (byte[])s1.select(sql);
            MemoryStream ms = new MemoryStream(b);
            Image image = System.Drawing.Image.FromStream(ms);
            img_width_change a = new img_width_change();
            image = a.change(image, pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Image = image;
            s1.close();
        }
    }
}
