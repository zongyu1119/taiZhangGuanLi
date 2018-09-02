namespace 台账管理
{
    partial class main
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
            this.taizhangguanli = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.caozuojilu = new System.Windows.Forms.ListBox();
            this.mean = new System.Windows.Forms.MenuStrip();
            this.user_zhiwei = new System.Windows.Forms.ToolStripMenuItem();
            this.xinhao_mean = new System.Windows.Forms.ToolStripMenuItem();
            this.tieuju_fengzhongxin = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.time_now = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mean.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // taizhangguanli
            // 
            this.taizhangguanli.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.taizhangguanli.Location = new System.Drawing.Point(3, 10);
            this.taizhangguanli.Name = "taizhangguanli";
            this.taizhangguanli.Size = new System.Drawing.Size(189, 103);
            this.taizhangguanli.TabIndex = 0;
            this.taizhangguanli.Text = "台账管理系统";
            this.taizhangguanli.UseVisualStyleBackColor = true;
            this.taizhangguanli.Click += new System.EventHandler(this.taizhangguanli_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Location = new System.Drawing.Point(3, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 103);
            this.button2.TabIndex = 1;
            this.button2.Text = "出差数据统计";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.Location = new System.Drawing.Point(3, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 103);
            this.button3.TabIndex = 2;
            this.button3.Text = "程序管理系统";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.Location = new System.Drawing.Point(3, 343);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 103);
            this.button4.TabIndex = 3;
            this.button4.Text = "项目进度概览";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // caozuojilu
            // 
            this.caozuojilu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.caozuojilu.Font = new System.Drawing.Font("宋体", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.caozuojilu.FormattingEnabled = true;
            this.caozuojilu.ItemHeight = 19;
            this.caozuojilu.Location = new System.Drawing.Point(320, 84);
            this.caozuojilu.Name = "caozuojilu";
            this.caozuojilu.Size = new System.Drawing.Size(760, 460);
            this.caozuojilu.TabIndex = 4;
            // 
            // mean
            // 
            this.mean.BackColor = System.Drawing.Color.Gainsboro;
            this.mean.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mean.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mean.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.user_zhiwei,
            this.xinhao_mean,
            this.tieuju_fengzhongxin});
            this.mean.Location = new System.Drawing.Point(0, 0);
            this.mean.Name = "mean";
            this.mean.Size = new System.Drawing.Size(1178, 32);
            this.mean.TabIndex = 5;
            this.mean.Text = "menuStrip1";
            // 
            // user_zhiwei
            // 
            this.user_zhiwei.Name = "user_zhiwei";
            this.user_zhiwei.Size = new System.Drawing.Size(148, 28);
            this.user_zhiwei.Text = "员工和职位管理";
            // 
            // xinhao_mean
            // 
            this.xinhao_mean.Name = "xinhao_mean";
            this.xinhao_mean.Size = new System.Drawing.Size(94, 28);
            this.xinhao_mean.Text = "设备管理";
            this.xinhao_mean.Click += new System.EventHandler(this.xinhao_Click);
            // 
            // tieuju_fengzhongxin
            // 
            this.tieuju_fengzhongxin.Name = "tieuju_fengzhongxin";
            this.tieuju_fengzhongxin.Size = new System.Drawing.Size(148, 28);
            this.tieuju_fengzhongxin.Text = "铁路局和分中心";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.Controls.Add(this.taizhangguanli);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(56, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 451);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.time_now);
            this.panel2.Location = new System.Drawing.Point(0, 640);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 36);
            this.panel2.TabIndex = 7;
            // 
            // time_now
            // 
            this.time_now.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.time_now.AutoSize = true;
            this.time_now.Location = new System.Drawing.Point(887, 8);
            this.time_now.Name = "time_now";
            this.time_now.Size = new System.Drawing.Size(62, 18);
            this.time_now.TabIndex = 0;
            this.time_now.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.caozuojilu);
            this.Controls.Add(this.mean);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.mean;
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.mean.ResumeLayout(false);
            this.mean.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button taizhangguanli;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox caozuojilu;
        private System.Windows.Forms.MenuStrip mean;
        private System.Windows.Forms.ToolStripMenuItem user_zhiwei;
        private System.Windows.Forms.ToolStripMenuItem xinhao_mean;
        private System.Windows.Forms.ToolStripMenuItem tieuju_fengzhongxin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label time_now;
        private System.Windows.Forms.Timer timer1;
    }
}