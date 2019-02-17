namespace CIS174AzureDemo.Domain.Migrations
{
    using CIS174AzureDemo.Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CIS174AzureDemo.Domain.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CIS174AzureDemo.Domain.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Students.AddOrUpdate(new Student
            {
                StudentId = Guid.Parse("585c98e9-821b-49dc-87f0-c4f5e7117f93"),
                StudentName = "Bill Gates",
                DateOfBirth = new DateTime(1955, 10, 28),
                Height = 5.83m,
                Weight = 154.3f
            });

            context.Students.AddOrUpdate(new Student
            {
                StudentId = Guid.Parse("9fd4fd41-fbef-42cf-9f52-b8a88cbed2ad"),
                StudentName = "Steve Jobs",
                DateOfBirth = new DateTime(1955, 02, 24),
                Height = 6.17m,
                Weight = 176.75f
            });
        }
    }
}
