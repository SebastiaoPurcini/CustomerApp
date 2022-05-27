using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CustomerApp.Core.Services.API
{
    public static class ResponseIBGE
    {
        public async static Task<string> GetContent(string path)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(Base.baseUrl)
            };

            var response = await client.GetAsync(path);
            
            return await response.Content.ReadAsStringAsync();
        }
    }
}
