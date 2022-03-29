using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketTrackingSystem.Repository;

namespace TicketTrackingSystem.Service.QA
{
    public partial class QAReportService : IQAReportService
    {
        private readonly ILogger<QAReportService> _logger;
        public IReportRepository ReportRepository { get; set; }

        public QAReportService(ILogger<QAReportService> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
