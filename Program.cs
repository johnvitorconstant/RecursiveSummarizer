using Newtonsoft.Json;
using RecursiveSummarizer.GeminiApi;
using System.Net.Http.Headers;

internal class Program
{
    private async static Task Main(string[] args)
    {

        var response = await GeminiConnectionFactory.PostGemini(new GeminiConverter().CreateCompletitionJson("Hino brasileiro", new GenerationConfig()));
        var responseContent =!string.IsNullOrWhiteSpace(response.Content) ? response.Content : "";
        dynamic? contentObj = JsonConvert.DeserializeObject<dynamic>(response.Content);
        var geminiResponse = new GeminiResponse(contentObj);

        Console.WriteLine(geminiResponse);

    }
}