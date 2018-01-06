using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class ProtectionArticle
    {
        private Phrase[] descriptionField;

        private Phrase manufacturerField;

        private Phrase[] sourcesOfSupplyField;

        private Phrase[] referenceRelevantStandardField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Description", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase Manufacturer
        {
            get
            {
                return this.manufacturerField;
            }
            set
            {
                this.manufacturerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SourcesOfSupply", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SourcesOfSupply
        {
            get
            {
                return this.sourcesOfSupplyField;
            }
            set
            {
                this.sourcesOfSupplyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ReferenceRelevantStandard", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ReferenceRelevantStandard
        {
            get
            {
                return this.referenceRelevantStandardField;
            }
            set
            {
                this.referenceRelevantStandardField = value;
            }
        }
    }
}
