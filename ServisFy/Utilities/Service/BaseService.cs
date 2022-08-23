using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ServisFy.Utilities.Service
{
    public class BaseService
    {
        private string _apiUrl = "https://bilmemne.cartcurft.com/api/";

        public async Task<string> GetMethod(string parameter)
        {
            using(HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_apiUrl);
                var response = await client.GetAsync(parameter);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                    return "Error!";
            }
        }


    }
}
