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
        Form fTraders;
        Form fAmmo;
        Form fTasks;
        Form fFlea;
        Form fPatch;

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
            // << Creating the forms >>

            // Traders form
            fPatch = new FormPatchNotes();
            fPatch.TopLevel = false;
            fPatch.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(fPatch);
            this.pnlMain.Tag = fPatch;

            // Traders form
            fTraders = new FormTraders();
            fTraders.TopLevel = false;
            fTraders.Dock = DockStyle.Fill;
            // Flea form
            fFlea = new FormFlea();
            fFlea.TopLevel = false;
            fFlea.Dock = DockStyle.Fill;
            // Tasks form
            fTasks = new FormTasks();
            fTasks.TopLevel = false;
            fTasks.Dock = DockStyle.Fill;
            // Ammo form
            fAmmo = new FormAmmo();
            fAmmo.TopLevel = false;
            fAmmo.Dock = DockStyle.Fill;

            // Hiding the forms by default
            hideAll();
            fPatch.Show();
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
        // Closing window
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Minimising window
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // Show panels
        private void btnTraders_Click(object sender, EventArgs e)
        {
            btnAmmo.Enabled = true;
            btnFlea.Enabled = true;
            btnTasks.Enabled = true;
            btnTraders.Enabled = false;

            hideAll();

            this.pnlMain.Controls.Add(fTraders);
            this.pnlMain.Tag = fTraders;
            fTraders.Show();
        }
        private void btnAmmo_Click(object sender, EventArgs e)
        {
            btnAmmo.Enabled = false;
            btnFlea.Enabled = true;
            btnTasks.Enabled = true;
            btnTraders.Enabled = true;

            hideAll();

            this.pnlMain.Controls.Add(fAmmo);
            this.pnlMain.Tag = fAmmo;
            fAmmo.Show();
        }
        private void btnTasks_Click(object sender, EventArgs e)
        {
            btnAmmo.Enabled = true;
            btnFlea.Enabled = true;
            btnTasks.Enabled = false;
            btnTraders.Enabled = true;

            hideAll();

            this.pnlMain.Controls.Add(fTasks);
            this.pnlMain.Tag = fTasks;
            fTasks.Show();
        }
        private void btnFlea_Click(object sender, EventArgs e)
        {
            btnAmmo.Enabled = true;
            btnFlea.Enabled = false;
            btnTasks.Enabled = true;
            btnTraders.Enabled = true;

            hideAll();

            this.pnlMain.Controls.Add(fFlea);
            this.pnlMain.Tag = fFlea;
            fFlea.Show();
        }
        private void hideAll()
        {
            fTraders.Hide();
            fAmmo.Hide();
            fTasks.Hide();
            fFlea.Hide();
            fPatch.Hide();
        }
    }
}