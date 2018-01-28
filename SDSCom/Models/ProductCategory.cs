using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class ProductCategory
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProductCategoryCodeEnum PcCode { get; set; }        

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase PcFulltext { get; set; }       
    }
}
