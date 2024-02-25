using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RecursiveSummarizer.GeminiApi
{
    public static class GeminiConnectionFactory
    {
        public static async Task<RestResponse> PostGemini(RootObject root)
        {

            var options = new RestClientOptions("https://generativelanguage.googleapis.com")
            {
                MaxTimeout = -1,
            };

            var client = new RestClient(options);
            var request = new RestRequest($"/v1beta/models/gemini-1.0-pro:generateContent?key={Environment.GetEnvironmentVariable("gemini_key")}", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = JsonConvert.SerializeObject(root);
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            return response;
        }

    }
}
