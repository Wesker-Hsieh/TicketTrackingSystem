using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketTrackingSystem.Repository
{
    public partial interface IReportRepository
    {
        Task ReportSearch();
    }
}
