using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class UnitValue : Value
    {

        private string unitField;

        private UnitIdEnum unitIdField;

        private bool unitIdFieldSpecified;

        private string unitSetIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitIdEnum UnitId
        {
            get
            {
                return this.unitIdField;
            }
            set
            {
                this.unitIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitIdSpecified
        {
            get
            {
                return this.unitIdFieldSpecified;
            }
            set
            {
                this.unitIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string UnitSetId
        {
            get
            {
                return this.unitSetIdField;
            }
            set
            {
                this.unitSetIdField = value;
            }
        }
    }
}
