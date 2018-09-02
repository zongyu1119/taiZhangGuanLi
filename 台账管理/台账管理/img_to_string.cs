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
    class img_to_string
    {
        public string leixin;//传出的image后缀
        public string name;//传出的文件名
        public byte[] bytes;//传出的image转为字节数组
        public Image img1;//传出的图片

        public void img_string(string path)
        {

            //初始化类
            MemoryStream ms = new MemoryStream();//创建一个流，其后备存储为内存。  
            Bitmap bmp = new Bitmap(Image.FromFile(path));
            FileInfo fI1 = new FileInfo(path);
            leixin = fI1.Extension;
            name = fI1.Name;
            switch (fI1.Extension)
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
            
            //ms.Flush();//重写 Stream.Flush 方法以便不执行任何操作。（覆盖 Stream.Flush()。）
            //将二进制数据存到byte数字中
            bytes= ms.ToArray();
            img1 = Image.FromStream(ms);

            ms.Close();
        }
    }
}
