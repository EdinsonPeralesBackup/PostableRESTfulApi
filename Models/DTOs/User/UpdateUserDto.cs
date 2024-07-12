using System.ComponentModel.DataAnnotations;

namespace PostableRESTfulApi.Models.DTOs.User
{
  public class UpdateUserDto
  {
    [EmailAddress(ErrorMessage = "El formato del correo electrónico es incorrecto.")]
    [MaxLength(100, ErrorMessage = "El correo electrónico no puede tener más de 100 caracteres.")]
    public string? Email { get; set; }
    
    [MaxLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
    public string? FirstName { get; set; }
    
    [MaxLength(50, ErrorMessage = "El apellido no puede tener más de 50 caracteres.")]
    public string? LastName { get; set; }
  }
}
