using Microsoft.EntityFrameworkCore;
using WebsiteCake.Logic.Categories;
using WebsiteCake.Logic.Filling;
using WebsiteCake.Logic.Fillings;
using WebsiteCake.Storage;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();
        
        builder.Services.AddScoped<ICategoryManger, CategoryManger>();

        builder.Services.AddScoped<IFillingManger, FillingManger>();
        builder.Services.AddDbContext<ConfectioneryContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ConfectioneryContext")));



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