using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class PrProductRegistrationNo
    {

        private string[] prProductNoField;

        private Phrase[] notApplicableReasonField;

        private string[] prProductCodeField;

        private string[] ucnCodeField;

        private string[] sicCodeField;

        private Phrase[] norwegianPrFunctionCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PrProductNo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] PrProductNo
        {
            get
            {
                return this.prProductNoField;
            }
            set
            {
                this.prProductNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("NotApplicableReason", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] NotApplicableReason
        {
            get
            {
                return this.notApplicableReasonField;
            }
            set
            {
                this.notApplicableReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PrProductCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] PrProductCode
        {
            get
            {
                return this.prProductCodeField;
            }
            set
            {
                this.prProductCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("UcnCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] UcnCode
        {
            get
            {
                return this.ucnCodeField;
            }
            set
            {
                this.ucnCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SicCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] SicCode
        {
            get
            {
                return this.sicCodeField;
            }
            set
            {
                this.sicCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("NorwegianPrFunctionCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] NorwegianPrFunctionCode
        {
            get
            {
                return this.norwegianPrFunctionCodeField;
            }
            set
            {
                this.norwegianPrFunctionCodeField = value;
            }
        }
    }
}
