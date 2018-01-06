using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{

    /// <remarks/>
    public class WasteListEntry
    {
        private string wasteCodeField;

        private Phrase wasteDescriptionField;

        private bool hazardousWasteField;

        private bool hazardousWasteFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WasteCode
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
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase WasteDescription
        {
            get
            {
                return this.wasteDescriptionField;
            }
            set
            {
                this.wasteDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool HazardousWaste
        {
            get
            {
                return this.hazardousWasteField;
            }
            set
            {
                this.hazardousWasteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HazardousWasteSpecified
        {
            get
            {
                return this.hazardousWasteFieldSpecified;
            }
            set
            {
                this.hazardousWasteFieldSpecified = value;
            }
        }
    }
}
