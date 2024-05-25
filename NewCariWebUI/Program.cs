using NewCari.BLL.Abstract;
using NewCari.BLL.Concrete;
using NewCari.Core.Concrete;
using NewCari.Core.DataAccess;
using NewCari.DAL.Abstract;
using NewCari.DAL.Concrete.EntityFramework;

namespace NewCariWebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IMusteriService, MusteriService>();
            builder.Services.AddScoped<IEntityRepository<Musteri>, EfMusteriDal>();

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
