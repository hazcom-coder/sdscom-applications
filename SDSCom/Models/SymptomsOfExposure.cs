using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class SymptomsOfExposure
    {
        private Phrase[] inCaseOfIngestionField;

        private Phrase[] inCaseOfSkinContactField;

        private Phrase[] inCaseOfInhalationField;

        private Phrase[] inCaseOfEyeContactField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("InCaseOfIngestion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] InCaseOfIngestion
        {
            get
            {
                return this.inCaseOfIngestionField;
            }
            set
            {
                this.inCaseOfIngestionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("InCaseOfSkinContact", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] InCaseOfSkinContact
        {
            get
            {
                return this.inCaseOfSkinContactField;
            }
            set
            {
                this.inCaseOfSkinContactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("InCaseOfInhalation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] InCaseOfInhalation
        {
            get
            {
                return this.inCaseOfInhalationField;
            }
            set
            {
                this.inCaseOfInhalationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("InCaseOfEyeContact", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] InCaseOfEyeContact
        {
            get
            {
                return this.inCaseOfEyeContactField;
            }
            set
            {
                this.inCaseOfEyeContactField = value;
            }
        }
    }
}
