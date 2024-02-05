using MobileBankingManagement.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileBankingManagement.DataLayer
{
    public class InsuranceDbContext : DbContext
    {
        public InsuranceDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<MobileBanking> InsurancePolicies { get; set; }
    }

}