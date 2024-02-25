using RecursiveSummarizer.GeminiApi;

internal class Program
{
    private static void Main(string[] args)
    {
        var chat = new List<GeminiModelDTO.ContentsDto>();
        chat.Add(new GeminiModelDTO.ContentsDto("user", "teste"));
        chat.Add(new GeminiModelDTO.ContentsDto("user", "teste 2"));
        var teste = new GeminiConverter().ConvertContentsDtoListToRootObject(chat, new GenerationConfig());
        return;
       
    }
}