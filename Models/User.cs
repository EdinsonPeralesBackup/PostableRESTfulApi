using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PostableRESTfulApi.Models
{
  public class User
  {
    public int Id { get; set; }
    
    [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
    [MaxLength(100, ErrorMessage = "El nombre de usuario no puede tener más de 100 caracteres.")]
    public required string UserName { get; set; }
    
    [Required(ErrorMessage = "La contraseña es obligatoria.")]
    public required string Password { get; set; }
    
    [EmailAddress(ErrorMessage = "El formato del correo electrónico es incorrecto.")]
    [MaxLength(100, ErrorMessage = "El correo electrónico no puede tener más de 100 caracteres.")]
    public string? Email { get; set; }
    
    [MaxLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
    public string? FirstName { get; set; }
    
    [MaxLength(50, ErrorMessage = "El apellido no puede tener más de 50 caracteres.")]
    public string? LastName { get; set; }
    
    [Required(ErrorMessage = "El rol es obligatorio.")]
    [MaxLength(10, ErrorMessage = "El rol no puede tener más de 10 caracteres.")]
    public required string Role { get; set; } = "user";
    
    [Required(ErrorMessage = "La fecha de creación es obligatoria.")]
    public required DateTime CreatedAt { get; set; } = DateTime.Now;

    //RELATIONS
    [JsonIgnore]
    public List<Post> Posts { get; set; } = new List<Post>();
  }
}