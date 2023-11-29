using Core.Persistence.Repositories;
using DataAccess.Context;
using DataAccess.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore.Query;
using Models.Dtos.ResponseDto.CompanyResponses;
using Models.Dtos.ResponseDto.OwnerResponses;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete;

public class OwnerRepository : EfRepositoryBase<BaseDbContext, Owner, int>, IOwnerRepository
{
    public OwnerRepository(BaseDbContext context) : base(context)
    {
    }

    public List<OwnerDetailDto> GetAllOwnerDetails()
    {
        var details = Context.Owners.Select(owner =>
        new OwnerDetailDto
        {
            Id = owner.Id,
            Name = owner.Name,
            Companies = owner.Companies

        }).ToList();
        return details;
    }

    public OwnerDetailDto GetDetailsById(int id)
    {
        var details = Context.Owners.Select(owner =>
          new OwnerDetailDto
          {
              Id = owner.Id,
              Name = owner.Name,
              Companies = owner.Companies

          }).Where(x=>x.Id.Equals(id)).SingleOrDefault();
        return details;
    }
}
