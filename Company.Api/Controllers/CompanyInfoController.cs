using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Company.Models;
using Company.Business.Services.Interfaces;

namespace Company.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyInfoService _companyInfoService;
        private readonly ILogger<CompanyController> _logger;

        public CompanyController(ILogger<CompanyController> logger, ICompanyInfoService companyInfoService)
        {
            _logger = logger;
            _companyInfoService = companyInfoService;
    }


        [HttpGet]
        public async Task<ActionResult<CompanyModel>> GetCompanyInfo(string name)
        {
            return await _companyInfoService.GetCompanyInfo(name);
        }
    }
}
