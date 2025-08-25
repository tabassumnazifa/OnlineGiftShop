﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FlowerShopAuth.Models;

namespace FlowerShopAuth.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Add DbSets for your other entities
        public DbSet<Gift> Gifts { get; set; }
        public DbSet<Cart> Carts { get; set; }
    }
}
