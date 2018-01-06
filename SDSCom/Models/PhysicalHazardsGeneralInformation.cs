using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class PhysicalHazardsGeneralInformation
    {
        private Phrase justificationForDataWaivingField;

        private Phrase assessmentField;

        private Phrase classificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase JustificationForDataWaiving
        {
            get
            {
                return this.justificationForDataWaivingField;
            }
            set
            {
                this.justificationForDataWaivingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase Assessment
        {
            get
            {
                return this.assessmentField;
            }
            set
            {
                this.assessmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase Classification
        {
            get
            {
                return this.classificationField;
            }
            set
            {
                this.classificationField = value;
            }
        }
    }
}
