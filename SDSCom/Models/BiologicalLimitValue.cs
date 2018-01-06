using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class BiologicalLimitValue
    {
        private ExposureLimitValueTypeEnum limitValueTypeWithCountryOrOrganisationField;

        private bool limitValueTypeWithCountryOrOrganisationFieldSpecified;

        private Phrase investigationParameterField;

        private UnitValue valueField;

        private Phrase testMaterialField;

        private System.DateTime testDateField;

        private bool testDateFieldSpecified;

        private Phrase referenceField;

        private Phrase recommendedMonitoringProcedureField;

        private Phrase[] commentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureLimitValueTypeEnum LimitValueTypeWithCountryOrOrganisation
        {
            get
            {
                return this.limitValueTypeWithCountryOrOrganisationField;
            }
            set
            {
                this.limitValueTypeWithCountryOrOrganisationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LimitValueTypeWithCountryOrOrganisationSpecified
        {
            get
            {
                return this.limitValueTypeWithCountryOrOrganisationFieldSpecified;
            }
            set
            {
                this.limitValueTypeWithCountryOrOrganisationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase InvestigationParameter
        {
            get
            {
                return this.investigationParameterField;
            }
            set
            {
                this.investigationParameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue Value
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
        public Phrase TestMaterial
        {
            get
            {
                return this.testMaterialField;
            }
            set
            {
                this.testMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime TestDate
        {
            get
            {
                return this.testDateField;
            }
            set
            {
                this.testDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TestDateSpecified
        {
            get
            {
                return this.testDateFieldSpecified;
            }
            set
            {
                this.testDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase RecommendedMonitoringProcedure
        {
            get
            {
                return this.recommendedMonitoringProcedureField;
            }
            set
            {
                this.recommendedMonitoringProcedureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Comments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }
    }
}
