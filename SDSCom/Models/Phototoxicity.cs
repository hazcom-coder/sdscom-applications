using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class Phototoxicity
    {
        private PhototoxicityTestResults[] phototoxicityTestResultsField;

        private Phrase[] phototoxicityOtherInfoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PhototoxicityTestResults", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhototoxicityTestResults[] PhototoxicityTestResults
        {
            get
            {
                return this.phototoxicityTestResultsField;
            }
            set
            {
                this.phototoxicityTestResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PhototoxicityOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] PhototoxicityOtherInfo
        {
            get
            {
                return this.phototoxicityOtherInfoField;
            }
            set
            {
                this.phototoxicityOtherInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhototoxicityTestResults
    {
        private ToxicityTypeEnum toxicityTypeField;

        private Phrase testMethodField;

        private UnitValue doseField;

        private ExposureRouteEnum exposureRouteField;

        private UnitValue testDurationField;

        private PhototoxicityTestResultsResults resultsField;

        private Species speciesField;

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
        public Phrase TestMethod
        {
            get
            {
                return this.testMethodField;
            }
            set
            {
                this.testMethodField = value;
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
        public PhototoxicityTestResultsResults Results
        {
            get
            {
                return this.resultsField;
            }
            set
            {
                this.resultsField = value;
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

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhototoxicityTestResultsResults    {

        private UnitValue valueField;

        private UnitValue photoIrritationFactorField;

        private UnitValue meanPhotoEffectField;

        private Phrase[] evaluationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue PhotoIrritationFactor
        {
            get
            {
                return this.photoIrritationFactorField;
            }
            set
            {
                this.photoIrritationFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue MeanPhotoEffect
        {
            get
            {
                return this.meanPhotoEffectField;
            }
            set
            {
                this.meanPhotoEffectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Evaluation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Evaluation
        {
            get
            {
                return this.evaluationField;
            }
            set
            {
                this.evaluationField = value;
            }
        }
    }
}
