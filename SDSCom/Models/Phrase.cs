using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class Phrase
    {  
        /// <remarks/>
        public Phrase()
        {
           
        }

        public string StructureCode { get; set; }

        public string English { get; set; }

        public string German { get; set; }

        public string Info { get; set; }

        public string Owner { get; set; }

        public string Region { get; set; }

        public string RevisionDate { get; set; }

        public string Source { get; set; }

        public string PhraseCode { get; set; }

        public string FullText { get; set; }       

        public string MergePhrase { get; set; }

        public string PhraseId { get; set; }   

        public string PhraseCatalogueId { get; set; }       
    }
}
