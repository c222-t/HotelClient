using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelClient
{
    public partial class FrmPayment : Form
    {
        public string yuan;
        public string jin;
        int a;
        public FrmPayment()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            //FrmHotelServices frm = new FrmHotelServices();
            this.textBox1.Text = yuan;

            Kan();
        }

        public void Kan()
        {
            a = int.Parse(shuliang.Text);
            int b = int.Parse(jin);
             (b * a).ToString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(shuliang.Text);
            int b = int.Parse(jin);
            (b * a).ToString();
            MessageBox.Show("请微信或支付宝支付" + (b * a).ToString() + "元");
            notifyIcon1.ShowBalloonTip(500, "歪嘴大酒店提醒您", "亲,您好 我们的歪嘴服务员正在给您送商品的路上，请稍等", ToolTipIcon.Info);
        }
    }
}
