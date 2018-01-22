using System;
using NpgsqlTypes;
using ServiceStack.DataAnnotations;

namespace SDSCom.Models
{
    public class FacetPhraseLink
    {
        public FacetPhraseLink()
        {

        }

        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

        [Required]
        public int EntityId { get; set; }

        [Required]
        public int FacetId { get; set; }

        [Required]
        public int PhraseId { get; set; }

        [Required]
        public DateTime StartDateStamp { get; set; }

        public DateTime StopDateStamp { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}