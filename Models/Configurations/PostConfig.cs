using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostableRESTfulApi.Models.DTOs.Post;

namespace PostableRESTfulApi.Models.Configurations
{
public class PostConfig : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasOne(p => p.User)
            .WithMany(u => u.Posts)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasData(
        // Posts for user with Id = 1
        new CreatePostDto { Id = 1, Content = "Post para crear una página web. Bienvenidos!!! en este post veremos los pasos para crear una página web", UserId = 1 },
        new CreatePostDto { Id = 2, Content = "Introducción a C# y .NET. En este post aprenderemos sobre los fundamentos de C# y .NET", UserId = 1 },
        new CreatePostDto { Id = 3, Content = "Cómo usar Entity Framework Core en tus proyectos. Tutorial paso a paso", UserId = 1 },
        new CreatePostDto { Id = 4, Content = "Mejores prácticas en el desarrollo de APIs RESTful", UserId = 1 },

        // Posts for user with Id = 2
        new CreatePostDto { Id = 5, Content = "Conceptos básicos de HTML y CSS", UserId = 2 },
        new CreatePostDto { Id = 6, Content = "Cómo empezar con JavaScript", UserId = 2 },
        new CreatePostDto { Id = 7, Content = "Guía para principiantes sobre React", UserId = 2 },
        new CreatePostDto { Id = 8, Content = "Cómo crear un portafolio en línea", UserId = 2 },

        // Posts for user with Id = 3
        new CreatePostDto { Id = 9, Content = "Introducción a SQL y bases de datos relacionales", UserId = 3 },
        new CreatePostDto { Id = 10, Content = "Cómo optimizar consultas SQL", UserId = 3 },
        new CreatePostDto { Id = 11, Content = "Manejo de transacciones en SQL Server", UserId = 3 },
        new CreatePostDto { Id = 12, Content = "Diseño de esquemas de base de datos eficientes", UserId = 3 },

        // Posts for user with Id = 4
        new CreatePostDto { Id = 13, Content = "Conceptos básicos de Python para principiantes", UserId = 4 },
        new CreatePostDto { Id = 14, Content = "Cómo usar pandas para análisis de datos", UserId = 4 },
        new CreatePostDto { Id = 15, Content = "Introducción a la inteligencia artificial con Python", UserId = 4 },
        new CreatePostDto { Id = 16, Content = "Desarrollo de aplicaciones web con Flask", UserId = 4 },

        // Posts for user with Id = 5
        new CreatePostDto { Id = 17, Content = "Fundamentos de programación orientada a objetos", UserId = 5 },
        new CreatePostDto { Id = 18, Content = "Cómo escribir código limpio y mantenible", UserId = 5 },
        new CreatePostDto { Id = 19, Content = "Introducción a los patrones de diseño", UserId = 5 },
        new CreatePostDto { Id = 20, Content = "Cómo hacer pruebas unitarias en C#", UserId = 5 }
        );
    }
}
}
