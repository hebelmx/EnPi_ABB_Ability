namespace WorkerService1
{


    public class Worker : BackgroundService
    {
        private readonly IServiceProvider _services;
        private readonly ILogger<Worker> _logger;
        public Worker(IServiceProvider services, ILogger<Worker> logger)
        {
            _services = services;
            _logger = logger;
        }





        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // Mientras la aplicación está corriendo.
            while (!stoppingToken.IsCancellationRequested)
            {
                // Se crea un nuevo ámbito para obtener una nueva instancia de ApiClient.
                using (var scope = _services.CreateScope())
                {
                    var apiClient = scope.ServiceProvider.GetRequiredService<ApiClient>();

                    // Se generan los datos para la solicitud POST.
                    var postData = new PostData
                    {
                        ParameterName = "oee",

                        //2023-08-04T00:26:14.4599884Z
                        //2023-08-04T00:26-06:00
                        //Date = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mmzzz"),
                        //Date = DateTime.UtcNow.ToString("2023-08-03T13:00-06:00"),
                        Date = DateHelper.ConvertDateFormat(DateTime.Now.AddMinutes(-60).ToString(), -6),
                        Value = 47
                    };

                    // Se envia la solicitud a la API.
                    await apiClient.SendRequest(postData);
                }

                // Se espera 10 segundos antes de enviar la próxima solicitud.
                await Task.Delay(10000, stoppingToken);
            }
        }
    }








}