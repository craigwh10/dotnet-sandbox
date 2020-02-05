using System;
using System.Threading.Tasks;
using Company.Business.Services.Interfaces;
using Company.Models;

namespace Company.Business.Services
{
    public class CompanyInfoService : ICompanyInfoService
    {
        public async Task<CompanyModel> GetCompanyInfo(string name)
        {
            return await Task.Run(() => { return new CompanyModel { Name = "AND Digital", CEO = "Paramjit Uppal", EmployeeCount = 632 }; });
        }
    }
}
