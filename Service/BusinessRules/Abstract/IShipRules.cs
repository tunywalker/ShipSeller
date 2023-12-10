using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessRules.Abstract;

public interface IShipRules
{
    void CheckShipNameAndLength(Ship ship);
    void ShipIsPresent(int id);

    void IsShipColorValid(int color);
}
