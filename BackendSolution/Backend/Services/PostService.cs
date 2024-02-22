using Backend.Models;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System.IO;

namespace Backend.Services
{
    public class PostService:IPostService
    {
        private readonly string apiUrl = "https://api.hatchways.io/assessment/blog/posts";

        public async Task<ServiceResponse<List<PostDto>>> GetPostsAsync(string tag)
        {
            var response= new ServiceResponse<List<PostDto>>();
            try
            {
                string uri = $"{apiUrl}?tag={tag}";
                Console.WriteLine(uri); 
                var posts= await GetAPIResponse(uri);

                response.Success = true;
                ApiResponse post = JsonConvert.DeserializeObject<ApiResponse>(posts);
                response.Data = post.Posts;
   
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
            }
            return response;
        }

        private async Task<string> GetAPIResponse(string apiURL)
        {
            using(var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiURL);
                string result = string.Empty;
                Console.WriteLine(result);
             
        
                result = await response.Content.ReadAsStringAsync();
              
                return result;
            }
        }

        

    }
}
