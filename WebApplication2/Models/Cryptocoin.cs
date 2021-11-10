using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
  public class Cryptocoin
  {
    public int Id { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<Portfolio> Portfolios { get; set; }

    public Cryptocoin()
    {
      Active = true;
      CreatedAt = DateTime.UtcNow;
      UpdatedAt = DateTime.UtcNow;
      Portfolios = new HashSet<Portfolio>();
    }
  }
}