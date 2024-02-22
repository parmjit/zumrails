using Backend.Models;

namespace Backend.Services
{
    public interface IPostService
    {
        Task<ServiceResponse<List<PostDto>>> GetPostsAsync(string tag);
    }
}
