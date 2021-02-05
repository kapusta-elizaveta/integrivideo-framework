﻿using WebCore;

namespace Services.Models
{
    public class User
    {
        public string Email { get; }
        public string Password { get; }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public static User WithCredentialsFromProperty()
        {
            return new User(Configurator.Email, Configurator.Password);
        }
    }
}