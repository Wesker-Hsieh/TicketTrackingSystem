using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketTrackingSystem.Models
{
    public class BaseResponse<T>
    {
        public T Result { get; set; }
    }
}
