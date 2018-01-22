using System;
using System.Collections.Generic;
using System.Text;
using NpgsqlTypes;
using ServiceStack.DataAnnotations;

namespace SDSCom.Models
{
    public class FacetRestriction
    {
        public FacetRestriction()
        {
            Enumerations = new List<string>();
        }

        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        [Required]
        public int FacetId { get; set; }

        [Required]
        public bool IsList { get; set; }

        public string RegularExpressionPattern { get; set; }

        public List<String> Enumerations { get; set; }

        public string OtherInfo { get; set; }

    }

}