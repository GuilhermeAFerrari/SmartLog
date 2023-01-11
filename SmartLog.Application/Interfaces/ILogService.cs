using SmartLog.Application.DTOs;

namespace SmartLog.Application.Interfaces;

public interface ILogService
{
    Task<IEnumerable<LogDTO>> GetLogsAsync();
    Task<LogDTO> GetLogAsync(Guid id);
    Task AddLogAsync(LogDTO log);
}