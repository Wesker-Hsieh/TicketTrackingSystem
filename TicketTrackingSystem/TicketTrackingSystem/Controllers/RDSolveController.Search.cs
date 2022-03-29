using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketTrackingSystem.Models;
using TicketTrackingSystem.Models.RD;
using TicketTrackingSystem.Service.RD;

namespace TicketTrackingSystem.Controllers
{
    public partial class RDSolveController : ControllerBase
    {
        public async Task<ActionResult<BaseResponse<ReportSearchReturn>>> ReportSearch(string id)
        {
            var result = _service.ReportSearch(id);
            return this.StatusCode(StatusCodes.Status200OK, result);
        }
    }
}
