using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostableRESTfulApi.Models.DTOs.User;

namespace PostableRESTfulApi.Models.Configurations
{
  public class UserConfig : IEntityTypeConfiguration<User>
  {
    public void Configure(EntityTypeBuilder<User> builder)
    {
        //UserName Config
        builder.HasIndex(u => u.UserName).IsUnique();

        //Email Config
        builder.HasIndex(u => u.Email).IsUnique();

        builder.HasData(
          new CreateUserDto { Id = 1, UserName = "EdinsonPerales", Password = "123456", Email = "edi_perales@neelvat.com", FirstName = "Edinson", LastName = "Perales", Role = "Admin" },
          new CreateUserDto { Id = 2, UserName = "JohnDoe", Password = "password1", FirstName = "John", LastName = "Doe" },
          new CreateUserDto { Id = 3, UserName = "JaneSmith", Password = "password2", Email = "jane_smith@example.com" },
          new CreateUserDto { Id = 4, UserName = "MikeBrown", Password = "password3", FirstName = "Mike" },
          new CreateUserDto { Id = 5, UserName = "SaraConnor", Password = "password4", LastName = "Connor", Role = "Admin" },
          new CreateUserDto { Id = 6, UserName = "TomHanks", Password = "password5" },
          new CreateUserDto { Id = 7, UserName = "EmmaWatson", Password = "password6", Email = "emma_watson@example.com", FirstName = "Emma", LastName = "Watson", Role = "User" },
          new CreateUserDto { Id = 8, UserName = "RobertDowney", Password = "password7", Email = "robert_downey@example.com" },
          new CreateUserDto { Id = 9, UserName = "ChrisEvans", Password = "password8", FirstName = "Chris", Role = "User" },
          new CreateUserDto { Id = 10, UserName = "ScarlettJohansson", Password = "password9", LastName = "Johansson" },
          new CreateUserDto { Id = 11, UserName = "BruceWayne", Password = "password10", FirstName = "Bruce", LastName = "Wayne" }
        );
    }
  }
}