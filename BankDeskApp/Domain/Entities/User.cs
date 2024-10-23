using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDeskApp.Domain.Entities
{
    class User
    {
        int Id;
        public string Username { get; private set; }
        byte[] Salt;
        string HashedPassword;
        int RoleId;
        int BranchId;
        

        User(string username, byte[] salt, string hashedPassword)
        {
            Username = username;
            Salt = salt;
            HashedPassword = hashedPassword;
        }
    }
}
