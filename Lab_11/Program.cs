using Microsoft.AspNetCore;

namespace Lab_11
{
    public static class Program
    {
        public static void Main() =>
            CreateWebHostBuilder().Build().Run();

        public static IWebHostBuilder CreateWebHostBuilder() =>
            WebHost.CreateDefaultBuilder().UseStartup<Startup>();
    }
}
