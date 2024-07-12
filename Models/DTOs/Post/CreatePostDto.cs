namespace PostableRESTfulApi.Models.DTOs.Post
{
  public class CreatePostDto
  {
    public int? Id { get; set; }
    public required string Content { get; set; }
    public required int UserId { get;set; }
    public DateTime? CreatedAt { get; set; } = DateTime.Now;
  }
}
