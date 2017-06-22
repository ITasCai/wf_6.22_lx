namespace Timer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrshow = new System.Windows.Forms.Timer(this.components);
            this.imapic = new System.Windows.Forms.ImageList(this.components);
            this.picimg = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picimg)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrshow
            // 
            this.tmrshow.Tick += new System.EventHandler(this.tmrshow_Tick);
            // 
            // imapic
            // 
            this.imapic.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imapic.ImageStream")));
            this.imapic.TransparentColor = System.Drawing.Color.Transparent;
            this.imapic.Images.SetKeyName(0, "X6{U8$7QZB{BSQ`GF%OION5.gif");
            this.imapic.Images.SetKeyName(1, "6`J_C$7[2D6H7)JKHIWV@$S.gif");
            // 
            // picimg
            // 
            this.picimg.Image = ((System.Drawing.Image)(resources.GetObject("picimg.Image")));
            this.picimg.Location = new System.Drawing.Point(63, 24);
            this.picimg.Name = "picimg";
            this.picimg.Size = new System.Drawing.Size(135, 128);
            this.picimg.TabIndex = 0;
            this.picimg.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picimg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrshow;
        private System.Windows.Forms.ImageList imapic;
        private System.Windows.Forms.PictureBox picimg;
        private System.Windows.Forms.Button button1;
    }
}

