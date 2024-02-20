using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveSummarizer.GeminiApi
{
    public class RootObject
    {
        [JsonProperty("contents")]
        public List<Content> Contents { get; set; } = new List<Content>();

        [JsonProperty("generationConfig")]
        public GenerationConfig GenerationConfig { get; set; } = new GenerationConfig();

        [JsonProperty("safetySettings")]
        public List<SafetySetting> SafetySettings { get; set; } = new List<SafetySetting>();
    }
    public class Content
    {
        [JsonProperty("role")]
        public string Role { get; set; } = string.Empty;

        [JsonProperty("parts")]
        public List<Part> Parts { get; set; } = new List<Part>();

        public class Part
        {
            [JsonProperty("text")]
            public string Text { get; set; } = string.Empty;
        }
    }

    public class GenerationConfig
    {
        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("topK")]
        public int TopK { get; set; }

        [JsonProperty("topP")]
        public int TopP { get; set; }

        [JsonProperty("maxOutputTokens")]
        public int MaxOutputTokens { get; set; }

        [JsonProperty("stopSequences")]
        public List<string> StopSequences { get; set; } = new List<string>();
    }


    public class SafetySetting

    {
        [JsonProperty("category")]
        public string Category { get; set; } = string.Empty;

        [JsonProperty("threshold")]
        public string Threshold { get; set; } = string.Empty;
    }



}
