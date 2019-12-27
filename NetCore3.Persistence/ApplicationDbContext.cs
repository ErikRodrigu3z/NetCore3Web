using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetCore3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore3.Persistence
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //DbSet 
        public DbSet<Cutomers> Cutomers { get; set; }





    }
}
