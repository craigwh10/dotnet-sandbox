using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Company.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace Company.Api.Controllers
{
    [Route("v1/[controller]")]
    public class CompanyInfoController : Controller
    {
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<CompanyModel>), 200)]
        public Task<IActionResult> ReadAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
