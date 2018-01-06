using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class EyeDamageOrIrritation
    {
        private CorrosionIrritationData[] eyeDamageOrIrritationTestResultsField;

        private Phrase[] eyeDamageOrIrritationOtherInfoField;

        private Phrase[] eyeIrritationField;

        private Phrase[] eyeCorrosivityField;

        private Phrase[] eyeDamageOrIrritationHumanExperienceField;

        private Phrase[] assessmentEyeDamageOrIrritationClassificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EyeDamageOrIrritationTestResults", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CorrosionIrritationData[] EyeDamageOrIrritationTestResults
        {
            get
            {
                return this.eyeDamageOrIrritationTestResultsField;
            }
            set
            {
                this.eyeDamageOrIrritationTestResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EyeDamageOrIrritationOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] EyeDamageOrIrritationOtherInfo
        {
            get
            {
                return this.eyeDamageOrIrritationOtherInfoField;
            }
            set
            {
                this.eyeDamageOrIrritationOtherInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EyeIrritation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] EyeIrritation
        {
            get
            {
                return this.eyeIrritationField;
            }
            set
            {
                this.eyeIrritationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EyeCorrosivity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] EyeCorrosivity
        {
            get
            {
                return this.eyeCorrosivityField;
            }
            set
            {
                this.eyeCorrosivityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EyeDamageOrIrritationHumanExperience", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] EyeDamageOrIrritationHumanExperience
        {
            get
            {
                return this.eyeDamageOrIrritationHumanExperienceField;
            }
            set
            {
                this.eyeDamageOrIrritationHumanExperienceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AssessmentEyeDamageOrIrritationClassification", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AssessmentEyeDamageOrIrritationClassification
        {
            get
            {
                return this.assessmentEyeDamageOrIrritationClassificationField;
            }
            set
            {
                this.assessmentEyeDamageOrIrritationClassificationField = value;
            }
        }
    }
}
