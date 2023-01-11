using SmartLog.Domain.Enum;

namespace SmartLog.Application.DTOs;

public class LogDTO
{
    public Guid Id_secondary { get; set; }
    public string Message { get; set; } = string.Empty;
    public Level Level { get; set; }
    public DateTime Date { get; set; }
}