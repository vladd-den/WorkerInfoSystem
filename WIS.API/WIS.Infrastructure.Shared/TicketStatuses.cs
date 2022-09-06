using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIS.Data.DataAccess.Models.Entities
{
    public enum TicketStatuses
    {
        Open = 1,
        InQueue = 2,
        InProgress = 3,
        PendingQA = 4,
        Tested = 5,
        PendingUAT = 6,
        UATApproved = 7,
        PendingMerge = 8,
        OnStaging = 9,
        Live = 10,
        Closed = 11
    }
}
