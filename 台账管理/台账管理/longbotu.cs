using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace 台账管理
{
    public partial class longbotu : UserControl
    {
        public ArrayList arry = new ArrayList();
        public string[] leixin;
        int i = 0;
        Image[] img;
        public longbotu()
        {
            InitializeComponent();
         
        }
        private void noimg()
        {
            Graphics g1 = Graphics.FromImage(pictureBox1.Image);
            g1.FillRectangle(Brushes.White, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height)); //涂成白色

            Font font = new Font("黑体", 20, FontStyle.Bold);
            Brush sb1 = new SolidBrush(Color.Black);
            g1.DrawString("这个台账没有图片！", font, sb1, 20, 20);
            pictureBox1.Image = pictureBox1.Image;
        }

        private void lunbotu_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {

            Bitmap b1 = new Bitmap(pictureBox1.Width, pictureBox1.Height); //新建位图b1
            Graphics g2 = Graphics.FromImage(b1); //创建b1的Graphics
            g2.FillRectangle(Brushes.White, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height)); //把b1涂成白色
            pictureBox1.Image = b1;
            noimg();
            img = new Image[arry.Count];
            if (arry.Count == 0)
            {
                noimg();
            }
            else
            {
                string_to_img strt1 = new string_to_img();
                img_width_change imgc1 = new img_width_change();
                for (int j = 0; j < arry.Count; j++)
                {
                    img[j] = strt1.byte_img((byte[])arry[j], leixin[j]);
                    img[j] = imgc1.change(img[j], pictureBox1.Width, pictureBox1.Height);
                }
                i = 0;
                pictureBox1.Image = img[i];
            }
            Button_load();
        }
        private void Button_load()
        {
            button2.Parent = this.pictureBox1;//将button父控件设为背景图片控件
            button1.Parent = this.pictureBox1;//将button父控件设为背景图片控件

            button1.FlatStyle = FlatStyle.Flat;//样式
            button1.ForeColor = Color.Transparent;//前景
            button1.BackColor = Color.Transparent;//去背景
            button1.FlatAppearance.BorderSize = 0;//去边线
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;//鼠标经过
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;//鼠标按下

            button2.FlatStyle = FlatStyle.Flat;//样式
            button2.ForeColor = Color.Transparent;//前景
            button2.BackColor = Color.Transparent;//去背景
            button2.FlatAppearance.BorderSize = 0;//去边线
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;//鼠标经过
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;//鼠标按下
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen1 = new Pen(Color.Yellow);
            pen1.Width = 5;
            Point p1 = new Point(button2.Width, 0);
            Point p2 = new Point(5, button2.Height / 2);
            Point p3 = new Point(button2.Width, button2.Height);
            Point[] ps = { p1, p2, p3 };

            g.DrawCurve(pen1, ps, 0.2f);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (img.Length != 0)
            {
                if (i < img.Length - 1)
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
                pictureBox1.Image = img[i];
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (img.Length != 0)
            {
                if (i > 0)
                {
                    i--;
                }
                else
                {
                    i = img.Length - 1;
                }
                pictureBox1.Image = img[i];
            }
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g22 = e.Graphics;
            Pen pen1 = new Pen(Color.Yellow);
            pen1.Width = 5;
            Point p1 = new Point(0, 0);
            Point p2 = new Point(button1.Width - 5, button1.Height / 2);
            Point p3 = new Point(0, button1.Height);
            Point[] ps = { p1, p2, p3 };
            g22.DrawCurve(pen1, ps, 0.2f);
        }
    }
}
