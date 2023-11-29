using Core.Persistence.Repositories;
using DataAccess.Context;
using DataAccess.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using Models.Dtos.ResponseDto.EmployeeResponses;
using Models.Dtos.ResponseDto.OwnerResponses;
using Models.Dtos.ResponseDto.ShipResponses;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete;

public class ShipRepository : EfRepositoryBase<BaseDbContext, Ship, int>, IShipRepository
{
    public ShipRepository(BaseDbContext context) : base(context)
    {
    }

    public List<ShipDetailDto> GetAllShipDetails()
    {
        var details = Context.Ships.Join(
                Context.Companies,
                s => s.Id,
                c => c.Id,
                (ship, company) => new ShipDetailDto
                {
                    Id=ship.Id,
                    ShipColor=ship.ShipColor,
                    AuthorCompany=company,
                    Name=ship.Name,
                    Length = ship.Length

                }
                ).ToList();

        return details;
    }

    public List<ShipDetailDto> GetByColor(ShipColor shipColor)
    {
        var details = Context.Ships.Join(
               Context.Companies,
               s => s.Id,
               c => c.Id,
               (ship, company) => new ShipDetailDto
               {
                   Id = ship.Id,
                   ShipColor = ship.ShipColor,
                   AuthorCompany = company,
                   Name = ship.Name,
                   Length = ship.Length

               }
               ).Where(s=>s.ShipColor.Equals(shipColor)).ToList();
        return details;
    }

    public List<ShipDetailDto> GetDetailsByAuthorCompanyId(int id)
    {

        var details = Context.Ships.Join(
               Context.Companies,
               s => s.Id,
               c => c.Id,
               (ship, company) => new ShipDetailDto
               {
                   Id = ship.Id,
                   ShipColor = ship.ShipColor,
                   AuthorCompany = company,
                   Name = ship.Name,
                   Length = ship.Length

               }
               ).Where(s => s.AuthorCompany.Id.Equals(id)).ToList();
        return details;
    }

    public List<ShipDetailDto> GetDetailsByLength(decimal shiplength)
    {

        var details = Context.Ships.Join(
               Context.Companies,
               s => s.Id,
               c => c.Id,
               (ship, company) => new ShipDetailDto
               {
                   Id = ship.Id,
                   ShipColor = ship.ShipColor,
                   AuthorCompany = company,
                   Name = ship.Name,
                   Length = ship.Length

               }
               ).Where(s => s.Length.Equals(shiplength)).ToList();
        return details;
    }

    public ShipDetailDto GetDetailsByShipId(int shipId)
    {
        var details = Context.Ships.Join(
               Context.Companies,
               s => s.Id,
               c => c.Id,
               (ship, company) => new ShipDetailDto
               {
                   Id = ship.Id,
                   ShipColor = ship.ShipColor,
                   AuthorCompany = company,
                   Name = ship.Name,
                   Length = ship.Length

               }
               ).Where(s => s.Id.Equals(shipId)).SingleOrDefault();
        return details;
    }
}
