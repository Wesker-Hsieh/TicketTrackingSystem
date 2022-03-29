using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketTrackingSystem.Models;
using TicketTrackingSystem.Models.RD;

namespace TicketTrackingSystem.Service.RD
{
    public partial interface IRDSolveService
    {
        BaseServiceReturn<ReportSearchReturn> ReportSearch(string id);
    }
}
