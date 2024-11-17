using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segurado_Banko
{
    public interface IBankAccount
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        string EmailAddress { get; set; }
        string RecoveryPINCode { get; set; }
        string PINCode { get; set; }
        string PasswordHash { get; set; }
        string PasswordSalt { get; set; }


        bool LoginMethod(string pincode);
        bool VerifyRegisterPassword(string pass);
        void SetDefault(BankAccount account, string email, string pincode);
        void CreatePasswordHash(string pincode, out byte[] passwordHash, out byte[] salt);
        bool VerifyPasswordHash(string pincode, string storedHash, string storedSalt);
        void SetPasswords(byte[] passwordHash, byte[] salt);
    }
}
