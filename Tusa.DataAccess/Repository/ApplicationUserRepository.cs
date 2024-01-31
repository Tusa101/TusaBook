﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TusaBulkyBook.DataAccess.Data;
using TusaBulkyBook.DataAccess.Migrations;
using TusaBulkyBook.DataAccess.Repository.IRepository;
using TusaBulkyBook.Models;

namespace TusaBulkyBook.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
