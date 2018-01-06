using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class ProcessCategory
    {
        private ProcessCategoryCodeEnum procCodeField;

        private Phrase procFulltextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProcessCategoryCodeEnum ProcCode
        {
            get
            {
                return this.procCodeField;
            }
            set
            {
                this.procCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ProcFulltext
        {
            get
            {
                return this.procFulltextField;
            }
            set
            {
                this.procFulltextField = value;
            }
        }
    }

}
