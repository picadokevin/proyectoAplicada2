using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Proyecto.Model.Data;
using Proyecto.Model.Domain;

namespace Proyecto.API.Controllers
{
    [Produces("application/json")]
    [Route("api/insert")]
    public class ProductInsertController : Controller
    {
        private readonly IConfiguration configuration;
        public ProductInsertController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        [HttpPost]
      
        public void insertProduct([FromBody] Producto product)
        {
            ConexionData compañiaData =
                new ConexionData(configuration.GetConnectionString("VideoContext").ToString());
            compañiaData.Insertar(product);
        }
    }
}