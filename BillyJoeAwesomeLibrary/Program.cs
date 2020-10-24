using BillyJoeAwesomeLibrary.Controller;
using BillyJoeAwesomeLibrary.Controller.Interface;
using BillyJoeAwesomeLibrary.Repository;
using BillyJoeAwesomeLibrary.Repository.Interface;
using BillyJoeAwesomeLibrary.Service;
using BillyJoeAwesomeLibrary.Service.Interface;
using BillyJoeAwesomeLibrary.View;
using Microsoft.Extensions.DependencyInjection;

namespace BillyJoeAwesomeLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var eventService = serviceProvider.GetService<IAlbumController>();
            TelaMenu telaMenu = new TelaMenu(eventService);
            telaMenu.InicializarVisual();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IAlbumController, AlbumController>()
            .AddScoped<IAlbumService, AlbumService>()
            .AddScoped<IAlbumRepository, AlbumRepository>();
                //.AddDbContext<DatabaseContext>(opt => opt.UseInMemoryDatabase("test"));
        }
    }
}
