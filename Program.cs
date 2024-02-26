using Newtonsoft.Json;
using RecursiveSummarizer.GeminiApi;
using System.Net.Http.Headers;

internal class Program
{
    private async static Task Main(string[] args)
    {

        Console.WriteLine(await GeminiConnectionFactory.GeminiGenerateContentFromString("Traduza para o ingles: \nBom dia, qual é a boa de hoje?"));

    }


}