using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
    }
  }
}
