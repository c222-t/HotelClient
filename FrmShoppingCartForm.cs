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
        public FrmShoppingCartForm()
        {
            InitializeComponent();
        }

        private void FrmShoppingCartForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Info.tables;
        }
    }
}
