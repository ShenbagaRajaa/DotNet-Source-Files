using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TypeWrittingBack.Models;

namespace TypeWrittingBack;


[ApiController]

[Route("api/[controller]")]

public class CSharpCornerArticlesController : ControllerBase
{
    private readonly UserDetailsContext userContext;
    public CSharpCornerArticlesController(UserDetailsContext context)
    {
        userContext = context;
    }
    // private static List<ListCSharpCornerArticles> _articles = GenerateSampleArticles();

    // private static List<ListCSharpCornerArticles> GenerateSampleArticles()
    // {
    //     // Generate and return sample articles
    //     return new List<ListCSharpCornerArticles>
    //     {

    //         new ListCSharpCornerArticles { Id = 1, Title = "Introduction to ASP.NET Core", Category = "ASP.NET Core" },
    //         new ListCSharpCornerArticles { Id = 2, Title = "Advanced C# Techniques", Category = "C#" },
    //         new ListCSharpCornerArticles { Id = 3, Title = "Introduction to ASP.NET Core", Category = "ASP.NET Core" },
    //         new ListCSharpCornerArticles { Id = 4, Title = "Advanced C# Techniques", Category = "C#" },
    //         new ListCSharpCornerArticles { Id = 5, Title = "Introduction to ASP.NET Core", Category = "ASP.NET Core" },
    //         new ListCSharpCornerArticles { Id = 6, Title = "Advanced C# Techniques", Category = "C#" },
    //         new ListCSharpCornerArticles { Id = 7, Title = "Introduction to ASP.NET Core", Category = "ASP.NET Core" },
    //         new ListCSharpCornerArticles { Id = 8, Title = "Advanced C# Techniques", Category = "C#" },
    //         new ListCSharpCornerArticles { Id = 9, Title = "Introduction to ASP.NET Core", Category = "ASP.NET Core" },
    //         new ListCSharpCornerArticles { Id = 10, Title = "Advanced C# Techniques", Category = "C#" },
    //         new ListCSharpCornerArticles { Id = 11, Title = "Introduction to ASP.NET Core", Category = "ASP.NET Core" },
    //         new ListCSharpCornerArticles { Id = 12, Title = "Advanced C# Techniques", Category = "C#" },
    //         // Add more sample articles
    //     };
    // }

    // private static List<UserDetailsShenba> _articles = GenerateSampleArticles();

    // private static List<UserDetailsShenba> GenerateSampleArticles()
    // {
    //     return new List<UserDetailsShenba>
    //     {
    //         new userContext.UserDetailsShenba.ToList()
    //     }; 
    // }






    [HttpGet]
    public IActionResult Get([FromQuery] int page = 1, [FromQuery] int pageSize = 5, [FromQuery] string filter = "")
    {
        var query = userContext.UserDetailsShenba.AsQueryable();

        if (!string.IsNullOrEmpty(filter))
        {
            query = query.Where(article => article.UserName.Contains(filter) || article.Type.Contains(filter));
        }
        var totalCount = query.Count();

        var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

        query = query.Skip((page - 1) * pageSize).Take(pageSize);

        var result = new
        {
            TotalCount = totalCount,
            TotalPages = totalPages,
            CurrentPage = page,
            PageSize = pageSize,
            Articles = query.ToList()
        };
        return Ok(result);
    }
}

