using System.ComponentModel.DataAnnotations;

namespace PostableRESTfulApi.Models.DTOs.Post
{
  public class CreatePostWithoutIdDto
  {
    [Required(ErrorMessage = "El contenido del post es obligatorio.")]
    [MaxLength(500, ErrorMessage = "El contenido del post no puede tener más de 500 caracteres.")]
    public required string Content { get; set; }
    
    [Required(ErrorMessage = "El id del usuario es obligatorio.")]
    public required int UserId { get;set; }
    public DateTime? CreatedAt { get; set; } = DateTime.Now;
  }
}
