using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemLib
{
    public class Account : Person
    {
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }

        public Account(string username, string name, string password, string role) : base(name, username)
        {
            Password = password;
            Role = role;
            Status = "Active";
        }

        public void UpdatePassword(string newPassword)
        {
            Password = newPassword;
        }

        public void DeactivateAccount()
        {
            Status = "Deactivated";
        }

        public void ActivateAccount()
        {
            Status = "Active";
        }

        public override string ToString()
        {
            return $"User: {UniqueID} | Name: {Name} | Role: {Role} | Status: {Status}";
        }

    }
}
