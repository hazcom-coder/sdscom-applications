using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>

    public class MergePhrase
    {
        private string mergeTextField;

        private string delimiterField;

        private string phraseIdField;

        private string phraseCatalogueIdField;

        private string mergePhraseNoField;

        private string listItemNoField;

        /// <remarks/>
        public MergePhrase()
        {
            this.phraseCatalogueIdField = "0";
            this.mergePhraseNoField = "0";
            this.listItemNoField = "0";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MergeText
        {
            get
            {
                return this.mergeTextField;
            }
            set
            {
                this.mergeTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Delimiter
        {
            get
            {
                return this.delimiterField;
            }
            set
            {
                this.delimiterField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string MergePhraseNo
        {
            get
            {
                return this.mergePhraseNoField;
            }
            set
            {
                this.mergePhraseNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string ListItemNo
        {
            get
            {
                return this.listItemNoField;
            }
            set
            {
                this.listItemNoField = value;
            }
        }
    }
}
