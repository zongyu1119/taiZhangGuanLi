using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 台账管理
{
    class img_width_change
    {
        public Image change(Image imgs,int width,int height)
        {
            int ow = imgs.Width; //画板大小
            int oh = imgs.Height;

            int toheight=height, towidth=width;
            if (ow > oh)
            {
                toheight = imgs.Height * width / imgs.Width;
            }
            else
            {
                towidth = imgs.Width * height / imgs.Height;
            }
            //新建一个bmp图片
            Image bm = new Bitmap(width, height);
            //新建一个画板
            Graphics gs = Graphics.FromImage(bm);
            //设置高质量插值法
            gs.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            //设置高质量,低速度呈现平滑程度
            gs.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //清空画布并以透明背景色填充
            gs.Clear(Color.White);
            //在指定位置并且按指定大小绘制原图片的指定部分
            gs.DrawImage(imgs, new Rectangle((width - towidth) / 2, (height - toheight) / 2, towidth, toheight),
                0, 0, ow, oh,
                GraphicsUnit.Pixel);

            return bm;
        }
 
                
    }
}
