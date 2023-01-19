using System.ComponentModel.DataAnnotations;
using SmartLog.Domain.Enum;

namespace SmartLog.Application.DTOs;

public class LogDTO
{
    public required Guid Id_secondary { get; set; }
    [MaxLength(300)]
    public string? Message { get; set; }
    public string? StackTrace { get; set; }
    public string? Request { get; set; }
    public string? Response { get; set; }
    public required Level Level { get; set; }
    public required DateTime Date { get; set; }
}