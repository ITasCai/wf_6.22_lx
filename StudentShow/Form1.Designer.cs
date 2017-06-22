namespace StudentShow
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
            this.comNJ = new System.Windows.Forms.ComboBox();
            this.lstShow = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comNJ
            // 
            this.comNJ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comNJ.FormattingEnabled = true;
            this.comNJ.Location = new System.Drawing.Point(67, 27);
            this.comNJ.Name = "comNJ";
            this.comNJ.Size = new System.Drawing.Size(121, 20);
            this.comNJ.TabIndex = 0;
            this.comNJ.SelectedIndexChanged += new System.EventHandler(this.comNJ_SelectedIndexChanged);
            // 
            // lstShow
            // 
            this.lstShow.FormattingEnabled = true;
            this.lstShow.ItemHeight = 12;
            this.lstShow.Location = new System.Drawing.Point(68, 84);
            this.lstShow.Name = "lstShow";
            this.lstShow.Size = new System.Drawing.Size(120, 100);
            this.lstShow.TabIndex = 1;
            this.lstShow.SelectedIndexChanged += new System.EventHandler(this.lstShow_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstShow);
            this.Controls.Add(this.comNJ);
            this.Name = "Form1";
            this.Text = "combobox案例";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comNJ;
        private System.Windows.Forms.ListBox lstShow;
        private System.Windows.Forms.Button button1;
    }
}

