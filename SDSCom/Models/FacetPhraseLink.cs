using System;
using NpgsqlTypes;

namespace SDSCom.Models
{
    public class FacetPhraseLink
    {
        public FacetPhraseLink()
        {

        }

        public int Id { get; set; }

        public int EntityId { get; set; }

        public int FacetId { get; set; }

        public int PhraseId { get; set; }

        public DateTime StartDateStamp { get; set; }

        public DateTime StopDateStamp { get; set; }

        public int UserId { get; set; }
    }
}