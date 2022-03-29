using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketTrackingSystem.Service.RD;

namespace TicketTrackingSystem.Controllers
{
    public partial class RDSolveController : ControllerBase
    {
        private readonly ILogger<RDSolveController> _logger;
        private readonly IRDSolveService _service;

        public RDSolveController(ILogger<RDSolveController> logger, IRDSolveService service)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _service = service ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
