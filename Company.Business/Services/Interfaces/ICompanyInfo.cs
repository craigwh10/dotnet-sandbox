using System;
using Company.Entities;

namespace Company.Business.Services.Interfaces
{
    public interface ICompanyInfo
    {
        CompanyModel GetCompanyInfo(string name);
    }
}
