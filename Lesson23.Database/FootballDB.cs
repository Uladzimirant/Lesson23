using Lesson23.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lesson23.Database
{
    public class FootballDB : DbContext
    {
        public FootballDB(DbContextOptions opts) : base(opts)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();

            var c = new Coach() { Name = "Иван", Surname = "Костоправов" };
            var g = new Group() { Name = "ГГ" };
            var t1 = new Team() { Name = "Первые", Coach = c, Group = g, Rate = 20 };
            var t2 = new Team() { Name = "Лидеры", Coach = c, Group = g, Rate = 20 };
            var p = new Player[]
            {
                new Player() { Name="Алексей", Surname="Бегунов", Team=t1,Age=21, Salary=12000 },
                new Player() { Name="Александр", Surname="Прыгунов", Team=t1,Age=22, Salary=11000 },
                new Player() { Name="Артем", Surname="Плывунов", Team=t2,Age=20, Salary=13000 },
                new Player() { Name="Артур", Surname="Скакунов", Team=t2,Age=21, Salary=11500 }
            };
            var s = new Schedule() { Group = g, TeamA = t1, TeamB = t2, Time = new DateTime(2012, 1, 24, 14, 30, 00) };

            Coaches.Add(c);
            Groups.Add(g);
            Teams.AddRange(t1, t2);
            Players.AddRange(p);
            Schedules.Add(s);

            SaveChanges();
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
    }
}