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

    public async Task<Log> CreateLogAsync(Log log)
    {
        _context.Add(log);
        await _context.SaveChangesAsync();
        return log;
    }

    public async Task<IEnumerable<Log>> GetLogsAsync()
    {
        return await _context.Log.ToListAsync();
    }
}
