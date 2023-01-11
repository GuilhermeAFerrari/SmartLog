using AutoMapper;
using SmartLog.Application.DTOs;
using SmartLog.Domain.Entities;

namespace SmartLog.Application.Mappings;

public class DTOToEntityLog : Profile
{
    public DTOToEntityLog()
    {
        CreateMap<Log, LogDTO>().ReverseMap();
    }
}