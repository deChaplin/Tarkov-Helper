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

        string sURL = "https://eft-ammo.com/api/data";  // API url
        string json = "";
        JObject jsonObject;

        // Lists
        List<string> allCalibers = new List<string>();
        List<string> allAmmo = new List<string>();
        List<round> rounds = new List<round>();

        // Classes

        class round
        {
            public round(string name, string damage, string penValue, string fragChange, string recoil, string effDist,
                         string maxHsDist, string class1, string class2, string class3, string class4, string class5,
                         string class6, string initialSpeed, string category)
            {
                this.name = name;
                this.damage = damage;
                this.penValue = penValue;
                this.fragChange = fragChange;
                this.recoil = recoil;
                this.effDist = effDist;
                this.maxHsDist = maxHsDist;
                this.class1 = class1;
                this.class2 = class2;
                this.class3 = class3;
                this.class4 = class4;
                this.class5 = class5;
                this.class6 = class6;
                this.initialSpeed = initialSpeed;
                this.category = category;
                this.category = category;
            }

            public string name { get; set; }
            public string damage { get; set; }
            public string penValue { get; set; }
            public string fragChange { get; set; }
            public string recoil { get; set; }
            public string effDist { get; set; }
            public string maxHsDist { get; set; }
            public string class1 { get; set; }
            public string class2 { get; set; }
            public string class3 { get; set; }
            public string class4 { get; set; }
            public string class5 { get; set; }
            public string class6 { get; set; }
            public string initialSpeed { get; set; }
            public string category { get; set; }
        }
        public void getUrl()
        {
            json = getJsonFromApiCall(sURL);  // Gets json

            jsonObject = JObject.Parse(json); // Parses to json
        }
        static string getJsonFromApiCall(string url)
        {
            string sURL = url;

            WebRequest wrGETURL = WebRequest.Create(sURL);

            Stream objStream = wrGETURL.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);

            string sLine = objReader.ReadLine();

            return sLine;
        }

        private void FormAmmo_Load(object sender, EventArgs e)
        {
            getUrl(); // calls the url
            resetForm();

            foreach (var item in jsonObject)
            {
                //string name = item.Key;
                JToken value = item.Value;
                JArray array = (JArray)value;

                allCalibers.Add(item.Key);  // Adding to the calibers list

                // Populates the class
                foreach (JObject item2 in array)
                {
                    string name = item2.GetValue("name").ToString();
                    string damage = item2.GetValue("damage").ToString();
                    string penValue = item2.GetValue("penValue").ToString();
                    string fragChange = item2.GetValue("fragChange").ToString();
                    string recoil = item2.GetValue("recoil").ToString();
                    string effDist = item2.GetValue("effDist").ToString();
                    string maxHsDist = item2.GetValue("maxHsDist").ToString();
                    string class1 = item2.GetValue("class1").ToString();
                    string class2 = item2.GetValue("class2").ToString();
                    string class3 = item2.GetValue("class3").ToString();
                    string class4 = item2.GetValue("class4").ToString();
                    string class5 = item2.GetValue("class5").ToString();
                    string class6 = item2.GetValue("class6").ToString();
                    string initialSpeed = item2.GetValue("initialSpeed").ToString();
                    string category = item2.GetValue("category").ToString();

                    round round = new round(name, damage, penValue, fragChange, recoil, effDist, maxHsDist, class1, class2, class3, class4, class5, class6, initialSpeed, category);

                    rounds.Add(round);  // Adds the rounds to a list
                }
            }

            for (int i = 0; i < allCalibers.Count; i++) // Adding calibers to the drop down box
            {
                cboCalibers.Items.Add(allCalibers[i]);
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

            for (int i = 0; i < allAmmo.Count; i++)
            {
                cboAmmo.Items.Add(allAmmo[i]);
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
