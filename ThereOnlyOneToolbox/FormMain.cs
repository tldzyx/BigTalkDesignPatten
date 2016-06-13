using System;
using System.Windows.Forms;

namespace ThereOnlyOneToolbox
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            ActiveForm = this;
            InitializeComponent();
        }

        public static FormMain ActiveForm { get; private set; }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void tsmiEntry1_Click(object sender, EventArgs e)
        {
            FormToolBox formToolBox = FormToolBox.GetInstance();
            formToolBox.WindowState = FormWindowState.Normal;
            formToolBox.Show();
        }

        private void tsmiEntry2_Click(object sender, EventArgs e)
        {
            FormToolBox formToolBox = FormToolBox.GetInstance();
            formToolBox.WindowState = FormWindowState.Normal;
            formToolBox.Show();
        }

        private void tsmiEntry3_Click(object sender, EventArgs e)
        {
            FormToolBox formToolBox = FormToolBox.GetInstance();
            formToolBox.WindowState = FormWindowState.Normal;
            formToolBox.Show();
        }
    }
}