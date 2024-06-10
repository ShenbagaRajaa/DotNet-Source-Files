using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Options;

namespace WonderHelp;

public class user_details
{
    [Key]
    public int user_id { get; set; }
    [Required]
    public string first_name { get; set; }
    [Required]
    public string last_name { get; set; }
    [Required]
    public string email { get; set; }
    [Required]
    public string password { get; set; }
    [Required]
    public string phone_number { get; set; }
    [Required]
    public int failed_attempts { get; set; }
    public string status { get; set; }
    [Required]
    public int user_type_id { get; set; }
    [Required]
    public int client_id { get; set; }
    public string token { get; set; }
    public string refresh_token { get; set; }
    [Required]
    public int created_by { get; set; }
    [Required]
    public DateTime created_dttm { get; set; }
    [Required]
    public int updated_by { get; set; }
    [Required]
    public DateTime updated_dttm { get; set; }
}

public enum Currentstatus {
    active, inactive
}

public class UserPersonalDetailDTO
{
    public string? First_name { get; set; }
    public string? Last_name { get; set; }
    public string? status {get; set;}
    public int Updated_by { get; set; }
    public DateTime Updated_dttm { get; set; }
}
public class user_app_role_mapping
{
    [Key]
    public int user_app_role_mapping_id { get; set; }
    [Required]
    public int user_id { get; set; }
    [Required]
    public int app_role_id { get; set; }
    [Required]
    public int created_by { get; set; }
    [Required]
    public DateTime created_dttm { get; set; }
}

public class external_user_role
{
    [Key]
    public int external_user_role_id { get; set; }
    [Required]
    public int client_id { get; set; }
    [Required, MinLength(3), MaxLength(50)]
    public string external_user_role_name { get; set; }
    public Currentstatus status { get; set; }
    [Required]
    public int created_by { get; set; }
    [Required]
    public DateTime created_dttm { get; set; }
    [Required]
    public int updated_by { get; set; }
    [Required]
    public DateTime updated_dttm { get; set; }
}

public class product_client_mapping
{
    [Key]
    public int product_client_mapping_id { get; set; }
    [Required]
    public int product_id { get; set; }
    [Required]
    public int client_id { get; set; }
    [Required]
    public int created_by { get; set; }
    [Required]
    public DateTime created_dttm { get; set; }

}

public class client{
    public Currentstatus status { get; set; }
}

public class article{
    public Currentstatus status { get; set; }
}

public static class MyJPIF
{
    public static NewtonsoftJsonPatchInputFormatter GetJsonPatchInputFormatter()
    {
        var builder = new ServiceCollection()
            .AddLogging()
            .AddMvc()
            .AddNewtonsoftJson()
            .Services.BuildServiceProvider();

        return builder
            .GetRequiredService<IOptions<MvcOptions>>()
            .Value
            .InputFormatters
            .OfType<NewtonsoftJsonPatchInputFormatter>()
            .First();
    }



    
}