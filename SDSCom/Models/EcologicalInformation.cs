using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class EcologicalInformation
    {

        private EcotoxicologicalInformation ecotoxicologicalInformationField;

        private PersistenceDegradability persistenceDegradabilityField;

        private Bioaccumulation bioaccumulationField;

        private EcologicalInformationMobility mobilityField;

        private ResultsOfPbtAndVpvbAssessment resultsOfPbtAndVpvbAssessmentField;

        private OtherAdverseEffects otherAdverseEffectsField;

        private Phrase[] conclusionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EcotoxicologicalInformation EcotoxicologicalInformation
        {
            get
            {
                return this.ecotoxicologicalInformationField;
            }
            set
            {
                this.ecotoxicologicalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PersistenceDegradability PersistenceDegradability
        {
            get
            {
                return this.persistenceDegradabilityField;
            }
            set
            {
                this.persistenceDegradabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Bioaccumulation Bioaccumulation
        {
            get
            {
                return this.bioaccumulationField;
            }
            set
            {
                this.bioaccumulationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EcologicalInformationMobility Mobility
        {
            get
            {
                return this.mobilityField;
            }
            set
            {
                this.mobilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ResultsOfPbtAndVpvbAssessment ResultsOfPbtAndVpvbAssessment
        {
            get
            {
                return this.resultsOfPbtAndVpvbAssessmentField;
            }
            set
            {
                this.resultsOfPbtAndVpvbAssessmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OtherAdverseEffects OtherAdverseEffects
        {
            get
            {
                return this.otherAdverseEffectsField;
            }
            set
            {
                this.otherAdverseEffectsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Conclusion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Conclusion
        {
            get
            {
                return this.conclusionField;
            }
            set
            {
                this.conclusionField = value;
            }
        }
    }
}
