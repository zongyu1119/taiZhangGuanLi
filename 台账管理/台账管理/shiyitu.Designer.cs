namespace 台账管理
{
    partial class shiyitu
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
            this.JXH = new System.Windows.Forms.Button();
            this.rec_fill = new System.Windows.Forms.Button();
            this.rec_line = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.ComboBox();
            this.from_file = new System.Windows.Forms.Button();
            this.clear_all = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pen_width = new System.Windows.Forms.ComboBox();
            this.fill_color = new System.Windows.Forms.Button();
            this.line_color = new System.Windows.Forms.Button();
            this.text_box = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.save_img = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jian = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.JF = new System.Windows.Forms.Button();
            this.GBX = new System.Windows.Forms.Button();
            this.CG = new System.Windows.Forms.Button();
            this.TX = new System.Windows.Forms.Button();
            this.GG = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // JXH
            // 
            this.JXH.Location = new System.Drawing.Point(6, 158);
            this.JXH.Margin = new System.Windows.Forms.Padding(4);
            this.JXH.Name = "JXH";
            this.JXH.Size = new System.Drawing.Size(112, 34);
            this.JXH.TabIndex = 23;
            this.JXH.Text = "接线盒";
            this.JXH.UseVisualStyleBackColor = true;
            this.JXH.Click += new System.EventHandler(this.JXH_Click);
            // 
            // rec_fill
            // 
            this.rec_fill.Location = new System.Drawing.Point(4, 374);
            this.rec_fill.Margin = new System.Windows.Forms.Padding(4);
            this.rec_fill.Name = "rec_fill";
            this.rec_fill.Size = new System.Drawing.Size(112, 34);
            this.rec_fill.TabIndex = 22;
            this.rec_fill.Text = "填充矩形";
            this.rec_fill.UseVisualStyleBackColor = true;
            this.rec_fill.Click += new System.EventHandler(this.rec_fill_Click);
            // 
            // rec_line
            // 
            this.rec_line.Location = new System.Drawing.Point(4, 330);
            this.rec_line.Margin = new System.Windows.Forms.Padding(4);
            this.rec_line.Name = "rec_line";
            this.rec_line.Size = new System.Drawing.Size(112, 34);
            this.rec_line.TabIndex = 21;
            this.rec_line.Text = "线条矩形";
            this.rec_line.UseVisualStyleBackColor = true;
            this.rec_line.Click += new System.EventHandler(this.rec_line_Click);
            // 
            // text
            // 
            this.text.FormattingEnabled = true;
            this.text.Location = new System.Drawing.Point(422, 538);
            this.text.Margin = new System.Windows.Forms.Padding(4);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(226, 26);
            this.text.TabIndex = 12;
            // 
            // from_file
            // 
            this.from_file.Location = new System.Drawing.Point(1070, 534);
            this.from_file.Margin = new System.Windows.Forms.Padding(4);
            this.from_file.Name = "from_file";
            this.from_file.Size = new System.Drawing.Size(112, 34);
            this.from_file.TabIndex = 20;
            this.from_file.Text = "从文件选择";
            this.from_file.UseVisualStyleBackColor = true;
            this.from_file.Click += new System.EventHandler(this.from_file_Click);
            // 
            // clear_all
            // 
            this.clear_all.Location = new System.Drawing.Point(918, 534);
            this.clear_all.Margin = new System.Windows.Forms.Padding(4);
            this.clear_all.Name = "clear_all";
            this.clear_all.Size = new System.Drawing.Size(112, 34);
            this.clear_all.TabIndex = 19;
            this.clear_all.Text = "清除画板";
            this.clear_all.UseVisualStyleBackColor = true;
            this.clear_all.Click += new System.EventHandler(this.clear_all_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pen_width);
            this.groupBox2.Location = new System.Drawing.Point(4, 479);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(106, 87);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "线条宽度";
            // 
            // pen_width
            // 
            this.pen_width.FormattingEnabled = true;
            this.pen_width.Location = new System.Drawing.Point(9, 34);
            this.pen_width.Margin = new System.Windows.Forms.Padding(4);
            this.pen_width.Name = "pen_width";
            this.pen_width.Size = new System.Drawing.Size(86, 26);
            this.pen_width.TabIndex = 11;
            this.pen_width.SelectedIndexChanged += new System.EventHandler(this.pen_width_SelectedIndexChanged);
            // 
            // fill_color
            // 
            this.fill_color.Location = new System.Drawing.Point(248, 536);
            this.fill_color.Margin = new System.Windows.Forms.Padding(4);
            this.fill_color.Name = "fill_color";
            this.fill_color.Size = new System.Drawing.Size(112, 34);
            this.fill_color.TabIndex = 17;
            this.fill_color.Text = "填充颜色\r\n";
            this.fill_color.UseVisualStyleBackColor = true;
            this.fill_color.Click += new System.EventHandler(this.fill_color_Click);
            // 
            // line_color
            // 
            this.line_color.Location = new System.Drawing.Point(126, 536);
            this.line_color.Margin = new System.Windows.Forms.Padding(4);
            this.line_color.Name = "line_color";
            this.line_color.Size = new System.Drawing.Size(112, 34);
            this.line_color.TabIndex = 16;
            this.line_color.Text = "线条颜色\r\n";
            this.line_color.UseVisualStyleBackColor = true;
            this.line_color.Click += new System.EventHandler(this.line_color_Click);
            // 
            // text_box
            // 
            this.text_box.Location = new System.Drawing.Point(658, 536);
            this.text_box.Margin = new System.Windows.Forms.Padding(4);
            this.text_box.Name = "text_box";
            this.text_box.Size = new System.Drawing.Size(112, 34);
            this.text_box.TabIndex = 15;
            this.text_box.Text = "绘制文本";
            this.text_box.UseVisualStyleBackColor = true;
            this.text_box.Click += new System.EventHandler(this.text_box_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 546);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "文本";
            // 
            // save_img
            // 
            this.save_img.Location = new System.Drawing.Point(1218, 534);
            this.save_img.Margin = new System.Windows.Forms.Padding(4);
            this.save_img.Name = "save_img";
            this.save_img.Size = new System.Drawing.Size(112, 34);
            this.save_img.TabIndex = 8;
            this.save_img.Text = "保存图片";
            this.save_img.UseVisualStyleBackColor = true;
            this.save_img.Click += new System.EventHandler(this.save_img_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.JXH);
            this.groupBox1.Controls.Add(this.rec_fill);
            this.groupBox1.Controls.Add(this.rec_line);
            this.groupBox1.Controls.Add(this.text);
            this.groupBox1.Controls.Add(this.from_file);
            this.groupBox1.Controls.Add(this.clear_all);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.fill_color);
            this.groupBox1.Controls.Add(this.line_color);
            this.groupBox1.Controls.Add(this.text_box);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.save_img);
            this.groupBox1.Controls.Add(this.jian);
            this.groupBox1.Controls.Add(this.Line);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.JF);
            this.groupBox1.Controls.Add(this.GBX);
            this.groupBox1.Controls.Add(this.CG);
            this.groupBox1.Controls.Add(this.TX);
            this.groupBox1.Controls.Add(this.GG);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1340, 582);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "安装示意图";
            // 
            // jian
            // 
            this.jian.Location = new System.Drawing.Point(4, 287);
            this.jian.Margin = new System.Windows.Forms.Padding(4);
            this.jian.Name = "jian";
            this.jian.Size = new System.Drawing.Size(112, 34);
            this.jian.TabIndex = 7;
            this.jian.Text = "箭头";
            this.jian.UseVisualStyleBackColor = true;
            this.jian.Click += new System.EventHandler(this.jian_Click);
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(4, 419);
            this.Line.Margin = new System.Windows.Forms.Padding(4);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(112, 34);
            this.Line.TabIndex = 6;
            this.Line.Text = "线";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(126, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1204, 501);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // JF
            // 
            this.JF.Location = new System.Drawing.Point(4, 244);
            this.JF.Margin = new System.Windows.Forms.Padding(4);
            this.JF.Name = "JF";
            this.JF.Size = new System.Drawing.Size(112, 34);
            this.JF.TabIndex = 4;
            this.JF.Text = "机房";
            this.JF.UseVisualStyleBackColor = true;
            this.JF.Click += new System.EventHandler(this.JF_Click);
            // 
            // GBX
            // 
            this.GBX.Location = new System.Drawing.Point(4, 200);
            this.GBX.Margin = new System.Windows.Forms.Padding(4);
            this.GBX.Name = "GBX";
            this.GBX.Size = new System.Drawing.Size(112, 34);
            this.GBX.TabIndex = 3;
            this.GBX.Text = "轨边箱";
            this.GBX.UseVisualStyleBackColor = true;
            this.GBX.Click += new System.EventHandler(this.GBX_Click);
            // 
            // CG
            // 
            this.CG.Location = new System.Drawing.Point(4, 112);
            this.CG.Margin = new System.Windows.Forms.Padding(4);
            this.CG.Name = "CG";
            this.CG.Size = new System.Drawing.Size(112, 34);
            this.CG.TabIndex = 2;
            this.CG.Text = "磁钢";
            this.CG.UseVisualStyleBackColor = true;
            this.CG.Click += new System.EventHandler(this.CG_Click);
            // 
            // TX
            // 
            this.TX.Location = new System.Drawing.Point(4, 69);
            this.TX.Margin = new System.Windows.Forms.Padding(4);
            this.TX.Name = "TX";
            this.TX.Size = new System.Drawing.Size(112, 34);
            this.TX.TabIndex = 1;
            this.TX.Text = "天线";
            this.TX.UseVisualStyleBackColor = true;
            this.TX.Click += new System.EventHandler(this.TX_Click);
            // 
            // GG
            // 
            this.GG.Location = new System.Drawing.Point(4, 26);
            this.GG.Margin = new System.Windows.Forms.Padding(4);
            this.GG.Name = "GG";
            this.GG.Size = new System.Drawing.Size(112, 34);
            this.GG.TabIndex = 0;
            this.GG.Text = "钢轨";
            this.GG.UseVisualStyleBackColor = true;
            this.GG.Click += new System.EventHandler(this.GG_Click);
            // 
            // shiyitu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 612);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1390, 668);
            this.MinimumSize = new System.Drawing.Size(1390, 668);
            this.Name = "shiyitu";
            this.Text = "示意图";
            this.Load += new System.EventHandler(this.shiyitu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button JXH;
        private System.Windows.Forms.Button rec_fill;
        private System.Windows.Forms.Button rec_line;
        private System.Windows.Forms.ComboBox text;
        private System.Windows.Forms.Button from_file;
        private System.Windows.Forms.Button clear_all;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox pen_width;
        private System.Windows.Forms.Button fill_color;
        private System.Windows.Forms.Button line_color;
        private System.Windows.Forms.Button text_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save_img;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button jian;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button JF;
        private System.Windows.Forms.Button GBX;
        private System.Windows.Forms.Button CG;
        private System.Windows.Forms.Button TX;
        private System.Windows.Forms.Button GG;
    }
}