using System;
using System.Security.Cryptography;

public class clsPasswordHasher
{
    private const int SaltSize = 16;
    private const int KeySize = 32;
    private const int Iterations = 100000;

    public static string Hash(string password)
    {
        using (var rng = RandomNumberGenerator.Create())
        {
            byte[] salt = new byte[SaltSize];
            rng.GetBytes(salt);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
            byte[] key = pbkdf2.GetBytes(KeySize);

            return $"{Convert.ToBase64String(salt)}.{Convert.ToBase64String(key)}";
        }
    }

    public static bool Verify(string password, string hashed)
    {
        var parts = hashed.Split('.');
        if (parts.Length != 2) return false;

        byte[] salt = Convert.FromBase64String(parts[0]);
        byte[] key = Convert.FromBase64String(parts[1]);

        var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256);
        byte[] keyToCheck = pbkdf2.GetBytes(KeySize);

        // Replace CryptographicOperations.FixedTimeEquals with a manual comparison to fix CS0103  
        if (keyToCheck.Length != key.Length) return false;
        for (int i = 0; i < keyToCheck.Length; i++)
        {
            if (keyToCheck[i] != key[i]) return false;
        }

        return true;
    }
}
