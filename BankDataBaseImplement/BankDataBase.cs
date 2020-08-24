﻿using BankDataBaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace BankDataBaseImplement
{
    public class BankDataBase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-1PF8O2J\SQLEXPRESS;
                Initial Catalog=BankDatabase2;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Money> Money { set; get; }
        public virtual DbSet<Credit> Credits { set; get; }       
        public virtual DbSet<Deal> Deals { set; get; }        
        public virtual DbSet<StorageMoney> StorageMoney { set; get; }
        public virtual DbSet<DealCredits> DealCredits { set; get; }
        public virtual DbSet<Client> Clients { set; get; }
        public virtual DbSet<Request> Request { set; get; }
        public virtual DbSet<MoneyRequest> MoneyRequest { set; get; }       
    }
}
