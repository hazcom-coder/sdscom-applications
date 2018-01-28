using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class ProcessCategory
    {     
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProcessCategoryCodeEnum ProcCode { get; set; }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ProcFulltext { get; set; }       
    }
}
