using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class Language
    {

        private LanguageCodeEnum freetextLanguageCodeField;

        private Phrase freetextLanguageNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LanguageCodeEnum FreetextLanguageCode
        {
            get
            {
                return this.freetextLanguageCodeField;
            }
            set
            {
                this.freetextLanguageCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase FreetextLanguageName
        {
            get
            {
                return this.freetextLanguageNameField;
            }
            set
            {
                this.freetextLanguageNameField = value;
            }
        }
    }
}
