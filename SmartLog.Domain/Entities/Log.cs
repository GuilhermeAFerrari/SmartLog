using SmartLog.Domain.Enum;

namespace SmartLog.Domain.Entities;

public class Log
{
    public int Id { get; set; }
    public Guid Id_secondary { get; set; }
    public required string Message { get; set; }
    public Level Level { get; set; }
    public DateTime Date { get; set; }
    public bool Active { get; set; }
}