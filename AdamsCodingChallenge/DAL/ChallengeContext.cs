using AdamsCodingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AdamsCodingChallenge.DAL
{
    public class ChallengeContext : DbContext
    {
        public ChallengeContext() : base("ChallengeContext")
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}