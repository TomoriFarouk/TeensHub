using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeensHub.Models
{
  public class School : BaseClass
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Others { get; set; }
    public string Rank { get; set; }
  }
}
