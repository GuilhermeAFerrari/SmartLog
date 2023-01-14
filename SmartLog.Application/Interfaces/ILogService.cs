using SmartLog.Application.DTOs;
using SmartLog.Domain.Entities;

namespace SmartLog.Application.Interfaces;

public interface ILogService
{
    Task<IEnumerable<LogDTO>> GetLogsAsync();
    Task<LogDTO> GetLogAsync(Guid id);
    Task AddLogAsync(LogDTO log);
    Task<Counter> GetCountersAsync();
}