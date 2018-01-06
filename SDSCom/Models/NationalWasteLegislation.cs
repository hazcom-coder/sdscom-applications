using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class NationalWasteLegislation
    {
        private Phrase[] nationalWasteCodeField;

        private Phrase[] nationalRegulationsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("NationalWasteCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] NationalWasteCode
        {
            get
            {
                return this.nationalWasteCodeField;
            }
            set
            {
                this.nationalWasteCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("NationalRegulations", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] NationalRegulations
        {
            get
            {
                return this.nationalRegulationsField;
            }
            set
            {
                this.nationalRegulationsField = value;
            }
        }
    }
}
