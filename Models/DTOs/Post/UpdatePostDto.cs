using System.ComponentModel.DataAnnotations;

namespace PostableRESTfulApi.Models.DTOs.Post
{
  public class UpdatePostDto
  {
    [MaxLength(500, ErrorMessage = "El contenido del post no puede tener más de 500 caracteres.")]
    public string? Content { get; set; }
    public int? UserId { get;set; }
  }
}
