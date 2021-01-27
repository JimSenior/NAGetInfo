using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace NAGetInfo
{
    public class HTTPClient
    {
        public async Task<string> GetData(string url)
        {

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseMsg = client.GetAsync(url).Result;
                //responseMsg.EnsureSuccessStatusCode();
                var data = await responseMsg.Content.ReadAsStringAsync();

                return data;
            }
        }



    }
}
