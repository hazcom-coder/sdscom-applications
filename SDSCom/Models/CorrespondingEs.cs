using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CorrespondingEs
    {

        private string exposureScenarioNameField;

        private string legalDocumentFileNameField;

        private System.DateTime legalDocumentPrintDateField;

        private bool legalDocumentPrintDateFieldSpecified;

        private string legalDocumentSignatureField;

        private string xmlFileNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ExposureScenarioName
        {
            get
            {
                return this.exposureScenarioNameField;
            }
            set
            {
                this.exposureScenarioNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LegalDocumentFileName
        {
            get
            {
                return this.legalDocumentFileNameField;
            }
            set
            {
                this.legalDocumentFileNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime LegalDocumentPrintDate
        {
            get
            {
                return this.legalDocumentPrintDateField;
            }
            set
            {
                this.legalDocumentPrintDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LegalDocumentPrintDateSpecified
        {
            get
            {
                return this.legalDocumentPrintDateFieldSpecified;
            }
            set
            {
                this.legalDocumentPrintDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LegalDocumentSignature
        {
            get
            {
                return this.legalDocumentSignatureField;
            }
            set
            {
                this.legalDocumentSignatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string XmlFileName
        {
            get
            {
                return this.xmlFileNameField;
            }
            set
            {
                this.xmlFileNameField = value;
            }
        }
    }
}
