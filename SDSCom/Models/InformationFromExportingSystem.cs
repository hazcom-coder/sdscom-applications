using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class InformationFromExportingSystem
    {

        private XmlStandardVersionEnum xmlStandardVersionNoField;

        private PhraseCatalogue[] phraseCatalogueField;

        private Language languageField;

        private List<RegulationsRelatedToCountryOrRegion> regulationsRelatedToCountryOrRegion;

        private string systemUsedInPreparationField;

        private System.DateTime dateGeneratedExportField;

        private bool dateGeneratedExportFieldSpecified;

        private LegalDocument legalDocumentField;

        private List<Extension> specialExtensions;

        private List<RelatedDocuments> relatedDocuments;

        private XMLStandardSubsetEnum xMLStandardSubsetField;

        private bool xMLStandardSubsetFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public XmlStandardVersionEnum XmlStandardVersionNo
        {
            get
            {
                return this.xmlStandardVersionNoField;
            }
            set
            {
                this.xmlStandardVersionNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PhraseCatalogue", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhraseCatalogue[] PhraseCatalogue
        {
            get
            {
                return this.phraseCatalogueField;
            }
            set
            {
                this.phraseCatalogueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Language Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RegulationsRelatedToCountryOrRegion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<RegulationsRelatedToCountryOrRegion> RegulationsRelatedToCountryOrRegion
        {
            get
            {
                return this.regulationsRelatedToCountryOrRegion;
            }
            set
            {
                this.regulationsRelatedToCountryOrRegion = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SystemUsedInPreparation
        {
            get
            {
                return this.systemUsedInPreparationField;
            }
            set
            {
                this.systemUsedInPreparationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime DateGeneratedExport
        {
            get
            {
                return this.dateGeneratedExportField;
            }
            set
            {
                this.dateGeneratedExportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateGeneratedExportSpecified
        {
            get
            {
                return this.dateGeneratedExportFieldSpecified;
            }
            set
            {
                this.dateGeneratedExportFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LegalDocument LegalDocument
        {
            get
            {
                return this.legalDocumentField;
            }
            set
            {
                this.legalDocumentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Extension", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<Extension> SpecialExtensions
        {
            get
            {
                return this.specialExtensions;
            }
            set
            {
                this.specialExtensions = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RelatedDocuments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<RelatedDocuments> RelatedDocuments
        {
            get
            {
                return this.relatedDocuments;
            }
            set
            {
                this.relatedDocuments = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public XMLStandardSubsetEnum XMLStandardSubset
        {
            get
            {
                return this.xMLStandardSubsetField;
            }
            set
            {
                this.xMLStandardSubsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XMLStandardSubsetSpecified
        {
            get
            {
                return this.xMLStandardSubsetFieldSpecified;
            }
            set
            {
                this.xMLStandardSubsetFieldSpecified = value;
            }
        }
    }


}
