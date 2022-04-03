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

    public partial class Form1 : Form
    {
        bool mouseDown;
        private Point offset;
        private RoomForm roomForm;
        private DataForm dataForm;

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

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            Point panelLocation = panel1.Location;
            Size panelSize = panel1.Size;
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(panelLocation.X, panelLocation.Y, panelSize.Width, panelSize.Height, 10, 10));
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void MakeRoomForm()
        {
            roomForm = new RoomForm();
            roomForm.TopLevel = false;
            childFormPanel.Controls.Add(roomForm);
            roomForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            roomForm.Size = childFormPanel.Size;
            roomForm.Dock = DockStyle.Fill;


        }

        private void MakeDataForm()
        {
            dataForm = new DataForm();
            dataForm.TopLevel = false;
            childFormPanel.Controls.Add(dataForm);
            dataForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dataForm.Size = childFormPanel.Size;
            dataForm.Dock = DockStyle.Fill;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeRoomForm();
            MakeDataForm();
            
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            dataForm.Hide();
            roomForm.Show();
        }
        private void usersButton_Click(object sender, EventArgs e)
        {
            roomForm.Hide();
            dataForm.Show();

        }
    }
}
