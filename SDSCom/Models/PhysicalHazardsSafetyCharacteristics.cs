using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class PhysicalHazardsSafetyCharacteristics
    {
        private Phrase safetyParameterField;

        private PhysChemUnitValue safetyResultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase SafetyParameter
        {
            get
            {
                return this.safetyParameterField;
            }
            set
            {
                this.safetyParameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue SafetyResult
        {
            get
            {
                return this.safetyResultField;
            }
            set
            {
                this.safetyResultField = value;
            }
        }
    }
}
