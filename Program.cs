using StudentWebApp.Data;
using StudentWebApp.Services;

namespace StudentWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            
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

            app.Run();
        }
    }
}
