using System;
using System.Collections.Generic;
using System.Text;
using NpgsqlTypes;

namespace SDSCom.Models
{
    public class FacetRestriction
    {
        public FacetRestriction(){ }

        public int Id { get; set; }

        public string Name { get; set; }

        public int FacetId { get; set; }

        public bool IsList { get; set; }

        public string RegularExpressionPattern { get; set; }

        public String Enumerations { get; set; }

        public string OtherInfo { get; set; }
    }

}