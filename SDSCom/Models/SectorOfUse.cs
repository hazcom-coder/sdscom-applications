using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class SectorOfUse
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SectorOfUseCodeEnum SuCode { get; set; }       

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase SuFulltext { get; set; }      
    }
}
