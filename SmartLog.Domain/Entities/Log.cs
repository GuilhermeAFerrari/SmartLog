using SmartLog.Domain.Enum;

namespace SmartLog.Domain.Entities;

public class Log
{
    public int Id { get; set; }
    public Guid Id_secondary { get; set; }
    public string Message { get; set; } = String.Empty;
    public Level Level { get; set; }
    public DateTime Date { get; set; }
    public bool Active { get; set; }
}