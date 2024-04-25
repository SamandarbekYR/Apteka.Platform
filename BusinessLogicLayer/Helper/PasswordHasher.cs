﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Helper
{
    public class PasswordHasher
    {
        public static (string Hash, string Salt) Hash(string password)
        {
            string salt = Guid.NewGuid().ToString();
            string hash = BCrypt.Net.BCrypt.HashPassword(password + salt);

            return (Hash: hash, Salt: salt);
        }
        public static bool Verify(string password, string salt, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password + salt, hash);
        }
    }
}
