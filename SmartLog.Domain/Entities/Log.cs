using SmartLog.Domain.Enum;

namespace SmartLog.Domain.Entities;

public class Log
{
    public int Id { get; set; }
    public Guid IdSecondary { get; set; }
    public string Message { get; set; } = String.Empty;
    public Level Level { get; set; }
    public DateTime Date => DateTime.Now;
    public bool Active => true;
}