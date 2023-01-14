using Lab_11.Services;

namespace Lab_11
{
    public class Startup
    {
        public IConfiguration _configuration { get; }

        public Startup(IConfiguration configuration) =>
            _configuration = configuration;
        public void ConfigureServices(IServiceCollection service)
        {
            service.AddTransient<ICalcService, CalcService>();
            service.AddControllersWithViews();
        }
        public void Configure(IApplicationBuilder applicationBuilder, IWebHostEnvironment webHostEnvironment)
        {
            if (webHostEnvironment.IsDevelopment())
                applicationBuilder.UseDeveloperExceptionPage();
            else {
                applicationBuilder.UseExceptionHandler("/Home/Error"); 
                applicationBuilder.UseHsts();
            }

            applicationBuilder.UseStaticFiles();

            applicationBuilder.UseHttpsRedirection();

            applicationBuilder.UseRouting();

            applicationBuilder.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
                }
            );
        }
    }
}