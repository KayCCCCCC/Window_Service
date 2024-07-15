using Microsoft.Extensions.Hosting.WindowsServices;
using WorkerService;

var builder = Host.CreateDefaultBuilder(args);

// Check if the app is running as a Windows Service
if (WindowsServiceHelpers.IsWindowsService())
{
    builder.UseWindowsService();
}

builder.ConfigureServices((hostContext, services) =>
{
    services.AddHostedService<Worker>(); // Assuming Worker is your hosted service class
    services.AddSingleton<TutorStorage>();
});

builder.ConfigureLogging(logging =>
{
    logging.AddConsole();
});

var host = builder.Build();

var tutorStorage = host.Services.GetRequiredService<TutorStorage>();
tutorStorage.InsertTutors(InitData.Tutors);

await host.RunAsync();
