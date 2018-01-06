using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class HydrolysisRate
    {
        private PhysChemValueWithTemperature valueField;

        private UnitValue concentrationField;

        private Value phValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemValueWithTemperature Value
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
        public Value PhValue
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
    }
}
