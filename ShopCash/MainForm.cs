using System;
using System.Globalization;
using System.Windows.Forms;
using ShopCash.Cashs;

namespace ShopCash
{
    public partial class MainForm : Form
    {
        private double _total = 0f;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CashContext context = new CashContext(cmbStategy.SelectedItem.ToString());
            
            double price = Convert.ToDouble(txtPrice.Text);
            double count = Convert.ToDouble(txtCount.Text);
            double money = price*count;
            double total = context.GetResult(money);

            lbxDetail.Items.Add($"单价：{price} 数量：{count} 合计：{total}");
            txtTotal.Text = total.ToString(CultureInfo.InvariantCulture);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _total = 0f;

            txtPrice.Clear();
            txtCount.Text = "1";
            cmbStategy.SelectedIndex = 0;
            lbxDetail.Items.Clear();
            txtTotal.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbStategy.SelectedIndex = 0;
        }
    }
}
