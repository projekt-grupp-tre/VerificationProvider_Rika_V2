

using Microsoft.EntityFrameworkCore;
using VerificationProvider_Rika_V2.Data.Entities;

namespace VerificationProvider_Rika_V2.Data.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<VerificationRequestEntity> VerificationRequests { get; set; } = null!;


}
