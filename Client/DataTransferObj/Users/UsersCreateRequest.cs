using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DataTransferObj.Users
{
    public class UsersCreateRequest
    {
        public  string UserName { get; set; }
        public  string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordHashConfirm { get; set; }

        public string IsValid()
        {
            string valid = "";
            if (PasswordHashConfirm != PasswordHash)
            {
                valid = "Passwords do not match";
            }
            return valid;
        }
    }
}
