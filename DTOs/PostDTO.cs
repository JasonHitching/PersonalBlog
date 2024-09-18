/// <summary>
/// Data transfer object for posts
/// </summary>
public class PostDTO
{
    /// <summary>
    /// The post title
    /// </summary>
    public string? PostTitle { get; set; }

    /// <summary>
    /// The post description
    /// </summary>
    public string? PostDescription { get; set; }

    /// <summary>
    /// The content of the post
    /// </summary>
    public string? PostContent { get; set; }

    /// <summary>
    /// Date the post was updated
    /// </summary>
    public DateTime UpdatedDate { get; set; }

    /// <summary>
    /// Date the post was created
    /// </summary>
    public DateTime CreatedDate { get; set; }
}