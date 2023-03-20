using ShoppingCart.Service.Infrastructure;
using ShoppingCart.Service.Repositories;
using ShoppingCart.Web2.Helper;

namespace ShoppingCart.Web2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        //this method get called by the runtime. use this method to add services
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddTransient<ICategory, CategoryRepo>();
            services.AddTransient<IProduct, ProductRepo>();
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutomapperProfile());
            });
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }
        //this method gets called by runtime . use this emthod to configure
        public void Configure(IApplicationBuilder app, IWebHostingEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                //the default HSTS bvalue in 30 days.you may want to change this
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(
                    name: "default");
            })
        }
    }
}
