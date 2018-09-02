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
using System.Collections;

namespace 台账管理
{

    public partial class xuanzetupian : UserControl
    {
        public event Action<string[] ,string[],ArrayList> AfterSelectEvent;
        public  string[] leixin;//图片类型集合
        public string[] name;//文件名集合
        public  ArrayList samons = new ArrayList();//字节数组集合
        ImageList imageList1 = new ImageList();
        
        public xuanzetupian()
        {
            InitializeComponent();
        }
        private void select_img_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            listView1.View = View.LargeIcon;
            listView1.MultiSelect = false;
            imageList1.ImageSize = new Size(25, 25);
            listView1.LargeImageList = imageList1;
            string_to_img s_ti1 = new string_to_img();
            if (samons.Count != 0)
            {
                for (int i = 0; i < samons.Count; i++)
                {
                    imageList1.Images.Add(s_ti1.byte_img((byte[])samons[i], leixin[i]));
                }
            }
            for (int i = 0; i < samons.Count; i++)
            {
                string_to_img sti1 = new string_to_img();
                array_jian arr_add = new array_jian();
                sti1.byte_img((byte[])samons[i],leixin[i]);              
                listView1.Items.Insert(listView1.Items.Count, new ListViewItem(name[i]));
                listView1.Items[i].ImageIndex = i;
            }
        }

        private void sel_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdl1 = new OpenFileDialog();
            fdl1.Title = "添加图片";
            fdl1.Filter = "图像文件(*.jpeg/jpg;*.bmp;*.png;*.gif)|*.jpeg;*.jpg;*.bmp;*.png;*.gif";
            fdl1.InitialDirectory = "D:\\";
            fdl1.Multiselect = true;
            fdl1.ShowDialog();

          //  name = new string[fdl1.FileNames.Length];
          //  leixin = new string[fdl1.FileNames.Length];
           
            for (int i = 0; i < fdl1.FileNames.Length; i++)
            {
                img_to_string img_to1 = new img_to_string();
                array_jian arr_add = new array_jian();
                img_to1.img_string(fdl1.FileNames[i]);
                leixin = arr_add.add_one(leixin, img_to1.leixin);
                // leixin[i] = img_to1.leixin;
                name = arr_add.add_one(name, img_to1.name);
                //name[i] = img_to1.name;

                listView1.Items.Insert(listView1.Items.Count, new ListViewItem(name[i]));

                samons.Add(img_to1.bytes);
                imageList1.Images.Add(img_to1.img1);
                listView1.Items[listView1.Items.Count-1].ImageIndex = samons.Count-1;
            }
            AfterSelectEvent(leixin,name,samons);
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            array_jian ar1 = new array_jian();
            int v = listView1.SelectedIndices[0];
            listView1.Items.RemoveAt(v);
            imageList1.Images.RemoveAt(v);
            samons.RemoveAt(v);
            leixin = ar1.str(v, leixin);
            name = ar1.str(v, name);
            AfterSelectEvent(leixin, name, samons);
        }
    }
}
