namespace _15._07._2019.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_15._07._2019.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(_15._07._2019.Model1 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Users.AddOrUpdate(
                t => t.Id,
                new User { Id = 1, Login = "Vlad", Password = "vlandr231".GetHashCode().ToString(), Address = "Pushkina, 4", PhoneNumber = "+380 94 838 7358", IsAdmin = true },
                new User { Id = 2, Login = "Vitalii", Password = "lksdlk".GetHashCode().ToString(), Address = "Kazkova, 21", PhoneNumber = "+380 68 563 8374" },
                new User { Id = 3, Login = "kubrrak", Password = "hduhfhs".GetHashCode().ToString(), Address = "Shychevycha, 1", PhoneNumber = "+380 97 873 8748" }
            );
        }
    }
}
