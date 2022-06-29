namespace EzHomeManagement.Business.Extensions
{
    using Microsoft.AspNetCore.Cryptography.KeyDerivation;
    using System.Text;

    public static class CryptographyExtensions
    {
        public static string EncryptString(this string value, string passwordSalt)
        {
            string hash = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: value + passwordSalt,
                salt: Encoding.ASCII.GetBytes(passwordSalt),
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));
            return hash;
        }

        /// <summary>Compares the encrypt string with a plain string.</summary>
        public static bool CompareEncryptString(this string encryptValue, string plainValue, string passwordSalt)
        {
            return !string.IsNullOrEmpty(plainValue) &&
                plainValue.EncryptString(passwordSalt).Equals(encryptValue, StringComparison.InvariantCulture);
        }
    }
}
