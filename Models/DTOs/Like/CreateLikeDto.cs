namespace PostableRESTfulApi.Models.DTOs.Like
{
  public class CreateLikeDto
  {
    public int? Id { get; set; }
    public required int PostId { get; set; }
    public required int UserId { get;set; }
    public DateTime? CreatedAt { get; set; } = DateTime.Now;
  }
}
