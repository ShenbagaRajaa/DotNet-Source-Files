using System.Security.Cryptography;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WonderHelp;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
}

public class SuperAdminService
{
    private readonly UserManager<User> _userManager;
    private readonly EmailService _emailService;
    private readonly Wonder_HelpContext _context;

    public SuperAdminService(UserManager<User> userManager, EmailService emailService, Wonder_HelpContext context)
    {
        _userManager = userManager;
        _emailService = emailService;
        _context = context;
    }

    public async Task CreateUserAsync(string email, string password)
    {
        var user = new User { Email = email };
    var passwordHasher = new PasswordHasher<User>();
    var hashedPassword = passwordHasher.HashPassword(user, password);
    user.PasswordHash = hashedPassword;
    await _userManager.CreateAsync(user);
    await _context.SaveChangesAsync();
    }

    public async Task SendPasswordAsync(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user == null)
        {
            return;
        }
        var password = GenerateRandomPassword(12);
        await CreateUserAsync(email, password);
        await _emailService.SendEmailAsync(email, "Password Reset", $"Your password is: {password}");
    }

    private static string GenerateRandomPassword(int length)
    {
        using (var rng = new RNGCryptoServiceProvider())
        {
            var bytes = new byte[length];
            rng.GetBytes(bytes);
            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }
    }
}

public class EmailService
{
    public Task SendEmailAsync(string email, string subject, string body)
    {
        // Implement your email sending logic here
        return Task.CompletedTask;
    }
}

public class SuperAdminController : Controller
{
    private readonly SuperAdminService _superAdminService;

    public SuperAdminController(SuperAdminService superAdminService)
    {
        _superAdminService = superAdminService;
    }

    [HttpPost]
    public async Task<IActionResult> SendPasswordAsync([FromBody] string email)
    {
        await _superAdminService.SendPasswordAsync(email);
        return Ok();
    }
}

public class Wonder_HelpContext : DbContext
    {
        public Wonder_HelpContext(DbContextOptions<Wonder_HelpContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }


































































































// [ApiController]
// [Route("[controller]")]
// public class userController : ControllerBase
// {
//     private readonly userContext userContext;
//     private readonly IConfiguration config;
//     public userController(userContext context, IConfiguration configuration)
//     {
//         userContext = context;
//         config = configuration;
// }
// 
//     [HttpGet("GetAll")]
//     public async Task<ActionResult<IEnumerable<user_details>>> GetAllUserDetials()
//     {
//         return await userContext.user_details.ToListAsync();
//     }

//     [HttpGet("GetById/{id}")]
//     public async Task<ActionResult<user_details>> GetParticularUserDetials(int id)
//     {
//         return await userContext.user_details.FindAsync(id);
//     }

//     [HttpPost("AddUser")]
//     public async Task<ActionResult<user_details>> AddUserDetails(user_details userdetails)
//     {
//         // byte[] passalt = PasswordHasher.GenerateSalt();
//         // if (!ModelState.IsValid)
//         // {
//         //     return BadRequest(ModelState);
//         // }

//         var existingUser = await userContext.user_details
//             .FirstOrDefaultAsync(u => u.email == userdetails.email);

//         if (existingUser != null)
//         {
//             return BadRequest("email already exists");
//         }
//         //     userdetails.password = passwordmethod,
//         // userContext.user_details.Add(userdetails);
//         await userContext.SaveChangesAsync();
//         return Ok();
//     }


//     [HttpPatch("Update/{id}")]
//     public async Task<IActionResult> UpdateUserPersonalDetails(int id, user_details student)
//     {

//         var existingUser = await userContext.user_details.FindAsync(id);

//         if (existingUser == null)
//         {
//             return NotFound();
//         }
//         try
//         {
//             existingUser.first_name = student.first_name;
//             existingUser.last_name = student.last_name;
//             existingUser.email = student.email;
//             existingUser.phone_number = student.phone_number;
//             existingUser.updated_by = student.updated_by;
//             await userContext.SaveChangesAsync();
//         }
//         catch (DbUpdateConcurrencyException)
//         {
//             return NotFound();
//         }
//         return NoContent();
//     }

//     // [HttpGet("active")]
//     // public IActionResult GetActiveClientsCount()
//     // {
//     //     var activeCustomers = userContext.client.Where(c => c.status == Currentstatus.active).ToList();
//     //     return Ok(activeCustomers.Count());
//     // }

//     // // GET api/customer/inactive
//     // [HttpGet("inactive")]
//     // public IActionResult GetInactiveClientsCount()
//     // {
//     //     var inactiveCustomers = userContext.client.Where(c => c.status == Currentstatus.inactive).ToList();
//     //     return Ok(inactiveCustomers.Count());
//     // }

//     // [HttpGet("article")]
//     // public IActionResult GetArticleCount()
//     // {
//     //     var activeCustomers = userContext.article.ToList();
//     //     return Ok(activeCustomers.Count());
//     // }


//     [HttpPatch("{id}")]
//     public IActionResult JsonPatchWithModelState(int id, [FromBody] JsonPatchDocument<user_details> patchDoc)
// {
//     if (patchDoc != null)
//     {
//         var user = userContext.user_details.FirstOrDefault(a => a.user_id == id);

//         if (user != null)
//         {
//             patchDoc.ApplyTo(user, ModelState);

//             if (!ModelState.IsValid)
//             {
//                 return BadRequest(ModelState);
//             }

//             userContext.SaveChanges();

//             return new ObjectResult(user);
//         }
//         else
//         {
//             return NotFound();
//         }
//     }
//     else
//     {
//         return BadRequest(ModelState);
//     }
// }

// }
