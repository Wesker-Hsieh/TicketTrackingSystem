using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketTrackingSystem.Repository;

namespace TicketTrackingSystem
{
    public class AutofacConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ReportRepository>().As<IReportRepository>();
        }
    }
}
