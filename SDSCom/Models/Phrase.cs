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

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PhraseCode { get; set; }
       
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FullText { get; set; }
       
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("MergePhrase", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MergePhrase { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PhraseId { get; set; }       

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string PhraseCatalogueId { get; set; }
       
    }
}
