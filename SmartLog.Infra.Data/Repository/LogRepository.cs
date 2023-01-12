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
        return await _context.Log.ToListAsync();
    }

    public async Task<Log> GetLogAsync(Guid id)
    {
        return await _context.Log.FirstOrDefaultAsync(x => x.Id_secondary == id);
    }
}
