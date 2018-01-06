using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class Viscosity    {

        private PhysChemUnitValueWithTemperature valueField;

        private ViscosityTypeEnum typeField;

        private bool typeFieldSpecified;

        private Phrase[] otherTypeDescriptionField;

        private UnitValue concentrationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValueWithTemperature Value
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
        public ViscosityTypeEnum Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OtherTypeDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] OtherTypeDescription
        {
            get
            {
                return this.otherTypeDescriptionField;
            }
            set
            {
                this.otherTypeDescriptionField = value;
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
    }
}
