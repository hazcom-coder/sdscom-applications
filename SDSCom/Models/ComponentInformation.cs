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
    public class ComponentInformation
    {

        private bool onLabelField;

        private bool isHazardousComponentField;

        private bool isHazardousComponentFieldSpecified;

        private bool includeOccupationalExposureLimitsField;

        private bool includeOccupationalExposureLimitsFieldSpecified;

        private bool includeBiologicalLimitValuesField;

        private bool includeBiologicalLimitValuesFieldSpecified;

        private bool isImpurityField;

        private bool isImpurityFieldSpecified;

        private bool isStabilizerField;

        private bool isStabilizerFieldSpecified;

        private bool includePhysicalValuesField;

        private bool includePhysicalValuesFieldSpecified;

        private bool includeToxicologicalValuesField;

        private bool includeToxicologicalValuesFieldSpecified;

        private bool includeEcoToxicologicalValuesField;

        private bool includeEcoToxicologicalValuesFieldSpecified;

        private Phrase[] compReasonForListedField;

        private ComponentInformationIdentifiedUse[] identifiedUseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool OnLabel
        {
            get
            {
                return this.onLabelField;
            }
            set
            {
                this.onLabelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool IsHazardousComponent
        {
            get
            {
                return this.isHazardousComponentField;
            }
            set
            {
                this.isHazardousComponentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsHazardousComponentSpecified
        {
            get
            {
                return this.isHazardousComponentFieldSpecified;
            }
            set
            {
                this.isHazardousComponentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool IncludeOccupationalExposureLimits
        {
            get
            {
                return this.includeOccupationalExposureLimitsField;
            }
            set
            {
                this.includeOccupationalExposureLimitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeOccupationalExposureLimitsSpecified
        {
            get
            {
                return this.includeOccupationalExposureLimitsFieldSpecified;
            }
            set
            {
                this.includeOccupationalExposureLimitsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool IncludeBiologicalLimitValues
        {
            get
            {
                return this.includeBiologicalLimitValuesField;
            }
            set
            {
                this.includeBiologicalLimitValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeBiologicalLimitValuesSpecified
        {
            get
            {
                return this.includeBiologicalLimitValuesFieldSpecified;
            }
            set
            {
                this.includeBiologicalLimitValuesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool IsImpurity
        {
            get
            {
                return this.isImpurityField;
            }
            set
            {
                this.isImpurityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsImpuritySpecified
        {
            get
            {
                return this.isImpurityFieldSpecified;
            }
            set
            {
                this.isImpurityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool IsStabilizer
        {
            get
            {
                return this.isStabilizerField;
            }
            set
            {
                this.isStabilizerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsStabilizerSpecified
        {
            get
            {
                return this.isStabilizerFieldSpecified;
            }
            set
            {
                this.isStabilizerFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool IncludePhysicalValues
        {
            get
            {
                return this.includePhysicalValuesField;
            }
            set
            {
                this.includePhysicalValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludePhysicalValuesSpecified
        {
            get
            {
                return this.includePhysicalValuesFieldSpecified;
            }
            set
            {
                this.includePhysicalValuesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool IncludeToxicologicalValues
        {
            get
            {
                return this.includeToxicologicalValuesField;
            }
            set
            {
                this.includeToxicologicalValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeToxicologicalValuesSpecified
        {
            get
            {
                return this.includeToxicologicalValuesFieldSpecified;
            }
            set
            {
                this.includeToxicologicalValuesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool IncludeEcoToxicologicalValues
        {
            get
            {
                return this.includeEcoToxicologicalValuesField;
            }
            set
            {
                this.includeEcoToxicologicalValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeEcoToxicologicalValuesSpecified
        {
            get
            {
                return this.includeEcoToxicologicalValuesFieldSpecified;
            }
            set
            {
                this.includeEcoToxicologicalValuesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("CompReasonForListed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] CompReasonForListed
        {
            get
            {
                return this.compReasonForListedField;
            }
            set
            {
                this.compReasonForListedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("IdentifiedUse", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ComponentInformationIdentifiedUse[] IdentifiedUse
        {
            get
            {
                return this.identifiedUseField;
            }
            set
            {
                this.identifiedUseField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ComponentInformationIdentifiedUse
    {

        private SectorOfUse[] sectorOfUseField;

        private ProductCategory[] productCategoryField;

        private ProcessCategory[] processCategoryField;

        private IdentifiedUseEnvironmentalReleaseCategory[] environmentalReleaseCategoryField;

        private IdentifiedUseSpecificEnvironmentalReleaseCategory[] specificEnvironmentalReleaseCategoryField;

        private ArticleCategory[] articleCategoryNoIntendedReleaseField;

        private ArticleCategory[] articleCategoryWithIntendedReleaseField;

        private CorrespondingEs[] correspondingExposureScenarioField;

        private string identifiedUseIdField;

        private bool printAsAttachmentField;

        /// <remarks/>
        public ComponentInformationIdentifiedUse()
        {
            this.identifiedUseIdField = "0";
            this.printAsAttachmentField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SectorOfUse", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SectorOfUse[] SectorOfUse
        {
            get
            {
                return this.sectorOfUseField;
            }
            set
            {
                this.sectorOfUseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProductCategory", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProductCategory[] ProductCategory
        {
            get
            {
                return this.productCategoryField;
            }
            set
            {
                this.productCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProcessCategory", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProcessCategory[] ProcessCategory
        {
            get
            {
                return this.processCategoryField;
            }
            set
            {
                this.processCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EnvironmentalReleaseCategory", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public IdentifiedUseEnvironmentalReleaseCategory[] EnvironmentalReleaseCategory
        {
            get
            {
                return this.environmentalReleaseCategoryField;
            }
            set
            {
                this.environmentalReleaseCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SpecificEnvironmentalReleaseCategory", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public IdentifiedUseSpecificEnvironmentalReleaseCategory[] SpecificEnvironmentalReleaseCategory
        {
            get
            {
                return this.specificEnvironmentalReleaseCategoryField;
            }
            set
            {
                this.specificEnvironmentalReleaseCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ArticleCategoryNoIntendedRelease", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ArticleCategory[] ArticleCategoryNoIntendedRelease
        {
            get
            {
                return this.articleCategoryNoIntendedReleaseField;
            }
            set
            {
                this.articleCategoryNoIntendedReleaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ArticleCategoryWithIntendedRelease", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ArticleCategory[] ArticleCategoryWithIntendedRelease
        {
            get
            {
                return this.articleCategoryWithIntendedReleaseField;
            }
            set
            {
                this.articleCategoryWithIntendedReleaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("CorrespondingExposureScenario", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CorrespondingEs[] CorrespondingExposureScenario
        {
            get
            {
                return this.correspondingExposureScenarioField;
            }
            set
            {
                this.correspondingExposureScenarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string IdentifiedUseId
        {
            get
            {
                return this.identifiedUseIdField;
            }
            set
            {
                this.identifiedUseIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool PrintAsAttachment
        {
            get
            {
                return this.printAsAttachmentField;
            }
            set
            {
                this.printAsAttachmentField = value;
            }
        }
    }
}
