﻿using Medicine.Entities.Enums;
using Medicine.Entities.Models.Auth;

namespace Medicine.Application.Interfaces
{
    public interface IUserService
    {
        public Role? GeRole(string email);
        public User? GetUserByEmail(string email);
        public User? GetUserById(int id);

    }
}
