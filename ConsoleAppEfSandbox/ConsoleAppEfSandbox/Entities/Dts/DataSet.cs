namespace ConsoleAppEfSandbox.Entities.Dts;

public class DataSet
{
    public int Id { get; set; }
    public int? CreatedByUserId { get; set; }
    public User? CreatedByUser { get; set; }
}
