namespace ExamWork.DataAccess
{
    using ExamWork.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ExamContext : DbContext
    {
        public ExamContext()
            : base("name=ExamContext")
        {
        }

      public DbSet<Cantry> Cantries { get; set; }
      public DbSet<City> Cities { get; set; }
      public DbSet<Street> Streets { get; set; }
    }

   
}