using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostableRESTfulApi.Models.DTOs.Like;

namespace PostableRESTfulApi.Models.Configurations
{
  public class LikeConfig : IEntityTypeConfiguration<Like>
  {
    public void Configure(EntityTypeBuilder<Like> builder)
    {        
        builder.HasOne(p => p.User)
            .WithMany(u => u.Likes)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(p => p.Post)
            .WithMany(u => u.Likes)
            .HasForeignKey(p => p.PostId)
            .OnDelete(DeleteBehavior.NoAction);
        
        builder.HasIndex(l => new { l.PostId, l.UserId }).IsUnique();

        builder.HasData(            
            new CreateLikeDto { Id = 2, PostId = 1, UserId = 4 },
            new CreateLikeDto { Id = 3, PostId = 1, UserId = 6 },
            new CreateLikeDto { Id = 4, PostId = 1, UserId = 8 },
            new CreateLikeDto { Id = 5, PostId = 1, UserId = 9 },
            new CreateLikeDto { Id = 6, PostId = 1, UserId = 10 },
            new CreateLikeDto { Id = 7, PostId = 1, UserId = 11 },
            new CreateLikeDto { Id = 8, PostId = 2, UserId = 1 },
            new CreateLikeDto { Id = 9, PostId = 2, UserId = 2 },
            new CreateLikeDto { Id = 10, PostId = 2, UserId = 3 },
            new CreateLikeDto { Id = 11, PostId = 2, UserId = 5 },
            new CreateLikeDto { Id = 12, PostId = 2, UserId = 6 },
            new CreateLikeDto { Id = 13, PostId = 2, UserId = 7 },
            new CreateLikeDto { Id = 14, PostId = 2, UserId = 8 },
            new CreateLikeDto { Id = 15, PostId = 2, UserId = 9 },
            new CreateLikeDto { Id = 16, PostId = 2, UserId = 10 },
            new CreateLikeDto { Id = 17, PostId = 2, UserId = 11 },
            new CreateLikeDto { Id = 18, PostId = 3, UserId = 1 },
            new CreateLikeDto { Id = 19, PostId = 3, UserId = 2 },
            new CreateLikeDto { Id = 20, PostId = 3, UserId = 3 },
            new CreateLikeDto { Id = 21, PostId = 3, UserId = 4 },
            new CreateLikeDto { Id = 22, PostId = 3, UserId = 5 },
            new CreateLikeDto { Id = 23, PostId = 3, UserId = 6 },
            new CreateLikeDto { Id = 24, PostId = 3, UserId = 7 },
            new CreateLikeDto { Id = 25, PostId = 3, UserId = 8 },
            new CreateLikeDto { Id = 26, PostId = 3, UserId = 9 },
            new CreateLikeDto { Id = 27, PostId = 3, UserId = 10 },
            new CreateLikeDto { Id = 28, PostId = 3, UserId = 11 },
            new CreateLikeDto { Id = 29, PostId = 4, UserId = 1 },
            new CreateLikeDto { Id = 30, PostId = 4, UserId = 2 },
            new CreateLikeDto { Id = 31, PostId = 4, UserId = 3 },
            new CreateLikeDto { Id = 32, PostId = 4, UserId = 4 },
            new CreateLikeDto { Id = 33, PostId = 4, UserId = 5 },
            new CreateLikeDto { Id = 34, PostId = 4, UserId = 6 },
            new CreateLikeDto { Id = 35, PostId = 4, UserId = 7 },
            new CreateLikeDto { Id = 36, PostId = 4, UserId = 8 },
            new CreateLikeDto { Id = 37, PostId = 4, UserId = 9 },
            new CreateLikeDto { Id = 38, PostId = 4, UserId = 10 },
            new CreateLikeDto { Id = 39, PostId = 4, UserId = 11 },
            new CreateLikeDto { Id = 40, PostId = 5, UserId = 1 },
            new CreateLikeDto { Id = 41, PostId = 5, UserId = 2 },
            new CreateLikeDto { Id = 42, PostId = 5, UserId = 3 },
            new CreateLikeDto { Id = 43, PostId = 5, UserId = 4 },
            new CreateLikeDto { Id = 44, PostId = 5, UserId = 5 },
            new CreateLikeDto { Id = 45, PostId = 5, UserId = 6 },
            new CreateLikeDto { Id = 46, PostId = 5, UserId = 7 },
            new CreateLikeDto { Id = 47, PostId = 5, UserId = 8 },
            new CreateLikeDto { Id = 48, PostId = 5, UserId = 9 },
            new CreateLikeDto { Id = 49, PostId = 5, UserId = 10 },
            new CreateLikeDto { Id = 50, PostId = 5, UserId = 11 },
            new CreateLikeDto { Id = 51, PostId = 6, UserId = 1 },
            new CreateLikeDto { Id = 52, PostId = 6, UserId = 2 },
            new CreateLikeDto { Id = 53, PostId = 6, UserId = 3 },
            new CreateLikeDto { Id = 54, PostId = 6, UserId = 4 },
            new CreateLikeDto { Id = 55, PostId = 6, UserId = 5 },
            new CreateLikeDto { Id = 56, PostId = 6, UserId = 6 },
            new CreateLikeDto { Id = 57, PostId = 6, UserId = 7 },
            new CreateLikeDto { Id = 58, PostId = 6, UserId = 8 },
            new CreateLikeDto { Id = 59, PostId = 6, UserId = 9 },
            new CreateLikeDto { Id = 60, PostId = 6, UserId = 10 },
            new CreateLikeDto { Id = 61, PostId = 6, UserId = 11 },
            new CreateLikeDto { Id = 62, PostId = 7, UserId = 1 },
            new CreateLikeDto { Id = 63, PostId = 7, UserId = 2 },
            new CreateLikeDto { Id = 64, PostId = 7, UserId = 3 },
            new CreateLikeDto { Id = 65, PostId = 7, UserId = 4 },
            new CreateLikeDto { Id = 66, PostId = 7, UserId = 5 },
            new CreateLikeDto { Id = 67, PostId = 7, UserId = 6 },
            new CreateLikeDto { Id = 68, PostId = 7, UserId = 7 },
            new CreateLikeDto { Id = 69, PostId = 7, UserId = 8 },
            new CreateLikeDto { Id = 70, PostId = 7, UserId = 9 },
            new CreateLikeDto { Id = 71, PostId = 7, UserId = 10 },
            new CreateLikeDto { Id = 72, PostId = 7, UserId = 11 },
            new CreateLikeDto { Id = 73, PostId = 8, UserId = 1 },
            new CreateLikeDto { Id = 74, PostId = 8, UserId = 2 },
            new CreateLikeDto { Id = 75, PostId = 8, UserId = 3 },
            new CreateLikeDto { Id = 76, PostId = 8, UserId = 4 },
            new CreateLikeDto { Id = 77, PostId = 8, UserId = 5 },
            new CreateLikeDto { Id = 78, PostId = 8, UserId = 6 },
            new CreateLikeDto { Id = 79, PostId = 8, UserId = 7 },
            new CreateLikeDto { Id = 80, PostId = 8, UserId = 8 },
            new CreateLikeDto { Id = 81, PostId = 8, UserId = 9 },
            new CreateLikeDto { Id = 82, PostId = 8, UserId = 10 },
            new CreateLikeDto { Id = 83, PostId = 8, UserId = 11 },
            new CreateLikeDto { Id = 84, PostId = 9, UserId = 1 },
            new CreateLikeDto { Id = 85, PostId = 9, UserId = 2 },
            new CreateLikeDto { Id = 86, PostId = 9, UserId = 3 },
            new CreateLikeDto { Id = 87, PostId = 9, UserId = 4 },
            new CreateLikeDto { Id = 88, PostId = 9, UserId = 5 },
            new CreateLikeDto { Id = 89, PostId = 9, UserId = 6 },
            new CreateLikeDto { Id = 90, PostId = 9, UserId = 7 },
            new CreateLikeDto { Id = 91, PostId = 9, UserId = 8 },
            new CreateLikeDto { Id = 92, PostId = 9, UserId = 9 },
            new CreateLikeDto { Id = 93, PostId = 9, UserId = 10 },
            new CreateLikeDto { Id = 94, PostId = 9, UserId = 11 },
            new CreateLikeDto { Id = 95, PostId = 10, UserId = 1 },
            new CreateLikeDto { Id = 96, PostId = 10, UserId = 2 },
            new CreateLikeDto { Id = 97, PostId = 10, UserId = 3 },
            new CreateLikeDto { Id = 98, PostId = 10, UserId = 4 },
            new CreateLikeDto { Id = 99, PostId = 10, UserId = 5 },
            new CreateLikeDto { Id = 100, PostId = 10, UserId = 6 },
            new CreateLikeDto { Id = 101, PostId = 10, UserId = 7 },
            new CreateLikeDto { Id = 102, PostId = 10, UserId = 8 },
            new CreateLikeDto { Id = 103, PostId = 10, UserId = 9 },
            new CreateLikeDto { Id = 104, PostId = 10, UserId = 10 },
            new CreateLikeDto { Id = 105, PostId = 10, UserId = 11 },
            new CreateLikeDto { Id = 106, PostId = 11, UserId = 1 },
            new CreateLikeDto { Id = 107, PostId = 11, UserId = 2 },
            new CreateLikeDto { Id = 108, PostId = 11, UserId = 3 },
            new CreateLikeDto { Id = 109, PostId = 11, UserId = 4 },
            new CreateLikeDto { Id = 110, PostId = 11, UserId = 5 },
            new CreateLikeDto { Id = 111, PostId = 11, UserId = 6 },
            new CreateLikeDto { Id = 112, PostId = 11, UserId = 7 },
            new CreateLikeDto { Id = 113, PostId = 11, UserId = 8 },
            new CreateLikeDto { Id = 114, PostId = 11, UserId = 9 },
            new CreateLikeDto { Id = 115, PostId = 11, UserId = 10 },
            new CreateLikeDto { Id = 116, PostId = 11, UserId = 11 },
            new CreateLikeDto { Id = 117, PostId = 12, UserId = 1 },
            new CreateLikeDto { Id = 118, PostId = 12, UserId = 2 },
            new CreateLikeDto { Id = 119, PostId = 12, UserId = 3 },
            new CreateLikeDto { Id = 120, PostId = 12, UserId = 4 },
            new CreateLikeDto { Id = 121, PostId = 12, UserId = 5 },
            new CreateLikeDto { Id = 122, PostId = 12, UserId = 6 },
            new CreateLikeDto { Id = 123, PostId = 12, UserId = 7 },
            new CreateLikeDto { Id = 124, PostId = 12, UserId = 8 },
            new CreateLikeDto { Id = 125, PostId = 12, UserId = 9 },
            new CreateLikeDto { Id = 126, PostId = 12, UserId = 10 },
            new CreateLikeDto { Id = 127, PostId = 12, UserId = 11 },
            new CreateLikeDto { Id = 128, PostId = 13, UserId = 1 },
            new CreateLikeDto { Id = 129, PostId = 13, UserId = 2 },
            new CreateLikeDto { Id = 130, PostId = 13, UserId = 3 },
            new CreateLikeDto { Id = 131, PostId = 13, UserId = 4 },
            new CreateLikeDto { Id = 132, PostId = 13, UserId = 5 },
            new CreateLikeDto { Id = 133, PostId = 13, UserId = 6 },
            new CreateLikeDto { Id = 134, PostId = 13, UserId = 7 },
            new CreateLikeDto { Id = 135, PostId = 13, UserId = 8 },
            new CreateLikeDto { Id = 136, PostId = 13, UserId = 9 },
            new CreateLikeDto { Id = 137, PostId = 13, UserId = 10 },
            new CreateLikeDto { Id = 138, PostId = 13, UserId = 11 },
            new CreateLikeDto { Id = 139, PostId = 14, UserId = 1 },
            new CreateLikeDto { Id = 140, PostId = 14, UserId = 2 },
            new CreateLikeDto { Id = 141, PostId = 14, UserId = 3 },
            new CreateLikeDto { Id = 142, PostId = 14, UserId = 4 },
            new CreateLikeDto { Id = 143, PostId = 14, UserId = 5 },
            new CreateLikeDto { Id = 144, PostId = 14, UserId = 6 },
            new CreateLikeDto { Id = 145, PostId = 14, UserId = 7 },
            new CreateLikeDto { Id = 146, PostId = 14, UserId = 8 },
            new CreateLikeDto { Id = 147, PostId = 14, UserId = 9 },
            new CreateLikeDto { Id = 148, PostId = 14, UserId = 10 },
            new CreateLikeDto { Id = 149, PostId = 14, UserId = 11 },
            new CreateLikeDto { Id = 150, PostId = 15, UserId = 1 },
            new CreateLikeDto { Id = 151, PostId = 15, UserId = 2 },
            new CreateLikeDto { Id = 152, PostId = 15, UserId = 3 },
            new CreateLikeDto { Id = 153, PostId = 15, UserId = 4 },
            new CreateLikeDto { Id = 154, PostId = 15, UserId = 5 },
            new CreateLikeDto { Id = 155, PostId = 15, UserId = 6 },
            new CreateLikeDto { Id = 156, PostId = 15, UserId = 7 },
            new CreateLikeDto { Id = 157, PostId = 15, UserId = 8 },
            new CreateLikeDto { Id = 158, PostId = 15, UserId = 9 },
            new CreateLikeDto { Id = 159, PostId = 15, UserId = 10 },
            new CreateLikeDto { Id = 160, PostId = 15, UserId = 11 }
        );
    }
  }
}
