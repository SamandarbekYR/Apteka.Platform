﻿using DataAccesLayer.Data;
using DataAccesLayer.Interfaces.Users;
using Domian.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories.Users
{
    public class UserRoleRepository(AppDbContext appDb)
            : Repository<UserRole>(appDb), IUserRole
    {
        public AppDbContext _appDb = appDb;
        public List<UserRole> SelectAll()
        {
            return _appDb.UserRole.Include(c => c.User).AsNoTracking().ToList();
        }
    }
}
