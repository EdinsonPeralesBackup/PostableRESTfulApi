using System.ComponentModel.DataAnnotations;

namespace PostableRESTfulApi.Models
{
  public class Post
  {
    public int Id { get; set; }
    
    [Required(ErrorMessage = "El contenido del post es obligatorio.")]
    [MaxLength(500, ErrorMessage = "El contenido del post no puede tener más de 500 caracteres.")]
    public required string Content { get; set; }
    
    [Required(ErrorMessage = "La fecha de creación es obligatoria.")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;
  }
}