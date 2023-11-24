using DisasterAlleviationFoundation.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace DisasterAlleviationFoundation
{
    public class Startup
    { public Startup(IConfiguration configuration)
            {
                Configuration = configuration;
            }

            public IConfiguration Configuration { get; }

            public void ConfigureServices(IServiceCollection services)
            {
                services.AddRazorPages();
                services.AddDbContext<AuthDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("AuthConnectionString")));

                services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AuthDbContext>();
            }

          
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }
                else
                {
                    app.UseExceptionHandler("/Error");
                  
                    app.UseHsts();
                }

                app.UseHttpsRedirection();
                app.UseStaticFiles();

                app.UseRouting();

                app.UseAuthentication();

                app.UseAuthorization();

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapRazorPages();
                });
            }
        }
    }