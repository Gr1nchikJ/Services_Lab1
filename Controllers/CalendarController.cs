using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplicationService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalendarController : ControllerBase
    {
        private static readonly string[] WeekDays = new[]
        {
        "Monday", "Thursday", "Wednesday", "Tuesday", "Friday", "Saturday", "Sunday"
    };

        private readonly ILogger<CalendarController> _logger;

        public CalendarController(ILogger<CalendarController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeekDays")]
        public IEnumerable<Calendar> Get()
        {
            
            return Enumerable.Range(1, 7).Select(index => new Calendar
            {
      
                Date = DateTime.Now.AddDays(index),
                WeekDay = DateTime.Now.AddDays(index).DayOfWeek.ToString(),
                
            })
            .ToArray();
        }
    }
}