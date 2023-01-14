using AutoMapper;
using SmartLog.Application.DTOs;
using SmartLog.Application.Interfaces;
using SmartLog.Domain.Entities;
using SmartLog.Domain.Interfaces;

namespace SmartLog.Application.Services;

public class LogService : ILogService
{
    private readonly ILogRepository _logRepository;
    private readonly IMapper _autoMapper;

    public LogService(ILogRepository repository, IMapper autoMapper)
    {
        _logRepository = repository;
        _autoMapper = autoMapper;
    }

    public async Task AddLogAsync(LogDTO log)
    {
        var logEntity = _autoMapper.Map<Log>(log);
        await _logRepository.CreateLogAsync(logEntity);
    }

    public async Task<LogDTO> GetLogAsync(Guid id)
    {
        var log = await _logRepository.GetLogAsync(id);
        return _autoMapper.Map<LogDTO>(log);
    }

    public async Task<IEnumerable<LogDTO>> GetLogsAsync()
    {
        var logs = await _logRepository.GetLogsAsync();
        return _autoMapper.Map<IEnumerable<LogDTO>>(logs);
    }

    public async Task<Counter> GetCountersAsync()
    {
        return await _logRepository.GetCountersAsync();
    }
}