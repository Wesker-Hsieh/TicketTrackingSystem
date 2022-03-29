using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketTrackingSystem.Models;
using TicketTrackingSystem.Models.QA;

namespace TicketTrackingSystem.Service.QA
{
    public partial interface IQAReportService
    {
        BaseServiceReturn<QAReportSearchReturn> QAReportSearch();
    }
}
