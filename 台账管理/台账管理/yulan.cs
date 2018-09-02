using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 台账管理
{
    
    public partial class yulan : UserControl
    {
        public string ID ;
        public yulan()
        {
            InitializeComponent();
        }

        private void yulan_Load(object sender, EventArgs e)
        {
            try
            {
                
                clear();
              //  yulan_ll();
                shuju();
            }
            catch
            {
                clear();
               // yulan_ll();
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
        public void shuju()
        {
            if (ID != null & ID != "")
            {
                string[] read;
                sql_sel s1 = new sql_sel();
                string r1 = "R名称,R型号,R序列号,RAEI编号,R射频缆长度,RIP地址,R联系人,R联系电话,R安装人员,R安装时间,RRadmin账号,RRadmin密码";
                read = s1.select_dataread_only_zu_where("B台账", r1, "R序号", ID.ToString());
                name.Text = read[0];
                xinghao.Text = read[1];
                sn.Text = read[2];
                aei.Text = read[3];
                shepinglan.Text = read[4];
                ip.Text = read[5];
                kehuname.Text = read[6];
                phone.Text = read[7];
                anzhuangren.Text = read[8];
                DateTime date = new DateTime();
                date = Convert.ToDateTime(read[9]);
                shijian.Text = date.ToShortDateString();
                radmin.Text = read[10];
                radminpw.Text = read[11];
                string_to_img s_t1 = new string_to_img();
                img_width_change ac = new img_width_change();
                try
                {
                    Image image = Image.FromStream(new MemoryStream((byte[])s1.select_only("B示意图", "R示意图", "R所属台账编号", ID.ToString())));
                    pictureBox1.Image = ac.change(image, pictureBox1.Width, pictureBox1.Height);
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
            }
            else
            {
                clear();
            }
           
          
        }

        private void yulan_ll()
        {
            Size = new Size(890, 208);
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Size = new System.Drawing.Size(98, 18);
           
           
            this.name.Location = new System.Drawing.Point(112, 9);
           
            this.name.Size = new System.Drawing.Size(152, 18);

            this.xinghao.Location = new System.Drawing.Point(112, 43);
            this.xinghao.Size = new System.Drawing.Size(35, 18);
            this.label3.Location = new System.Drawing.Point(17, 43);
            this.label3.Size = new System.Drawing.Size(98, 18);
 
            this.aei.Location = new System.Drawing.Point(112, 111);
            this.aei.Size = new System.Drawing.Size(17, 18);

            this.label5.Location = new System.Drawing.Point(26, 111);
            this.label5.Size = new System.Drawing.Size(89, 18);

            this.sn.Location = new System.Drawing.Point(112, 77);
            this.sn.Size = new System.Drawing.Size(89, 18);
 
            this.label6.Location = new System.Drawing.Point(17, 77);
            this.label6.Size = new System.Drawing.Size(98, 18);

            this.shepinglan.Location = new System.Drawing.Point(112, 145);
            this.shepinglan.Size = new System.Drawing.Size(26, 18);
 

            this.label7.Location = new System.Drawing.Point(17, 145);
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.ip.Location = new System.Drawing.Point(112, 179);
            this.ip.Size = new System.Drawing.Size(26, 18);

            this.label4.Location = new System.Drawing.Point(35, 179);
            this.label4.Size = new System.Drawing.Size(80, 18);
 
            this.anzhuangren.Location = new System.Drawing.Point(423, 77);
            this.anzhuangren.Size = new System.Drawing.Size(89, 18);

            this.label9.Location = new System.Drawing.Point(350, 77);
            this.label9.Size = new System.Drawing.Size(80, 18);
 
            this.shijian.Location = new System.Drawing.Point(423, 111);
            this.shijian.Size = new System.Drawing.Size(17, 18);

            this.label11.Location = new System.Drawing.Point(332, 111);
            this.label11.Size = new System.Drawing.Size(98, 18);
 
            this.phone.Location = new System.Drawing.Point(423, 43);
            this.phone.Size = new System.Drawing.Size(35, 18);

            this.label13.Location = new System.Drawing.Point(332, 43);
            this.label13.Size = new System.Drawing.Size(98, 18);
 
            this.kehuname.Location = new System.Drawing.Point(423, 9);
            this.kehuname.Size = new System.Drawing.Size(44, 18);

            this.label15.Location = new System.Drawing.Point(332, 9);
            this.label15.Size = new System.Drawing.Size(98, 18);

            //this.groupBox1.Location = new System.Drawing.Point(539, 3);
           // this.groupBox1.Size = new System.Drawing.Size(348, 202);


            this.pictureBox1.Location = new System.Drawing.Point(6, 27);
            this.pictureBox1.Size = new System.Drawing.Size(336, 169);
 
            this.radmin.Location = new System.Drawing.Point(423, 145);
            this.radmin.Size = new System.Drawing.Size(26, 18);

            this.label8.Location = new System.Drawing.Point(350, 145);
            this.label8.Size = new System.Drawing.Size(80, 18);

            this.radminpw.Location = new System.Drawing.Point(423, 179);
            this.radminpw.Size = new System.Drawing.Size(26, 18);

            this.label10.Location = new System.Drawing.Point(368, 179);
            this.label10.Size = new System.Drawing.Size(62, 18);

        }
    }
}
