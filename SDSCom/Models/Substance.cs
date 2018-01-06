using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class Substance
    {
        private string substanceNameField;

        private string casNoField;

        private string indexNoField;

        private string authorisationNoField;

        private string ecNoField;

        private string[] reachRegNoField;

        private Phrase[] reachRegNoCommentsField;

        private string idNoCLInventoryField;

        private string[] synonymField;

        private string formulaField;

        private string iupacNameField;

        private string productNameInSection2Field;

        private string productNameInSection3Field;

        private string productNameInSection8Field;

        private string nameDetergentsRegulationField;

        private Phrase[] substanceAdditionalInformationField;

        private Phrase[] hazardousImpuritiesField;

        private Phrase[] stabilizerField;

        private Phrase[] chemicalPurityField;

        private Phrase[] chemicalPropertiesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SubstanceName
        {
            get
            {
                return this.substanceNameField;
            }
            set
            {
                this.substanceNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CasNo
        {
            get
            {
                return this.casNoField;
            }
            set
            {
                this.casNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IndexNo
        {
            get
            {
                return this.indexNoField;
            }
            set
            {
                this.indexNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AuthorisationNo
        {
            get
            {
                return this.authorisationNoField;
            }
            set
            {
                this.authorisationNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EcNo
        {
            get
            {
                return this.ecNoField;
            }
            set
            {
                this.ecNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ReachRegNo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] ReachRegNo
        {
            get
            {
                return this.reachRegNoField;
            }
            set
            {
                this.reachRegNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ReachRegNoComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ReachRegNoComments
        {
            get
            {
                return this.reachRegNoCommentsField;
            }
            set
            {
                this.reachRegNoCommentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IdNoCLInventory
        {
            get
            {
                return this.idNoCLInventoryField;
            }
            set
            {
                this.idNoCLInventoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Synonym", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] Synonym
        {
            get
            {
                return this.synonymField;
            }
            set
            {
                this.synonymField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Formula
        {
            get
            {
                return this.formulaField;
            }
            set
            {
                this.formulaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IupacName
        {
            get
            {
                return this.iupacNameField;
            }
            set
            {
                this.iupacNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ProductNameInSection2
        {
            get
            {
                return this.productNameInSection2Field;
            }
            set
            {
                this.productNameInSection2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ProductNameInSection3
        {
            get
            {
                return this.productNameInSection3Field;
            }
            set
            {
                this.productNameInSection3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ProductNameInSection8
        {
            get
            {
                return this.productNameInSection8Field;
            }
            set
            {
                this.productNameInSection8Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NameDetergentsRegulation
        {
            get
            {
                return this.nameDetergentsRegulationField;
            }
            set
            {
                this.nameDetergentsRegulationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SubstanceAdditionalInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] SubstanceAdditionalInformation
        {
            get
            {
                return this.substanceAdditionalInformationField;
            }
            set
            {
                this.substanceAdditionalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("HazardousImpurities", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] HazardousImpurities
        {
            get
            {
                return this.hazardousImpuritiesField;
            }
            set
            {
                this.hazardousImpuritiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Stabilizer", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Stabilizer
        {
            get
            {
                return this.stabilizerField;
            }
            set
            {
                this.stabilizerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ChemicalPurity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ChemicalPurity
        {
            get
            {
                return this.chemicalPurityField;
            }
            set
            {
                this.chemicalPurityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ChemicalProperties", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ChemicalProperties
        {
            get
            {
                return this.chemicalPropertiesField;
            }
            set
            {
                this.chemicalPropertiesField = value;
            }
        }
    }
}
