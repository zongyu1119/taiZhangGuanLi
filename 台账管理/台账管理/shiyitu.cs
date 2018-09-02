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
    public delegate void syt_cd(byte[] bytes1);
    public partial class shiyitu : Form
    {
        public byte[] bytes_shiyitu;//传出的image转为字节数组
        public string tzid;
        int x, y;
        Point  startp, endp;
        Pen pen1;
        SolidBrush Sb1;
        Rectangle rec1;
        Font font;
        string shibie;
        public string username;

        int rec_width, rec_height;

        public shiyitu()
        {
            InitializeComponent();
        }

        private void shiyitu_Load(object sender, EventArgs e)
        {
            AcceptButton = save_img;

            Text = "远望谷—铁路车号识别—台账示意图。" + username + ",欢迎您！";

            this.Size = new Size(1390, 668);
            font = new Font("黑体", 20, FontStyle.Bold);
            pen1 = new Pen(Color.Black);
            Sb1 = new SolidBrush(Color.Black);
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in a)
            {
                pen_width.Items.Add(i.ToString());
            }
            string[] b = { "1#", "2#", "3#", "4#", "接线盒", "磁钢", "上行", "下行" };
            text.Items.AddRange(b);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            shibie = "Line";
            
            pictureBox1.Image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            sql_sel s1 = new sql_sel();
            try
            {
                byte[] syt_bytes = (byte[])s1.select_only("B示意图", "R示意图", "R所属台账编号", tzid);
                string_to_img sti1 = new string_to_img();
                img_width_change iwc1 = new img_width_change();
                pictureBox1.Image = iwc1.change(sti1.byte_img(syt_bytes, "jpg"), pictureBox1.Width, pictureBox1.Height);
            }
            catch
            {
                /*
                Graphics g1 = Graphics.FromImage(pictureBox1.Image);
                g1.FillRectangle(Brushes.White, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height)); //涂成白色
                Font font = new Font("黑体", 20, FontStyle.Bold);
                Brush sb1 = new SolidBrush(Color.Yellow);
                g1.DrawString("这个台账没有示意图！", font, sb1, 20, 20);
                pictureBox1.Image = pictureBox1.Image;
                */
                clear();
            }
        }
        private void GG_Click(object sender, EventArgs e)
        {
            shibie = "GG";
        }

        private void TX_Click(object sender, EventArgs e)
        {
            shibie = "TX";
        }

        private void CG_Click(object sender, EventArgs e)
        {
            shibie = "CG";
        }

        private void GBX_Click(object sender, EventArgs e)
        {
            shibie = "GBX";
        }

        private void JF_Click(object sender, EventArgs e)
        {
            shibie = "JF";
        }

        private void jian_Click(object sender, EventArgs e)
        {
            shibie = "jian";
        }

        private void rec_line_Click(object sender, EventArgs e)
        {
            shibie = "rec_line";
        }

        private void rec_fill_Click(object sender, EventArgs e)
        {
            shibie = "rec_fill";
        }

        private void Line_Click(object sender, EventArgs e)
        {
            shibie = "Line";
        }

        private void JXH_Click(object sender, EventArgs e)
        {
            shibie = "JXH";
        }

        public void line()
        {
            Graphics g1 = Graphics.FromImage(pictureBox1.Image);
            g1.DrawLine(pen1, startp, endp);
            pictureBox1.Image = pictureBox1.Image;

        }
        public void ganggui()
        {
            Graphics g1 = Graphics.FromImage(pictureBox1.Image);
            g1.DrawLine(pen1, startp, endp);
            g1.DrawLine(pen1, startp.X, startp.Y + 80, endp.X, endp.Y + 80);
            pictureBox1.Image = pictureBox1.Image;

        }
        public void jiantou()
        {
            Graphics g1 = Graphics.FromImage(pictureBox1.Image);
            g1.DrawLine(pen1, startp, endp);
            g1.DrawLine(pen1, endp.X, endp.Y, endp.X - 10, endp.Y + 8);
            g1.DrawLine(pen1, endp.X, endp.Y, endp.X - 10, endp.Y - 8);
            pictureBox1.Image = pictureBox1.Image;

        }

        private void line_color_Click(object sender, EventArgs e)
        {
            ColorDialog color1 = new ColorDialog();
            color1.AllowFullOpen = true;
            color1.AnyColor = true;
            color1.SolidColorOnly = false;
            if (color1.ShowDialog() == DialogResult.OK)
            {
                pen1.Color = color1.Color;
            }
        }

        private void fill_color_Click(object sender, EventArgs e)
        {
            ColorDialog color1 = new ColorDialog();
            color1.AllowFullOpen = true;
            color1.AnyColor = true;
            color1.SolidColorOnly = false;
            if (color1.ShowDialog() == DialogResult.OK)
            {
                Sb1.Color = color1.Color;
            }
        }

        public void jifang()
        {
            Graphics g1 = Graphics.FromImage(pictureBox1.Image);
            rec_width = 200;
            rec_height = 120;
            rec1 = new Rectangle(x, y, rec_width, rec_height);
            Sb1.Color = Color.Blue;
            g1.FillRectangle(Sb1, rec1);
            rec_width = 180;
            rec_height = 100;
            rec1 = new Rectangle(x + 10, y + 10, rec_width, rec_height);
            pen1.Color = Color.Yellow;
            pen1.Width = 2;
            Sb1.Color = Color.White;
            g1.FillRectangle(Sb1, rec1);
            Sb1.Color = Color.Black;
            g1.DrawString("机房", font, Sb1, rec1);
            pictureBox1.Image = pictureBox1.Image;

        }
        public void guibianxiang()
        {
            Graphics g1 = Graphics.FromImage(pictureBox1.Image);
            rec_width = 120;
            rec_height = 60;
            rec1 = new Rectangle(x, y, rec_width, rec_height);
            Sb1.Color = Color.Blue;
            g1.FillRectangle(Sb1, rec1);
            rec_width = 100;
            rec_height = 40;
            rec1 = new Rectangle(x + 10, y + 10, rec_width, rec_height);
            Sb1.Color = Color.White;
            g1.FillRectangle(Sb1, rec1);
            Sb1.Color = Color.Black;
            g1.DrawString("轨边箱", font, Sb1, rec1);
            pictureBox1.Image = pictureBox1.Image;

        }

        private void pen_width_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen1.Width = int.Parse(pen_width.Text);
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            switch (shibie)
            {
                case "TX":
                    tianxian();
                    break;
                case "CG":
                    cigang();
                    break;
                case "JXH":
                    jiexianhe();
                    break;
                case "GBX":
                    guibianxiang();
                    break;
                case "JF":
                    jifang();
                    break;
                case "text":
                    wenzi();
                    break;

            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            startp.X = e.X;
            startp.Y = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            endp.X = e.X;
            endp.Y = e.Y;
            if (shibie == "GG")
            {
                ganggui();
            }
            if (shibie == "jian")
            {
                jiantou();
            }
            if (shibie == "Line")
            {
                line();
            }
            if (shibie == "rec_line")
            {
                xiantiaojuxing();
            }
            if (shibie == "rec_fill")
            {
                tianchongjuxing();
            }
        }

        private void text_box_Click(object sender, EventArgs e)
        {
            shibie = "text";
        }

        private void clear()
        {
            int i = pictureBox1.Width;
            int j = pictureBox1.Height;
            Bitmap b1 = new Bitmap(i, j); //新建位图b1
            Graphics g2 = Graphics.FromImage(b1); //创建b1的Graphics
            g2.FillRectangle(Brushes.White, new Rectangle(0, 0, i, j)); //把b1涂成红色
            //b1.Save(@"D:\p1.bmp"); //把b1存到D盘
            pictureBox1.Image = b1;
        }
        private void clear_all_Click(object sender, EventArgs e)
        {
            int i = pictureBox1.Width;
            int j = pictureBox1.Height;
            Bitmap b1 = new Bitmap(i, j); //新建位图b1
            Graphics g2 = Graphics.FromImage(b1); //创建b1的Graphics
            g2.FillRectangle(Brushes.White, new Rectangle(0, 0, i, j)); //把b1涂成红色
            //b1.Save(@"D:\p1.bmp"); //把b1存到D盘
            pictureBox1.Image = b1;
        }

        private void from_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdl1 = new OpenFileDialog();
            fdl1.Title = "选择图片";

            fdl1.Filter = "图像文件(*.jpeg/jpg;*.bmp;*.png;*.gif)|*.jpeg;*.jpg;*.bmp;*.png;*.gif";
            fdl1.InitialDirectory = "D:\\";
            fdl1.Multiselect = false;
            fdl1.ShowDialog();

            Image imgs = Image.FromFile(fdl1.FileName);
            //画板大小
            int towidth = pictureBox1.Width;
            int toheight = pictureBox1.Height;

            int ow = imgs.Width;
            int oh = imgs.Height;

            if (ow > oh)
            {
                toheight = imgs.Height * pictureBox1.Width / imgs.Width;
            }
            else
            {
                towidth = imgs.Width * pictureBox1.Height / imgs.Height;
            }
            //新建一个bmp图片
            Image bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //新建一个画板
            Graphics gs = Graphics.FromImage(bm);
            //设置高质量插值法
            gs.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            //设置高质量,低速度呈现平滑程度
            gs.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //清空画布并以透明背景色填充
            gs.Clear(Color.White);
            //在指定位置并且按指定大小绘制原图片的指定部分
            gs.DrawImage(imgs, new Rectangle((pictureBox1.Width - towidth) / 2, (pictureBox1.Height - toheight) / 2, towidth, toheight),
                0, 0, ow, oh,
                GraphicsUnit.Pixel);

            pictureBox1.Image = bm;

        }
        public event syt_cd setbytevlues;

        private void save_img_Click(object sender, EventArgs e)
        {
            Image img2 = pictureBox1.Image;

            MemoryStream mss = new MemoryStream();//创建一个流，其后备存储为内存。  
            Bitmap jpg1 = new Bitmap(img2);
            jpg1.Save(mss, System.Drawing.Imaging.ImageFormat.Jpeg);
            bytes_shiyitu = mss.ToArray();

            setbytevlues(this.bytes_shiyitu);

        }



        public void tianxian()
        {
            Graphics g1 = Graphics.FromImage(pictureBox1.Image);
            rec_width = 40;
            rec_height = 80;
            rec1 = new Rectangle(x, y, rec_width, rec_height);
            Sb1.Color = Color.Blue;
            g1.FillRectangle(Sb1, rec1);
            rec_width = 30;
            rec_height = 70;
            rec1 = new Rectangle(x + 5, y + 5, rec_width, rec_height);
            Sb1.Color = Color.CadetBlue;
            g1.FillRectangle(Sb1, rec1);
            Sb1.Color = Color.Black;
            g1.DrawString("天线", font, Sb1, rec1);
            pictureBox1.Image = pictureBox1.Image;

        }
        public void jiexianhe()
        {
            Graphics g1 = Graphics.FromImage(pictureBox1.Image);
            rec_width = 40;
            rec_height = 40;
            rec1 = new Rectangle(x, y, rec_width, rec_height);
            Sb1.Color = Color.CadetBlue;
            g1.FillRectangle(Sb1, rec1);
            pictureBox1.Image = pictureBox1.Image;

        }
        public void cigang()
        {
            Graphics g1 = Graphics.FromImage(pictureBox1.Image);
            rec_width = 25;
            rec_height = 25;
            rec1 = new Rectangle(x, y, rec_width, rec_height);
            Sb1.Color = Color.Gray;
            g1.FillRectangle(Sb1, rec1);
            pictureBox1.Image = pictureBox1.Image;

        }
        public void tianchongjuxing()
        {
            Graphics g1 = Graphics.FromImage(pictureBox1.Image);
            rec_width = endp.X - startp.X;
            rec_height = endp.Y - startp.Y;
            rec1 = new Rectangle(startp.X, startp.Y, rec_width, rec_height);
            g1.FillRectangle(Sb1, rec1);
            pictureBox1.Image = pictureBox1.Image;
        }
        public void xiantiaojuxing()
        {
            Graphics g1 = Graphics.FromImage(pictureBox1.Image);
            rec_width = endp.X - startp.X;
            rec_height = endp.Y - startp.Y;
            rec1 = new Rectangle(startp.X, startp.Y, rec_width, rec_height);
            g1.DrawRectangle(pen1, rec1);
            pictureBox1.Image = pictureBox1.Image;

        }
        public void wenzi()
        {
            Graphics g1 = Graphics.FromImage(pictureBox1.Image);
            g1.DrawString(text.Text, font, Sb1, x, y);
            pictureBox1.Image = pictureBox1.Image;

        }
    }
}
