using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class SafetyPhrase
    {
        private SafetyPhraseEnum phraseCodeField;

        private bool phraseCodeFieldSpecified;

        private string fullTextField;

        private MergePhrase[] mergePhraseField;

        private string phraseIdField;

        private string phraseCatalogueIdField;

        /// <remarks/>
        public SafetyPhrase()
        {
            this.phraseCatalogueIdField = "0";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SafetyPhraseEnum PhraseCode
        {
            get
            {
                return this.phraseCodeField;
            }
            set
            {
                this.phraseCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PhraseCodeSpecified
        {
            get
            {
                return this.phraseCodeFieldSpecified;
            }
            set
            {
                this.phraseCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FullText
        {
            get
            {
                return this.fullTextField;
            }
            set
            {
                this.fullTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("MergePhrase", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MergePhrase[] MergePhrase
        {
            get
            {
                return this.mergePhraseField;
            }
            set
            {
                this.mergePhraseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PhraseId
        {
            get
            {
                return this.phraseIdField;
            }
            set
            {
                this.phraseIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string PhraseCatalogueId
        {
            get
            {
                return this.phraseCatalogueIdField;
            }
            set
            {
                this.phraseCatalogueIdField = value;
            }
        }
    }

}
