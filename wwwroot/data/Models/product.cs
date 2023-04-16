﻿namespace Allergies.wwwroot.data.Models
{
    public class product
    {
        public string Id {get; set;}
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        public string Image  { get; set; } 

        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int[] Ratings  { get; set; }

        public override ToString() => JsonSerializer.Serialize<product>(this);

        







    }
}
