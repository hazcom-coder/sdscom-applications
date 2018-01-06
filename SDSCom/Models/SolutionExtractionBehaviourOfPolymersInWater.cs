using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class SolutionExtractionBehaviourOfPolymersInWater
    {
        private PhysChemUnitValueWithTemperature valueField;

        private Value phValueField;

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
