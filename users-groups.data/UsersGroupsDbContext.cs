using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace users_groups.data
{
    public class UsersGroupsDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Group> Groups { get; set; }

        public static readonly LoggerFactory MyLoggerFactory
            = new LoggerFactory(new[] { new ConsoleLoggerProvider((_, __) => true, true) });

        public UsersGroupsDbContext(DbContextOptions<UsersGroupsDbContext> options)
            : base(options)
        { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(MyLoggerFactory)
                .UseSqlServer(@"Server=.\DEVLOCAL;Database=UsersGroupsDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Group>().HasData(
                new Group() { Id = 1, GroupName = "Hosts" },
                new Group() { Id = 2, GroupName = "Replicants"},
                new Group() { Id = 3, GroupName = "Humans"},
                new Group() { Id = 4, GroupName = "Cyborgs" }
            );

            builder.Entity<Person>().HasData(
                new Person() { Id = 1, Name = "Dolores Abernathy", GroupId = 1},
                new Person() { Id = 2, Name = "Bernard Lowe", GroupId = 1},
                new Person() { Id = 3, Name = "Maeve Millay", GroupId = 1 },
                new Person() { Id = 4, Name = "Rick Deckard", GroupId = 2 },
                new Person() { Id = 5, Name = "Rachel", GroupId = 2 },
                new Person() { Id = 6, Name = "Robert Ford", GroupId = 3},
                new Person() { Id = 7, Name = "William", GroupId = 3},
                new Person() { Id = 8, Name = "T1000", GroupId = 4}
            );

        }
    }
}
