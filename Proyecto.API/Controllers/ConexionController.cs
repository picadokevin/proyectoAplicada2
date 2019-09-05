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
    [Route("api/conexion")]
    public class ConexionController : Controller
    {
        private readonly IConfiguration configuration;
        public ConexionController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // GET: api/peliculas/love
        [HttpGet("{title}", Name = "GetBykey")]
        public IEnumerable<Key> GetBykey(String title)
        {
            ConexionData conexionData =
                new ConexionData(configuration.GetConnectionString("VideoContext").ToString());
            return conexionData.GetKey(title);
        }
    }
}