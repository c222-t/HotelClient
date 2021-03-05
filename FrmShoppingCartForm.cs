using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelBLL;
using HotelModel;

namespace HotelClient
{
    public partial class FrmShoppingCartForm : Form
    {
        public string Id;
        int cishu = 0;

        #region 客户端
        public void Client()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        /// <summary>
        /// 连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Conn()
        {
            try
            {
                //创建一个负责链接的Socket
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //获得链接的IP地址 
                IPAddress iP = IPAddress.Parse("192.168.43.207");
                //获得要远程连接的IP地址和端口号
                IPEndPoint point = new IPEndPoint(iP, Convert.ToInt32("52000"));

                socketSend.Connect(point);
                ShowMsg("链接成功");
            }
            catch
            {
                ShowMsg("链接失败");
            }
        }
        Socket socketSend;

        /// <summary>
        /// 客服端给服务器发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void  Send ()
        {
            //定义一个字符串变量，用来储存txtText.Text的文本内容
            string str = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                str += dataGridView1.Rows[i].Cells[1].Value.ToString().Trim()+",";
            }
            //通过UTF8编码转换成8位无符号整数，字节数组
            str = str.Substring(0,str.Length -1);
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
            //socketSend.Send(buffer);
            //将buffer中的数据发送到Socket
            socketSend.Send(buffer);
        }

        /// <summary>
        /// 将信息显示到服务端的对话框上
        /// </summary>
        /// <param name="str"></param>
        void ShowMsg(string str)
        {
            MessageBox.Show(str + "\r\n");

        }
        #endregion
        public FrmShoppingCartForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void FrmShoppingCartForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Info.tables;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 224, 224);//设置背景色
            Client();
            Conn();

            //dataGridView1.ClearSelection();
            // dataGridView1.Enabled = false;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("您没有购买任何商品!!!");
                return;
            }
            if (cishu<1)
            {
                Send();
                string i = Id;
                double a;
                double b = 0;
                foreach (var item in Info.tables)
                {
                    a = (double)item.Retail;
                    b += a;
                }
                //string sql = "insert into TrolleyTable(IDCard, Number, Quantity)values('431122200202021234','1','1')";
                MessageBox.Show("总金额" + b + "元,欢迎下次光临", "系统提示");
                cishu++;
                Info.tables.Clear();
                nfl.ShowBalloonTip(500, "歪嘴大酒店提醒您", "您的商品歪嘴服务员正在送来的路上请稍等", ToolTipIcon.Info);

            }
            else
            {
                MessageBox.Show("您已经结账!!","系统提示");

            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
