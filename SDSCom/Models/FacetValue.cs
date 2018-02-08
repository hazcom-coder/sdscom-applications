using System;
using NpgsqlTypes;
using System.ComponentModel.DataAnnotations;

namespace SDSCom.Models
{
    public class FacetValue
    {
        public FacetValue()
        {

        }

        [Key]
        public int Id { get; set; }

        public int FacetId { get; set; }

        public long EntityId { get; set; }

        public string Data { get; set; }

        public DateTime StartDateStamp { get; set; }

        public DateTime StopDateStamp { get; set; }

        public int UserId { get; set; }
    }
}