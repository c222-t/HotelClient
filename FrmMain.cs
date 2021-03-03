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
using HotelRegulator;


namespace HotelClient
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (Check())
            { 
                UserLoginManager QWE = new UserLoginManager();
                UserLogin userLogin = QWE.userLogin(txtAccount.Text, txtPassword.Text);
                
                if (userLogin != null)
                {
                    string name = userLogin.UserName;
                    int shu = userLogin.Days;
                    FrmMenu menu = new FrmMenu();
                    menu.Name = name;
                    menu.RoomNumber = txtAccount.Text;
                    menu.IDCard = txtPassword.Text;

                    if (shu < 2)
                        nfl.ShowBalloonTip(500, "歪嘴大酒店提醒您", "您的房间还有一天到期 请及时续费", ToolTipIcon.Info);
                    
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("登录失败，账号或密码错误!!");
                }
            }
        }

        /// <summary>
        /// 判断输入的账号和密码是否为空
        /// </summary>
        /// <returns></returns>
        public bool Check()
        {
            if (txtAccount.Text == "")
            {
                MessageBox.Show("请输入账号！！");
                return false;
            }
            else if(txtPassword.Text == "")
            {
                MessageBox.Show("请输入密码！！");
                return false;
            }
            return true;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_HOR_POSITIVE);
        }
    }
}
