using System.Net;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace tarkovAmmo
{
    class Utils
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

        public static JObject GetJsonFromPost(string url, string key, string value)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
                client.DefaultRequestHeaders.Add("Accept", "*/*");

                var Parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>(key, value),
            };

                var Request = new HttpRequestMessage(HttpMethod.Post, url)
                {
                    Content = new FormUrlEncodedContent(Parameters)
                };

                var Result = client.SendAsync(Request).Result.Content.ReadAsStringAsync();
                return JObject.Parse(Result.ToString());
            }
            return null;
        }
    }
}
