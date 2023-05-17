using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SportsStore.Models;

public class AppIdentityDbContext : IdentityDbContext<IdentityUser>
{
  public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
    : base(options) { }
}