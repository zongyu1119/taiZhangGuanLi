namespace 台账管理
{
    partial class my_info
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
            this.label1 = new System.Windows.Forms.Label();
            this.pw = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zz = new System.Windows.Forms.Label();
            this.zw = new System.Windows.Forms.Label();
            this.up_mima = new System.Windows.Forms.Button();
            this.quxiao = new System.Windows.Forms.Button();
            this.bumen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.change_p = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // pw
            // 
            this.pw.Location = new System.Drawing.Point(225, 134);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(239, 28);
            this.pw.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(222, 82);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(62, 18);
            this.name.TabIndex = 2;
            this.name.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "密码：";
            // 
            // zz
            // 
            this.zz.AutoSize = true;
            this.zz.Location = new System.Drawing.Point(145, 247);
            this.zz.Name = "zz";
            this.zz.Size = new System.Drawing.Size(62, 18);
            this.zz.TabIndex = 4;
            this.zz.Text = "职位：";
            // 
            // zw
            // 
            this.zw.AutoSize = true;
            this.zw.Location = new System.Drawing.Point(222, 248);
            this.zw.Name = "zw";
            this.zw.Size = new System.Drawing.Size(62, 18);
            this.zw.TabIndex = 5;
            this.zw.Text = "姓名：";
            // 
            // up_mima
            // 
            this.up_mima.AutoSize = true;
            this.up_mima.Location = new System.Drawing.Point(154, 359);
            this.up_mima.Name = "up_mima";
            this.up_mima.Size = new System.Drawing.Size(90, 28);
            this.up_mima.TabIndex = 6;
            this.up_mima.Text = "修改密码";
            this.up_mima.UseVisualStyleBackColor = true;
            this.up_mima.Click += new System.EventHandler(this.up_mima_Click);
            // 
            // quxiao
            // 
            this.quxiao.AutoSize = true;
            this.quxiao.Location = new System.Drawing.Point(398, 359);
            this.quxiao.Name = "quxiao";
            this.quxiao.Size = new System.Drawing.Size(81, 28);
            this.quxiao.TabIndex = 7;
            this.quxiao.Text = "取消";
            this.quxiao.UseVisualStyleBackColor = true;
            this.quxiao.Click += new System.EventHandler(this.quxiao_Click);
            // 
            // bumen
            // 
            this.bumen.AutoSize = true;
            this.bumen.Location = new System.Drawing.Point(222, 196);
            this.bumen.Name = "bumen";
            this.bumen.Size = new System.Drawing.Size(62, 18);
            this.bumen.TabIndex = 9;
            this.bumen.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "部门：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "电话：";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(225, 300);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(239, 28);
            this.phone.TabIndex = 10;
            // 
            // change_p
            // 
            this.change_p.AutoSize = true;
            this.change_p.Location = new System.Drawing.Point(276, 359);
            this.change_p.Name = "change_p";
            this.change_p.Size = new System.Drawing.Size(90, 28);
            this.change_p.TabIndex = 12;
            this.change_p.Text = "修改电话";
            this.change_p.UseVisualStyleBackColor = true;
            this.change_p.Click += new System.EventHandler(this.change_p_Click);
            // 
            // my_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 474);
            this.Controls.Add(this.change_p);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.bumen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quxiao);
            this.Controls.Add(this.up_mima);
            this.Controls.Add(this.zw);
            this.Controls.Add(this.zz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.label1);
            this.Name = "my_info";
            this.Text = "my_create";
            this.Load += new System.EventHandler(this.my_info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label zz;
        private System.Windows.Forms.Label zw;
        private System.Windows.Forms.Button up_mima;
        private System.Windows.Forms.Button quxiao;
        private System.Windows.Forms.Label bumen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Button change_p;
    }
}