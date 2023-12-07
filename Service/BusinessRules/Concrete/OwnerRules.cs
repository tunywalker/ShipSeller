using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Repositories.Abstracts;
using DataAccess.Repositories.Concrete;
using Service.BusinessRules.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessRules.Concrete;

public class OwnerRules : IOwnerRules
{
    private readonly IOwnerRepository _ownerRepository;

    public OwnerRules(IOwnerRepository ownerRepository)
    {
        _ownerRepository = ownerRepository;
    }

    public void OwnerIsPresent(int id)
    {
        var owner = _ownerRepository.GetById(id);
        if (owner == null && id>-1 )
        {
            throw new BusinessException($"Id:{id} olan şirket sahibi bulunamadı");
        }
    }

    public void OwnerNameMustBeUnique(string ownerName)
    {
        var company = _ownerRepository.GetByFilter(x => x.Name == ownerName);
        if (company != null)
        {
            throw new BusinessException("Şirket sahibi ismi benzersiz olmalı.");
        }
    }
}
