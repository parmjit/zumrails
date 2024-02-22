using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controller
{
    [Route("Post")]
    [ApiController]
    public class PostController:ControllerBase
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
                _postService= postService;
        }

        [HttpGet("GetPosts")]
        public async Task<ActionResult<ServiceResponse<List<PostDto>>>> GetPostsByTag(string tag)
        {
          var response=  await _postService.GetPostsAsync(tag);
            if (!response.Success)
            {
                return BadRequest("Tag not found");
            }
            return Ok(response);
        }



    }
}
