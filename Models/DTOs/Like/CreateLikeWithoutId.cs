using System.ComponentModel.DataAnnotations;

namespace PostableRESTfulApi.Models.DTOs.Like
{
  public class CreateLikeWithoutIdDto
  {
    [Required(ErrorMessage = "El id del post es obligatorio.")]
    public required int PostId { get; set; }
    [Required(ErrorMessage = "El id del usuario es obligatorio.")]
    public required int UserId { get;set; }
    public DateTime? CreatedAt { get; set; } = DateTime.Now;
  }
}
