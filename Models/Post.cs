using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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

    //RELATIONS
    public required int UserId { get;set; }
    public required User User { get;set; }

    [JsonIgnore]
    public List<Like> Likes { get; set; } = new List<Like>();
  }
}