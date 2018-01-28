using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ArticleCategory
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ArticleCategoryCodeEnum AcCode { get; set; }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase AcFulltext { get; set; }       
    }
}
