using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class ToxicologicalInformation
    {
        private AcuteToxicity acuteToxicityField;

        private ToxicokineticInfo toxicokineticInfoField;

        private SkinCorrosionIrritation skinCorrosionIrritationField;

        private EyeDamageOrIrritation eyeDamageOrIrritationField;

        private RespiratoryOrSkinSensitisation respiratoryOrSkinSensitisationField;

        private GermCellMutagenicity germCellMutagenicityField;

        private Carcinogenicity carcinogenicityField;

        private ReproductiveToxicity reproductiveToxicityField;

        private Phrase[] overallAssessmentOnCMRPropertiesField;

        private SpecificTargetOrganSE specificTargetOrganSEField;

        private SpecificTargetOrganRE specificTargetOrganREField;

        private AspirationHazard aspirationHazardField;

        private Phototoxicity phototoxicityField;

        private Phrase[] otherAdverseToxicologicalEffectsField;

        private SymptomsOfExposure symptomsOfExposureField;

        private Phrase[] otherInformationField;

        private Phrase[] commentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AcuteToxicity AcuteToxicity
        {
            get
            {
                return this.acuteToxicityField;
            }
            set
            {
                this.acuteToxicityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ToxicokineticInfo ToxicokineticInfo
        {
            get
            {
                return this.toxicokineticInfoField;
            }
            set
            {
                this.toxicokineticInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SkinCorrosionIrritation SkinCorrosionIrritation
        {
            get
            {
                return this.skinCorrosionIrritationField;
            }
            set
            {
                this.skinCorrosionIrritationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EyeDamageOrIrritation EyeDamageOrIrritation
        {
            get
            {
                return this.eyeDamageOrIrritationField;
            }
            set
            {
                this.eyeDamageOrIrritationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RespiratoryOrSkinSensitisation RespiratoryOrSkinSensitisation
        {
            get
            {
                return this.respiratoryOrSkinSensitisationField;
            }
            set
            {
                this.respiratoryOrSkinSensitisationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GermCellMutagenicity GermCellMutagenicity
        {
            get
            {
                return this.germCellMutagenicityField;
            }
            set
            {
                this.germCellMutagenicityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Carcinogenicity Carcinogenicity
        {
            get
            {
                return this.carcinogenicityField;
            }
            set
            {
                this.carcinogenicityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ReproductiveToxicity ReproductiveToxicity
        {
            get
            {
                return this.reproductiveToxicityField;
            }
            set
            {
                this.reproductiveToxicityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OverallAssessmentOnCMRProperties", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] OverallAssessmentOnCMRProperties
        {
            get
            {
                return this.overallAssessmentOnCMRPropertiesField;
            }
            set
            {
                this.overallAssessmentOnCMRPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SpecificTargetOrganSE SpecificTargetOrganSE
        {
            get
            {
                return this.specificTargetOrganSEField;
            }
            set
            {
                this.specificTargetOrganSEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SpecificTargetOrganRE SpecificTargetOrganRE
        {
            get
            {
                return this.specificTargetOrganREField;
            }
            set
            {
                this.specificTargetOrganREField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AspirationHazard AspirationHazard
        {
            get
            {
                return this.aspirationHazardField;
            }
            set
            {
                this.aspirationHazardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phototoxicity Phototoxicity
        {
            get
            {
                return this.phototoxicityField;
            }
            set
            {
                this.phototoxicityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OtherAdverseToxicologicalEffects", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] OtherAdverseToxicologicalEffects
        {
            get
            {
                return this.otherAdverseToxicologicalEffectsField;
            }
            set
            {
                this.otherAdverseToxicologicalEffectsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SymptomsOfExposure SymptomsOfExposure
        {
            get
            {
                return this.symptomsOfExposureField;
            }
            set
            {
                this.symptomsOfExposureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OtherInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] OtherInformation
        {
            get
            {
                return this.otherInformationField;
            }
            set
            {
                this.otherInformationField = value;
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
    public class AcuteToxicity
    {

        private TestResults[] testResultsField;

        private AcuteToxicityOtherInformation acuteToxicityOtherInformationField;

        private AcuteToxicityEstimatesMixture[] acuteToxicityEstimatesMixtureField;

        private Phrase[] acuteToxicityHumanExperienceField;

        private Phrase[] assessmentAcuteToxicityClassificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("TestResults", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TestResults[] TestResults
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
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AcuteToxicityOtherInformation AcuteToxicityOtherInformation
        {
            get
            {
                return this.acuteToxicityOtherInformationField;
            }
            set
            {
                this.acuteToxicityOtherInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AcuteToxicityEstimatesMixture", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AcuteToxicityEstimatesMixture[] AcuteToxicityEstimatesMixture
        {
            get
            {
                return this.acuteToxicityEstimatesMixtureField;
            }
            set
            {
                this.acuteToxicityEstimatesMixtureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AcuteToxicityHumanExperience", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AcuteToxicityHumanExperience
        {
            get
            {
                return this.acuteToxicityHumanExperienceField;
            }
            set
            {
                this.acuteToxicityHumanExperienceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AssessmentAcuteToxicityClassification", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AssessmentAcuteToxicityClassification
        {
            get
            {
                return this.assessmentAcuteToxicityClassificationField;
            }
            set
            {
                this.assessmentAcuteToxicityClassificationField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class TestResults
    {

        private ToxicityTypeEnum toxicityTypeField;

        private DoseEnum effectTestedField;

        private ExposureRouteEnum exposureRouteField;

        private Phrase methodField;

        private UnitValue exposureTimeField;

        private UnitValue valueField;

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
        public DoseEnum EffectTested
        {
            get
            {
                return this.effectTestedField;
            }
            set
            {
                this.effectTestedField = value;
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
    public class AcuteToxicityOtherInformation
    {

        private Phrase[] otherToxicologicalDataField;

        private Phrase[] acuteToxicityDescriptionGeneralField;

        private Phrase[] inhalationField;

        private Phrase[] skinField;

        private Phrase[] eyeField;

        private Phrase[] ingestionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OtherToxicologicalData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] OtherToxicologicalData
        {
            get
            {
                return this.otherToxicologicalDataField;
            }
            set
            {
                this.otherToxicologicalDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AcuteToxicityDescriptionGeneral", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AcuteToxicityDescriptionGeneral
        {
            get
            {
                return this.acuteToxicityDescriptionGeneralField;
            }
            set
            {
                this.acuteToxicityDescriptionGeneralField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Inhalation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Inhalation
        {
            get
            {
                return this.inhalationField;
            }
            set
            {
                this.inhalationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Skin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Skin
        {
            get
            {
                return this.skinField;
            }
            set
            {
                this.skinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Eye", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Eye
        {
            get
            {
                return this.eyeField;
            }
            set
            {
                this.eyeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Ingestion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Ingestion
        {
            get
            {
                return this.ingestionField;
            }
            set
            {
                this.ingestionField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class AcuteToxicityEstimatesMixture
    {

        private DoseEnum effectDoseConcentrationField;

        private ExposureRouteEnum exposureRouteField;

        private UnitValue valueField;

        private Phrase[] commentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DoseEnum EffectDoseConcentration
        {
            get
            {
                return this.effectDoseConcentrationField;
            }
            set
            {
                this.effectDoseConcentrationField = value;
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
    public class ToxicokineticInfo
    {

        private Phrase[] distributionInBodyField;

        private Phrase[] metabolismField;

        private Phrase[] toxicokineticsField;

        private Phrase[] humanToxicologicalDataField;

        private Phrase[] toxicokineticInfoCommentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DistributionInBody", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] DistributionInBody
        {
            get
            {
                return this.distributionInBodyField;
            }
            set
            {
                this.distributionInBodyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Metabolism", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Metabolism
        {
            get
            {
                return this.metabolismField;
            }
            set
            {
                this.metabolismField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Toxicokinetics", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Toxicokinetics
        {
            get
            {
                return this.toxicokineticsField;
            }
            set
            {
                this.toxicokineticsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("HumanToxicologicalData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] HumanToxicologicalData
        {
            get
            {
                return this.humanToxicologicalDataField;
            }
            set
            {
                this.humanToxicologicalDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ToxicokineticInfoComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ToxicokineticInfoComments
        {
            get
            {
                return this.toxicokineticInfoCommentsField;
            }
            set
            {
                this.toxicokineticInfoCommentsField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class SkinCorrosionIrritation
    {

        private CorrosionIrritationData[] skinCorrosionIrritationTestResultsField;

        private ToxicologicalInformationSkinCorrosionIrritationSkinCorrosionAcidicOrAlkalineReserve skinCorrosionAcidicOrAlkalineReserveField;

        private Phrase[] skinCorrosionIrritationOtherInformationField;

        private Phrase[] irritationField;

        private Phrase[] corrosivityField;

        private Phrase[] skinCorrosionIrritationHumanExperienceField;

        private Phrase[] assessmentCorrosionIrritationClassificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SkinCorrosionIrritationTestResults", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CorrosionIrritationData[] SkinCorrosionIrritationTestResults
        {
            get
            {
                return this.skinCorrosionIrritationTestResultsField;
            }
            set
            {
                this.skinCorrosionIrritationTestResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ToxicologicalInformationSkinCorrosionIrritationSkinCorrosionAcidicOrAlkalineReserve SkinCorrosionAcidicOrAlkalineReserve
        {
            get
            {
                return this.skinCorrosionAcidicOrAlkalineReserveField;
            }
            set
            {
                this.skinCorrosionAcidicOrAlkalineReserveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SkinCorrosionIrritationOtherInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SkinCorrosionIrritationOtherInformation
        {
            get
            {
                return this.skinCorrosionIrritationOtherInformationField;
            }
            set
            {
                this.skinCorrosionIrritationOtherInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Irritation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Irritation
        {
            get
            {
                return this.irritationField;
            }
            set
            {
                this.irritationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Corrosivity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Corrosivity
        {
            get
            {
                return this.corrosivityField;
            }
            set
            {
                this.corrosivityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SkinCorrosionIrritationHumanExperience", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SkinCorrosionIrritationHumanExperience
        {
            get
            {
                return this.skinCorrosionIrritationHumanExperienceField;
            }
            set
            {
                this.skinCorrosionIrritationHumanExperienceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AssessmentCorrosionIrritationClassification", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AssessmentCorrosionIrritationClassification
        {
            get
            {
                return this.assessmentCorrosionIrritationClassificationField;
            }
            set
            {
                this.assessmentCorrosionIrritationClassificationField = value;
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ToxicologicalInformationSkinCorrosionIrritationSkinCorrosionAcidicOrAlkalineReserve
    {

        private ToxicologicalInformationSkinCorrosionIrritationSkinCorrosionAcidicOrAlkalineReserveSkinCorrosionAcidicReserve skinCorrosionAcidicReserveField;

        private ToxicologicalInformationSkinCorrosionIrritationSkinCorrosionAcidicOrAlkalineReserveSkinCorrosionAlkalineReserve skinCorrosionAlkalineReserveField;

        private Phrase[] skinCorrosionAcidicOrAlkalineReserveCommentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ToxicologicalInformationSkinCorrosionIrritationSkinCorrosionAcidicOrAlkalineReserveSkinCorrosionAcidicReserve SkinCorrosionAcidicReserve
        {
            get
            {
                return this.skinCorrosionAcidicReserveField;
            }
            set
            {
                this.skinCorrosionAcidicReserveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ToxicologicalInformationSkinCorrosionIrritationSkinCorrosionAcidicOrAlkalineReserveSkinCorrosionAlkalineReserve SkinCorrosionAlkalineReserve
        {
            get
            {
                return this.skinCorrosionAlkalineReserveField;
            }
            set
            {
                this.skinCorrosionAlkalineReserveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SkinCorrosionAcidicOrAlkalineReserveComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SkinCorrosionAcidicOrAlkalineReserveComments
        {
            get
            {
                return this.skinCorrosionAcidicOrAlkalineReserveCommentsField;
            }
            set
            {
                this.skinCorrosionAcidicOrAlkalineReserveCommentsField = value;
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ToxicologicalInformationSkinCorrosionIrritationSkinCorrosionAcidicOrAlkalineReserveSkinCorrosionAcidicReserve
    {

        private UnitValue skinCorrosionAcidicReserveValueField;

        private Phrase skinCorrosionAcidicReserveResultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue SkinCorrosionAcidicReserveValue
        {
            get
            {
                return this.skinCorrosionAcidicReserveValueField;
            }
            set
            {
                this.skinCorrosionAcidicReserveValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase SkinCorrosionAcidicReserveResult
        {
            get
            {
                return this.skinCorrosionAcidicReserveResultField;
            }
            set
            {
                this.skinCorrosionAcidicReserveResultField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ToxicologicalInformationSkinCorrosionIrritationSkinCorrosionAcidicOrAlkalineReserveSkinCorrosionAlkalineReserve
    {

        private UnitValue skinCorrosionAlkalineReserveValueField;

        private Phrase skinCorrosionAlkalineReserveResultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue SkinCorrosionAlkalineReserveValue
        {
            get
            {
                return this.skinCorrosionAlkalineReserveValueField;
            }
            set
            {
                this.skinCorrosionAlkalineReserveValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase SkinCorrosionAlkalineReserveResult
        {
            get
            {
                return this.skinCorrosionAlkalineReserveResultField;
            }
            set
            {
                this.skinCorrosionAlkalineReserveResultField = value;
            }
        }
    }

}
