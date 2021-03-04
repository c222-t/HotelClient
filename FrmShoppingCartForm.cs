using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelClient
{
    public partial class FrmShoppingCartForm : Form
    {
        public string Id;
        int cishu = 0;
        public FrmShoppingCartForm()
        {
            InitializeComponent();
        }

        private void FrmShoppingCartForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Info.tables;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 224, 224);//设置背景色
            //dataGridView1.ClearSelection();
            // dataGridView1.Enabled = false;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (cishu<1)
            {
                string i = Id;
                double a;
                double b = 0;
                foreach (var item in Info.tables)
                {
                    a = (double)item.Retail;
                    b += a;
                }
                MessageBox.Show("总金额" + b + "元,欢迎下次光临", "系统提示");
                cishu++;
            }
            else
            {
                MessageBox.Show("您已经结账!!","系统提示");

            }
        }
    }
}
