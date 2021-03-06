﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TeensHub.Models
{
  // Add profile data for application users by adding properties to the ApplicationUser class
  public class ApplicationUser : IdentityUser
  {

    public string FullName { get; set; }
    public string NickName { get; set; }
    public string Rank { get; set; }
    public int Coin { get; set; }
    public string RefLink { get; set; }
  }
}
