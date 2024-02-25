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
    }
}
