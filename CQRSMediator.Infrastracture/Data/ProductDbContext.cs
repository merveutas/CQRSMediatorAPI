﻿using CQRSMediator.Domain.Entitiy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSMediator.Infrastracture.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
        }

        public DbSet<Product> Products { get; set; }

    }
}
