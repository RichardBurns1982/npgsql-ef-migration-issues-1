using ConsoleAppEfSandbox.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleAppEfSandbox.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Entities.Dts.DataSet>(b =>
        {
            b.HasKey(a => a.Id);
            b.IsAuditable();
            b.ToTable("data_sets", "dts");
        });

        modelBuilder.Entity<Entities.Organizations.DataSet>(b =>
        {
            b.HasKey(a => a.Id);
            b.IsAuditable();
            b.ToTable("data_sets", "organizations");
        });
    }
}

public static class AuditableExtensions
{
    public static EntityTypeBuilder<TEntity> IsAuditable<TEntity>(this EntityTypeBuilder<TEntity> entityTypeBuilder)
        where TEntity : AuditableEntity
    {
        entityTypeBuilder.HasOne(x => x.CreatedByUser).WithMany().HasForeignKey(x => x.CreatedByUserId).OnDelete(DeleteBehavior.Restrict);
        return entityTypeBuilder;
    }
}