using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Backend.Models
{
    public class Post
    {
         
            public int Id { get; set; }
            public string Author { get; set; } =string.Empty;
            public int AuthorId { get; set; }    
            public int Likes { get; set; }
            public double Popularity { get; set; }
            public int Reads { get; set; }
            public List<string> Tags { get; set; }=new List<string>();
        }

    [System.Serializable]
    public class PostDto
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("author")]
        public string Author { get; set; } = string.Empty;
        [JsonPropertyName("authorId")]
        public int AuthorId { get; set; }
        [JsonPropertyName("likes")]
        public int Likes { get; set; }
        [JsonPropertyName("popularity")]
        public double Popularity { get; set; }
        [JsonPropertyName("reads")]
        public int Reads { get; set; }
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; } = new List<string>();



    }

    public class ApiResponse
    {
        [JsonProperty("posts")]
        public List<PostDto> Posts { get; set; }
    }



}

