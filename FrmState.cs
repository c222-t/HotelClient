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
    public partial class FrmState : Form
    {
        public string roomNumber;
        public string roomStatus;
        public string roomType;
        public string floor;
        public FrmState()
        {
            InitializeComponent();
        }

        private void FrmState_Load(object sender, EventArgs e)
        {
            lblRoomNumber.Text = roomNumber;
            lblRoomStatus.Text = roomStatus;
            lblRoomType.Text = roomType;
            lblFloor.Text = floor;
        }
    }
}
