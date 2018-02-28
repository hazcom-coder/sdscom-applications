using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    public class Document
    {
        public Document()
        {

        }

        [Key]
        public long Id { get; set; }

        public string EntityID { get; set; }

        public string EntityName { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CreatedUser { get; set; }

        public string Language { get; set; }

        public string Content { get; set; }

        public string Source { get; set; }

        public int Status { get; set; }

        public bool Active { get; set; }

    }
}
