using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

using Newtonsoft.Json.Linq;
using System.Net;

namespace tarkovAmmo
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();

            // Material form colour settings
            var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(Win32.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        // Movable window
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Win32.ReleaseCapture();
            Win32.SendMessage(this.Handle, tarkovAmmo.Win32.WM_NCLBUTTONDOWN, tarkovAmmo.Win32.HT_CAPTION, 0);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Win32.ReleaseCapture();
            Win32.SendMessage(this.Handle, tarkovAmmo.Win32.WM_NCLBUTTONDOWN, tarkovAmmo.Win32.HT_CAPTION, 0);
        }

        // Closing and minimising window
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Show panels
        private void btnTraders_Click(object sender, EventArgs e)
        {
            
        }
        private void btnAmmo_Click(object sender, EventArgs e)
        {
            loadForm(new FormAmmo(), FormTab.Ammo);
        }

        public enum FormTab
        {
            Traders,
            Ammo,
            Tasks,
            Flea
        }

        Form fTraders;
        Form fAmmo;
        Form fTasks;
        Form fFlea;

        Form f;
        public void loadForm(object Form, FormTab ft)
        {
            Form f = null;

            switch (ft)
            {
                case FormTab.Traders:
                    f = fTraders;
                    break;
                case FormTab.Ammo:
                    f = fAmmo;
                    break;
                case FormTab.Tasks:
                    f = fTasks;
                    break;
                case FormTab.Flea:
                    f = fFlea;
                    break;
                default:
                    break;
            }

            if (f == null)
            {
                if (this.pnlMain.Controls.Count > 0)
                {
                    this.pnlMain.Controls.RemoveAt(0);
                }
                f = Form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.pnlMain.Controls.Add(f);
                this.pnlMain.Tag = f;
                f.Show();
            }
            else
            { 
                f.Show();
            }
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            loadForm(new FormTasks(), FormTab.Tasks);
        }
        private void btnFlea_Click(object sender, EventArgs e)
        { 

        }
        private void roundedButtons1_Click(object sender, EventArgs e)
        {
            f.Hide();
        }
    }
}