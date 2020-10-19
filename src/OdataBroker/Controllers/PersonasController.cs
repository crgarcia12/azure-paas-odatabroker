using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataV3.Data;
using ODataV3.Models;

namespace ODataV3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonasController : ControllerBase
    {
        private readonly IDocumentDBRepository<Persona> Respository;
        public PersonasController(IDocumentDBRepository<Persona> respository)
        {
            this.Respository = respository;
        }

        [HttpGet]
        [EnableQuery()]
        public async Task<IEnumerable<Persona>> Get()
        {
            return await Respository.GetItemsAsync();
        }
    }
}
