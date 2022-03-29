using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketTrackingSystem.Models;
using TicketTrackingSystem.Models.QA;

namespace TicketTrackingSystem.Service.QA
{
    public partial class QAReportService : IQAReportService
    {
        public BaseServiceReturn<QAReportCreateReturn> QAReportCreate()
        {
            throw new Exception();
        }

        public BaseServiceReturn<QAReportUpdateReturn> QAReportUpdate()
        {
            throw new Exception();
        }
    }
}
