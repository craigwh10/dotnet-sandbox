using System;
using System.Threading.Tasks;
using Company.Models;

namespace Company.Business.Services.Interfaces
{
    public interface ICompanyInfoService
    {
        Task<CompanyModel> GetCompanyInfo(string name);
    }
}
