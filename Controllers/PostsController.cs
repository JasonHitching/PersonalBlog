using Microsoft.AspNetCore.Mvc;


/// <summary>
/// Controller defining the API endpoints related to posts
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class PostController : ControllerBase
{

    private readonly IPostService PostService;

    public PostController()
    {

    }

    /// <summary>
    /// Retrieve all posts
    /// </summary>
    [HttpGet]
    public void GetPosts(PostDTO postDTO)
    {
        // TODO: Implement
    }
}
}