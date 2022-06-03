
using System.Net;
using Newtonsoft.Json.Linq;


namespace tarkovAmmo
{
    class trader
    {
        public trader(string name, string resetTimeStamp)
        {
            this.name = name;
            this.resetTimeStamp = resetTimeStamp;
        }

        public string name { get; set; }
        public string resetTimeStamp { get; set; }
    }

    class traderUtils
    {
        public List<trader> getAllTraders()
        {
            List<trader> traders = new List<trader>();

            string url = "https://eft-ammo.com/api/data";
            string kKey = "query";
            string vValue = "{traders(lang: en){name resetTime}}";
            JObject jsonObject = Utils.GetJsonFromPost(url, kKey, vValue);

            foreach (var item in jsonObject)
            {
                String key = item.Key; // Key of "item"
                JToken value = item.Value; // Value of "item"
                JArray array = (JArray)value; // Turning JArray "item" into real JArray
            }

            return traders;
        }
    }
}
