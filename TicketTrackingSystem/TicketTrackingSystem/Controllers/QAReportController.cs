using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketTrackingSystem.Service.QA;

namespace TicketTrackingSystem.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public partial class QAReportController : ControllerBase
    {
        private readonly ILogger<QAReportController> _logger;
        private readonly IQAReportService _service;

        public QAReportController(ILogger<QAReportController> logger, IQAReportService service)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _service = service ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
