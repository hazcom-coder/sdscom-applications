using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    public class Document
    {
        public Document()
        {

        }

        public long Id { get; set; }

        public long EntityID { get; set; }

        public DateTime DateCreated { get; set; }

        public int UserCreated { get; set; }

        public string Content { get; set; }
    }
}
