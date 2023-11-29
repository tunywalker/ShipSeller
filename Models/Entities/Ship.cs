using Core.Persistence.EntityBaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities;

public class Ship:Entity<int>
{
    public string Name { get; set; }
    public double Length { get; set; }
   
    public int AuthorCompanyId { get; set; }
    public Company AuthorCompany { get; set; }

    
    public ShipColor ShipColor { get; set; }

}

public enum ShipColor
{
    Red,
    Green,
    Blue,
    Yellow,
    YellowGreen,
    Black
}