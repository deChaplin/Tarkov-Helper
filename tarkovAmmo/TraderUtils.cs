
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
            return null;
        }
    }
}
