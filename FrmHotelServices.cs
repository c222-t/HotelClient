using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBLL;
using HotelModel;
using System.Data.SqlClient;

namespace HotelClient
{
    public partial class FrmHotelServices : Form
    {

        public DataTable Data;
        public string name;
        public string jin;


        public string mingchen;
        public string danwei;
        public string jine;


        HotelServiceBusinessLayer hotel = new HotelServiceBusinessLayer();
        public FrmHotelServices()
        {
            InitializeComponent();
        }

        private void FrmHotelServices_Load(object sender, EventArgs e)
        {
            List<CommodityTable> tables = hotel.tables();
            //dataGridView1.SelectedRows[0].Cells[0].Value = imageList1.Images[0];
            dataGridView1.DataSource = tables;
            dataGridView1.ClearSelection();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Check();
        }
        public void Check()
        {
            dataGridView1.Rows[0].Cells[0].Value = imageList1.Images[0];
            dataGridView1.Rows[1].Cells[0].Value = imageList1.Images[1];
            dataGridView1.Rows[2].Cells[0].Value = imageList1.Images[2];
            dataGridView1.Rows[3].Cells[0].Value = imageList1.Images[3];
            dataGridView1.Rows[4].Cells[0].Value = imageList1.Images[4];
        }

        private void 加入购物车ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否加入购物车"+this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim()+"?","购物车提示",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CommodityTable commodityTable = new CommodityTable()
                {
                    PicturePath = "1",
                    CommodityName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim(),
                    CommodityUnit = dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Trim(),
                    Retail = (double) dataGridView1.SelectedRows[0].Cells[3].Value
                };
                Info.tables.Add(commodityTable);

            }
        }

        private void 购买ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPayment fp = new FrmPayment();
            name = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            fp.yuan = name;
            jin = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            fp.jin = jin;
            fp.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmShoppingCartForm frmHotel = new FrmShoppingCartForm();
            frmHotel.Show();
        }
    }
}

