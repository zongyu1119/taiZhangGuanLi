using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 台账管理
{
    class string_to_img
    {
        string path;//转出保存image的路径
        public Image img1;//传出的图片

        public Image byte_img(byte[] byte_str, string a)//str是图片string字符串，a是文件名后缀；
        {
            MemoryStream ms = new MemoryStream();//创建一个流，其后备存储为内存。
            Bitmap bmp = new Bitmap(new MemoryStream(byte_str));
            switch (a)
            {
                case ".png":
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    break;
                case ".bmp":
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    break;
                case ".gif":
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                    break;
                default:
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
            }
            img1 = Image.FromStream(ms);
            ms.Close();
            return img1;
        }

        void string_img(byte[] byte_str, string a)//str是图片string字符串，a是文件名后缀；
        {
            MemoryStream ms = new MemoryStream();//创建一个流，其后备存储为内存。
            Bitmap bmp = new Bitmap(new MemoryStream(byte_str));
            switch (a)
            {
                case ".png":
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    break;
                case ".bmp":
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    break;
                case ".gif":
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                    break;
                default:
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
            }
            img1 = Image.FromStream(ms);
            ms.Close();
        }



        void string_img_path(byte[] byte_str, string a)//str是图片string字符串，a是文件名后缀；
        {
            MemoryStream ms = new MemoryStream();//创建一个流，其后备存储为内存。

            Bitmap bmp = new Bitmap(new MemoryStream(byte_str));
            string apppath = Application.StartupPath;
            DirectoryInfo Dinfo = new DirectoryInfo(apppath + "\\images");
            if (!Dinfo.Exists)
            {
                Dinfo.Create();
            }

            path = apppath + "\\images\\" + Guid.NewGuid().ToString() + a;
            switch (a)
            {
                case ".png":
                    bmp.Save(path, System.Drawing.Imaging.ImageFormat.Png);
                    break;
                case ".bmp":
                    bmp.Save(path, System.Drawing.Imaging.ImageFormat.Bmp);
                    break;
                case ".gif":
                    bmp.Save(path, System.Drawing.Imaging.ImageFormat.Gif);
                    break;
                default:
                    bmp.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
            }
            ms.Close();
        }
    }
}
