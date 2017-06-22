namespace StudentManager
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_yx = new System.Windows.Forms.Label();
            this.btny = new System.Windows.Forms.Button();
            this.btnz = new System.Windows.Forms.Button();
            this.lbl_md = new System.Windows.Forms.Label();
            this.btn_name = new System.Windows.Forms.Button();
            this.lstz = new System.Windows.Forms.ListBox();
            this.lsty = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_yx
            // 
            this.lbl_yx.AutoSize = true;
            this.lbl_yx.Location = new System.Drawing.Point(13, 23);
            this.lbl_yx.Name = "lbl_yx";
            this.lbl_yx.Size = new System.Drawing.Size(89, 12);
            this.lbl_yx.TabIndex = 0;
            this.lbl_yx.Text = "优秀学员候选人";
            // 
            // btny
            // 
            this.btny.Location = new System.Drawing.Point(150, 74);
            this.btny.Name = "btny";
            this.btny.Size = new System.Drawing.Size(75, 23);
            this.btny.TabIndex = 2;
            this.btny.Text = ">>";
            this.btny.UseVisualStyleBackColor = true;
            this.btny.Click += new System.EventHandler(this.btny_Click);
            // 
            // btnz
            // 
            this.btnz.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnz.Location = new System.Drawing.Point(150, 144);
            this.btnz.Name = "btnz";
            this.btnz.Size = new System.Drawing.Size(75, 23);
            this.btnz.TabIndex = 3;
            this.btnz.Text = "<<";
            this.btnz.UseVisualStyleBackColor = true;
            this.btnz.Click += new System.EventHandler(this.btnz_Click);
            // 
            // lbl_md
            // 
            this.lbl_md.AutoSize = true;
            this.lbl_md.Location = new System.Drawing.Point(274, 23);
            this.lbl_md.Name = "lbl_md";
            this.lbl_md.Size = new System.Drawing.Size(77, 12);
            this.lbl_md.TabIndex = 4;
            this.lbl_md.Text = "优秀学员名单";
            // 
            // btn_name
            // 
            this.btn_name.Location = new System.Drawing.Point(150, 218);
            this.btn_name.Name = "btn_name";
            this.btn_name.Size = new System.Drawing.Size(75, 23);
            this.btn_name.TabIndex = 6;
            this.btn_name.Text = "显示优秀学员";
            this.btn_name.UseVisualStyleBackColor = true;
            this.btn_name.Click += new System.EventHandler(this.btn_name_Click);
            // 
            // lstz
            // 
            this.lstz.FormattingEnabled = true;
            this.lstz.ItemHeight = 12;
            this.lstz.Location = new System.Drawing.Point(12, 50);
            this.lstz.Name = "lstz";
            this.lstz.Size = new System.Drawing.Size(120, 172);
            this.lstz.TabIndex = 7;
            // 
            // lsty
            // 
            this.lsty.FormattingEnabled = true;
            this.lsty.ItemHeight = 12;
            this.lsty.Location = new System.Drawing.Point(261, 50);
            this.lsty.Name = "lsty";
            this.lsty.Size = new System.Drawing.Size(120, 172);
            this.lsty.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 262);
            this.Controls.Add(this.lsty);
            this.Controls.Add(this.lstz);
            this.Controls.Add(this.btn_name);
            this.Controls.Add(this.lbl_md);
            this.Controls.Add(this.btnz);
            this.Controls.Add(this.btny);
            this.Controls.Add(this.lbl_yx);
            this.Name = "Form1";
            this.Text = "优秀学员选择";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_yx;
        private System.Windows.Forms.Button btny;
        private System.Windows.Forms.Button btnz;
        private System.Windows.Forms.Label lbl_md;
        private System.Windows.Forms.Button btn_name;
        private System.Windows.Forms.ListBox lstz;
        private System.Windows.Forms.ListBox lsty;
    }
}

