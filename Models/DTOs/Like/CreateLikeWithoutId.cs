namespace PostableRESTfulApi.Models.DTOs.Like
{
  public class CreateLikeWithoutIdDto
  {
    public required int PostId { get; set; }
    public required int UserId { get;set; }
    public DateTime? CreatedAt { get; set; } = DateTime.Now;
  }
}
