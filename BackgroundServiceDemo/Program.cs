using BackgroundServiceDemo;
using BackgroundServiceDemo.Data;
using BackgroundServiceDemo.Model;

IHost host = Host.CreateDefaultBuilder(args)
	.ConfigureServices(services =>
	{
		services.AddHostedService<Worker>();
		services.AddTransient<IItemService, ItemService>();
	})
	.Build();

await host.RunAsync();