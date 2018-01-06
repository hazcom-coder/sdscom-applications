using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class SpecialSupplementalLabelInfo
    {
        private SpecialSupplementalLabelInfoEnum phraseCodeField;

        private bool phraseCodeFieldSpecified;

        private string fullTextField;

        private MergePhrase[] mergePhraseField;

        private string phraseIdField;

        private string phraseCatalogueIdField;

        /// <remarks/>
        public SpecialSupplementalLabelInfo()
        {
            this.phraseCatalogueIdField = "0";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SpecialSupplementalLabelInfoEnum PhraseCode
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

    /// <remarks/>
    public class SupplementalHazardInformation
    {

        private SupplementalHazardInformationEnum phraseCodeField;

        private bool phraseCodeFieldSpecified;

        private string fullTextField;

        private MergePhrase[] mergePhraseField;

        private string phraseIdField;

        private string phraseCatalogueIdField;

        /// <remarks/>
        public SupplementalHazardInformation()
        {
            this.phraseCatalogueIdField = "0";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SupplementalHazardInformationEnum PhraseCode
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

    /// <remarks/>
    public class PrecautionaryStatement
    {

        private string phraseCodeField;

        private string fullTextField;

        private MergePhrase[] mergePhraseField;

        private string phraseIdField;

        private string phraseCatalogueIdField;

        /// <remarks/>
        public PrecautionaryStatement()
        {
            this.phraseCatalogueIdField = "0";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PhraseCode
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

    /// <remarks/>
    public class SignalWord
    {

        private SignalWordEnum phraseCodeField;

        private string fullTextField;

        private MergePhrase[] mergePhraseField;

        private string phraseIdField;

        private string phraseCatalogueIdField;

        /// <remarks/>
        public SignalWord()
        {
            this.phraseCatalogueIdField = "0";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SignalWordEnum PhraseCode
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

    /// <remarks/>
    public class HazardPictogram
    {

        private PictogramCodeEnum phraseCodeField;

        private string fullTextField;

        private MergePhrase[] mergePhraseField;

        private string phraseIdField;

        private string phraseCatalogueIdField;

        /// <remarks/>
        public HazardPictogram()
        {
            this.phraseCatalogueIdField = "0";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PictogramCodeEnum PhraseCode
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

    /// <remarks/>
    public class ProductGtin
    {
        private string noField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string No
        {
            get
            {
                return this.noField;
            }
            set
            {
                this.noField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

}
