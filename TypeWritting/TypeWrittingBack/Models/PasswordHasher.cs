using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.IdentityModel.Tokens;

namespace TypeWrittingBack;

public class PasswordHasher
{
    public static string ComputeHash(string password, byte[] salt)
    {
        string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password!,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));

        Console.WriteLine($"Hashed: {hashed}");
        return hashed;
    }
    public static byte[] GenerateSalt()
    {
        byte[] salt = RandomNumberGenerator.GetBytes(128 / 8); 
        Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");
        string salts = Convert.ToBase64String(salt);
        return salt;
    }

    public static SymmetricSecurityKey GetSigningKey()
    {

        var secret = "THis_is_EncryptedKey_Is_Created_By_Shenbagaraj_Developer_BuSoftTechnologies_Chennai_Tamilnadu_India";
        return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
    }

    public static bool VerifyHashedPassword(string providedPassword, string storedSalt, string storedHash)
    {
        byte[] saltBytes = Convert.FromBase64String(storedSalt);
        string newHash = ComputeHash(providedPassword, saltBytes);
        return newHash == storedHash;
    }

    // public static string MachineIdGenerate(){

    // }

    
}
