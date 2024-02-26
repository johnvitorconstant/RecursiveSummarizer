using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RecursiveSummarizer.GeminiApi.GeminiModelDTO;

namespace RecursiveSummarizer.GeminiApi
{
    public class GeminiConverter
    {
        public RootObject ConvertContentsDtoListToRootObject(
        List<ContentsDto> contentsDtoList,
        GenerationConfig generationConfig)
        {
            List<Content> contents = new List<Content>();
            foreach (var contentsDto in contentsDtoList)
            {
                List<Content.Part> parts = new List<Content.Part>
            {
                new Content.Part(contentsDto.Text)
            };

                Content content = new Content(contentsDto.Role, parts);
                contents.Add(content);
            }

            return new RootObject(contents, generationConfig);
        }

        public RootObject CreateCompletionJson(string input, GenerationConfig generationConfig)
        {
            var contents = CreateContentJson(input, generationConfig);
            return new RootObject(contents, generationConfig);
        }

        public List<Content> CreateContentJson(string input, GenerationConfig generationConfig)
        {
            List<Content> contents = new List<Content>()
            {
             new Content("user", new List<Content.Part> { new Content.Part(input) })
            };


            return contents;
        }

    }
    public class GeminiModelDTO
    {


        public class ContentsDto
        {
            public ContentsDto(string role, string text)
            {
                Role = role;
                Text = text;
            }

            public string Role { get; set; } = "user";

            public string Text { get; set; } = string.Empty;
        }
    }
}
