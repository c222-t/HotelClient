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


namespace HotelClient
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                UserLoginManager QWE = new UserLoginManager();
                UserLogin userLogin = QWE.userLogin(txtAccount.Text, txtPassword.Text);
                string name = userLogin.UserName;
                if (userLogin != null)
                {
                    FrmMenu menu = new FrmMenu();
                    menu.Name = name;
                    menu.RoomNumber = txtAccount.Text;
                    menu.IDCard = txtPassword.Text;
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("登录失败，账号或密码错误!!");
                }
            }
        }
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
    }
}
