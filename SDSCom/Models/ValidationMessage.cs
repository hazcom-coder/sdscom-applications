using System;
using NpgsqlTypes;

namespace SDSCom.Models
{
    public class ValidationMessage
    {
        public ValidationMessage()
        {
        }

        public int Id { get; set; }

        public int FacetId { get; set; }

        public string Data { get; set; }
    }
}