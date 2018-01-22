using System;
using NpgsqlTypes;
using ServiceStack.DataAnnotations;


namespace SDSCom.Models
{
    public class FacetValue
    {
        public FacetValue()
        {

        }

        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

        [Required]
        public int FacetId { get; set; }

        [Required]
        public long EntityId { get; set; }

        [Required]
        public string Data { get; set; }

        [Required]
        public DateTime StartDateStamp { get; set; }

        public DateTime StopDateStamp { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}