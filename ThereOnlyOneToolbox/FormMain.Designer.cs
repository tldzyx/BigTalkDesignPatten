namespace ThereOnlyOneToolbox
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiEntry1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEntry2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEntry3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEntry1,
            this.tsmiEntry2,
            this.tsmiEntry3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiEntry1
            // 
            this.tsmiEntry1.Name = "tsmiEntry1";
            this.tsmiEntry1.Size = new System.Drawing.Size(99, 21);
            this.tsmiEntry1.Text = "工具窗口入口1";
            this.tsmiEntry1.Click += new System.EventHandler(this.tsmiEntry1_Click);
            // 
            // tsmiEntry2
            // 
            this.tsmiEntry2.Name = "tsmiEntry2";
            this.tsmiEntry2.Size = new System.Drawing.Size(99, 21);
            this.tsmiEntry2.Text = "工具窗口入口2";
            this.tsmiEntry2.Click += new System.EventHandler(this.tsmiEntry2_Click);
            // 
            // tsmiEntry3
            // 
            this.tsmiEntry3.Name = "tsmiEntry3";
            this.tsmiEntry3.Size = new System.Drawing.Size(99, 21);
            this.tsmiEntry3.Text = "工具窗口入口3";
            this.tsmiEntry3.Click += new System.EventHandler(this.tsmiEntry3_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "应用程序";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEntry1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEntry2;
        private System.Windows.Forms.ToolStripMenuItem tsmiEntry3;
    }
}

