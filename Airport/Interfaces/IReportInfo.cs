using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Interfaces
{
    internal interface IReportInfo
    {
        int TotalPassangers { get; }

        int TotalArrivingFlights { get; }

        int TotalCrew { get; }

        decimal TotalRevenue { get; }
    }
}
