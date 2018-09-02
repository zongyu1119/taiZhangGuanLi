namespace 台账管理
{
    partial class user_and_zhiwei
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
            this.fzx_s = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.del_user_btn = new System.Windows.Forms.Button();
            this.up_user_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.phone_yl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.zw_yl = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fzx_yl = new System.Windows.Forms.ComboBox();
            this.pw_yl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name_yl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.zw_s = new System.Windows.Forms.ComboBox();
            this.user_list = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.up_num = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.add_zw_btn = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.del_num = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.add_zhiwei = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.add_user_btn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.phone_add = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.zhiwei_add = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.fzx_add = new System.Windows.Forms.ComboBox();
            this.pw_add = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.name_add = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.del_zw_btn = new System.Windows.Forms.Button();
            this.zhiwei_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // fzx_s
            // 
            this.fzx_s.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fzx_s.FormattingEnabled = true;
            this.fzx_s.Location = new System.Drawing.Point(119, 12);
            this.fzx_s.Name = "fzx_s";
            this.fzx_s.Size = new System.Drawing.Size(187, 26);
            this.fzx_s.TabIndex = 0;
            this.fzx_s.SelectedIndexChanged += new System.EventHandler(this.fzx_s_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "分中心筛选";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.del_user_btn);
            this.groupBox1.Controls.Add(this.up_user_btn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.phone_yl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.zw_yl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.fzx_yl);
            this.groupBox1.Controls.Add(this.pw_yl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.name_yl);
            this.groupBox1.Location = new System.Drawing.Point(615, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 290);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息预览";
            // 
            // del_user_btn
            // 
            this.del_user_btn.AutoSize = true;
            this.del_user_btn.Location = new System.Drawing.Point(92, 243);
            this.del_user_btn.Name = "del_user_btn";
            this.del_user_btn.Size = new System.Drawing.Size(90, 28);
            this.del_user_btn.TabIndex = 14;
            this.del_user_btn.Text = "删除员工";
            this.del_user_btn.UseVisualStyleBackColor = true;
            this.del_user_btn.Click += new System.EventHandler(this.del_user_btn_Click);
            // 
            // up_user_btn
            // 
            this.up_user_btn.AutoSize = true;
            this.up_user_btn.Location = new System.Drawing.Point(188, 243);
            this.up_user_btn.Name = "up_user_btn";
            this.up_user_btn.Size = new System.Drawing.Size(90, 28);
            this.up_user_btn.TabIndex = 13;
            this.up_user_btn.Text = "修改信息";
            this.up_user_btn.UseVisualStyleBackColor = true;
            this.up_user_btn.Click += new System.EventHandler(this.up_user_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "电话：";
            // 
            // phone_yl
            // 
            this.phone_yl.Location = new System.Drawing.Point(92, 196);
            this.phone_yl.Name = "phone_yl";
            this.phone_yl.Size = new System.Drawing.Size(186, 28);
            this.phone_yl.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "职位：";
            // 
            // zw_yl
            // 
            this.zw_yl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zw_yl.FormattingEnabled = true;
            this.zw_yl.Location = new System.Drawing.Point(92, 157);
            this.zw_yl.Name = "zw_yl";
            this.zw_yl.Size = new System.Drawing.Size(186, 26);
            this.zw_yl.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "分中心：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "密码：";
            // 
            // fzx_yl
            // 
            this.fzx_yl.FormattingEnabled = true;
            this.fzx_yl.Location = new System.Drawing.Point(92, 118);
            this.fzx_yl.Name = "fzx_yl";
            this.fzx_yl.Size = new System.Drawing.Size(186, 26);
            this.fzx_yl.TabIndex = 6;
            // 
            // pw_yl
            // 
            this.pw_yl.Location = new System.Drawing.Point(92, 77);
            this.pw_yl.Name = "pw_yl";
            this.pw_yl.Size = new System.Drawing.Size(186, 28);
            this.pw_yl.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "姓名：";
            // 
            // name_yl
            // 
            this.name_yl.Location = new System.Drawing.Point(92, 36);
            this.name_yl.Name = "name_yl";
            this.name_yl.Size = new System.Drawing.Size(186, 28);
            this.name_yl.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "职位筛选";
            // 
            // zw_s
            // 
            this.zw_s.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zw_s.FormattingEnabled = true;
            this.zw_s.Location = new System.Drawing.Point(474, 12);
            this.zw_s.Name = "zw_s";
            this.zw_s.Size = new System.Drawing.Size(121, 26);
            this.zw_s.TabIndex = 4;
            this.zw_s.SelectedIndexChanged += new System.EventHandler(this.zw_s_SelectedIndexChanged);
            // 
            // user_list
            // 
            this.user_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.user_list.FullRowSelect = true;
            this.user_list.GridLines = true;
            this.user_list.Location = new System.Drawing.Point(12, 51);
            this.user_list.MultiSelect = false;
            this.user_list.Name = "user_list";
            this.user_list.Size = new System.Drawing.Size(582, 550);
            this.user_list.TabIndex = 6;
            this.user_list.UseCompatibleStateImageBehavior = false;
            this.user_list.View = System.Windows.Forms.View.Details;
            this.user_list.SelectedIndexChanged += new System.EventHandler(this.user_list_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "序号";
            this.columnHeader6.Width = 45;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "姓名";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 65;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "分中心";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "职位";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "电话";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 140;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.up_num);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.add_zw_btn);
            this.groupBox2.Controls.Add(this.lv);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.del_num);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.add_zhiwei);
            this.groupBox2.Location = new System.Drawing.Point(914, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 242);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加职位";
            // 
            // up_num
            // 
            this.up_num.Location = new System.Drawing.Point(188, 118);
            this.up_num.Name = "up_num";
            this.up_num.Size = new System.Drawing.Size(97, 28);
            this.up_num.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "权限等级：";
            // 
            // add_zw_btn
            // 
            this.add_zw_btn.AutoSize = true;
            this.add_zw_btn.Location = new System.Drawing.Point(188, 198);
            this.add_zw_btn.Name = "add_zw_btn";
            this.add_zw_btn.Size = new System.Drawing.Size(90, 28);
            this.add_zw_btn.TabIndex = 13;
            this.add_zw_btn.Text = "添加职位";
            this.add_zw_btn.UseVisualStyleBackColor = true;
            this.add_zw_btn.Click += new System.EventHandler(this.add_zw_btn_Click);
            // 
            // lv
            // 
            this.lv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lv.FormattingEnabled = true;
            this.lv.Location = new System.Drawing.Point(127, 157);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(151, 26);
            this.lv.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "每日可修改数量：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "每日可删除数量：";
            // 
            // del_num
            // 
            this.del_num.Location = new System.Drawing.Point(181, 77);
            this.del_num.Name = "del_num";
            this.del_num.Size = new System.Drawing.Size(97, 28);
            this.del_num.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "职位：";
            // 
            // add_zhiwei
            // 
            this.add_zhiwei.Location = new System.Drawing.Point(92, 36);
            this.add_zhiwei.Name = "add_zhiwei";
            this.add_zhiwei.Size = new System.Drawing.Size(186, 28);
            this.add_zhiwei.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.add_user_btn);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.phone_add);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.zhiwei_add);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.fzx_add);
            this.groupBox3.Controls.Add(this.pw_add);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.name_add);
            this.groupBox3.Location = new System.Drawing.Point(615, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 290);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "添加员工";
            // 
            // add_user_btn
            // 
            this.add_user_btn.AutoSize = true;
            this.add_user_btn.Location = new System.Drawing.Point(188, 243);
            this.add_user_btn.Name = "add_user_btn";
            this.add_user_btn.Size = new System.Drawing.Size(90, 28);
            this.add_user_btn.TabIndex = 13;
            this.add_user_btn.Text = "添加员工";
            this.add_user_btn.UseVisualStyleBackColor = true;
            this.add_user_btn.Click += new System.EventHandler(this.add_user_btn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "电话：";
            // 
            // phone_add
            // 
            this.phone_add.Location = new System.Drawing.Point(92, 196);
            this.phone_add.Name = "phone_add";
            this.phone_add.Size = new System.Drawing.Size(186, 28);
            this.phone_add.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 18);
            this.label14.TabIndex = 10;
            this.label14.Text = "职位：";
            // 
            // zhiwei_add
            // 
            this.zhiwei_add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zhiwei_add.FormattingEnabled = true;
            this.zhiwei_add.Location = new System.Drawing.Point(92, 157);
            this.zhiwei_add.Name = "zhiwei_add";
            this.zhiwei_add.Size = new System.Drawing.Size(186, 26);
            this.zhiwei_add.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 18);
            this.label15.TabIndex = 7;
            this.label15.Text = "分中心：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 18);
            this.label16.TabIndex = 8;
            this.label16.Text = "密码：";
            // 
            // fzx_add
            // 
            this.fzx_add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fzx_add.FormattingEnabled = true;
            this.fzx_add.Location = new System.Drawing.Point(92, 118);
            this.fzx_add.Name = "fzx_add";
            this.fzx_add.Size = new System.Drawing.Size(186, 26);
            this.fzx_add.TabIndex = 6;
            // 
            // pw_add
            // 
            this.pw_add.Location = new System.Drawing.Point(92, 77);
            this.pw_add.Name = "pw_add";
            this.pw_add.Size = new System.Drawing.Size(186, 28);
            this.pw_add.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 18);
            this.label17.TabIndex = 6;
            this.label17.Text = "姓名：";
            // 
            // name_add
            // 
            this.name_add.Location = new System.Drawing.Point(92, 36);
            this.name_add.Name = "name_add";
            this.name_add.Size = new System.Drawing.Size(186, 28);
            this.name_add.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.del_zw_btn);
            this.groupBox4.Controls.Add(this.zhiwei_list);
            this.groupBox4.Location = new System.Drawing.Point(914, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 335);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "所有职位";
            // 
            // del_zw_btn
            // 
            this.del_zw_btn.AutoSize = true;
            this.del_zw_btn.Location = new System.Drawing.Point(197, 301);
            this.del_zw_btn.Name = "del_zw_btn";
            this.del_zw_btn.Size = new System.Drawing.Size(90, 28);
            this.del_zw_btn.TabIndex = 15;
            this.del_zw_btn.Text = "删除职位";
            this.del_zw_btn.UseVisualStyleBackColor = true;
            this.del_zw_btn.Click += new System.EventHandler(this.del_zw_btn_Click);
            // 
            // zhiwei_list
            // 
            this.zhiwei_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.zhiwei_list.FullRowSelect = true;
            this.zhiwei_list.GridLines = true;
            this.zhiwei_list.Location = new System.Drawing.Point(8, 27);
            this.zhiwei_list.Name = "zhiwei_list";
            this.zhiwei_list.Size = new System.Drawing.Size(279, 269);
            this.zhiwei_list.TabIndex = 16;
            this.zhiwei_list.UseCompatibleStateImageBehavior = false;
            this.zhiwei_list.View = System.Windows.Forms.View.Details;
            this.zhiwei_list.SelectedIndexChanged += new System.EventHandler(this.zhiwei_list_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "职位";
            this.columnHeader1.Width = 58;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "删除";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 48;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "修改";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "等级";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // user_and_zhiwei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 613);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.user_list);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zw_s);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fzx_s);
            this.Name = "user_and_zhiwei";
            this.Text = "user_and_zhiwei";
            this.Load += new System.EventHandler(this.user_and_zhiwei_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fzx_s;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button up_user_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phone_yl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox zw_yl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox fzx_yl;
        private System.Windows.Forms.TextBox pw_yl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_yl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox zw_s;
        private System.Windows.Forms.Button del_user_btn;
        private System.Windows.Forms.ListView user_list;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button add_zw_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox lv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox del_num;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox add_zhiwei;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button add_user_btn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox phone_add;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox zhiwei_add;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox fzx_add;
        private System.Windows.Forms.TextBox pw_add;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox name_add;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button del_zw_btn;
        private System.Windows.Forms.ListView zhiwei_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox up_num;
    }
}