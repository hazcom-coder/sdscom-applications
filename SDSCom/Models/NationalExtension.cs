using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{




    /// <remarks/>
    public class NationalExtensionDE
    {

        private Phrase[] restrictionsOfOccupationField;

        private Stoerfallverordnung stoerfallverordnungField;

        private TaLuft[] taLuftField;

        private WaterHazardClass waterHazardClassField;

        private Phrase[] otherRestrictionsAndProhibitionRegulationsField;

        private Phrase registrationNoAccordingToBiozidMeldeverordnungField;

        private Phrase[] additionalInformationField;

        private NationalWasteLegislationDE[] nationalWasteLegislationDEField;

        private StorageClassEnum[] storageClassField;

        private GisCodeEnum gisCodeField;

        private bool gisCodeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RestrictionsOfOccupation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] RestrictionsOfOccupation
        {
            get
            {
                return this.restrictionsOfOccupationField;
            }
            set
            {
                this.restrictionsOfOccupationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Stoerfallverordnung Stoerfallverordnung
        {
            get
            {
                return this.stoerfallverordnungField;
            }
            set
            {
                this.stoerfallverordnungField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("TaLuft", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TaLuft[] TaLuft
        {
            get
            {
                return this.taLuftField;
            }
            set
            {
                this.taLuftField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WaterHazardClass WaterHazardClass
        {
            get
            {
                return this.waterHazardClassField;
            }
            set
            {
                this.waterHazardClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OtherRestrictionsAndProhibitionRegulations", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] OtherRestrictionsAndProhibitionRegulations
        {
            get
            {
                return this.otherRestrictionsAndProhibitionRegulationsField;
            }
            set
            {
                this.otherRestrictionsAndProhibitionRegulationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase RegistrationNoAccordingToBiozidMeldeverordnung
        {
            get
            {
                return this.registrationNoAccordingToBiozidMeldeverordnungField;
            }
            set
            {
                this.registrationNoAccordingToBiozidMeldeverordnungField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AdditionalInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AdditionalInformation
        {
            get
            {
                return this.additionalInformationField;
            }
            set
            {
                this.additionalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("NationalWasteLegislationDE", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalWasteLegislationDE[] NationalWasteLegislationDE
        {
            get
            {
                return this.nationalWasteLegislationDEField;
            }
            set
            {
                this.nationalWasteLegislationDEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("StorageClass", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StorageClassEnum[] StorageClass
        {
            get
            {
                return this.storageClassField;
            }
            set
            {
                this.storageClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public GisCodeEnum GisCode
        {
            get
            {
                return this.gisCodeField;
            }
            set
            {
                this.gisCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GisCodeSpecified
        {
            get
            {
                return this.gisCodeFieldSpecified;
            }
            set
            {
                this.gisCodeFieldSpecified = value;
            }
        }
    }


    /// <remarks/>
    public class NationalExtensionCZ
    {
    }

    /// <remarks/>
    public class NationalExtensionCH
    {
    }

    /// <remarks/>
    public class NationalExtensionBY
    {
    }

    /// <remarks/>
    public class NationalExtensionBG
    {
    }

    /// <remarks/>
    public class NationalExtensionBE
    {
    }

    /// <remarks/>
    public class NationalExtensionBA
    {
    }

    /// <remarks/>
    public class NationalExtensionAT
    {
    }

    /// <remarks/>
    public class NationalExtensionAM
    {
    }

    /// <remarks/>
    public class NationalExtensionAL
    {
    }

    /// <remarks/>
    public class NationalExtensionAD
    {
    }

    /// <remarks/>
    public class NationalWasteLegislationDE
    {

        private Phrase wasteCodeField;

        private Phrase[] wasteRegulationsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase WasteCode
        {
            get
            {
                return this.wasteCodeField;
            }
            set
            {
                this.wasteCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("WasteRegulations", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] WasteRegulations
        {
            get
            {
                return this.wasteRegulationsField;
            }
            set
            {
                this.wasteRegulationsField = value;
            }
        }
    }

    /// <remarks/>
    public class NationalExtensionNO
    {

        private Phrase assessedRegulationsField;

        private Phrase[] nationalLegislationsDescriptionField;

        private PrProductRegistrationNo[] prProductRegistrationNoField;

        private OccupationalAirRequirement occupationalAirRequirementField;

        private NationalWasteLegislation[] nationalWasteLegislationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase AssessedRegulations
        {
            get
            {
                return this.assessedRegulationsField;
            }
            set
            {
                this.assessedRegulationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("NationalLegislationsDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] NationalLegislationsDescription
        {
            get
            {
                return this.nationalLegislationsDescriptionField;
            }
            set
            {
                this.nationalLegislationsDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PrProductRegistrationNo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PrProductRegistrationNo[] PrProductRegistrationNo
        {
            get
            {
                return this.prProductRegistrationNoField;
            }
            set
            {
                this.prProductRegistrationNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OccupationalAirRequirement OccupationalAirRequirement
        {
            get
            {
                return this.occupationalAirRequirementField;
            }
            set
            {
                this.occupationalAirRequirementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("NationalWasteLegislation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalWasteLegislation[] NationalWasteLegislation
        {
            get
            {
                return this.nationalWasteLegislationField;
            }
            set
            {
                this.nationalWasteLegislationField = value;
            }
        }
    }


    /// <remarks/>

    public class NationalExtensionNL
    {
    }

    /// <remarks/>
    public  class NationalExtensionMT
    {
    }

    /// <remarks/>
    public  class NationalExtensionMK
    {
    }

    /// <remarks/>
    public  class NationalExtensionME
    {
    }

    /// <remarks/>
    public  class NationalExtensionMD
    {
    }

    /// <remarks/>
    public  class NationalExtensionMC
    {
    }

    /// <remarks/>
    public  class NationalExtensionLV
    {
    }

    /// <remarks/>
    public  class NationalExtensionLU
    {
    }

    /// <remarks/>
    public  class NationalExtensionLT
    {
    }

    /// <remarks/>
    public  class NationalExtensionLI
    {
    }

    /// <remarks/>
    public  class NationalExtensionKZ
    {
    }

    /// <remarks/>
    public  class NationalExtensionIT
    {
    }

    /// <remarks/>
    public  class NationalExtensionIS
    {
    }

    /// <remarks/>
    public  class NationalExtensionIE
    {
    }

    /// <remarks/>
    public  class NationalExtensionHU
    {
    }

    /// <remarks/>
    public  class NationalExtensionHR
    {
    }

    /// <remarks/>
    public  class NationalExtensionGR
    {
    }

    /// <remarks/>
    public  class NationalExtensionGE
    {
    }

    /// <remarks/>
    public  class NationalExtensionGB
    {
    }

    /// <remarks/>
    public  class NationalExtensionFR
    {
    }

    /// <remarks/>
    public  class NationalExtensionFI
    {
    }

    /// <remarks/>
    public  class NationalExtensionES
    {
    }

    /// <remarks/>
    public  class NationalExtensionEE
    {
    }

    /// <remarks/>
    public  class NationalExtensionDK
    {
    }

    /// <remarks/>
    public class NationalExtensionVA
    {
    }

    /// <remarks/>
    public class NationalExtensionUZ
    {
    }

    /// <remarks/>
    public class NationalExtensionUA
    {
    }

    /// <remarks/>
    public class NationalExtensionTR
    {
    }

    /// <remarks/>
    public class NationalExtensionSM
    {
    }

    /// <remarks/>
    public class NationalExtensionSK
    {
    }

    /// <remarks/>
    public class NationalExtensionSI
    {
    }

    /// <remarks/>
    public class NationalExtensionSE
    {
    }

    /// <remarks/>
    public class NationalExtensionRU
    {
    }

    /// <remarks/>
    public class NationalExtensionRS
    {
    }

    /// <remarks/>
    public class NationalExtensionRO
    {
    }

    /// <remarks/>
    public class NationalExtensionPT
    {
    }

    /// <remarks/>
    public class NationalExtensionPL
    {
    }

}
