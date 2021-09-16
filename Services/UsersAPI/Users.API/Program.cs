using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Users.API.Business.DependencyResolvers.Autofac;

namespace Users.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
             Host.CreateDefaultBuilder(args)
              .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureContainer<ContainerBuilder>(builder =>
                {
                    builder.RegisterModule(new AutofacBussinessModule());
                })
                 .ConfigureWebHostDefaults(webBuilder =>
                 {
                     webBuilder.UseUrls("http://*:8000");
                     webBuilder.UseStartup<Startup>();
                 });
    }
}
