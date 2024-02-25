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
        public RootObject(List<Content> contents, GenerationConfig generationConfig)
        {
            Contents = contents;
            GenerationConfig = generationConfig;
            SafetySettings = new List<SafetySetting> { 
            new SafetySetting("HARM_CATEGORY_HARASSMENT", "BLOCK_ONLY_HIGH"),
            new SafetySetting("HARM_CATEGORY_HATE_SPEECH", "BLOCK_ONLY_HIGH"),
            new SafetySetting("HARM_CATEGORY_SEXUALLY_EXPLICIT", "BLOCK_ONLY_HIGH"),
            new SafetySetting("HARM_CATEGORY_DANGEROUS_CONTENT", "BLOCK_ONLY_HIGH"),
            };
        }

        [JsonProperty("contents")]
        public List<Content> Contents { get; private set; }

        [JsonProperty("generationConfig")]
        public GenerationConfig GenerationConfig { get; private set; }

        [JsonProperty("safetySettings")]
        public List<SafetySetting> SafetySettings { get; private set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
    public class Content
    {
        public Content(string role, List<Part> parts)
        {
            Role = role;
            Parts = parts;
        }

        [JsonProperty("role")]
        public string Role { get; private set; }

        [JsonProperty("parts")]
        public List<Part> Parts { get; private set; }

        public class Part
        {
            public Part(string text)
            {
                Text = text;
            }

            [JsonProperty("text")]
            public string Text { get; private set; }

            public override bool Equals(object? obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public override string? ToString()
            {
                return base.ToString();
            }
        }
    }

    public class GenerationConfig
    {
        public GenerationConfig(double temperature = 0.9, int topK = 1, int topP = 1, int maxOutputTokens = 2048, List<string> stopSequences = null)
        {
            Temperature = temperature;
            TopK = topK;
            TopP = topP;
            MaxOutputTokens = maxOutputTokens;
            StopSequences = stopSequences ?? new List<string>();
        }

        [JsonProperty("temperature")]
        public double Temperature { get; private set; }

        [JsonProperty("topK")]
        public int TopK { get; private set; }

        [JsonProperty("topP")]
        public int TopP { get; private set; }

        [JsonProperty("maxOutputTokens")]
        public int MaxOutputTokens { get; private set; }

        [JsonProperty("stopSequences")]
        public List<string> StopSequences { get; private set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }


    public class SafetySetting

    {
        public SafetySetting(string category, string threshold)
        {
            Category = category;
            Threshold = threshold;
        }

        [JsonProperty("category")]
        public string Category { get; private set; }

        [JsonProperty("threshold")]
        public string Threshold { get; private set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }



}
