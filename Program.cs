using Newtonsoft.Json;
using RecursiveSummarizer.GeminiApi;
using System.Net.Http.Headers;

internal class Program
{
    private async static Task Main(string[] args)
    {

        var teste = await GeminiConnectionFactory.PostGemini(new GeminiConverter().CreateCompletitionJson("Hino brasileiro", new GenerationConfig()));
        Console.WriteLine(teste.Content);

    }
}