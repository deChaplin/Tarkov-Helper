using System.Net;
using Newtonsoft.Json.Linq;

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

    class AmmoUtils
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

        public static List<string> getAllCalibers()
        {
            List<string> calibers = new List<string>();

            string url = "https://eft-ammo.com/api/data";
            JObject jsonObject = tarkovAmmo.AmmoUtils.GetJSONFromApiCall(url);

            foreach (var item in jsonObject)
            {
                calibers.Add(item.Key);
            }

            return calibers;
        }
        // Double API call here.. not great but will fix eventually.
        public static List<round> getAllRounds()
        {
            List<round> rounds = new List<round>();

            string url = "https://eft-ammo.com/api/data";
            JObject jsonObject = tarkovAmmo.AmmoUtils.GetJSONFromApiCall(url);

            foreach (var item in jsonObject)
            {
                JToken value = item.Value; // Value of "item"
                JArray array = (JArray)value; // Turning JArray "item" into real JArray

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
            return rounds; // Returns said list
        }
    }
}
