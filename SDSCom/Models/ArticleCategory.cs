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
        private ArticleCategoryCodeEnum acCodeField;

        private Phrase acFulltextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ArticleCategoryCodeEnum AcCode
        {
            get
            {
                return this.acCodeField;
            }
            set
            {
                this.acCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase AcFulltext
        {
            get
            {
                return this.acFulltextField;
            }
            set
            {
                this.acFulltextField = value;
            }
        }
    }
}
