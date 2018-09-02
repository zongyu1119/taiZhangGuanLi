namespace 台账管理
{
    partial class xuanzetupian
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.del_btn = new System.Windows.Forms.Button();
            this.sel_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(224, 322);
            this.del_btn.Margin = new System.Windows.Forms.Padding(4);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(112, 34);
            this.del_btn.TabIndex = 5;
            this.del_btn.Text = "删除选中";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // sel_btn
            // 
            this.sel_btn.Location = new System.Drawing.Point(3, 323);
            this.sel_btn.Margin = new System.Windows.Forms.Padding(4);
            this.sel_btn.Name = "sel_btn";
            this.sel_btn.Size = new System.Drawing.Size(112, 34);
            this.sel_btn.TabIndex = 4;
            this.sel_btn.Text = "添加图片";
            this.sel_btn.UseVisualStyleBackColor = true;
            this.sel_btn.Click += new System.EventHandler(this.sel_btn_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 4);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(340, 307);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // xuanzetupian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.sel_btn);
            this.Controls.Add(this.listView1);
            this.Name = "xuanzetupian";
            this.Size = new System.Drawing.Size(347, 361);
            this.Load += new System.EventHandler(this.select_img_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button sel_btn;
        private System.Windows.Forms.ListView listView1;
    }
}
