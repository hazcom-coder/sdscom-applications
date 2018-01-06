using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class Datasheet
    {

        private InformationFromExportingSystem informationFromExportingSystemField;

        private IdentificationSubstPrep identificationSubstPrepField;

        private HazardIdentification hazardIdentificationField;

        private Composition compositionField;

        private FirstAidMeasures firstAidMeasuresField;

        private FireFightingMeasures fireFightingMeasuresField;

        private AccidentalReleaseMeasures accidentalReleaseMeasuresField;

        private HandlingAndStorage handlingAndStorageField;

        private ExposureControlPersonalProtection exposureControlPersonalProtectionField;

        private PhysicalChemicalProperties physicalChemicalPropertiesField;

        private StabilityReactivity stabilityReactivityField;

        private ToxicologicalInformation toxicologicalInformationField;

        private EcologicalInformation ecologicalInformationField;

        private DisposalConsiderations disposalConsiderationsField;

        private TransportInformation transportInformationField;

        private RegulatoryInfo regulatoryInfoField;

        private OtherInformation otherInformationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformationFromExportingSystem InformationFromExportingSystem
        {
            get
            {
                return this.informationFromExportingSystemField;
            }
            set
            {
                this.informationFromExportingSystemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public IdentificationSubstPrep IdentificationSubstPrep
        {
            get
            {
                return this.identificationSubstPrepField;
            }
            set
            {
                this.identificationSubstPrepField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HazardIdentification HazardIdentification
        {
            get
            {
                return this.hazardIdentificationField;
            }
            set
            {
                this.hazardIdentificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Composition Composition
        {
            get
            {
                return this.compositionField;
            }
            set
            {
                this.compositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FirstAidMeasures FirstAidMeasures
        {
            get
            {
                return this.firstAidMeasuresField;
            }
            set
            {
                this.firstAidMeasuresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FireFightingMeasures FireFightingMeasures
        {
            get
            {
                return this.fireFightingMeasuresField;
            }
            set
            {
                this.fireFightingMeasuresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AccidentalReleaseMeasures AccidentalReleaseMeasures
        {
            get
            {
                return this.accidentalReleaseMeasuresField;
            }
            set
            {
                this.accidentalReleaseMeasuresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HandlingAndStorage HandlingAndStorage
        {
            get
            {
                return this.handlingAndStorageField;
            }
            set
            {
                this.handlingAndStorageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureControlPersonalProtection ExposureControlPersonalProtection
        {
            get
            {
                return this.exposureControlPersonalProtectionField;
            }
            set
            {
                this.exposureControlPersonalProtectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysicalChemicalProperties PhysicalChemicalProperties
        {
            get
            {
                return this.physicalChemicalPropertiesField;
            }
            set
            {
                this.physicalChemicalPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StabilityReactivity StabilityReactivity
        {
            get
            {
                return this.stabilityReactivityField;
            }
            set
            {
                this.stabilityReactivityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ToxicologicalInformation ToxicologicalInformation
        {
            get
            {
                return this.toxicologicalInformationField;
            }
            set
            {
                this.toxicologicalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EcologicalInformation EcologicalInformation
        {
            get
            {
                return this.ecologicalInformationField;
            }
            set
            {
                this.ecologicalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DisposalConsiderations DisposalConsiderations
        {
            get
            {
                return this.disposalConsiderationsField;
            }
            set
            {
                this.disposalConsiderationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransportInformation TransportInformation
        {
            get
            {
                return this.transportInformationField;
            }
            set
            {
                this.transportInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RegulatoryInfo RegulatoryInfo
        {
            get
            {
                return this.regulatoryInfoField;
            }
            set
            {
                this.regulatoryInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OtherInformation OtherInformation
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
    }
}
