using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace WorkerService1;


/// <summary>
///  Modelo para el cuerpo de la solicitud POST.
/// </summary>
public class PostData
    {
        /// <summary>
        /// Nombre del parámetro.
        /// </summary>
        public string ParameterName { get; set; }

        /// <summary>
        /// Fecha y hora de la medición.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Valor del parámetro.
        /// </summary>
        public int Value { get; set; }
    }


    
    


