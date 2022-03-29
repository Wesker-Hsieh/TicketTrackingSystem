using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketTrackingSystem.Repository;

namespace TicketTrackingSystem.Service.RD
{
    public partial class RDSolveService : IRDSolveService
    {
        private readonly ILogger<RDSolveService> _logger;
        public ISolveRepository SolveRepository { get; set; }

        public RDSolveService(ILogger<RDSolveService> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
