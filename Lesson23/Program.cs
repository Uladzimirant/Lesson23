using Lesson23.Database;
using Lesson23DatabaseDFirst;
using Microsoft.EntityFrameworkCore;

namespace Lesson23
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddAutoMapper(typeof(AutoMapperProfile));



            var connectionStringDF = builder.Configuration.GetConnectionString("DatabaseFirst");
            var connectionString = builder.Configuration.GetConnectionString("CodeFirst");

            builder.Services.AddDbContext<Lesson19Context>(opts => opts.UseSqlServer(connectionStringDF));
            builder.Services.AddDbContext<FootballDB>(opts => opts.UseSqlServer(connectionString));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}