using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
  public class Exchange
  {
    public int Id { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<Portfolio> Portfolios { get; set; }

    public Exchange()
    {
      Active = true;
      CreatedAt = DateTime.UtcNow;
      UpdatedAt = DateTime.UtcNow;
      Portfolios = new HashSet<Portfolio>();
    }
  }
}