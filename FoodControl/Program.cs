using FoodControl.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SQLiteTeste.Models;

namespace FoodControl
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //services.AddDbContext<DogFoodContext>(
            //        options => options.UseSqlite("Data Source=Lanchonete.db"));


            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();

            // Modifique aqui para que o FormMain tenha suas dependências resolvidas no início da aplicação
            Application.Run(ServiceProvider.GetRequiredService<Form1>());

        }

        // É necessário criar o provedor de serviços e adicionar todos os serviços que se deseja prover por injeção de dependência
        // Use ServiceProvider.GetRequiredService<FormQualquer>() sempre que for necessário instanciar novos formulários e adicione-os ao repositório de serviços no corpo do método a seguir.
        public static IServiceProvider? ServiceProvider { get; private set; }

        // Método de configuração de injeção de dependência
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Adicionando os serviços de injeção de dependência a coleção de serviços

                    // Forms da Aplicação
                    services.AddTransient<Form1>();

                    // Contexto Data Base
                    services.AddDbContext<DogTreatmentDbContext>(
                            options => options.UseSqlite("Data Source=FoodDog.db"));

                    // Services

                });
        }
    }
}