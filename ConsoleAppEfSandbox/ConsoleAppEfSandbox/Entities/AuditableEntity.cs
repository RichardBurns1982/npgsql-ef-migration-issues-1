namespace ConsoleAppEfSandbox.Entities;

public class AuditableEntity
{
    public int Id { get; set; }

    public int? CreatedByUserId { get; set; }

    public User? CreatedByUser { get; set; }
}
