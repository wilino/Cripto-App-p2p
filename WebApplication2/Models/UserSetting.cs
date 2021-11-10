using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace WebApplication2.Data
{
  public class UserSetting
  {
    public int Id { get; set; }
    public string Setting { get; set; }

    [ForeignKey(nameof(ApplicationUser))]
    public string UserId { get; set; }
    public virtual ApplicationUser User { get; set; }
  }
}