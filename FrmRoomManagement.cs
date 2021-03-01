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
    public partial class FrmRoomManagement : Form
    {
        RoomManagementBusinessLayer room = new RoomManagementBusinessLayer();
        public FrmRoomManagement()
        {
            InitializeComponent();
        }

        private void FrmRoomManagement_Load(object sender, EventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_HOR_POSITIVE);
            List<RoomSchedules> rooms = room.rooms();
            dataGridView1.DataSource = rooms;
        }
    }
}
