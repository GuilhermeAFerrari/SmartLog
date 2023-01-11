using SmartLog.Domain.Entities;

namespace SmartLog.Domain.Interfaces;

public interface ILogRepository
{
    Task<IEnumerable<Log>> GetLogsAsync();
    Task CreateLogAsync(Log log);
    Task<Log> GetLogAsync(Guid id);
}