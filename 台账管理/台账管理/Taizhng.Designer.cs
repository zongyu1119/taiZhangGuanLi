namespace 台账管理
{
    partial class Taizhng
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.select_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.updata_btn = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.全部展开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.new_jilu = new System.Windows.Forms.Button();
            this.youjicaidan_list = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看详细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改台账ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增台账ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增维护记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除台账ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.my_wh = new System.Windows.Forms.MenuStrip();
            this.my_info = new System.Windows.Forms.ToolStripMenuItem();
            this.my_creat = new System.Windows.Forms.ToolStripMenuItem();
            this.my_whsb = new System.Windows.Forms.ToolStripMenuItem();
            this.my_anzhuan = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.jishu = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.zhuangtai_shai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yongtu_shai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.xinhao_shai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date_min = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.date_max = new System.Windows.Forms.DateTimePicker();
            this.yulan1 = new 台账管理.yulan();
            this.contextMenuStrip1.SuspendLayout();
            this.youjicaidan_list.SuspendLayout();
            this.my_wh.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // select_btn
            // 
            this.select_btn.AutoSize = true;
            this.select_btn.Location = new System.Drawing.Point(887, 4);
            this.select_btn.Margin = new System.Windows.Forms.Padding(4);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(108, 29);
            this.select_btn.TabIndex = 12;
            this.select_btn.Text = "关键字查找";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(527, 4);
            this.del_btn.Margin = new System.Windows.Forms.Padding(4);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(90, 29);
            this.del_btn.TabIndex = 11;
            this.del_btn.Text = "删除选中";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // updata_btn
            // 
            this.updata_btn.Location = new System.Drawing.Point(365, 4);
            this.updata_btn.Margin = new System.Windows.Forms.Padding(4);
            this.updata_btn.Name = "updata_btn";
            this.updata_btn.Size = new System.Drawing.Size(90, 29);
            this.updata_btn.TabIndex = 10;
            this.updata_btn.Text = "修改选中";
            this.updata_btn.UseVisualStyleBackColor = true;
            this.updata_btn.Click += new System.EventHandler(this.updata_btn_Click);
            // 
            // new_btn
            // 
            this.new_btn.Location = new System.Drawing.Point(203, 4);
            this.new_btn.Margin = new System.Windows.Forms.Padding(4);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(90, 29);
            this.new_btn.TabIndex = 9;
            this.new_btn.Text = "新建台账";
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Font = new System.Drawing.Font("宋体", 9F);
            this.listView1.Location = new System.Drawing.Point(4, 36);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(794, 291);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(4, 4);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(191, 562);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部展开ToolStripMenuItem,
            this.全部关闭ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 60);
            // 
            // 全部展开ToolStripMenuItem
            // 
            this.全部展开ToolStripMenuItem.Name = "全部展开ToolStripMenuItem";
            this.全部展开ToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.全部展开ToolStripMenuItem.Text = "全部展开";
            this.全部展开ToolStripMenuItem.Click += new System.EventHandler(this.全部展开ToolStripMenuItem_Click);
            // 
            // 全部关闭ToolStripMenuItem
            // 
            this.全部关闭ToolStripMenuItem.Name = "全部关闭ToolStripMenuItem";
            this.全部关闭ToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.全部关闭ToolStripMenuItem.Text = "全部关闭";
            this.全部关闭ToolStripMenuItem.Click += new System.EventHandler(this.全部关闭ToolStripMenuItem_Click);
            // 
            // new_jilu
            // 
            this.new_jilu.AutoSize = true;
            this.new_jilu.Location = new System.Drawing.Point(689, 4);
            this.new_jilu.Margin = new System.Windows.Forms.Padding(4);
            this.new_jilu.Name = "new_jilu";
            this.new_jilu.Size = new System.Drawing.Size(126, 29);
            this.new_jilu.TabIndex = 13;
            this.new_jilu.Text = "添加维护记录";
            this.new_jilu.UseVisualStyleBackColor = true;
            this.new_jilu.Click += new System.EventHandler(this.new_jilu_Click);
            // 
            // youjicaidan_list
            // 
            this.youjicaidan_list.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.youjicaidan_list.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看详细ToolStripMenuItem,
            this.修改台账ToolStripMenuItem,
            this.新增台账ToolStripMenuItem,
            this.新增维护记录ToolStripMenuItem,
            this.删除台账ToolStripMenuItem});
            this.youjicaidan_list.Name = "youjicaidan_list";
            this.youjicaidan_list.Size = new System.Drawing.Size(189, 144);
            // 
            // 查看详细ToolStripMenuItem
            // 
            this.查看详细ToolStripMenuItem.Name = "查看详细ToolStripMenuItem";
            this.查看详细ToolStripMenuItem.Size = new System.Drawing.Size(188, 28);
            this.查看详细ToolStripMenuItem.Text = "查看详细";
            this.查看详细ToolStripMenuItem.Click += new System.EventHandler(this.查看详细ToolStripMenuItem_Click);
            // 
            // 修改台账ToolStripMenuItem
            // 
            this.修改台账ToolStripMenuItem.Name = "修改台账ToolStripMenuItem";
            this.修改台账ToolStripMenuItem.Size = new System.Drawing.Size(188, 28);
            this.修改台账ToolStripMenuItem.Text = "修改台账";
            this.修改台账ToolStripMenuItem.Click += new System.EventHandler(this.修改台账ToolStripMenuItem_Click);
            // 
            // 新增台账ToolStripMenuItem
            // 
            this.新增台账ToolStripMenuItem.Name = "新增台账ToolStripMenuItem";
            this.新增台账ToolStripMenuItem.Size = new System.Drawing.Size(188, 28);
            this.新增台账ToolStripMenuItem.Text = "新增台账";
            this.新增台账ToolStripMenuItem.Click += new System.EventHandler(this.新增台账ToolStripMenuItem_Click);
            // 
            // 新增维护记录ToolStripMenuItem
            // 
            this.新增维护记录ToolStripMenuItem.Name = "新增维护记录ToolStripMenuItem";
            this.新增维护记录ToolStripMenuItem.Size = new System.Drawing.Size(188, 28);
            this.新增维护记录ToolStripMenuItem.Text = "新增维护记录";
            this.新增维护记录ToolStripMenuItem.Click += new System.EventHandler(this.新增维护记录ToolStripMenuItem_Click);
            // 
            // 删除台账ToolStripMenuItem
            // 
            this.删除台账ToolStripMenuItem.Name = "删除台账ToolStripMenuItem";
            this.删除台账ToolStripMenuItem.Size = new System.Drawing.Size(188, 28);
            this.删除台账ToolStripMenuItem.Text = "删除台账";
            this.删除台账ToolStripMenuItem.Click += new System.EventHandler(this.删除台账ToolStripMenuItem_Click);
            // 
            // my_wh
            // 
            this.my_wh.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.my_wh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.my_info,
            this.my_creat,
            this.my_whsb,
            this.my_anzhuan});
            this.my_wh.Location = new System.Drawing.Point(0, 0);
            this.my_wh.Name = "my_wh";
            this.my_wh.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.my_wh.Size = new System.Drawing.Size(1004, 32);
            this.my_wh.TabIndex = 15;
            this.my_wh.Text = "menuStrip1";
            // 
            // my_info
            // 
            this.my_info.Name = "my_info";
            this.my_info.Size = new System.Drawing.Size(94, 28);
            this.my_info.Text = "我的信息";
            this.my_info.Click += new System.EventHandler(this.my_info_Click);
            // 
            // my_creat
            // 
            this.my_creat.Name = "my_creat";
            this.my_creat.Size = new System.Drawing.Size(130, 28);
            this.my_creat.Text = "我创建的台账";
            this.my_creat.Click += new System.EventHandler(this.my_creat_Click);
            // 
            // my_whsb
            // 
            this.my_whsb.Name = "my_whsb";
            this.my_whsb.Size = new System.Drawing.Size(148, 28);
            this.my_whsb.Text = "我维护过的设备";
            this.my_whsb.Click += new System.EventHandler(this.my_whsb_Click);
            // 
            // my_anzhuan
            // 
            this.my_anzhuan.Name = "my_anzhuan";
            this.my_anzhuan.Size = new System.Drawing.Size(130, 28);
            this.my_anzhuan.Text = "我安装的设备";
            this.my_anzhuan.Click += new System.EventHandler(this.my_anzhuan_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.yulan1);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.new_jilu);
            this.panel1.Controls.Add(this.new_btn);
            this.panel1.Controls.Add(this.updata_btn);
            this.panel1.Controls.Add(this.select_btn);
            this.panel1.Controls.Add(this.del_btn);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 605);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.jishu);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(199, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 355);
            this.panel2.TabIndex = 14;
            // 
            // jishu
            // 
            this.jishu.AutoSize = true;
            this.jishu.Location = new System.Drawing.Point(3, 331);
            this.jishu.Name = "jishu";
            this.jishu.Size = new System.Drawing.Size(188, 18);
            this.jishu.TabIndex = 19;
            this.jishu.Text = "该条件下共有个台账！";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.zhuangtai_shai);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.yongtu_shai);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.xinhao_shai);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.date_min);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.date_max);
            this.panel3.Location = new System.Drawing.Point(4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(803, 32);
            this.panel3.TabIndex = 12;
            // 
            // zhuangtai_shai
            // 
            this.zhuangtai_shai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zhuangtai_shai.FormattingEnabled = true;
            this.zhuangtai_shai.Location = new System.Drawing.Point(712, 0);
            this.zhuangtai_shai.Name = "zhuangtai_shai";
            this.zhuangtai_shai.Size = new System.Drawing.Size(80, 26);
            this.zhuangtai_shai.TabIndex = 18;
            this.zhuangtai_shai.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.zhuangtai_shai.SelectionChangeCommitted += new System.EventHandler(this.zhuangtai_shai_SelectionChangeCommitted);
            this.zhuangtai_shai.Click += new System.EventHandler(this.zhuangtai_shai_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(669, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "状态：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "安装时间";
            // 
            // yongtu_shai
            // 
            this.yongtu_shai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yongtu_shai.FormattingEnabled = true;
            this.yongtu_shai.Location = new System.Drawing.Point(558, 1);
            this.yongtu_shai.Name = "yongtu_shai";
            this.yongtu_shai.Size = new System.Drawing.Size(80, 26);
            this.yongtu_shai.TabIndex = 15;
            this.yongtu_shai.SelectedIndexChanged += new System.EventHandler(this.yongtu_shai_SelectedIndexChanged);
            this.yongtu_shai.Click += new System.EventHandler(this.yongtu_shai_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "用途：";
            // 
            // xinhao_shai
            // 
            this.xinhao_shai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xinhao_shai.FormattingEnabled = true;
            this.xinhao_shai.Location = new System.Drawing.Point(399, 1);
            this.xinhao_shai.Name = "xinhao_shai";
            this.xinhao_shai.Size = new System.Drawing.Size(92, 26);
            this.xinhao_shai.TabIndex = 13;
            this.xinhao_shai.SelectedIndexChanged += new System.EventHandler(this.xinhao_shai_SelectedIndexChanged);
            this.xinhao_shai.Click += new System.EventHandler(this.xinhao_shai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "型号：";
            // 
            // date_min
            // 
            this.date_min.Location = new System.Drawing.Point(65, 0);
            this.date_min.Name = "date_min";
            this.date_min.Size = new System.Drawing.Size(123, 28);
            this.date_min.TabIndex = 9;
            this.date_min.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.date_min.CloseUp += new System.EventHandler(this.date_min_CloseUp);
            this.date_min.ValueChanged += new System.EventHandler(this.date_min_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "至";
            // 
            // date_max
            // 
            this.date_max.Location = new System.Drawing.Point(225, 0);
            this.date_max.Name = "date_max";
            this.date_max.Size = new System.Drawing.Size(132, 28);
            this.date_max.TabIndex = 10;
            this.date_max.CloseUp += new System.EventHandler(this.date_max_CloseUp);
            this.date_max.ValueChanged += new System.EventHandler(this.date_max_ValueChanged);
            // 
            // yulan1
            // 
            this.yulan1.AutoSize = true;
            this.yulan1.Font = new System.Drawing.Font("宋体", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yulan1.Location = new System.Drawing.Point(196, 393);
            this.yulan1.Margin = new System.Windows.Forms.Padding(4);
            this.yulan1.Name = "yulan1";
            this.yulan1.Size = new System.Drawing.Size(890, 208);
            this.yulan1.TabIndex = 0;
            // 
            // Taizhng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 607);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.my_wh);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.MainMenuStrip = this.my_wh;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Taizhng";
            this.Text = "Taizhng";
            this.Load += new System.EventHandler(this.Taizhng_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.youjicaidan_list.ResumeLayout(false);
            this.my_wh.ResumeLayout(false);
            this.my_wh.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button updata_btn;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 全部展开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部关闭ToolStripMenuItem;
        private yulan yulan1;
        private System.Windows.Forms.Button new_jilu;
        private System.Windows.Forms.ContextMenuStrip youjicaidan_list;
        private System.Windows.Forms.ToolStripMenuItem 新增台账ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增维护记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除台账ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看详细ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改台账ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip my_wh;
        private System.Windows.Forms.ToolStripMenuItem my_info;
        private System.Windows.Forms.ToolStripMenuItem my_creat;
        private System.Windows.Forms.ToolStripMenuItem my_whsb;
        private System.Windows.Forms.ToolStripMenuItem my_anzhuan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_max;
        private System.Windows.Forms.DateTimePicker date_min;
        private System.Windows.Forms.ComboBox yongtu_shai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox xinhao_shai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox zhuangtai_shai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label jishu;
    }
}