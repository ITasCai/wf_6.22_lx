namespace 窗体跳转
{
    partial class Towfrom
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
            this.txtshow = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // txtshow
            // 
            this.txtshow.Location = new System.Drawing.Point(38, 33);
            this.txtshow.Multiline = true;
            this.txtshow.Name = "txtshow";
            this.txtshow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtshow.Size = new System.Drawing.Size(197, 185);
            this.txtshow.TabIndex = 0;
            this.txtshow.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(88, 149);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 1;
            // 
            // Towfrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txtshow);
            this.Name = "Towfrom";
            this.Text = "Towfrom";
            this.Load += new System.EventHandler(this.Towfrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtshow;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}