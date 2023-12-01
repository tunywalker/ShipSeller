using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Repositories.Abstracts;
using Service.BusinessRules.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessRules.Concrete;

public class CompanyRules : ICompanyRules
{
    private readonly ICompanyRepository _companyRepository;

    public CompanyRules(ICompanyRepository companyRepository)
    {
        _companyRepository = companyRepository;
    }

    public void CompanyIsPresent(int id)
    {
       var company = _companyRepository.GetById(id);
       if (company == null)
        {
            throw new BusinessException($"Id:{id} olan şirket bulunamadı");
        }
    }

    public void CompanyNameMustBeUnique(string companyName)
    {
        var company = _companyRepository.GetByFilter(x => x.Name == companyName);
        if(company != null) 
        {
            throw new BusinessException("Şirket ismi benzersiz olmalı.");
        }
    }
}
