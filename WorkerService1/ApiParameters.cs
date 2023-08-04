using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService1;
/// <summary>
/// // Modelo para los parámetros de la API.
/// </summary>
public class ApiParameters
{
    /// <summary>
    /// Identificador de la aplicación.
    /// </summary>
    public string ApplicationId { get; set; }

    /// <summary>
    /// Identificador de la planta.
    /// </summary>
    public string PlantId { get; set; }

    /// <summary>
    /// Clave de la API.
    /// </summary>
    public string ApiKey { get; set; }

    /// <summary>
    /// Clave de suscripción.
    /// </summary>
    public string SubscriptionKey { get; set; }
}

   