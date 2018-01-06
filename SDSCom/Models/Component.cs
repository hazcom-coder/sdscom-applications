using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class Component
    {
        private Substance substanceField;

        private Classification classificationField;

        private UnitValue concentrationField;

        private ComponentInformation componentInformationField;

        private ComponentCompRestrictions compRestrictionsField;

        private Phrase[] componentCommentsField;

        private ExposureControlPersonalProtection exposureControlPersonalProtectionField;

        private PhysicalChemicalProperties physicalChemicalPropertiesField;

        private ToxicologicalInformation toxicologicalInformationField;

        private EcologicalInformation ecologicalInformationField;

        private ComponentTransportInformation transportInformationField;

        private string componentIdField;

        private string componentInternalSdsIdField;

        /// <summary>
        /// 
        /// </summary>
        public Component()
        {
            this.componentIdField = "0";
            this.componentInternalSdsIdField = "";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Substance Substance
        {
            get
            {
                return this.substanceField;
            }
            set
            {
                this.substanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Classification Classification
        {
            get
            {
                return this.classificationField;
            }
            set
            {
                this.classificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue Concentration
        {
            get
            {
                return this.concentrationField;
            }
            set
            {
                this.concentrationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ComponentInformation ComponentInformation
        {
            get
            {
                return this.componentInformationField;
            }
            set
            {
                this.componentInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ComponentCompRestrictions CompRestrictions
        {
            get
            {
                return this.compRestrictionsField;
            }
            set
            {
                this.compRestrictionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ComponentComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ComponentComments
        {
            get
            {
                return this.componentCommentsField;
            }
            set
            {
                this.componentCommentsField = value;
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
        public ComponentTransportInformation TransportInformation
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string ComponentId
        {
            get
            {
                return this.componentIdField;
            }
            set
            {
                this.componentIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string ComponentInternalSdsId
        {
            get
            {
                return this.componentInternalSdsIdField;
            }
            set
            {
                this.componentInternalSdsIdField = value;
            }
        }
    }
}
