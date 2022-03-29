using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketTrackingSystem.Models;
using TicketTrackingSystem.Models.QA;

namespace TicketTrackingSystem.Controllers
{
    public partial class QAReportController : ControllerBase
    {
        public async Task<ActionResult<BaseResponse<QAReportSearchReturn>>> QAReportSearch()
        {
            var result = _service.QAReportSearch();
            return this.StatusCode(StatusCodes.Status200OK,result);
        }
    }
}
