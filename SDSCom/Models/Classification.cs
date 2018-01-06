using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Classification
    {
        private ClpClassification clpClassificationField;

        private ClassificationDpdDsdClassification dpdDsdClassificationField;

        private Phrase[] simpleClassificationDescriptionField;

        private Phrase[] classificationAdditionalInformationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClpClassification ClpClassification
        {
            get
            {
                return this.clpClassificationField;
            }
            set
            {
                this.clpClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClassificationDpdDsdClassification DpdDsdClassification
        {
            get
            {
                return this.dpdDsdClassificationField;
            }
            set
            {
                this.dpdDsdClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SimpleClassificationDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SimpleClassificationDescription
        {
            get
            {
                return this.simpleClassificationDescriptionField;
            }
            set
            {
                this.simpleClassificationDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ClassificationAdditionalInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ClassificationAdditionalInformation
        {
            get
            {
                return this.classificationAdditionalInformationField;
            }
            set
            {
                this.classificationAdditionalInformationField = value;
            }
        }
    }
}
