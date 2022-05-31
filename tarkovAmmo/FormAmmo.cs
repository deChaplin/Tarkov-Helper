using System;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;

namespace tarkovAmmo
{
    public partial class FormAmmo : Form
    {
        public FormAmmo()
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

        // Lists
        List<string> allCalibers = new List<string>();
        List<string> allAmmo = new List<string>();
        List<round> rounds = new List<round>();

        private void FormAmmo_Load(object sender, EventArgs e)
        {
            string url = "https://eft-ammo.com/api/data";
            JObject jsonObject = tarkovAmmo.utilities.GetJSONFromApiCall(url);
            resetForm();

            foreach (var item in jsonObject)
            {
                JToken value = item.Value; // Value of "item"
                JArray array = (JArray) value; // Turning JArray "item" into real JArray

                allCalibers.Add(item.Key);  // Adding to the calibers list

                // Populates the class
                foreach (JObject item2 in array)
                {
                    // Create new round with given properties
                    round round = new round(
                        item2.GetValue("name").ToString(),
                        item2.GetValue("damage").ToString(),
                        item2.GetValue("penValue").ToString(),
                        item2.GetValue("fragChange").ToString(),
                        item2.GetValue("recoil").ToString(),
                        item2.GetValue("effDist").ToString(),
                        item2.GetValue("maxHsDist").ToString(),
                        item2.GetValue("class1").ToString(),
                        item2.GetValue("class2").ToString(),
                        item2.GetValue("class3").ToString(),
                        item2.GetValue("class4").ToString(),
                        item2.GetValue("class5").ToString(),
                        item2.GetValue("class6").ToString(),
                        item2.GetValue("initialSpeed").ToString(),
                        item2.GetValue("category").ToString()
                    );

                    rounds.Add(round);  // Adds the rounds to a list
                }
            }

            foreach (String caliber in allCalibers)
            {
                cboCalibers.Items.Add(caliber);
            }
        }

        private void cboCalibers_TextChanged(object sender, EventArgs e)
        {
            cboAmmo.Items.Clear();
            allAmmo.Clear();
            resetForm();

            string selectedCaliber = cboCalibers.Text;

            foreach (round rnd in rounds)
            {
                if (rnd.category == selectedCaliber)
                {
                    allAmmo.Add(rnd.name);
                }
            }

            foreach (String rnd in allAmmo)
            {
                cboAmmo.Items.Add(rnd);
            }
        }

        private void cboAmmo_TextChanged(object sender, EventArgs e)
        {
            string selectedAmmo = cboAmmo.Text;

            foreach (round rnd in rounds)
            {
                if (rnd.name == selectedAmmo)
                {
                    lblRDamage.Text = rnd.damage;
                    lblRPenValue.Text = rnd.penValue;
                    lblRFragChance.Text = rnd.fragChange;
                    lblRRecoil.Text = rnd.recoil;
                    lblREffDist.Text = rnd.effDist;
                    lblRMaxHsDist.Text = rnd.maxHsDist;
                    lblRC1.Text = rnd.class1;
                    lblRC2.Text = rnd.class2;
                    lblRC3.Text = rnd.class3;
                    lblRC4.Text = rnd.class4;
                    lblRC5.Text = rnd.class5;
                    lblRC6.Text = rnd.class6;
                }
            }

            groupBox.Text = selectedAmmo;

        }

        void resetForm()
        {
            // Clears text box
            lblRDamage.Text = "";
            lblRPenValue.Text = "";
            lblRFragChance.Text = "";
            lblRRecoil.Text = "";
            lblREffDist.Text = "";
            lblRMaxHsDist.Text = "";
            lblRC1.Text = "";
            lblRC2.Text = "";
            lblRC3.Text = "";
            lblRC4.Text = "";
            lblRC5.Text = "";
            lblRC6.Text = "";

            groupBox.Text = "Round";
        }
    }
}
