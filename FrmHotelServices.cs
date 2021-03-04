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
        public string Id;
        HotelServiceBusinessLayer hotel = new HotelServiceBusinessLayer();
        public FrmHotelServices()
        {
            InitializeComponent();
        }

        private void FrmHotelServices_Load(object sender, EventArgs e)
        {
            Check();
        }
        public void Check()
        {
            List<CommodityTable> tables = hotel.tables();
            dataGridView1.DataSource = tables;
            for (int i = 0; i < tables.Count; i++)
            {
                imageList1.Images.Add(Image.FromFile(tables[i].PicturePath.Trim()));
                dataGridView1.Rows[i].Cells[0].Value = imageList1.Images[i];
            }
            dataGridView1.ClearSelection();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void 加入购物车ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否加入购物车"+this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim()+"?","购物车提示",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CommodityTable commodityTable = new CommodityTable()
                {
                    CommodityName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim(),
                    CommodityUnit = dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Trim(),
                    Retail = (double) dataGridView1.SelectedRows[0].Cells[3].Value
                };
                Info.tables.Add(commodityTable);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            FrmShoppingCartForm frmHotel = new FrmShoppingCartForm();
            frmHotel.Id = Id;
            frmHotel.Show();
        }
    }
}

