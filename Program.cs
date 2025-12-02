<<<<<<< HEAD
using StudentWebApp.Data;
using StudentWebApp.Services;

namespace StudentWebApp
=======

using Microsoft.EntityFrameworkCore;
using StudentAPI.Data;

namespace StudentAPI
>>>>>>> bdb365cb097ab2d431762969e71c4587c82a328c
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

<<<<<<< HEAD
            
            builder.Services.AddControllersWithViews();

            builder.Services.AddHttpClient("StudentAPI", client =>
            {
                client.BaseAddress = new Uri("http://localhost:7004/api/"); // <-- your API URL
            });

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>();

            
            builder.Services.AddScoped<StudentService>();

            builder.Services.AddSingleton<MarksService>();



            var app = builder.Build();

            
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
=======
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
>>>>>>> bdb365cb097ab2d431762969e71c4587c82a328c

            app.Run();
        }
    }
}
