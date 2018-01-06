using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class IdentifiedUseEnvironmentalReleaseCategory
    {

        private EnvironmentalReleaseCategoryCodeEnum ercCodeField;

        private bool ercCodeFieldSpecified;

        private Phrase ercFulltextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EnvironmentalReleaseCategoryCodeEnum ErcCode
        {
            get
            {
                return this.ercCodeField;
            }
            set
            {
                this.ercCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ErcCodeSpecified
        {
            get
            {
                return this.ercCodeFieldSpecified;
            }
            set
            {
                this.ercCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ErcFulltext
        {
            get
            {
                return this.ercFulltextField;
            }
            set
            {
                this.ercFulltextField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class IdentifiedUseSpecificEnvironmentalReleaseCategory
    {

        private string spercCodeField;

        private Phrase spercFulltextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SpercCode
        {
            get
            {
                return this.spercCodeField;
            }
            set
            {
                this.spercCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase SpercFulltext
        {
            get
            {
                return this.spercFulltextField;
            }
            set
            {
                this.spercFulltextField = value;
            }
        }
    }

}
