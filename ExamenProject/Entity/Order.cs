using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenProject.Entity
{
    public class Order : BaseEntity
    {
        public Int64 LegacyNumber { get; set; }
        public Int32 DistributorId { get; set; }
        public Decimal OrderTotal { get; set; }
    }
}