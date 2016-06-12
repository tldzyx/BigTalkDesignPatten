namespace PersonBuilder
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pic00 = new System.Windows.Forms.PictureBox();
            this.pic01 = new System.Windows.Forms.PictureBox();
            this.pic10 = new System.Windows.Forms.PictureBox();
            this.pic11 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic11)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pic00, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pic01, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pic10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pic11, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pic00
            // 
            this.pic00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic00.Location = new System.Drawing.Point(3, 3);
            this.pic00.Name = "pic00";
            this.pic00.Size = new System.Drawing.Size(386, 274);
            this.pic00.TabIndex = 0;
            this.pic00.TabStop = false;
            this.pic00.Paint += new System.Windows.Forms.PaintEventHandler(this.pic00_Paint);
            // 
            // pic01
            // 
            this.pic01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic01.Location = new System.Drawing.Point(395, 3);
            this.pic01.Name = "pic01";
            this.pic01.Size = new System.Drawing.Size(386, 274);
            this.pic01.TabIndex = 1;
            this.pic01.TabStop = false;
            this.pic01.Paint += new System.Windows.Forms.PaintEventHandler(this.pic01_Paint);
            // 
            // pic10
            // 
            this.pic10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic10.Location = new System.Drawing.Point(3, 283);
            this.pic10.Name = "pic10";
            this.pic10.Size = new System.Drawing.Size(386, 275);
            this.pic10.TabIndex = 2;
            this.pic10.TabStop = false;
            this.pic10.Paint += new System.Windows.Forms.PaintEventHandler(this.pic10_Paint);
            // 
            // pic11
            // 
            this.pic11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic11.Location = new System.Drawing.Point(395, 283);
            this.pic11.Name = "pic11";
            this.pic11.Size = new System.Drawing.Size(386, 275);
            this.pic11.TabIndex = 3;
            this.pic11.TabStop = false;
            this.pic11.Paint += new System.Windows.Forms.PaintEventHandler(this.pic11_Paint);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "建造小人";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pic00;
        private System.Windows.Forms.PictureBox pic01;
        private System.Windows.Forms.PictureBox pic10;
        private System.Windows.Forms.PictureBox pic11;
    }
}

