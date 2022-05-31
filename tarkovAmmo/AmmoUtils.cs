﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;

namespace tarkovAmmo
{
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

    class utilities
    {
        public static JObject GetJSONFromApiCall(string url)
        {
            string sURL = url;

            WebRequest wrGETURL = WebRequest.Create(sURL);

            Stream objStream = wrGETURL.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);

            string sLine = objReader.ReadLine();

            return JObject.Parse(sLine);
        }
    }
}
