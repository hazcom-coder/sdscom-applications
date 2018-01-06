using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <summary>
    /// 
    /// </summary>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class Carcinogenicity
    {
        private CMRData[] carcinogenicityTestResultsField;

        private Phrase[] carcinogenicityOtherInfoField;

        private Phrase[] carcinogenicityHumanExperienceField;

        private Phrase[] assessmentCarcinogenicityClassificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("CarcinogenicityTestResults", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CMRData[] CarcinogenicityTestResults
        {
            get
            {
                return this.carcinogenicityTestResultsField;
            }
            set
            {
                this.carcinogenicityTestResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("CarcinogenicityOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] CarcinogenicityOtherInfo
        {
            get
            {
                return this.carcinogenicityOtherInfoField;
            }
            set
            {
                this.carcinogenicityOtherInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("CarcinogenicityHumanExperience", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] CarcinogenicityHumanExperience
        {
            get
            {
                return this.carcinogenicityHumanExperienceField;
            }
            set
            {
                this.carcinogenicityHumanExperienceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AssessmentCarcinogenicityClassification", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AssessmentCarcinogenicityClassification
        {
            get
            {
                return this.assessmentCarcinogenicityClassificationField;
            }
            set
            {
                this.assessmentCarcinogenicityClassificationField = value;
            }
        }
    }
}
