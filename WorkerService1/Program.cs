using WorkerService1;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.Core;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureServices((_, services) =>
        {
            // Se registran los servicios necesarios en el contenedor de inyección de dependencias.
            services.AddSingleton(new ApiParameters
            {
                ApplicationId = "55420070-03fb-4b4f-bf84-23ffc20625ff",
                PlantId = "cde0ea28-70d7-424e-8064-271f96c3a2c5",
                ApiKey = "TSVPNQaT4s78hs8ZsO7NxXeGst77mlgGVw==",
                SubscriptionKey = "9ab2f67bb5b3425baf7896105d09949d"
            });
            services.AddHttpClient<ApiClient>();
            services.AddHostedService<Worker>();
   
        });
}