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

            // Modifique aqui para que o FormMain tenha suas depend�ncias resolvidas no in�cio da aplica��o
            Application.Run(ServiceProvider.GetRequiredService<Form1>());

        }

        // � necess�rio criar o provedor de servi�os e adicionar todos os servi�os que se deseja prover por inje��o de depend�ncia
        // Use ServiceProvider.GetRequiredService<FormQualquer>() sempre que for necess�rio instanciar novos formul�rios e adicione-os ao reposit�rio de servi�os no corpo do m�todo a seguir.
        public static IServiceProvider? ServiceProvider { get; private set; }

        // M�todo de configura��o de inje��o de depend�ncia
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Adicionando os servi�os de inje��o de depend�ncia a cole��o de servi�os

                    // Forms da Aplica��o
                    services.AddTransient<Form1>();

                    // Contexto Data Base
                    services.AddDbContext<DogTreatmentDbContext>(
                            options => options.UseSqlite("Data Source=FoodDog.db"));

                    // Services

                });
        }
    }
}