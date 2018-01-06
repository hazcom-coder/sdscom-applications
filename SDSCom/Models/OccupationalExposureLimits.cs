using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class OccupationalExposureLimit
    {

        private ExposureLimitValueTypeEnum limitValueTypeWithCountryOrOrganisationField;

        private bool limitValueTypeWithCountryOrOrganisationFieldSpecified;

        private UnitValue[] limit8HField;

        private STEL[] limitShortTermField;

        private OccupationalExposureLimitPeakLimitation[] peakLimitationField;

        private Phrase recommendedMonitoringProcedureField;

        private OccupationalExposureLimitExposureLimitLetter[] exposureLimitLetterField;

        private Phrase referenceField;

        private Phrase[] commentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureLimitValueTypeEnum LimitValueTypeWithCountryOrOrganisation
        {
            get
            {
                return this.limitValueTypeWithCountryOrOrganisationField;
            }
            set
            {
                this.limitValueTypeWithCountryOrOrganisationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LimitValueTypeWithCountryOrOrganisationSpecified
        {
            get
            {
                return this.limitValueTypeWithCountryOrOrganisationFieldSpecified;
            }
            set
            {
                this.limitValueTypeWithCountryOrOrganisationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Limit8H", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue[] Limit8H
        {
            get
            {
                return this.limit8HField;
            }
            set
            {
                this.limit8HField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("LimitShortTerm", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public STEL[] LimitShortTerm
        {
            get
            {
                return this.limitShortTermField;
            }
            set
            {
                this.limitShortTermField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PeakLimitation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OccupationalExposureLimitPeakLimitation[] PeakLimitation
        {
            get
            {
                return this.peakLimitationField;
            }
            set
            {
                this.peakLimitationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase RecommendedMonitoringProcedure
        {
            get
            {
                return this.recommendedMonitoringProcedureField;
            }
            set
            {
                this.recommendedMonitoringProcedureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ExposureLimitLetter", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OccupationalExposureLimitExposureLimitLetter[] ExposureLimitLetter
        {
            get
            {
                return this.exposureLimitLetterField;
            }
            set
            {
                this.exposureLimitLetterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
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
    public class OccupationalExposureLimitPeakLimitation
    {

        private UnitValue valueField;

        private Value peakLimitationOverflowFactorField;

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
        public Value PeakLimitationOverflowFactor
        {
            get
            {
                return this.peakLimitationOverflowFactorField;
            }
            set
            {
                this.peakLimitationOverflowFactorField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class OccupationalExposureLimitExposureLimitLetter
    {

        private Phrase letterCodeField;

        private Phrase letterDescriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase LetterCode
        {
            get
            {
                return this.letterCodeField;
            }
            set
            {
                this.letterCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase LetterDescription
        {
            get
            {
                return this.letterDescriptionField;
            }
            set
            {
                this.letterDescriptionField = value;
            }
        }
    }

    /// <remarks/>
    public class ExposureControlPersonalProtection
    {

        private Phrase[] preventiveIndustrialMedicalExaminationRequiredField;

        private ExposureControlPersonalProtectionControlParameters controlParametersField;

        private ExposureControlPersonalProtectionSummaryRMMeasures summaryRMMeasuresField;

        private ExposureControlPersonalProtectionExposureControlAppropriateMeasures exposureControlAppropriateMeasuresField;

        private ExposureControlPersonalProtectionPersonalProtectionEquipment personalProtectionEquipmentField;

        private ExposureControlPersonalProtectionEnvironmentalExposureControls environmentalExposureControlsField;

        private ExposureControlPersonalProtectionConsumerExposureControl consumerExposureControlField;

        private Phrase[] exposureControlsPersonalProtectionAdditionalInfoField;

        private Phrase[] exposureControlCommentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PreventiveIndustrialMedicalExaminationRequired", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] PreventiveIndustrialMedicalExaminationRequired
        {
            get
            {
                return this.preventiveIndustrialMedicalExaminationRequiredField;
            }
            set
            {
                this.preventiveIndustrialMedicalExaminationRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureControlPersonalProtectionControlParameters ControlParameters
        {
            get
            {
                return this.controlParametersField;
            }
            set
            {
                this.controlParametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureControlPersonalProtectionSummaryRMMeasures SummaryRMMeasures
        {
            get
            {
                return this.summaryRMMeasuresField;
            }
            set
            {
                this.summaryRMMeasuresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureControlPersonalProtectionExposureControlAppropriateMeasures ExposureControlAppropriateMeasures
        {
            get
            {
                return this.exposureControlAppropriateMeasuresField;
            }
            set
            {
                this.exposureControlAppropriateMeasuresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureControlPersonalProtectionPersonalProtectionEquipment PersonalProtectionEquipment
        {
            get
            {
                return this.personalProtectionEquipmentField;
            }
            set
            {
                this.personalProtectionEquipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureControlPersonalProtectionEnvironmentalExposureControls EnvironmentalExposureControls
        {
            get
            {
                return this.environmentalExposureControlsField;
            }
            set
            {
                this.environmentalExposureControlsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureControlPersonalProtectionConsumerExposureControl ConsumerExposureControl
        {
            get
            {
                return this.consumerExposureControlField;
            }
            set
            {
                this.consumerExposureControlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ExposureControlsPersonalProtectionAdditionalInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ExposureControlsPersonalProtectionAdditionalInfo
        {
            get
            {
                return this.exposureControlsPersonalProtectionAdditionalInfoField;
            }
            set
            {
                this.exposureControlsPersonalProtectionAdditionalInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ExposureControlComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ExposureControlComments
        {
            get
            {
                return this.exposureControlCommentsField;
            }
            set
            {
                this.exposureControlCommentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ExposureControlPersonalProtectionControlParameters
    {

        private ExposureControlPersonalProtectionControlParametersExposureGuidelines exposureGuidelinesField;

        private ExposureControlPersonalProtectionControlParametersBiologicalLimitValues biologicalLimitValuesField;

        private DNEL[] derivedNoEffectLevelField;

        private DMEL[] derivedMinimalEffectLevelField;

        private PNEC[] predictedNoEffectConcentrationField;

        private Phrase[] controlParametersCommentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureControlPersonalProtectionControlParametersExposureGuidelines ExposureGuidelines
        {
            get
            {
                return this.exposureGuidelinesField;
            }
            set
            {
                this.exposureGuidelinesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureControlPersonalProtectionControlParametersBiologicalLimitValues BiologicalLimitValues
        {
            get
            {
                return this.biologicalLimitValuesField;
            }
            set
            {
                this.biologicalLimitValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DerivedNoEffectLevel", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DNEL[] DerivedNoEffectLevel
        {
            get
            {
                return this.derivedNoEffectLevelField;
            }
            set
            {
                this.derivedNoEffectLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DerivedMinimalEffectLevel", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DMEL[] DerivedMinimalEffectLevel
        {
            get
            {
                return this.derivedMinimalEffectLevelField;
            }
            set
            {
                this.derivedMinimalEffectLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PredictedNoEffectConcentration", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PNEC[] PredictedNoEffectConcentration
        {
            get
            {
                return this.predictedNoEffectConcentrationField;
            }
            set
            {
                this.predictedNoEffectConcentrationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ControlParametersComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ControlParametersComments
        {
            get
            {
                return this.controlParametersCommentsField;
            }
            set
            {
                this.controlParametersCommentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ExposureControlPersonalProtectionControlParametersExposureGuidelines
    {

        private OccupationalExposureLimit[] occupationalExposureLimitField;

        private OccupationalExposureLimit[] intendedUseOccupationalExposureLimitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OccupationalExposureLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OccupationalExposureLimit[] OccupationalExposureLimit
        {
            get
            {
                return this.occupationalExposureLimitField;
            }
            set
            {
                this.occupationalExposureLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("IntendedUseOccupationalExposureLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OccupationalExposureLimit[] IntendedUseOccupationalExposureLimit
        {
            get
            {
                return this.intendedUseOccupationalExposureLimitField;
            }
            set
            {
                this.intendedUseOccupationalExposureLimitField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ExposureControlPersonalProtectionControlParametersBiologicalLimitValues
    {

        private BiologicalLimitValue[] biologicalLimitValueField;

        private BiologicalLimitValue[] intendedUseBiologicalLimitValueField;

        private Phrase[] biologicalLimitValuesOtherInformationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("BiologicalLimitValue", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BiologicalLimitValue[] BiologicalLimitValue
        {
            get
            {
                return this.biologicalLimitValueField;
            }
            set
            {
                this.biologicalLimitValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("IntendedUseBiologicalLimitValue", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BiologicalLimitValue[] IntendedUseBiologicalLimitValue
        {
            get
            {
                return this.intendedUseBiologicalLimitValueField;
            }
            set
            {
                this.intendedUseBiologicalLimitValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("BiologicalLimitValuesOtherInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] BiologicalLimitValuesOtherInformation
        {
            get
            {
                return this.biologicalLimitValuesOtherInformationField;
            }
            set
            {
                this.biologicalLimitValuesOtherInformationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ExposureControlPersonalProtectionSummaryRMMeasures
    {

        private Phrase[] summaryRMMeasuresManField;

        private Phrase[] summaryRMMeasuresEnvironmField;

        private ExposureControlPersonalProtectionSummaryRMMeasuresRMMControlBandingApproach[] rMMControlBandingApproachField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SummaryRMMeasuresMan", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SummaryRMMeasuresMan
        {
            get
            {
                return this.summaryRMMeasuresManField;
            }
            set
            {
                this.summaryRMMeasuresManField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SummaryRMMeasuresEnvironm", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SummaryRMMeasuresEnvironm
        {
            get
            {
                return this.summaryRMMeasuresEnvironmField;
            }
            set
            {
                this.summaryRMMeasuresEnvironmField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RMMControlBandingApproach", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureControlPersonalProtectionSummaryRMMeasuresRMMControlBandingApproach[] RMMControlBandingApproach
        {
            get
            {
                return this.rMMControlBandingApproachField;
            }
            set
            {
                this.rMMControlBandingApproachField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ExposureControlPersonalProtectionSummaryRMMeasuresRMMControlBandingApproach
    {

        private Phrase taskField;

        private Phrase hazardBandField;

        private Phrase scaleOfUseField;

        private Phrase abilityToBecomeAirborneField;

        private Phrase controlApproachField;

        private Phrase[] commentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase Task
        {
            get
            {
                return this.taskField;
            }
            set
            {
                this.taskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase HazardBand
        {
            get
            {
                return this.hazardBandField;
            }
            set
            {
                this.hazardBandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ScaleOfUse
        {
            get
            {
                return this.scaleOfUseField;
            }
            set
            {
                this.scaleOfUseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase AbilityToBecomeAirborne
        {
            get
            {
                return this.abilityToBecomeAirborneField;
            }
            set
            {
                this.abilityToBecomeAirborneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ControlApproach
        {
            get
            {
                return this.controlApproachField;
            }
            set
            {
                this.controlApproachField = value;
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
    public class ExposureControlPersonalProtectionExposureControlAppropriateMeasures
    {

        private Phrase[] appropriateEngineeringControlsField;

        private Phrase[] productRelatedMeasuresField;

        private Phrase[] instructionalMeasuresField;

        private Phrase[] organisationalMeasuresField;

        private Phrase[] technicalMeasuresField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AppropriateEngineeringControls", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AppropriateEngineeringControls
        {
            get
            {
                return this.appropriateEngineeringControlsField;
            }
            set
            {
                this.appropriateEngineeringControlsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProductRelatedMeasures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ProductRelatedMeasures
        {
            get
            {
                return this.productRelatedMeasuresField;
            }
            set
            {
                this.productRelatedMeasuresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("InstructionalMeasures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] InstructionalMeasures
        {
            get
            {
                return this.instructionalMeasuresField;
            }
            set
            {
                this.instructionalMeasuresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OrganisationalMeasures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] OrganisationalMeasures
        {
            get
            {
                return this.organisationalMeasuresField;
            }
            set
            {
                this.organisationalMeasuresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("TechnicalMeasures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] TechnicalMeasures
        {
            get
            {
                return this.technicalMeasuresField;
            }
            set
            {
                this.technicalMeasuresField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ExposureControlPersonalProtectionPersonalProtectionEquipment
    {

        private ExposureControlPersonalProtectionPersonalProtectionEquipmentRespiratoryProtection respiratoryProtectionField;

        private ExposureControlPersonalProtectionPersonalProtectionEquipmentEyeProtection eyeProtectionField;

        private ExposureControlPersonalProtectionPersonalProtectionEquipmentHandProtection handProtectionField;

        private ExposureControlPersonalProtectionPersonalProtectionEquipmentSkinProtection skinProtectionField;

        private Phrase[] thermalHazardsProtectionField;

        private Phrase[] personalProtectionEquipmentCommentsField;

        private Phrase[] specificHygieneMeasuresField;

        private SafetySign[] safetySignsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureControlPersonalProtectionPersonalProtectionEquipmentRespiratoryProtection RespiratoryProtection
        {
            get
            {
                return this.respiratoryProtectionField;
            }
            set
            {
                this.respiratoryProtectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureControlPersonalProtectionPersonalProtectionEquipmentEyeProtection EyeProtection
        {
            get
            {
                return this.eyeProtectionField;
            }
            set
            {
                this.eyeProtectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureControlPersonalProtectionPersonalProtectionEquipmentHandProtection HandProtection
        {
            get
            {
                return this.handProtectionField;
            }
            set
            {
                this.handProtectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureControlPersonalProtectionPersonalProtectionEquipmentSkinProtection SkinProtection
        {
            get
            {
                return this.skinProtectionField;
            }
            set
            {
                this.skinProtectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ThermalHazardsProtection", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ThermalHazardsProtection
        {
            get
            {
                return this.thermalHazardsProtectionField;
            }
            set
            {
                this.thermalHazardsProtectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PersonalProtectionEquipmentComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] PersonalProtectionEquipmentComments
        {
            get
            {
                return this.personalProtectionEquipmentCommentsField;
            }
            set
            {
                this.personalProtectionEquipmentCommentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SpecificHygieneMeasures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SpecificHygieneMeasures
        {
            get
            {
                return this.specificHygieneMeasuresField;
            }
            set
            {
                this.specificHygieneMeasuresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SafetySigns", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SafetySign[] SafetySigns
        {
            get
            {
                return this.safetySignsField;
            }
            set
            {
                this.safetySignsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ExposureControlPersonalProtectionPersonalProtectionEquipmentRespiratoryProtection
    {

        private Phrase[] respiratoryProtectionGeneralField;

        private Phrase[] respiratoryProtectionNecessaryAtField;

        private Phrase[] tasksNeedingRespiratoryProtectionField;

        private Phrase[] suitableRespiratoryProtectionEquipmentField;

        private RespiratoryProtectionArticle[] recommendedRespiratoryProtectionArticlesField;

        private Phrase[] additionalRespiratoryProtectionMeasuresField;

        private Phrase[] referenceRelevantStandardField;

        private Phrase[] respiratoryProtectionCommentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RespiratoryProtectionGeneral", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] RespiratoryProtectionGeneral
        {
            get
            {
                return this.respiratoryProtectionGeneralField;
            }
            set
            {
                this.respiratoryProtectionGeneralField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RespiratoryProtectionNecessaryAt", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] RespiratoryProtectionNecessaryAt
        {
            get
            {
                return this.respiratoryProtectionNecessaryAtField;
            }
            set
            {
                this.respiratoryProtectionNecessaryAtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("TasksNeedingRespiratoryProtection", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] TasksNeedingRespiratoryProtection
        {
            get
            {
                return this.tasksNeedingRespiratoryProtectionField;
            }
            set
            {
                this.tasksNeedingRespiratoryProtectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SuitableRespiratoryProtectionEquipment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SuitableRespiratoryProtectionEquipment
        {
            get
            {
                return this.suitableRespiratoryProtectionEquipmentField;
            }
            set
            {
                this.suitableRespiratoryProtectionEquipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RecommendedRespiratoryProtectionArticles", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RespiratoryProtectionArticle[] RecommendedRespiratoryProtectionArticles
        {
            get
            {
                return this.recommendedRespiratoryProtectionArticlesField;
            }
            set
            {
                this.recommendedRespiratoryProtectionArticlesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AdditionalRespiratoryProtectionMeasures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AdditionalRespiratoryProtectionMeasures
        {
            get
            {
                return this.additionalRespiratoryProtectionMeasuresField;
            }
            set
            {
                this.additionalRespiratoryProtectionMeasuresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ReferenceRelevantStandard", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ReferenceRelevantStandard
        {
            get
            {
                return this.referenceRelevantStandardField;
            }
            set
            {
                this.referenceRelevantStandardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RespiratoryProtectionComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] RespiratoryProtectionComments
        {
            get
            {
                return this.respiratoryProtectionCommentsField;
            }
            set
            {
                this.respiratoryProtectionCommentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ExposureControlPersonalProtectionPersonalProtectionEquipmentEyeProtection
    {

        private Phrase[] requiredPropertiesField;

        private Phrase[] suitableEyeProtectionField;

        private Phrase[] unsuitableEyeProtectionField;

        private ProtectionArticle[] eyeProtectionEquipmentField;

        private Phrase[] additionalEyeProtectionMeasuresField;

        private Phrase[] referenceRelevantStandardField;

        private Phrase[] eyeProtectionCommentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RequiredProperties", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] RequiredProperties
        {
            get
            {
                return this.requiredPropertiesField;
            }
            set
            {
                this.requiredPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SuitableEyeProtection", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SuitableEyeProtection
        {
            get
            {
                return this.suitableEyeProtectionField;
            }
            set
            {
                this.suitableEyeProtectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("UnsuitableEyeProtection", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] UnsuitableEyeProtection
        {
            get
            {
                return this.unsuitableEyeProtectionField;
            }
            set
            {
                this.unsuitableEyeProtectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EyeProtectionEquipment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProtectionArticle[] EyeProtectionEquipment
        {
            get
            {
                return this.eyeProtectionEquipmentField;
            }
            set
            {
                this.eyeProtectionEquipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AdditionalEyeProtectionMeasures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AdditionalEyeProtectionMeasures
        {
            get
            {
                return this.additionalEyeProtectionMeasuresField;
            }
            set
            {
                this.additionalEyeProtectionMeasuresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ReferenceRelevantStandard", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ReferenceRelevantStandard
        {
            get
            {
                return this.referenceRelevantStandardField;
            }
            set
            {
                this.referenceRelevantStandardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EyeProtectionComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] EyeProtectionComments
        {
            get
            {
                return this.eyeProtectionCommentsField;
            }
            set
            {
                this.eyeProtectionCommentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ExposureControlPersonalProtectionPersonalProtectionEquipmentHandProtection
    {

        private Phrase[] skinHandProtectionShortTermContactField;

        private Phrase[] skinHandProtectionLongTermContactField;

        private Phrase[] suitableGlovesTypeField;

        private Phrase[] suitableMaterialsField;

        private Phrase[] unsuitableMaterialsField;

        private Phrase[] handProtectionNecessaryPropertiesField;

        private UnitValue[] gloveBreakthroughTimeField;

        private UnitValue[] thicknessOfGloveMaterialField;

        private Phrase[] wearDurationAtOccationalContactField;

        private Phrase[] wearDurationAtPermanentContactField;

        private ProtectionArticle[] handProtectionEquipmentField;

        private ExposureControlPersonalProtectionPersonalProtectionEquipmentHandProtectionEquipment[] equipmentField;

        private Phrase[] additionalHandProtectionMeasuresField;

        private Phrase[] referenceRelevantStandardField;

        private Phrase[] handProtectionCommentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SkinHandProtectionShortTermContact", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SkinHandProtectionShortTermContact
        {
            get
            {
                return this.skinHandProtectionShortTermContactField;
            }
            set
            {
                this.skinHandProtectionShortTermContactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SkinHandProtectionLongTermContact", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SkinHandProtectionLongTermContact
        {
            get
            {
                return this.skinHandProtectionLongTermContactField;
            }
            set
            {
                this.skinHandProtectionLongTermContactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SuitableGlovesType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SuitableGlovesType
        {
            get
            {
                return this.suitableGlovesTypeField;
            }
            set
            {
                this.suitableGlovesTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SuitableMaterials", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SuitableMaterials
        {
            get
            {
                return this.suitableMaterialsField;
            }
            set
            {
                this.suitableMaterialsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("UnsuitableMaterials", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] UnsuitableMaterials
        {
            get
            {
                return this.unsuitableMaterialsField;
            }
            set
            {
                this.unsuitableMaterialsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("HandProtectionNecessaryProperties", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] HandProtectionNecessaryProperties
        {
            get
            {
                return this.handProtectionNecessaryPropertiesField;
            }
            set
            {
                this.handProtectionNecessaryPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("GloveBreakthroughTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue[] GloveBreakthroughTime
        {
            get
            {
                return this.gloveBreakthroughTimeField;
            }
            set
            {
                this.gloveBreakthroughTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ThicknessOfGloveMaterial", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue[] ThicknessOfGloveMaterial
        {
            get
            {
                return this.thicknessOfGloveMaterialField;
            }
            set
            {
                this.thicknessOfGloveMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("WearDurationAtOccationalContact", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] WearDurationAtOccationalContact
        {
            get
            {
                return this.wearDurationAtOccationalContactField;
            }
            set
            {
                this.wearDurationAtOccationalContactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("WearDurationAtPermanentContact", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] WearDurationAtPermanentContact
        {
            get
            {
                return this.wearDurationAtPermanentContactField;
            }
            set
            {
                this.wearDurationAtPermanentContactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("HandProtectionEquipment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProtectionArticle[] HandProtectionEquipment
        {
            get
            {
                return this.handProtectionEquipmentField;
            }
            set
            {
                this.handProtectionEquipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Equipment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureControlPersonalProtectionPersonalProtectionEquipmentHandProtectionEquipment[] Equipment
        {
            get
            {
                return this.equipmentField;
            }
            set
            {
                this.equipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AdditionalHandProtectionMeasures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AdditionalHandProtectionMeasures
        {
            get
            {
                return this.additionalHandProtectionMeasuresField;
            }
            set
            {
                this.additionalHandProtectionMeasuresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ReferenceRelevantStandard", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ReferenceRelevantStandard
        {
            get
            {
                return this.referenceRelevantStandardField;
            }
            set
            {
                this.referenceRelevantStandardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("HandProtectionComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] HandProtectionComments
        {
            get
            {
                return this.handProtectionCommentsField;
            }
            set
            {
                this.handProtectionCommentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ExposureControlPersonalProtectionPersonalProtectionEquipmentHandProtectionEquipment
    {

        private Phrase suitableGlovesTypeField;

        private Phrase suitableMaterialField;

        private UnitValue gloveBreakthroughTimeField;

        private UnitValue thicknessOfGloveMaterialField;

        private UnitValue maxWearDurationOccasionalContactField;

        private UnitValue maxWearDurationPermanentContactField;

        private ProtectionArticle[] articleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase SuitableGlovesType
        {
            get
            {
                return this.suitableGlovesTypeField;
            }
            set
            {
                this.suitableGlovesTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase SuitableMaterial
        {
            get
            {
                return this.suitableMaterialField;
            }
            set
            {
                this.suitableMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue GloveBreakthroughTime
        {
            get
            {
                return this.gloveBreakthroughTimeField;
            }
            set
            {
                this.gloveBreakthroughTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue ThicknessOfGloveMaterial
        {
            get
            {
                return this.thicknessOfGloveMaterialField;
            }
            set
            {
                this.thicknessOfGloveMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue MaxWearDurationOccasionalContact
        {
            get
            {
                return this.maxWearDurationOccasionalContactField;
            }
            set
            {
                this.maxWearDurationOccasionalContactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue MaxWearDurationPermanentContact
        {
            get
            {
                return this.maxWearDurationPermanentContactField;
            }
            set
            {
                this.maxWearDurationPermanentContactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Article", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProtectionArticle[] Article
        {
            get
            {
                return this.articleField;
            }
            set
            {
                this.articleField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ExposureControlPersonalProtectionPersonalProtectionEquipmentSkinProtection
    {

        private Phrase[] suitableProtectiveClothingField;

        private Phrase[] unsuitableProtectiveClothingField;

        private Phrase[] protectiveClothingNecessaryPropertiesField;

        private Phrase[] protectiveClothingRecommendedMaterialField;

        private ProtectionArticle[] recommendedProtectiveClothingArticlesField;

        private Phrase[] additionalSkinProtectionMeasuresField;

        private Phrase[] skinBodyOtherProtectionField;

        private Phrase[] referenceRelevantStandardField;

        private Phrase[] skinProtectionCommentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SuitableProtectiveClothing", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SuitableProtectiveClothing
        {
            get
            {
                return this.suitableProtectiveClothingField;
            }
            set
            {
                this.suitableProtectiveClothingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("UnsuitableProtectiveClothing", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] UnsuitableProtectiveClothing
        {
            get
            {
                return this.unsuitableProtectiveClothingField;
            }
            set
            {
                this.unsuitableProtectiveClothingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProtectiveClothingNecessaryProperties", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ProtectiveClothingNecessaryProperties
        {
            get
            {
                return this.protectiveClothingNecessaryPropertiesField;
            }
            set
            {
                this.protectiveClothingNecessaryPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProtectiveClothingRecommendedMaterial", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ProtectiveClothingRecommendedMaterial
        {
            get
            {
                return this.protectiveClothingRecommendedMaterialField;
            }
            set
            {
                this.protectiveClothingRecommendedMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RecommendedProtectiveClothingArticles", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProtectionArticle[] RecommendedProtectiveClothingArticles
        {
            get
            {
                return this.recommendedProtectiveClothingArticlesField;
            }
            set
            {
                this.recommendedProtectiveClothingArticlesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AdditionalSkinProtectionMeasures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AdditionalSkinProtectionMeasures
        {
            get
            {
                return this.additionalSkinProtectionMeasuresField;
            }
            set
            {
                this.additionalSkinProtectionMeasuresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SkinBodyOtherProtection", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SkinBodyOtherProtection
        {
            get
            {
                return this.skinBodyOtherProtectionField;
            }
            set
            {
                this.skinBodyOtherProtectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ReferenceRelevantStandard", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ReferenceRelevantStandard
        {
            get
            {
                return this.referenceRelevantStandardField;
            }
            set
            {
                this.referenceRelevantStandardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SkinProtectionComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SkinProtectionComments
        {
            get
            {
                return this.skinProtectionCommentsField;
            }
            set
            {
                this.skinProtectionCommentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ExposureControlPersonalProtectionEnvironmentalExposureControls
    {

        private Phrase[] environmentalExposureControlsField;

        private ExposureControlPersonalProtectionEnvironmentalExposureControlsAppropriateEnvionmentalExposureControl appropriateEnvionmentalExposureControlField;

        private Phrase[] environmentalExposureControlCommentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EnvironmentalExposureControls", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] EnvironmentalExposureControls
        {
            get
            {
                return this.environmentalExposureControlsField;
            }
            set
            {
                this.environmentalExposureControlsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureControlPersonalProtectionEnvironmentalExposureControlsAppropriateEnvionmentalExposureControl AppropriateEnvionmentalExposureControl
        {
            get
            {
                return this.appropriateEnvionmentalExposureControlField;
            }
            set
            {
                this.appropriateEnvionmentalExposureControlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EnvironmentalExposureControlComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] EnvironmentalExposureControlComments
        {
            get
            {
                return this.environmentalExposureControlCommentsField;
            }
            set
            {
                this.environmentalExposureControlCommentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ExposureControlPersonalProtectionEnvironmentalExposureControlsAppropriateEnvionmentalExposureControl
    {

        private Phrase[] productRelatedMeasuresField;

        private Phrase[] instructionalMeasuresField;

        private Phrase[] organisationalMeasuresField;

        private Phrase[] technicalMeasuresField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProductRelatedMeasures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ProductRelatedMeasures
        {
            get
            {
                return this.productRelatedMeasuresField;
            }
            set
            {
                this.productRelatedMeasuresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("InstructionalMeasures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] InstructionalMeasures
        {
            get
            {
                return this.instructionalMeasuresField;
            }
            set
            {
                this.instructionalMeasuresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OrganisationalMeasures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] OrganisationalMeasures
        {
            get
            {
                return this.organisationalMeasuresField;
            }
            set
            {
                this.organisationalMeasuresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("TechnicalMeasures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] TechnicalMeasures
        {
            get
            {
                return this.technicalMeasuresField;
            }
            set
            {
                this.technicalMeasuresField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ExposureControlPersonalProtectionConsumerExposureControl
    {

        private Phrase[] measuresOnConsumerUseOfTheChemicalField;

        private Phrase[] measuresOnServiceLifeInArticlesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("MeasuresOnConsumerUseOfTheChemical", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] MeasuresOnConsumerUseOfTheChemical
        {
            get
            {
                return this.measuresOnConsumerUseOfTheChemicalField;
            }
            set
            {
                this.measuresOnConsumerUseOfTheChemicalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("MeasuresOnServiceLifeInArticles", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] MeasuresOnServiceLifeInArticles
        {
            get
            {
                return this.measuresOnServiceLifeInArticlesField;
            }
            set
            {
                this.measuresOnServiceLifeInArticlesField = value;
            }
        }
    }
}
