using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityModel;
using Helper;

namespace FirstEFCoreSample
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BlogDbContext>(options=>options.UseMySql(Configuration.GetConnectionString("blog_db"),ServerVersion.Parse("5.7.31-mysql")));
            services.AddControllersWithViews();
           
            TestService(services);
        }
        public void TestService(IServiceCollection services)
        {
            var service = services.BuildServiceProvider();//将服务集合build一下，然后注入到TestHelper，
            var instance = ActivatorUtilities.CreateInstance<TestHelper>(service);//通过ActivatorUtilities相当于反射获取到TestHelper类
            instance.RunTest();

            SeedData seedData = new SeedData(service.GetService<BlogDbContext>());
            seedData.InitializeData();

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
