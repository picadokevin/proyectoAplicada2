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
    [Route("api/product")]
    public class ProductController : Controller
    {
        private readonly IConfiguration configuration;
        public ProductController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        [HttpGet("{title}", Name = "GetByTitle")]
        public IEnumerable<Producto> GetByTitle(String title)
        {
            ConexionData conexionData =
                new ConexionData(configuration.GetConnectionString("VideoContext").ToString());
            return conexionData.getAllProducts(title);
        }
    }
}