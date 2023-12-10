using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Repositories.Abstracts;
using Models.Entities;
using Service.BusinessRules.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessRules.Concrete;

public class ShipRules : IShipRules
{
    private readonly IShipRepository _shipRepository;

    public ShipRules(IShipRepository shipRepository)
    {
        _shipRepository = shipRepository;
    }
    public void CheckShipNameAndLength(Ship ship)
    {


    }

    public void IsShipColorValid(int numericValue)
    {
        if (!Enum.IsDefined(typeof(ShipColor), numericValue))
        {
            throw new BusinessException($"Gemi rengi bulunamadı");
        }
    }

    public void ShipIsPresent(int id)
    {
        Ship ship = _shipRepository.GetById(id);
        if (ship == null)
        {
            throw new BusinessException($"{id} ine sahip bir gemi bulunamadı");
        }
    }
}
