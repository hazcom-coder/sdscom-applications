using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class GermCellMutagenicity
    {

        private GermCellMutagenicityTestResults[] testResultsField;

        private Phrase[] germCellMutagenicityOtherInfoField;

        private Phrase[] germCellMutagenicityHumanExperienceField;

        private Phrase[] assessmentGermCellMutagenicityClassificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("TestResults", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GermCellMutagenicityTestResults[] TestResults
        {
            get
            {
                return this.testResultsField;
            }
            set
            {
                this.testResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("GermCellMutagenicityOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] GermCellMutagenicityOtherInfo
        {
            get
            {
                return this.germCellMutagenicityOtherInfoField;
            }
            set
            {
                this.germCellMutagenicityOtherInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("GermCellMutagenicityHumanExperience", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] GermCellMutagenicityHumanExperience
        {
            get
            {
                return this.germCellMutagenicityHumanExperienceField;
            }
            set
            {
                this.germCellMutagenicityHumanExperienceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AssessmentGermCellMutagenicityClassification", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AssessmentGermCellMutagenicityClassification
        {
            get
            {
                return this.assessmentGermCellMutagenicityClassificationField;
            }
            set
            {
                this.assessmentGermCellMutagenicityClassificationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class GermCellMutagenicityTestResults
    {

        private ToxicityTypeEnum toxicityTypeField;

        private Phrase methodField;

        private UnitValue effectValueField;

        private UnitValue testDurationField;

        private ExposureRouteEnum exposureRouteField;

        private bool exposureRouteFieldSpecified;

        private UnitValue doseField;

        private UnitValue exposureTimeField;

        private Species speciesField;

        private Phrase geneticEndpointField;

        private UnitValue resultField;

        private Phrase[] resultEvaluationField;

        private Phrase testReferenceField;

        private Phrase[] commentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ToxicityTypeEnum ToxicityType
        {
            get
            {
                return this.toxicityTypeField;
            }
            set
            {
                this.toxicityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase Method
        {
            get
            {
                return this.methodField;
            }
            set
            {
                this.methodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue EffectValue
        {
            get
            {
                return this.effectValueField;
            }
            set
            {
                this.effectValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue TestDuration
        {
            get
            {
                return this.testDurationField;
            }
            set
            {
                this.testDurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureRouteEnum ExposureRoute
        {
            get
            {
                return this.exposureRouteField;
            }
            set
            {
                this.exposureRouteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExposureRouteSpecified
        {
            get
            {
                return this.exposureRouteFieldSpecified;
            }
            set
            {
                this.exposureRouteFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue Dose
        {
            get
            {
                return this.doseField;
            }
            set
            {
                this.doseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue ExposureTime
        {
            get
            {
                return this.exposureTimeField;
            }
            set
            {
                this.exposureTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Species Species
        {
            get
            {
                return this.speciesField;
            }
            set
            {
                this.speciesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase GeneticEndpoint
        {
            get
            {
                return this.geneticEndpointField;
            }
            set
            {
                this.geneticEndpointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue Result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ResultEvaluation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ResultEvaluation
        {
            get
            {
                return this.resultEvaluationField;
            }
            set
            {
                this.resultEvaluationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase TestReference
        {
            get
            {
                return this.testReferenceField;
            }
            set
            {
                this.testReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Comments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }
    }
}
