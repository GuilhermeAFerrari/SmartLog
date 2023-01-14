using SmartLog.Application.DTOs;
using SmartLog.Domain.Entities;

namespace SmartLog.UI.Models
{
    public class DashboardViewModel
    {
        public IEnumerable<LogDTO>? Log { get; set; }
        public Counter? Counters { get; set; }
    }
}