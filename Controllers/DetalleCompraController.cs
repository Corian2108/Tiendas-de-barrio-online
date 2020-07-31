using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tiendas_de_barrio_online.Models;

namespace Tiendas_de_barrio_online.Controllers
{
    public class DetalleCompraController : Controller
    {
        private readonly ILogger<DetalleCompraController> _logger;
        
        public DetalleCompraController(ILogger<DetalleCompraController> logger) 
        {
            _logger = logger;
        }

        public IActionResult DetalleCompra() 
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() 
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}