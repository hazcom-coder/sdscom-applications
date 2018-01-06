using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ReproductiveToxicity
    {
        private CMRData[] reproductiveToxicityTestResultsField;

        private Phrase[] reproductiveToxicityOtherInfoField;

        private Phrase[] reproductiveToxicityHumanExperienceField;

        private Phrase[] assessmentReproductiveToxicityClassificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ReproductiveToxicityTestResults", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CMRData[] ReproductiveToxicityTestResults
        {
            get
            {
                return this.reproductiveToxicityTestResultsField;
            }
            set
            {
                this.reproductiveToxicityTestResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ReproductiveToxicityOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ReproductiveToxicityOtherInfo
        {
            get
            {
                return this.reproductiveToxicityOtherInfoField;
            }
            set
            {
                this.reproductiveToxicityOtherInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ReproductiveToxicityHumanExperience", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ReproductiveToxicityHumanExperience
        {
            get
            {
                return this.reproductiveToxicityHumanExperienceField;
            }
            set
            {
                this.reproductiveToxicityHumanExperienceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AssessmentReproductiveToxicityClassification", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AssessmentReproductiveToxicityClassification
        {
            get
            {
                return this.assessmentReproductiveToxicityClassificationField;
            }
            set
            {
                this.assessmentReproductiveToxicityClassificationField = value;
            }
        }
    }
}
