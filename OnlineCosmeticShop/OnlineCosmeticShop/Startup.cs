namespace OnlineCosmeticShop
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using OnlineCosmeticShop.Data;
    using OnlineCosmeticShop.Data.Models;
    using OnlineCosmeticShop.Infrastructures;
    using OnlineCosmeticShop.Services.Prodicts;
    using OnlineCosmeticShop.Services.TradePartners;

    public class Startup
    {
        public Startup(IConfiguration configuration)
            => this.Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<OnlineShopDbContext>(options =>
                options.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection")));

            services
                .AddDatabaseDeveloperPageExceptionFilter();

            services
                .AddDefaultIdentity<User>(options =>
                {
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;

                })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<OnlineShopDbContext>();
            
            services.AddAutoMapper(typeof(Startup));

            services
                .AddControllersWithViews(options =>
                {
                    options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
                });

            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ITradePartnerService, TradePartnerService>();
            //services.AddTransient<ICartService, CartService>();
            //services.AddTransient<IOrderService, OrderService>();
            //services.AddTransient<IShippingDetailsService, ShippingDetailsService>();
            //services.AddTransient<IAllOrdersService, AllOrdersService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection()
                .UseStaticFiles()
                .UseRouting()
                .UseAuthentication()
                .UseAuthorization()
                .UseEndpoints(endpoints =>
                {
                    //endpoints.MapControllerRoute(
                    //    "areaRoute",
                    //    "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                    endpoints.MapDefaultAreaRoute();
                    endpoints.MapDefaultControllerRoute();
                    endpoints.MapRazorPages();
                });
        }
    }
}
