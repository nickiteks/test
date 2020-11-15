using MainLogic.BindingModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainLogic.DataBase
{
    class DataBase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-3FLK5BJ\SQLEXPRESS;Initial Catalog=KOPDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<OrganizationUnit> Employees { set; get; }
    }
}
