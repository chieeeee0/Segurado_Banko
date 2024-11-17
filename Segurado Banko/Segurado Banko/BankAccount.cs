using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segurado_Banko
{
    public class BankAccount : IBankAccount
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string EmailAddress { get; set; }
        public string RecoveryPINCode { get; set; }
        public string PINCode { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

        public BankAccount()
        {

        }
        public BankAccount(BankAccount account)
        {
            this.Firstname = account.Firstname;
            this.Lastname = account.Lastname;
            this.EmailAddress = account.EmailAddress;
            this.RecoveryPINCode = account.RecoveryPINCode;
            this.PasswordHash = account.PasswordHash;
            this.PasswordSalt = account.PasswordSalt;
            byte[] passwordHash, passwordSalt;
        }

        public bool LoginMethod(string pincode)
        {
            if (!VerifyPasswordHash(pincode, PasswordHash, PasswordSalt))
            {
                MessageBox.Show("Wrong PIN code!", "Segurado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }
        public bool VerifyRegisterPassword(string pass)
        {
            if (pass.Length > 4 || pass.Length < 4)
            {
                MessageBox.Show("PIN code must consist of 4 numbers", "Segurado Banko", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }
        public void SetDefault(BankAccount account, string email, string pincode)
        {
            this.Firstname = account.Firstname;
            this.Lastname = account.Lastname;
            this.EmailAddress = email;
            this.RecoveryPINCode = pincode;

            byte[] passwordHash, salt;
            CreatePasswordHash(pincode, out passwordHash, out salt);
            SetPasswords(passwordHash, salt);
        }

        public void CreatePasswordHash(string pincode, out byte[] passwordHash, out byte[] salt)
        {

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                salt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(pincode));
            }
        }

        public bool VerifyPasswordHash(string pincode, string storedHash, string storedSalt)
        {
            byte[] salt = Convert.FromBase64String(storedSalt);
            byte[] hash = Convert.FromBase64String(storedHash);

            using (var hmac = new System.Security.Cryptography.HMACSHA512(salt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(pincode));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != hash[i])
                    {
                        MessageBox.Show("Incorrect password");
                        return false;
                    }
                }
            }
            return true;
        }

        public void SetPasswords(byte[] passwordHash, byte[] salt)
        {
            PasswordHash = Convert.ToBase64String(passwordHash);
            PasswordSalt = Convert.ToBase64String(salt);
        }
    }
}
