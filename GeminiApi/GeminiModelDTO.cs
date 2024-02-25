using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveSummarizer.GeminiApi
{
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

