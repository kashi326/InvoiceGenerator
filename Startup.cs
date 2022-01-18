using InvoiceGenerator.Data;
using InvoiceGenerator.Resources;
using InvoiceGenerator.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceGenerator
{
    public class Startup
    {
        private readonly string RESOURCE_PATH = "Resources";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();


            services.AddAuthentication()
                .AddCookie(options =>
                {
                    options.LoginPath = "/Identity/Account/Login";
                    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                    options.ForwardForbid = "Identity.Application";                    

                });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.ForwardForbid = "Identity.Application";

            });

            //Added Localization
            services.AddLocalization(options =>
            {
                options.ResourcesPath = RESOURCE_PATH;

            });
            services.AddMvc()
                .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null)
                .AddViewLocalization(options =>
                {
                    options.ResourcesPath = RESOURCE_PATH;
                })
                .AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization(options =>
                {
                    options.DataAnnotationLocalizerProvider = (t, f) => f.Create(typeof(Resource));
                })
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddTransient<ViewLocalizer>();


            services.Configure<RequestLocalizationOptions>(options =>
            {
                // var englishCulture = new CultureInfo("en-US");
                // englishCulture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";


                var arabicCulture = new CultureInfo("ar-SA");
                arabicCulture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
                var englishCulture = new CultureInfo("en-US");
                englishCulture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
                arabicCulture.DateTimeFormat = englishCulture.DateTimeFormat;
                arabicCulture.NumberFormat = englishCulture.NumberFormat;


                var SupportedCultures = new List<CultureInfo>
                {
                    arabicCulture,
                    englishCulture
                };

                CultureInfo.DefaultThreadCurrentCulture = englishCulture;
                CultureInfo.DefaultThreadCurrentUICulture = englishCulture;

                options.DefaultRequestCulture = new RequestCulture(englishCulture);
                options.SupportedCultures = SupportedCultures;
                options.SupportedUICultures = SupportedCultures;

            });

            services.AddTransient<IQrCodeGenerator, QrCodeGenerator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            var locationsOptions = new RequestLocalizationOptions()
                .SetDefaultCulture("en-US");

            app.UseRequestLocalization();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
