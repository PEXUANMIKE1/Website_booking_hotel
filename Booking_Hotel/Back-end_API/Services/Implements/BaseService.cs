﻿using Back_end_API.Context;

namespace Back_end_API.Services.Implements
{
    public class BaseService
    {
        public readonly AppDbContext _context;
        public BaseService( AppDbContext dbContext)
        {
            _context = dbContext;
        }
    }
}
