using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OdataBroker.Models;
using ODataV3.Data;
using ODataV3.Models;

namespace OdataBroker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InsurancePoliciesController : ControllerBase
    {
        private readonly IDocumentDBRepository<InsurancePolicy> Respository;
        public InsurancePoliciesController(IDocumentDBRepository<InsurancePolicy> respository)
        {
            this.Respository = respository;
        }

        [HttpGet]
        [EnableQuery()]
        public async Task<IEnumerable<InsurancePolicy>> Get()
        {
            return await Respository.GetItemsAsync();
        }
    }
}
