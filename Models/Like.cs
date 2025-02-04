using System.ComponentModel.DataAnnotations;

namespace PostableRESTfulApi.Models
{
  public class Like
  {
    public int Id { get; set; }
    
    [Required(ErrorMessage = "La fecha de creación es obligatoria.")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;

    //RELATIONS
    public int UserId { get;set; }
    public required User User { get;set; }

    public int PostId { get;set; }
    public required Post Post { get;set; }
  }
}