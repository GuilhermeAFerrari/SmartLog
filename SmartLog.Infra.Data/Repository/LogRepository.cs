using System.Security.Cryptography.X509Certificates;
using SmartLog.Domain.Interfaces;
using SmartLog.Domain.Entities;
using SmartLog.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace SmartLog.Infra.Data.Repository;

public class LogRepository : ILogRepository
{
    private readonly ApplicationDbContext _context;

    public LogRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task CreateLogAsync(Log log)
    {
        _context.Add(log);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Log>> GetLogsAsync()
    {
        var logs = await _context.Log.ToListAsync();
        return logs.OrderBy(x => x.Level);
    }

    public async Task<Log> GetLogAsync(Guid id)
    {
        return await _context.Log.FirstOrDefaultAsync(x => x.Id_secondary == id);
    }

    public async Task<Counter> GetCountersAsync()
    {
        var logs = await GetLogsAsync();
        var counter = new Counter()
        {
            High = logs.Count(x => x.Level == Domain.Enum.Level.High),
            Mid = logs.Count(x => x.Level == Domain.Enum.Level.Middle),
            Low = logs.Count(x => x.Level == Domain.Enum.Level.Low)
        };

        return counter;
    }
}
