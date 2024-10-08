using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDeskApp.Domain.Entities
{
    class Users
    {
        int id;
        String username;
        String salt;
        String hashedPassword;
    }
}
