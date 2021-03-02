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
            a =int.Parse(textBox2.Text);
            //textBox3.Text = (jin * a).ToString();
        }
    }
}
