using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class OccupationalAirRequirement
    {

        private string oarGroupField;

        private string oarValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OarGroup
        {
            get
            {
                return this.oarGroupField;
            }
            set
            {
                this.oarGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OarValue
        {
            get
            {
                return this.oarValueField;
            }
            set
            {
                this.oarValueField = value;
            }
        }
    }
}
