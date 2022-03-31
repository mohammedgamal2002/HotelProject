using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class RoomForm : Form
    {
        public static List<Room> roomList = new List<Room>();
        private bool IsShown = false;
        private int shown = 0;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,     // x-coordinate of upper-left corner
    int nTopRect,      // y-coordinate of upper-left corner
    int nRightRect,    // x-coordinate of lower-right corner
    int nBottomRect,   // y-coordinate of lower-right corner
    int nWidthEllipse, // width of ellipse
    int nHeightEllipse // height of ellipse
);

        public RoomForm()
        {
            InitializeComponent();


        }
        private void RenderRoomObject()
        {
            for (int i = shown; i < roomList.Count; i++)
            {
                Room room = roomList[i];

                Panel panel = new Panel();
                panel.Margin = new System.Windows.Forms.Padding(10, 10, 20, 20);
                panel.Size = new System.Drawing.Size(240, 205);

                //Rounded Borders
                panel.BorderStyle = System.Windows.Forms.BorderStyle.None;
                Point panelLocation = panel.Location;
                Size panelSize = panel.Size;
                panel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(panelLocation.X, panelLocation.Y, panelSize.Width, panelSize.Height, 20, 20));




                Label roomNumber = new Label();
                roomNumber.Size = new Size(240, 29);
                roomNumber.Dock = DockStyle.Bottom;
                roomNumber.ForeColor = Color.FromArgb(17, 141, 237);
                roomNumber.BackColor = Color.FromArgb(242, 245, 247);
                roomNumber.Text = room.roomNumber.ToString();
                roomNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                roomNumber.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                roomNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                roomNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                roomNumber.Click += new System.EventHandler(this.roomLink_Click);


                PictureBox picture = new PictureBox();
                picture.Dock = DockStyle.Fill;
                picture.BackColor = Color.Transparent;
                picture.LoadAsync(room.roomPic);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Click += new System.EventHandler(Room_Click);


                panel.Controls.Add(roomNumber);
                panel.Controls.Add(picture);


                roomsFlowPanel.Controls.Add(panel);
                shown = i + 1;
            }
        }

        private void Room_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void roomLink_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            Room room1 = new Room("normal",500,"Hotel-Room.jpg","12312qdsada");
            Room room2 = new Room("Vip",900, "Hotel-Room.jpg", "12312qdsada");
            Room room3 = new Room("Test",800, "Hotel-Room.jpg", "12312qdsada");
            roomList.Add(room1);
            roomList.Add(room2);
            roomList.Add(room3);

            roomsNumLabel.Text = roomList.Count.ToString();

            if (IsShown == false)
            {
                RenderRoomObject();
                IsShown = true;
            }
        }

        private void roomsFlowPanel_VisibleChanged(object sender, EventArgs e)
        {
            RenderRoomObject();

        }
    }


    public class Room
    {
        public int roomNumber { get; set; }
        public string roomType { get; set; }
        public int roomPrice { get; set; }
        public string roomPic;
        public string link;
        static int count = 0;
        public Room( string roomType, int roomPrice, string roomPic, string link)
        {
            this.roomNumber = count++;
            this.roomType = roomType;
            this.roomPrice = roomPrice;
            this.roomPic = roomPic;
            this.link = link;
        }
    }
}
