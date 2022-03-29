using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketTrackingSystem.Models
{
    public class BaseServiceReturn<T>
    {
        public string ErrorCode { get; set; }

        public string Desc { get; set; }

        public T Content { get; set; }
    }
}
