using System.Text.Json;

namespace WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly TutorStorage _tutorStorage;

        public Worker(ILogger<Worker> logger, TutorStorage tutorStorage)
        {
            _logger = logger;
            _tutorStorage = tutorStorage;
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            string logFilePath = "D:\\CN7\\PRN221\\RazorPage\\NET1704_221_ASM4_SE172587_NguyenNgoThanhNha\\TutorWorker.txt"; // Path to the log file

            while (!cancellationToken.IsCancellationRequested)
            {
                var tutors = _tutorStorage.GetTutors();
                var tutorsJson = JsonSerializer.Serialize(tutors, new JsonSerializerOptions { WriteIndented = true });

                // Log current list of tutors to console/logger
                _logger.LogInformation("Tutors: {tutors}", tutorsJson);

                // Write current list of tutors to file
                await File.AppendAllTextAsync(logFilePath, $"Tutors: {tutorsJson}\n", cancellationToken);

                // Delay before removing deleted tutors
                await Task.Delay(5000, cancellationToken);

                // Remove deleted tutors
                _tutorStorage.RemoveDeletedTutors();
                string removalLog = $"Deleted tutors removed at: {DateTimeOffset.Now}\n";

                // Log removal to console/logger
                _logger.LogInformation(removalLog);

                // Write removal log to file
                await File.AppendAllTextAsync(logFilePath, removalLog, cancellationToken);
            }
        }
    }
}
