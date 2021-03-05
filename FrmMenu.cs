using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelModel;
using HotelBLL;
using HotelRegulator;

namespace HotelClient
{
    public partial class FrmMenu : Form
    {
        public string Name;
        public string RoomNumber;
        public string IDCard;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblName.Text = "欢迎" + Name + "光临";
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_HOR_POSITIVE);
            State();
            Check();
            textBox2.Text = "正在获取当前位置天气信息............";
            Weather();
        }
        public void Check()
        {
            HotelServiceBusinessLayer hotel = new HotelServiceBusinessLayer();
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
        private void TmAime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }
        public void Weather()
        {
            cn.com.webxml.www.WeatherWebService w = new cn.com.webxml.www.WeatherWebService();
            string[] s = new string[23];//声明string数组存放返回结果  
            string city = "深圳";//获得文本框录入的查询城市
            s = w.getWeatherbyCityName(city);
            try
            {
                textBox2.Text = String.Format("省份:{0}  城市: {1}\r\n今日气温: {2}\r\n概况: {3}\r\n现在的天气实况: {4}\r\n天气和生活指数: {5}", s[0], s[1],s[5], s[6], s[7], s[10]);
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\weather\\" + s[8]);
                pbWeather2.Image = Image.FromFile(Application.StartupPath + "\\weather\\" + s[9]);
                lblda.Text = ">";
            }
            catch (Exception)
            {
                textBox2.Text = "查询错误！链接网络或刷新....";
            }

        }
        public void State()
        {
            RoomStatusBusiness_layer roomStatusBusiness_Layer = new RoomStatusBusiness_layer();
            RoomSchedules roomSchedules = roomStatusBusiness_Layer.rooms(RoomNumber);
            ReportBusinessLayerManager report = new ReportBusinessLayerManager();
            StatementOfAccount ofAccounts = report.Soa(IDCard);
            
            lblRoomNumber.Text = roomSchedules.RoomNumber;
            lblRoomStatus.Text = roomSchedules.RoomStatus;
            lblRoomType.Text = roomSchedules.RoomType;
            lblFloor.Text = roomSchedules.Floor;
            lblTotalConsumption.Text = ofAccounts.TotalConsumption;
            lblBalance.Text = ofAccounts.money;
        }

        private void BtnShoppingCart_Click(object sender, EventArgs e)
        {
            FrmShoppingCartForm frmShoppingCart = new FrmShoppingCartForm();
            frmShoppingCart.Id = IDCard;
            frmShoppingCart.Show();
        }

        private void TsmiAddShoppingCart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否加入购物车" + this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim() + "?", "购物车提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CommodityTable commodityTable = new CommodityTable()
                {
                    CommodityName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Trim(),
                    CommodityUnit = dataGridView1.SelectedRows[0].Cells[3].Value.ToString().Trim(),
                    Retail = (double)dataGridView1.SelectedRows[0].Cells[4].Value
                };
                Info.tables.Add(commodityTable);
            }
        }

        private void LblWeather_Click(object sender, EventArgs e)
        {
            Weather();
        }
    }
}
