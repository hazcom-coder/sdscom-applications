using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <summary>
    /// 
    /// </summary>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ComponentCompRestrictions
    {

        private ComponentCompRestrictionsEuRestrictions euRestrictionsField;

        private ComponentCompRestrictionsNationalRestrictions nationalRestrictionsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ComponentCompRestrictionsEuRestrictions EuRestrictions
        {
            get
            {
                return this.euRestrictionsField;
            }
            set
            {
                this.euRestrictionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ComponentCompRestrictionsNationalRestrictions NationalRestrictions
        {
            get
            {
                return this.nationalRestrictionsField;
            }
            set
            {
                this.nationalRestrictionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ComponentCompRestrictionsEuRestrictions
    {

        private AssessmentEnum assessedEuRestrictionsField;

        private bool assessedEuRestrictionsFieldSpecified;

        private Phrase[] restrictionAccordingReachField;

        private Phrase[] otherEuRestrictionsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AssessmentEnum AssessedEuRestrictions
        {
            get
            {
                return this.assessedEuRestrictionsField;
            }
            set
            {
                this.assessedEuRestrictionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AssessedEuRestrictionsSpecified
        {
            get
            {
                return this.assessedEuRestrictionsFieldSpecified;
            }
            set
            {
                this.assessedEuRestrictionsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RestrictionAccordingReach", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] RestrictionAccordingReach
        {
            get
            {
                return this.restrictionAccordingReachField;
            }
            set
            {
                this.restrictionAccordingReachField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OtherEuRestrictions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] OtherEuRestrictions
        {
            get
            {
                return this.otherEuRestrictionsField;
            }
            set
            {
                this.otherEuRestrictionsField = value;
            }
        }
    }


    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ComponentCompRestrictionsNationalRestrictions
    {

        private AssessmentEnum assessedNationalRestrictionsField;

        private bool assessedNationalRestrictionsFieldSpecified;

        private Phrase[] nationalRestrictionsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AssessmentEnum AssessedNationalRestrictions
        {
            get
            {
                return this.assessedNationalRestrictionsField;
            }
            set
            {
                this.assessedNationalRestrictionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AssessedNationalRestrictionsSpecified
        {
            get
            {
                return this.assessedNationalRestrictionsFieldSpecified;
            }
            set
            {
                this.assessedNationalRestrictionsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("NationalRestrictions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] NationalRestrictions
        {
            get
            {
                return this.nationalRestrictionsField;
            }
            set
            {
                this.nationalRestrictionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ComponentTransportInformation
    {
        private bool isDangerReleasingSubstanceAdrRidAdnField;

        private bool isDangerReleasingSubstanceAdrRidAdnFieldSpecified;

        private bool isDangerReleasingSubstanceImdgField;

        private bool isDangerReleasingSubstanceImdgFieldSpecified;

        private bool isDangerReleasingSubstanceIcaoField;

        private bool isDangerReleasingSubstanceIcaoFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool IsDangerReleasingSubstanceAdrRidAdn
        {
            get
            {
                return this.isDangerReleasingSubstanceAdrRidAdnField;
            }
            set
            {
                this.isDangerReleasingSubstanceAdrRidAdnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsDangerReleasingSubstanceAdrRidAdnSpecified
        {
            get
            {
                return this.isDangerReleasingSubstanceAdrRidAdnFieldSpecified;
            }
            set
            {
                this.isDangerReleasingSubstanceAdrRidAdnFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool IsDangerReleasingSubstanceImdg
        {
            get
            {
                return this.isDangerReleasingSubstanceImdgField;
            }
            set
            {
                this.isDangerReleasingSubstanceImdgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsDangerReleasingSubstanceImdgSpecified
        {
            get
            {
                return this.isDangerReleasingSubstanceImdgFieldSpecified;
            }
            set
            {
                this.isDangerReleasingSubstanceImdgFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool IsDangerReleasingSubstanceIcao
        {
            get
            {
                return this.isDangerReleasingSubstanceIcaoField;
            }
            set
            {
                this.isDangerReleasingSubstanceIcaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsDangerReleasingSubstanceIcaoSpecified
        {
            get
            {
                return this.isDangerReleasingSubstanceIcaoFieldSpecified;
            }
            set
            {
                this.isDangerReleasingSubstanceIcaoFieldSpecified = value;
            }
        }
    }


}
