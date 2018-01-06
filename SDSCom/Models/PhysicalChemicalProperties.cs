using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class PhysicalChemicalProperties
    {

        private PhysicalChemicalPropertiesAppearance appearanceField;

        private PhysicalChemicalPropertiesSafetyRelevantInformation safetyRelevantInformationField;

        private PhysicalChemicalPropertiesPhysicalHazards physicalHazardsField;

        private PhysicalChemicalPropertiesOtherSafetyInformation otherSafetyInformationField;

        private Phrase[] otherPhysicalChemicalPropertyField;

        private Phrase[] chemicalPhysicalPropertiesCommentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesAppearance Appearance
        {
            get
            {
                return this.appearanceField;
            }
            set
            {
                this.appearanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesSafetyRelevantInformation SafetyRelevantInformation
        {
            get
            {
                return this.safetyRelevantInformationField;
            }
            set
            {
                this.safetyRelevantInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesPhysicalHazards PhysicalHazards
        {
            get
            {
                return this.physicalHazardsField;
            }
            set
            {
                this.physicalHazardsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesOtherSafetyInformation OtherSafetyInformation
        {
            get
            {
                return this.otherSafetyInformationField;
            }
            set
            {
                this.otherSafetyInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OtherPhysicalChemicalProperty", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] OtherPhysicalChemicalProperty
        {
            get
            {
                return this.otherPhysicalChemicalPropertyField;
            }
            set
            {
                this.otherPhysicalChemicalPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ChemicalPhysicalPropertiesComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ChemicalPhysicalPropertiesComments
        {
            get
            {
                return this.chemicalPhysicalPropertiesCommentsField;
            }
            set
            {
                this.chemicalPhysicalPropertiesCommentsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesAppearance
    {

        private Phrase[] physicalStateField;

        private StateUnderStandardConditionsEnum stateUnderStandardConditionsField;

        private bool stateUnderStandardConditionsFieldSpecified;

        private Phrase[] colourField;

        private Phrase[] odourField;

        private PhysChemUnitValueWithTemperature[] odourThresholdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PhysicalState", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] PhysicalState
        {
            get
            {
                return this.physicalStateField;
            }
            set
            {
                this.physicalStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StateUnderStandardConditionsEnum StateUnderStandardConditions
        {
            get
            {
                return this.stateUnderStandardConditionsField;
            }
            set
            {
                this.stateUnderStandardConditionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StateUnderStandardConditionsSpecified
        {
            get
            {
                return this.stateUnderStandardConditionsFieldSpecified;
            }
            set
            {
                this.stateUnderStandardConditionsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Colour", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Colour
        {
            get
            {
                return this.colourField;
            }
            set
            {
                this.colourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Odour", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Odour
        {
            get
            {
                return this.odourField;
            }
            set
            {
                this.odourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OdourThreshold", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValueWithTemperature[] OdourThreshold
        {
            get
            {
                return this.odourThresholdField;
            }
            set
            {
                this.odourThresholdField = value;
            }
        }
    }

    /// <remarks/>


    public enum StateUnderStandardConditionsEnum
    {

        /// <remarks/>
        solid,

        /// <remarks/>
        liquid,

        /// <remarks/>
        gaseous,
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesSafetyRelevantInformation
    {

        private PhValue[] phValueField;

        private PhysicalChemicalPropertiesSafetyRelevantInformationMeltingPointRelated meltingPointRelatedField;

        private PhysicalChemicalPropertiesSafetyRelevantInformationBoilingPointRelated boilingPointRelatedField;

        private FlashPoint[] flashPointField;

        private PhysChemValueWithTemperature[] evaporationRateField;

        private Phrase[] flammabilityField;

        private PhysicalChemicalPropertiesSafetyRelevantInformationExplosionLimit explosionLimitField;

        private PhysChemUnitValueWithTemperature[] vapourPressureField;

        private RelativeVapourDensity[] relativeVapourDensityField;

        private PhysicalChemicalPropertiesSafetyRelevantInformationDensities densitiesField;

        private Solubilities[] solubilitiesField;

        private PartitionCoefficient[] partitionCoefficientField;

        private PhysChemUnitValue[] autoignitionTemperatureField;

        private PhysChemUnitValue[] decompositionTemperatureField;

        private Viscosity[] viscosityField;

        private Phrase[] explosivePropertiesField;

        private Phrase[] oxidisingPropertiesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PhValue", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhValue[] PhValue
        {
            get
            {
                return this.phValueField;
            }
            set
            {
                this.phValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesSafetyRelevantInformationMeltingPointRelated MeltingPointRelated
        {
            get
            {
                return this.meltingPointRelatedField;
            }
            set
            {
                this.meltingPointRelatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesSafetyRelevantInformationBoilingPointRelated BoilingPointRelated
        {
            get
            {
                return this.boilingPointRelatedField;
            }
            set
            {
                this.boilingPointRelatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("FlashPoint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FlashPoint[] FlashPoint
        {
            get
            {
                return this.flashPointField;
            }
            set
            {
                this.flashPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EvaporationRate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemValueWithTemperature[] EvaporationRate
        {
            get
            {
                return this.evaporationRateField;
            }
            set
            {
                this.evaporationRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Flammability", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Flammability
        {
            get
            {
                return this.flammabilityField;
            }
            set
            {
                this.flammabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesSafetyRelevantInformationExplosionLimit ExplosionLimit
        {
            get
            {
                return this.explosionLimitField;
            }
            set
            {
                this.explosionLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("VapourPressure", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValueWithTemperature[] VapourPressure
        {
            get
            {
                return this.vapourPressureField;
            }
            set
            {
                this.vapourPressureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RelativeVapourDensity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RelativeVapourDensity[] RelativeVapourDensity
        {
            get
            {
                return this.relativeVapourDensityField;
            }
            set
            {
                this.relativeVapourDensityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesSafetyRelevantInformationDensities Densities
        {
            get
            {
                return this.densitiesField;
            }
            set
            {
                this.densitiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Solubilities", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Solubilities[] Solubilities
        {
            get
            {
                return this.solubilitiesField;
            }
            set
            {
                this.solubilitiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PartitionCoefficient", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PartitionCoefficient[] PartitionCoefficient
        {
            get
            {
                return this.partitionCoefficientField;
            }
            set
            {
                this.partitionCoefficientField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AutoignitionTemperature", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] AutoignitionTemperature
        {
            get
            {
                return this.autoignitionTemperatureField;
            }
            set
            {
                this.autoignitionTemperatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DecompositionTemperature", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] DecompositionTemperature
        {
            get
            {
                return this.decompositionTemperatureField;
            }
            set
            {
                this.decompositionTemperatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Viscosity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Viscosity[] Viscosity
        {
            get
            {
                return this.viscosityField;
            }
            set
            {
                this.viscosityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ExplosiveProperties", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ExplosiveProperties
        {
            get
            {
                return this.explosivePropertiesField;
            }
            set
            {
                this.explosivePropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OxidisingProperties", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] OxidisingProperties
        {
            get
            {
                return this.oxidisingPropertiesField;
            }
            set
            {
                this.oxidisingPropertiesField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesSafetyRelevantInformationMeltingPointRelated
    {

        private PhysChemUnitValue[] meltingPointField;

        private PhysChemUnitValue[] freezingPointField;

        private PhysChemUnitValue[] softeningPointField;

        private PhysChemUnitValue[] solidificationPointField;

        private PhysChemUnitValue[] cloudPointField;

        private PhysChemUnitValue[] crystallisationPointField;

        private PhysChemUnitValue[] droppingPointField;

        private PhysChemUnitValue[] pourPointField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("MeltingPoint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] MeltingPoint
        {
            get
            {
                return this.meltingPointField;
            }
            set
            {
                this.meltingPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("FreezingPoint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] FreezingPoint
        {
            get
            {
                return this.freezingPointField;
            }
            set
            {
                this.freezingPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SofteningPoint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] SofteningPoint
        {
            get
            {
                return this.softeningPointField;
            }
            set
            {
                this.softeningPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SolidificationPoint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] SolidificationPoint
        {
            get
            {
                return this.solidificationPointField;
            }
            set
            {
                this.solidificationPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("CloudPoint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] CloudPoint
        {
            get
            {
                return this.cloudPointField;
            }
            set
            {
                this.cloudPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("CrystallisationPoint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] CrystallisationPoint
        {
            get
            {
                return this.crystallisationPointField;
            }
            set
            {
                this.crystallisationPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DroppingPoint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] DroppingPoint
        {
            get
            {
                return this.droppingPointField;
            }
            set
            {
                this.droppingPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PourPoint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] PourPoint
        {
            get
            {
                return this.pourPointField;
            }
            set
            {
                this.pourPointField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesSafetyRelevantInformationBoilingPointRelated
    {

        private PhysChemUnitValue[] boilingPointField;

        private PhysChemUnitValue[] sublimationPointField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("BoilingPoint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] BoilingPoint
        {
            get
            {
                return this.boilingPointField;
            }
            set
            {
                this.boilingPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SublimationPoint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] SublimationPoint
        {
            get
            {
                return this.sublimationPointField;
            }
            set
            {
                this.sublimationPointField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesSafetyRelevantInformationExplosionLimit
    {

        private PhysChemUnitValue[] lowerExplosionLimitField;

        private PhysChemUnitValue[] upperExplosionLimitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("LowerExplosionLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] LowerExplosionLimit
        {
            get
            {
                return this.lowerExplosionLimitField;
            }
            set
            {
                this.lowerExplosionLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("UpperExplosionLimit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] UpperExplosionLimit
        {
            get
            {
                return this.upperExplosionLimitField;
            }
            set
            {
                this.upperExplosionLimitField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesSafetyRelevantInformationDensities
    {

        private PhysChemValueWithTemperature[] relativeDensityField;

        private PhysChemUnitValueWithTemperature[] densityField;

        private PhysChemUnitValueWithTemperature[] bulkDensityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RelativeDensity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemValueWithTemperature[] RelativeDensity
        {
            get
            {
                return this.relativeDensityField;
            }
            set
            {
                this.relativeDensityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Density", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValueWithTemperature[] Density
        {
            get
            {
                return this.densityField;
            }
            set
            {
                this.densityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("BulkDensity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValueWithTemperature[] BulkDensity
        {
            get
            {
                return this.bulkDensityField;
            }
            set
            {
                this.bulkDensityField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesPhysicalHazards
    {

        private PhysicalChemicalPropertiesPhysicalHazardsExplosives explosivesField;

        private PhysicalChemicalPropertiesPhysicalHazardsFlammableGases flammableGasesField;

        private PhysicalChemicalPropertiesPhysicalHazardsFlammableAerosols flammableAerosolsField;

        private PhysicalChemicalPropertiesPhysicalHazardsOxidisingGases oxidisingGasesField;

        private PhysicalChemicalPropertiesPhysicalHazardsGasesUnderPressure gasesUnderPressureField;

        private PhysicalChemicalPropertiesPhysicalHazardsFlammableLiquids flammableLiquidsField;

        private PhysicalChemicalPropertiesPhysicalHazardsFlammableSolids flammableSolidsField;

        private PhysicalChemicalPropertiesPhysicalHazardsSelfreactiveSubstancesAndMixtures selfreactiveSubstancesAndMixturesField;

        private PhysicalChemicalPropertiesPhysicalHazardsPyrophoricLiquids pyrophoricLiquidsField;

        private PhysicalChemicalPropertiesPhysicalHazardsPyrophoricSolids pyrophoricSolidsField;

        private PhysicalChemicalPropertiesPhysicalHazardsSelfheatingSubstancesAndMixtures selfheatingSubstancesAndMixturesField;

        private PhysicalChemicalPropertiesPhysicalHazardsSubstancesWhichInContactWithWaterEmitFlammableGases substancesWhichInContactWithWaterEmitFlammableGasesField;

        private PhysicalChemicalPropertiesPhysicalHazardsOxidisingLiquids oxidisingLiquidsField;

        private PhysicalChemicalPropertiesPhysicalHazardsOxidisingSolids oxidisingSolidsField;

        private PhysicalChemicalPropertiesPhysicalHazardsOrganicPeroxides organicPeroxidesField;

        private PhysicalChemicalPropertiesPhysicalHazardsCorrosiveToMetals corrosiveToMetalsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesPhysicalHazardsExplosives Explosives
        {
            get
            {
                return this.explosivesField;
            }
            set
            {
                this.explosivesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesPhysicalHazardsFlammableGases FlammableGases
        {
            get
            {
                return this.flammableGasesField;
            }
            set
            {
                this.flammableGasesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesPhysicalHazardsFlammableAerosols FlammableAerosols
        {
            get
            {
                return this.flammableAerosolsField;
            }
            set
            {
                this.flammableAerosolsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesPhysicalHazardsOxidisingGases OxidisingGases
        {
            get
            {
                return this.oxidisingGasesField;
            }
            set
            {
                this.oxidisingGasesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesPhysicalHazardsGasesUnderPressure GasesUnderPressure
        {
            get
            {
                return this.gasesUnderPressureField;
            }
            set
            {
                this.gasesUnderPressureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesPhysicalHazardsFlammableLiquids FlammableLiquids
        {
            get
            {
                return this.flammableLiquidsField;
            }
            set
            {
                this.flammableLiquidsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesPhysicalHazardsFlammableSolids FlammableSolids
        {
            get
            {
                return this.flammableSolidsField;
            }
            set
            {
                this.flammableSolidsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesPhysicalHazardsSelfreactiveSubstancesAndMixtures SelfreactiveSubstancesAndMixtures
        {
            get
            {
                return this.selfreactiveSubstancesAndMixturesField;
            }
            set
            {
                this.selfreactiveSubstancesAndMixturesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesPhysicalHazardsPyrophoricLiquids PyrophoricLiquids
        {
            get
            {
                return this.pyrophoricLiquidsField;
            }
            set
            {
                this.pyrophoricLiquidsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesPhysicalHazardsPyrophoricSolids PyrophoricSolids
        {
            get
            {
                return this.pyrophoricSolidsField;
            }
            set
            {
                this.pyrophoricSolidsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesPhysicalHazardsSelfheatingSubstancesAndMixtures SelfheatingSubstancesAndMixtures
        {
            get
            {
                return this.selfheatingSubstancesAndMixturesField;
            }
            set
            {
                this.selfheatingSubstancesAndMixturesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesPhysicalHazardsSubstancesWhichInContactWithWaterEmitFlammableGases SubstancesWhichInContactWithWaterEmitFlammableGases
        {
            get
            {
                return this.substancesWhichInContactWithWaterEmitFlammableGasesField;
            }
            set
            {
                this.substancesWhichInContactWithWaterEmitFlammableGasesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesPhysicalHazardsOxidisingLiquids OxidisingLiquids
        {
            get
            {
                return this.oxidisingLiquidsField;
            }
            set
            {
                this.oxidisingLiquidsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesPhysicalHazardsOxidisingSolids OxidisingSolids
        {
            get
            {
                return this.oxidisingSolidsField;
            }
            set
            {
                this.oxidisingSolidsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesPhysicalHazardsOrganicPeroxides OrganicPeroxides
        {
            get
            {
                return this.organicPeroxidesField;
            }
            set
            {
                this.organicPeroxidesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesPhysicalHazardsCorrosiveToMetals CorrosiveToMetals
        {
            get
            {
                return this.corrosiveToMetalsField;
            }
            set
            {
                this.corrosiveToMetalsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesPhysicalHazardsExplosives
    {

        private PhysicalHazardsGeneralInformation generalInformationField;

        private PhysicalHazardsScreeningProcedures[] screeningProceduresField;

        private PhysicalChemicalPropertiesPhysicalHazardsExplosivesTestPerformed[] testPerformedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsGeneralInformation GeneralInformation
        {
            get
            {
                return this.generalInformationField;
            }
            set
            {
                this.generalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ScreeningProcedures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsScreeningProcedures[] ScreeningProcedures
        {
            get
            {
                return this.screeningProceduresField;
            }
            set
            {
                this.screeningProceduresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("TestPerformed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalPropertiesPhysicalHazardsExplosivesTestPerformed[] TestPerformed
        {
            get
            {
                return this.testPerformedField;
            }
            set
            {
                this.testPerformedField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesPhysicalHazardsExplosivesTestPerformed
    {

        private Phrase parameterTestedField;

        private PhysChemUnitValue testResultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ParameterTested
        {
            get
            {
                return this.parameterTestedField;
            }
            set
            {
                this.parameterTestedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue TestResult
        {
            get
            {
                return this.testResultField;
            }
            set
            {
                this.testResultField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesPhysicalHazardsFlammableGases
    {

        private PhysicalHazardsGeneralInformation generalInformationField;

        private PhysicalHazardsSafetyCharacteristics[] safetyCharacteristicsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsGeneralInformation GeneralInformation
        {
            get
            {
                return this.generalInformationField;
            }
            set
            {
                this.generalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SafetyCharacteristics", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsSafetyCharacteristics[] SafetyCharacteristics
        {
            get
            {
                return this.safetyCharacteristicsField;
            }
            set
            {
                this.safetyCharacteristicsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesPhysicalHazardsFlammableAerosols
    {

        private PhysicalHazardsGeneralInformation generalInformationField;

        private PhysicalHazardsSafetyCharacteristics[] safetyCharacteristicsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsGeneralInformation GeneralInformation
        {
            get
            {
                return this.generalInformationField;
            }
            set
            {
                this.generalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SafetyCharacteristics", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsSafetyCharacteristics[] SafetyCharacteristics
        {
            get
            {
                return this.safetyCharacteristicsField;
            }
            set
            {
                this.safetyCharacteristicsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesPhysicalHazardsOxidisingGases
    {

        private PhysicalHazardsGeneralInformation generalInformationField;

        private PhysicalHazardsSafetyCharacteristics[] safetyCharacteristicsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsGeneralInformation GeneralInformation
        {
            get
            {
                return this.generalInformationField;
            }
            set
            {
                this.generalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SafetyCharacteristics", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsSafetyCharacteristics[] SafetyCharacteristics
        {
            get
            {
                return this.safetyCharacteristicsField;
            }
            set
            {
                this.safetyCharacteristicsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesPhysicalHazardsGasesUnderPressure
    {

        private PhysicalHazardsGeneralInformation generalInformationField;

        private PhysicalHazardsSafetyCharacteristics[] safetyCharacteristicsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsGeneralInformation GeneralInformation
        {
            get
            {
                return this.generalInformationField;
            }
            set
            {
                this.generalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SafetyCharacteristics", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsSafetyCharacteristics[] SafetyCharacteristics
        {
            get
            {
                return this.safetyCharacteristicsField;
            }
            set
            {
                this.safetyCharacteristicsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesPhysicalHazardsFlammableLiquids
    {

        private PhysicalHazardsGeneralInformation generalInformationField;

        private PhysicalHazardsSafetyCharacteristics[] safetyCharacteristicsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsGeneralInformation GeneralInformation
        {
            get
            {
                return this.generalInformationField;
            }
            set
            {
                this.generalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SafetyCharacteristics", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsSafetyCharacteristics[] SafetyCharacteristics
        {
            get
            {
                return this.safetyCharacteristicsField;
            }
            set
            {
                this.safetyCharacteristicsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesPhysicalHazardsFlammableSolids
    {

        private PhysicalHazardsGeneralInformation generalInformationField;

        private PhysicalHazardsSafetyCharacteristics[] safetyCharacteristicsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsGeneralInformation GeneralInformation
        {
            get
            {
                return this.generalInformationField;
            }
            set
            {
                this.generalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SafetyCharacteristics", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsSafetyCharacteristics[] SafetyCharacteristics
        {
            get
            {
                return this.safetyCharacteristicsField;
            }
            set
            {
                this.safetyCharacteristicsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesPhysicalHazardsSelfreactiveSubstancesAndMixtures
    {

        private PhysicalHazardsGeneralInformation generalInformationField;

        private PhysicalHazardsScreeningProcedures[] screeningProceduresField;

        private PhysicalHazardsSafetyCharacteristics[] safetyCharacteristicsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsGeneralInformation GeneralInformation
        {
            get
            {
                return this.generalInformationField;
            }
            set
            {
                this.generalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ScreeningProcedures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsScreeningProcedures[] ScreeningProcedures
        {
            get
            {
                return this.screeningProceduresField;
            }
            set
            {
                this.screeningProceduresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SafetyCharacteristics", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsSafetyCharacteristics[] SafetyCharacteristics
        {
            get
            {
                return this.safetyCharacteristicsField;
            }
            set
            {
                this.safetyCharacteristicsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesPhysicalHazardsPyrophoricLiquids
    {

        private PhysicalHazardsGeneralInformation generalInformationField;

        private PhysicalHazardsSafetyCharacteristics[] safetyCharacteristicsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsGeneralInformation GeneralInformation
        {
            get
            {
                return this.generalInformationField;
            }
            set
            {
                this.generalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SafetyCharacteristics", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsSafetyCharacteristics[] SafetyCharacteristics
        {
            get
            {
                return this.safetyCharacteristicsField;
            }
            set
            {
                this.safetyCharacteristicsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesPhysicalHazardsPyrophoricSolids
    {

        private PhysicalHazardsGeneralInformation generalInformationField;

        private PhysicalHazardsSafetyCharacteristics[] safetyCharacteristicsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsGeneralInformation GeneralInformation
        {
            get
            {
                return this.generalInformationField;
            }
            set
            {
                this.generalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SafetyCharacteristics", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsSafetyCharacteristics[] SafetyCharacteristics
        {
            get
            {
                return this.safetyCharacteristicsField;
            }
            set
            {
                this.safetyCharacteristicsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesPhysicalHazardsSelfheatingSubstancesAndMixtures
    {

        private PhysicalHazardsGeneralInformation generalInformationField;

        private PhysicalHazardsSafetyCharacteristics[] safetyCharacteristicsField;

        private UnitValue maxTemperatureReachedField;

        private UnitValue inductionTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsGeneralInformation GeneralInformation
        {
            get
            {
                return this.generalInformationField;
            }
            set
            {
                this.generalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SafetyCharacteristics", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsSafetyCharacteristics[] SafetyCharacteristics
        {
            get
            {
                return this.safetyCharacteristicsField;
            }
            set
            {
                this.safetyCharacteristicsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue MaxTemperatureReached
        {
            get
            {
                return this.maxTemperatureReachedField;
            }
            set
            {
                this.maxTemperatureReachedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue InductionTime
        {
            get
            {
                return this.inductionTimeField;
            }
            set
            {
                this.inductionTimeField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesPhysicalHazardsSubstancesWhichInContactWithWaterEmitFlammableGases
    {

        private PhysicalHazardsGeneralInformation generalInformationField;

        private PhysicalHazardsSafetyCharacteristics[] safetyCharacteristicsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsGeneralInformation GeneralInformation
        {
            get
            {
                return this.generalInformationField;
            }
            set
            {
                this.generalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SafetyCharacteristics", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsSafetyCharacteristics[] SafetyCharacteristics
        {
            get
            {
                return this.safetyCharacteristicsField;
            }
            set
            {
                this.safetyCharacteristicsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesPhysicalHazardsOxidisingLiquids
    {

        private PhysicalHazardsGeneralInformation generalInformationField;

        private PhysicalHazardsSafetyCharacteristics[] safetyCharacteristicsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsGeneralInformation GeneralInformation
        {
            get
            {
                return this.generalInformationField;
            }
            set
            {
                this.generalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SafetyCharacteristics", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsSafetyCharacteristics[] SafetyCharacteristics
        {
            get
            {
                return this.safetyCharacteristicsField;
            }
            set
            {
                this.safetyCharacteristicsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesPhysicalHazardsOxidisingSolids
    {

        private PhysicalHazardsGeneralInformation generalInformationField;

        private PhysicalHazardsSafetyCharacteristics[] safetyCharacteristicsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsGeneralInformation GeneralInformation
        {
            get
            {
                return this.generalInformationField;
            }
            set
            {
                this.generalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SafetyCharacteristics", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsSafetyCharacteristics[] SafetyCharacteristics
        {
            get
            {
                return this.safetyCharacteristicsField;
            }
            set
            {
                this.safetyCharacteristicsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesPhysicalHazardsOrganicPeroxides
    {

        private PhysicalHazardsGeneralInformation generalInformationField;

        private PhysicalHazardsSafetyCharacteristics[] safetyCharacteristicsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsGeneralInformation GeneralInformation
        {
            get
            {
                return this.generalInformationField;
            }
            set
            {
                this.generalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SafetyCharacteristics", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsSafetyCharacteristics[] SafetyCharacteristics
        {
            get
            {
                return this.safetyCharacteristicsField;
            }
            set
            {
                this.safetyCharacteristicsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesPhysicalHazardsCorrosiveToMetals
    {

        private PhysicalHazardsGeneralInformation generalInformationField;

        private PhysicalHazardsSafetyCharacteristics[] safetyCharacteristicsField;

        private UnitValue exposureTimeField;

        private UnitValue intrusionDepthField;

        private Phrase materialTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsGeneralInformation GeneralInformation
        {
            get
            {
                return this.generalInformationField;
            }
            set
            {
                this.generalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SafetyCharacteristics", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalHazardsSafetyCharacteristics[] SafetyCharacteristics
        {
            get
            {
                return this.safetyCharacteristicsField;
            }
            set
            {
                this.safetyCharacteristicsField = value;
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
        public UnitValue IntrusionDepth
        {
            get
            {
                return this.intrusionDepthField;
            }
            set
            {
                this.intrusionDepthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase MaterialType
        {
            get
            {
                return this.materialTypeField;
            }
            set
            {
                this.materialTypeField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PhysicalChemicalPropertiesOtherSafetyInformation
    {

        private Phrase[] miscibilityField;

        private PhysChemUnitValue[] anilinePointField;

        private PhysChemUnitValueWithTemperature[] electricConductivityField;

        private GasGroup[] gasGroupField;

        private PhysChemUnitValue[] solventSeparationTestField;

        private PhysChemValue[] contentOfVocField;

        private PhysChemUnitValue[] solidContentField;

        private PhysChemUnitValue[] propellantContentField;

        private PhysChemUnitValue[] sinterTemperatureField;

        private PhysChemUnitValue[] acidNoField;

        private DissociationConstant[] dissociationConstantField;

        private HydrolysisRate[] hydrolysisRateField;

        private Phrase[] waterReactiveField;

        private Phrase[] airReactiveField;

        private PhysChemUnitValueWithTemperature[] penetrationNoField;

        private PhysChemUnitValueWithTemperature[] particleSizeField;

        private PhysChemUnitValueWithTemperature[] criticalPressureField;

        private PhysChemUnitValueWithTemperature[] expansionCoefficientField;

        private PhysChemUnitValueWithTemperature[] redoxPotentialField;

        private PhysChemValueWithTemperature[] radicalFormationPotentialField;

        private PhysChemUnitValueWithTemperature[] photocatalyticPropertiesField;

        private PhysChemUnitValue[] numberAverageMolecularWeightField;

        private PhysChemUnitValue[] weightAverageMolecularWeightField;

        private PhysChemUnitValue[] molecularWeightDistributionField;

        private PhysChemUnitValue[] lowMolecularWeightContentOfPolymersField;

        private SolutionExtractionBehaviourOfPolymersInWater[] solutionExtractionBehaviourOfPolymersInWaterField;

        private PhysChemValueWithTemperature[] refractionIndexField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Miscibility", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Miscibility
        {
            get
            {
                return this.miscibilityField;
            }
            set
            {
                this.miscibilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AnilinePoint", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] AnilinePoint
        {
            get
            {
                return this.anilinePointField;
            }
            set
            {
                this.anilinePointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ElectricConductivity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValueWithTemperature[] ElectricConductivity
        {
            get
            {
                return this.electricConductivityField;
            }
            set
            {
                this.electricConductivityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("GasGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GasGroup[] GasGroup
        {
            get
            {
                return this.gasGroupField;
            }
            set
            {
                this.gasGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SolventSeparationTest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] SolventSeparationTest
        {
            get
            {
                return this.solventSeparationTestField;
            }
            set
            {
                this.solventSeparationTestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ContentOfVoc", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemValue[] ContentOfVoc
        {
            get
            {
                return this.contentOfVocField;
            }
            set
            {
                this.contentOfVocField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SolidContent", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] SolidContent
        {
            get
            {
                return this.solidContentField;
            }
            set
            {
                this.solidContentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PropellantContent", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] PropellantContent
        {
            get
            {
                return this.propellantContentField;
            }
            set
            {
                this.propellantContentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SinterTemperature", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] SinterTemperature
        {
            get
            {
                return this.sinterTemperatureField;
            }
            set
            {
                this.sinterTemperatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AcidNo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] AcidNo
        {
            get
            {
                return this.acidNoField;
            }
            set
            {
                this.acidNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DissociationConstant", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DissociationConstant[] DissociationConstant
        {
            get
            {
                return this.dissociationConstantField;
            }
            set
            {
                this.dissociationConstantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("HydrolysisRate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HydrolysisRate[] HydrolysisRate
        {
            get
            {
                return this.hydrolysisRateField;
            }
            set
            {
                this.hydrolysisRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("WaterReactive", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] WaterReactive
        {
            get
            {
                return this.waterReactiveField;
            }
            set
            {
                this.waterReactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AirReactive", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AirReactive
        {
            get
            {
                return this.airReactiveField;
            }
            set
            {
                this.airReactiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PenetrationNo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValueWithTemperature[] PenetrationNo
        {
            get
            {
                return this.penetrationNoField;
            }
            set
            {
                this.penetrationNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ParticleSize", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValueWithTemperature[] ParticleSize
        {
            get
            {
                return this.particleSizeField;
            }
            set
            {
                this.particleSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("CriticalPressure", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValueWithTemperature[] CriticalPressure
        {
            get
            {
                return this.criticalPressureField;
            }
            set
            {
                this.criticalPressureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ExpansionCoefficient", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValueWithTemperature[] ExpansionCoefficient
        {
            get
            {
                return this.expansionCoefficientField;
            }
            set
            {
                this.expansionCoefficientField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RedoxPotential", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValueWithTemperature[] RedoxPotential
        {
            get
            {
                return this.redoxPotentialField;
            }
            set
            {
                this.redoxPotentialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RadicalFormationPotential", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemValueWithTemperature[] RadicalFormationPotential
        {
            get
            {
                return this.radicalFormationPotentialField;
            }
            set
            {
                this.radicalFormationPotentialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PhotocatalyticProperties", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValueWithTemperature[] PhotocatalyticProperties
        {
            get
            {
                return this.photocatalyticPropertiesField;
            }
            set
            {
                this.photocatalyticPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("NumberAverageMolecularWeight", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] NumberAverageMolecularWeight
        {
            get
            {
                return this.numberAverageMolecularWeightField;
            }
            set
            {
                this.numberAverageMolecularWeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("WeightAverageMolecularWeight", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] WeightAverageMolecularWeight
        {
            get
            {
                return this.weightAverageMolecularWeightField;
            }
            set
            {
                this.weightAverageMolecularWeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("MolecularWeightDistribution", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] MolecularWeightDistribution
        {
            get
            {
                return this.molecularWeightDistributionField;
            }
            set
            {
                this.molecularWeightDistributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("LowMolecularWeightContentOfPolymers", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] LowMolecularWeightContentOfPolymers
        {
            get
            {
                return this.lowMolecularWeightContentOfPolymersField;
            }
            set
            {
                this.lowMolecularWeightContentOfPolymersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SolutionExtractionBehaviourOfPolymersInWater", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SolutionExtractionBehaviourOfPolymersInWater[] SolutionExtractionBehaviourOfPolymersInWater
        {
            get
            {
                return this.solutionExtractionBehaviourOfPolymersInWaterField;
            }
            set
            {
                this.solutionExtractionBehaviourOfPolymersInWaterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RefractionIndex", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemValueWithTemperature[] RefractionIndex
        {
            get
            {
                return this.refractionIndexField;
            }
            set
            {
                this.refractionIndexField = value;
            }
        }
    }
}
