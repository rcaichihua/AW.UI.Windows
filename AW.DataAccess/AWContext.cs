using AW.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AW.DataAccess
{
    public class AWContext: DbContext    {
        public virtual DbSet<BusinessEntities> BusinessEntity { get; set; }

        public AWContext():base("Data Source=(local);Initial Catalog=AdventureWorks2014CodeFirst;Integrated Security=true;")
        {

        }
        //verificar singular o plural
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
