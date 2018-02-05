using System;
using NpgsqlTypes;

namespace SDSCom.Models
{
    public class FacetValue
    {
        public FacetValue()
        {

        }

        public int Id { get; set; }

        public int FacetId { get; set; }

        public long EntityId { get; set; }

        public string Data { get; set; }

        public DateTime StartDateStamp { get; set; }

        public DateTime StopDateStamp { get; set; }

        public int UserId { get; set; }
    }
}