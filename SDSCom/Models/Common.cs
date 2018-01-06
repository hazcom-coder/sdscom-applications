    namespace SDSCom.Models
    {
        /// <summary>
        /// 
        /// </summary>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class RegulationsRelatedToCountryOrRegion
        {
            private CountryCodeEnum regulationsRelatedToCountryOrRegionCodeField;

            private Phrase regulationsRelatedToCountryOrRegionNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public CountryCodeEnum RegulationsRelatedToCountryOrRegionCode
            {
                get
                {
                    return this.regulationsRelatedToCountryOrRegionCodeField;
                }
                set
                {
                    this.regulationsRelatedToCountryOrRegionCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase RegulationsRelatedToCountryOrRegionName
            {
                get
                {
                    return this.regulationsRelatedToCountryOrRegionNameField;
                }
                set
                {
                    this.regulationsRelatedToCountryOrRegionNameField = value;
                }
            }
        }

    /// <summary>
    /// 
    /// </summary>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class LegalDocument
        {
            private string legalDocumentFileNameField;

            private System.DateTime legalDocumentPrintDateField;

            private bool legalDocumentPrintDateFieldSpecified;

            private string legalDocumentSignatureField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string LegalDocumentFileName
            {
                get
                {
                    return this.legalDocumentFileNameField;
                }
                set
                {
                    this.legalDocumentFileNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
            public System.DateTime LegalDocumentPrintDate
            {
                get
                {
                    return this.legalDocumentPrintDateField;
                }
                set
                {
                    this.legalDocumentPrintDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool LegalDocumentPrintDateSpecified
            {
                get
                {
                    return this.legalDocumentPrintDateFieldSpecified;
                }
                set
                {
                    this.legalDocumentPrintDateFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string LegalDocumentSignature
            {
                get
                {
                    return this.legalDocumentSignatureField;
                }
                set
                {
                    this.legalDocumentSignatureField = value;
                }
            }
        }

    /// <summary>
    /// 
    /// </summary>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class Extension
        {
            private string extensionIssuerIdField;

            private string extensionNameField;

            private string extensionValueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string ExtensionIssuerId
            {
                get
                {
                    return this.extensionIssuerIdField;
                }
                set
                {
                    this.extensionIssuerIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string ExtensionName
            {
                get
                {
                    return this.extensionNameField;
                }
                set
                {
                    this.extensionNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string ExtensionValue
            {
                get
                {
                    return this.extensionValueField;
                }
                set
                {
                    this.extensionValueField = value;
                }
            }
        }

    /// <summary>
    /// 
    /// </summary>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class RelatedDocuments
        {
            private string fileNameField;

            private string descriptionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string FileName
            {
                get
                {
                    return this.fileNameField;
                }
                set
                {
                    this.fileNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }
        }

    /// <summary>
    /// 
    /// </summary>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class IdentificationSubstPrep
        {
            private System.DateTime issueDateField;

            private System.DateTime revisionDateField;

            private bool revisionDateFieldSpecified;

            private string versionNoField;

            private string specificationNoField;

            private string[] itemNoField;

            private ProductNo[] productNoField;

            private IdentificationSubstPrepProductIdentity[] productIdentityField;

            private InformationOnTheSds informationOnTheSdsField;

            private bool productDiscontinuedFromMarketField;

            private bool productDiscontinuedFromMarketFieldSpecified;

            private IdentificationSubstPrepRelevantIdentifiedUse relevantIdentifiedUseField;

            private IdentificationSubstPrepUseAdvisedAgainst useAdvisedAgainstField;

            private ChemicalUsedByTheGeneralPublic chemicalUsedByTheGeneralPublicField;

            private Phrase[] useOfChemicalCommentsField;

            private IdentificationSubstPrepSupplierInformation[] supplierInformationField;

            private EmergencyPhone[] emergencyPhoneField;

            private string internalSdsIdField;

            private Phrase[] identificationCommentsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
            public System.DateTime IssueDate
            {
                get
                {
                    return this.issueDateField;
                }
                set
                {
                    this.issueDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
            public System.DateTime RevisionDate
            {
                get
                {
                    return this.revisionDateField;
                }
                set
                {
                    this.revisionDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool RevisionDateSpecified
            {
                get
                {
                    return this.revisionDateFieldSpecified;
                }
                set
                {
                    this.revisionDateFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string VersionNo
            {
                get
                {
                    return this.versionNoField;
                }
                set
                {
                    this.versionNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string SpecificationNo
            {
                get
                {
                    return this.specificationNoField;
                }
                set
                {
                    this.specificationNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ItemNo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string[] ItemNo
            {
                get
                {
                    return this.itemNoField;
                }
                set
                {
                    this.itemNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ProductNo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public ProductNo[] ProductNo
            {
                get
                {
                    return this.productNoField;
                }
                set
                {
                    this.productNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ProductIdentity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public IdentificationSubstPrepProductIdentity[] ProductIdentity
            {
                get
                {
                    return this.productIdentityField;
                }
                set
                {
                    this.productIdentityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public InformationOnTheSds InformationOnTheSds
            {
                get
                {
                    return this.informationOnTheSdsField;
                }
                set
                {
                    this.informationOnTheSdsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool ProductDiscontinuedFromMarket
            {
                get
                {
                    return this.productDiscontinuedFromMarketField;
                }
                set
                {
                    this.productDiscontinuedFromMarketField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ProductDiscontinuedFromMarketSpecified
            {
                get
                {
                    return this.productDiscontinuedFromMarketFieldSpecified;
                }
                set
                {
                    this.productDiscontinuedFromMarketFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public IdentificationSubstPrepRelevantIdentifiedUse RelevantIdentifiedUse
            {
                get
                {
                    return this.relevantIdentifiedUseField;
                }
                set
                {
                    this.relevantIdentifiedUseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public IdentificationSubstPrepUseAdvisedAgainst UseAdvisedAgainst
            {
                get
                {
                    return this.useAdvisedAgainstField;
                }
                set
                {
                    this.useAdvisedAgainstField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public ChemicalUsedByTheGeneralPublic ChemicalUsedByTheGeneralPublic
            {
                get
                {
                    return this.chemicalUsedByTheGeneralPublicField;
                }
                set
                {
                    this.chemicalUsedByTheGeneralPublicField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("UseOfChemicalComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] UseOfChemicalComments
            {
                get
                {
                    return this.useOfChemicalCommentsField;
                }
                set
                {
                    this.useOfChemicalCommentsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("SupplierInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public IdentificationSubstPrepSupplierInformation[] SupplierInformation
            {
                get
                {
                    return this.supplierInformationField;
                }
                set
                {
                    this.supplierInformationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("EmergencyPhone", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public EmergencyPhone[] EmergencyPhone
            {
                get
                {
                    return this.emergencyPhoneField;
                }
                set
                {
                    this.emergencyPhoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string InternalSdsId
            {
                get
                {
                    return this.internalSdsIdField;
                }
                set
                {
                    this.internalSdsIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("IdentificationComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] IdentificationComments
            {
                get
                {
                    return this.identificationCommentsField;
                }
                set
                {
                    this.identificationCommentsField = value;
                }
            }
        }

    /// <summary>
    /// 
    /// </summary>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class ProductNo
        {

            private string userIdField;

            private string[] productNoUserField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string UserId
            {
                get
                {
                    return this.userIdField;
                }
                set
                {
                    this.userIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ProductNoUser", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string[] ProductNoUser
            {
                get
                {
                    return this.productNoUserField;
                }
                set
                {
                    this.productNoUserField = value;
                }
            }
        }

    /// <summary>
    /// 
    /// </summary>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class IdentificationSubstPrepProductIdentity
        {

            private string tradeNameField;

            private string[] synonymField;

            private ProductGtin[] productGtinField;

            private Phrase productDefinitionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string TradeName
            {
                get
                {
                    return this.tradeNameField;
                }
                set
                {
                    this.tradeNameField = value;
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
            [System.Xml.Serialization.XmlElement("ProductGtin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public ProductGtin[] ProductGtin
            {
                get
                {
                    return this.productGtinField;
                }
                set
                {
                    this.productGtinField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase ProductDefinition
            {
                get
                {
                    return this.productDefinitionField;
                }
                set
                {
                    this.productDefinitionField = value;
                }
            }
        }

    /// <summary>
    /// 
    /// </summary>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class InformationOnTheSds
        {

            private Phrase[] sdsNotLegallyRequiredField;

            private CompleteSdsWithEsIncorporated completeSdsWithEsIncorporatedField;

            private System.DateTime distributionStoppedDateField;

            private bool distributionStoppedDateFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("SdsNotLegallyRequired", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] SdsNotLegallyRequired
            {
                get
                {
                    return this.sdsNotLegallyRequiredField;
                }
                set
                {
                    this.sdsNotLegallyRequiredField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public CompleteSdsWithEsIncorporated CompleteSdsWithEsIncorporated
            {
                get
                {
                    return this.completeSdsWithEsIncorporatedField;
                }
                set
                {
                    this.completeSdsWithEsIncorporatedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
            public System.DateTime DistributionStoppedDate
            {
                get
                {
                    return this.distributionStoppedDateField;
                }
                set
                {
                    this.distributionStoppedDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool DistributionStoppedDateSpecified
            {
                get
                {
                    return this.distributionStoppedDateFieldSpecified;
                }
                set
                {
                    this.distributionStoppedDateFieldSpecified = value;
                }
            }
        }

    /// <summary>
    /// 
    /// </summary>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class CompleteSdsWithEsIncorporated
        {

            private bool extendedSdsWithEsIncorporatedField;

            private bool extendedSdsWithEsIncorporatedFieldSpecified;

            private Phrase[] extendedSdsWithEsIncorporatedCommentsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool ExtendedSdsWithEsIncorporated
            {
                get
                {
                    return this.extendedSdsWithEsIncorporatedField;
                }
                set
                {
                    this.extendedSdsWithEsIncorporatedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ExtendedSdsWithEsIncorporatedSpecified
            {
                get
                {
                    return this.extendedSdsWithEsIncorporatedFieldSpecified;
                }
                set
                {
                    this.extendedSdsWithEsIncorporatedFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ExtendedSdsWithEsIncorporatedComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ExtendedSdsWithEsIncorporatedComments
            {
                get
                {
                    return this.extendedSdsWithEsIncorporatedCommentsField;
                }
                set
                {
                    this.extendedSdsWithEsIncorporatedCommentsField = value;
                }
            }
        }

    /// <summary>
    /// 
    /// </summary>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class IdentificationSubstPrepRelevantIdentifiedUse
        {

            private IdentificationSubstPrepRelevantIdentifiedUseIdentifiedUse[] identifiedUseField;

            private Phrase[] productTypeField;

            private RelevantIdentifiedUseProductFunction[] productFunctionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("IdentifiedUse", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public IdentificationSubstPrepRelevantIdentifiedUseIdentifiedUse[] IdentifiedUse
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

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ProductType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ProductType
            {
                get
                {
                    return this.productTypeField;
                }
                set
                {
                    this.productTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ProductFunction", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public RelevantIdentifiedUseProductFunction[] ProductFunction
            {
                get
                {
                    return this.productFunctionField;
                }
                set
                {
                    this.productFunctionField = value;
                }
            }
        }

    /// <summary>
    /// 
    /// </summary>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class IdentificationSubstPrepRelevantIdentifiedUseIdentifiedUse
        {

            private SectorOfUse[] sectorOfUseField;

            private ProductCategory[] productCategoryField;

            private ProcessCategory[] processCategoryField;

            private EnvironmentalReleaseCategory[] environmentalReleaseCategoryField;

            private SpecificEnvironmentalReleaseCategory[] specificEnvironmentalReleaseCategoryField;

            private ArticleCategory[] articleCategoryNoIntendedReleaseField;

            private ArticleCategory[] articleCategoryWithIntendedReleaseField;

            private CorrespondingEs[] correspondingExposureScenarioField;

            private string identifiedUseIdField;

            private bool printAsAttachmentField;

            /// <remarks/>
            public IdentificationSubstPrepRelevantIdentifiedUseIdentifiedUse()
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
            public EnvironmentalReleaseCategory[] EnvironmentalReleaseCategory
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
            public SpecificEnvironmentalReleaseCategory[] SpecificEnvironmentalReleaseCategory
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

        /// <remarks/>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class EnvironmentalReleaseCategory
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

    /// <summary>
    /// 
    /// </summary>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class SpecificEnvironmentalReleaseCategory
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


        /// <remarks/>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class RelevantIdentifiedUseProductFunction
        {

            private Phrase[] productFunctionDescriptionField;

            private Phrase[] productFunctionCodeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ProductFunctionDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ProductFunctionDescription
            {
                get
                {
                    return this.productFunctionDescriptionField;
                }
                set
                {
                    this.productFunctionDescriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ProductFunctionCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ProductFunctionCode
            {
                get
                {
                    return this.productFunctionCodeField;
                }
                set
                {
                    this.productFunctionCodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class IdentificationSubstPrepUseAdvisedAgainst
        {

            private UseAdvisedAgainstNotToBeUsedIn[] notToBeUsedInField;

            private Phrase[] otherUseAdvisedAgainstField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("NotToBeUsedIn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public UseAdvisedAgainstNotToBeUsedIn[] NotToBeUsedIn
            {
                get
                {
                    return this.notToBeUsedInField;
                }
                set
                {
                    this.notToBeUsedInField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("OtherUseAdvisedAgainst", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] OtherUseAdvisedAgainst
            {
                get
                {
                    return this.otherUseAdvisedAgainstField;
                }
                set
                {
                    this.otherUseAdvisedAgainstField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class UseAdvisedAgainstNotToBeUsedIn
        {

            private SectorOfUse[] sectorOfUseField;

            private ProductCategory[] productCategoryField;

            private ProcessCategory[] processCategoryField;

            private ArticleCategory[] articleCategoryNoIntendedReleaseField;

            private ArticleCategory[] articleCategoryWithIntendedReleaseField;

            private string identifiedUseIdField;

            private bool printAsAttachmentField;

        /// <remarks/>
        public UseAdvisedAgainstNotToBeUsedIn()
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


        /// <remarks/>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class ChemicalUsedByTheGeneralPublic
        {

            private bool canBeUsedByTheGeneralPublicField;

            private bool canBeUsedByTheGeneralPublicFieldSpecified;

            private bool usedByTheGeneralPublicOnlyField;

            private bool usedByTheGeneralPublicOnlyFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool CanBeUsedByTheGeneralPublic
            {
                get
                {
                    return this.canBeUsedByTheGeneralPublicField;
                }
                set
                {
                    this.canBeUsedByTheGeneralPublicField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool CanBeUsedByTheGeneralPublicSpecified
            {
                get
                {
                    return this.canBeUsedByTheGeneralPublicFieldSpecified;
                }
                set
                {
                    this.canBeUsedByTheGeneralPublicFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool UsedByTheGeneralPublicOnly
            {
                get
                {
                    return this.usedByTheGeneralPublicOnlyField;
                }
                set
                {
                    this.usedByTheGeneralPublicOnlyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool UsedByTheGeneralPublicOnlySpecified
            {
                get
                {
                    return this.usedByTheGeneralPublicOnlyFieldSpecified;
                }
                set
                {
                    this.usedByTheGeneralPublicOnlyFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class IdentificationSubstPrepSupplierInformation
        {

            private SupplierInformationRole roleField;

            private CountryCodeEnum countryField;

            private bool countryFieldSpecified;

            private string nameField;

            private SupplierInformationAddress addressField;

            private string[] phoneField;

            private string[] faxField;

            private string[] emailField;

            private string companyUrlField;

            private SupplierInformationCompanyContact[] companyContactField;

            private string legalRegistrationNoField;

            private string dunsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public SupplierInformationRole Role
            {
                get
                {
                    return this.roleField;
                }
                set
                {
                    this.roleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public CountryCodeEnum Country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool CountrySpecified
            {
                get
                {
                    return this.countryFieldSpecified;
                }
                set
                {
                    this.countryFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public SupplierInformationAddress Address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("Phone", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string[] Phone
            {
                get
                {
                    return this.phoneField;
                }
                set
                {
                    this.phoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("Fax", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string[] Fax
            {
                get
                {
                    return this.faxField;
                }
                set
                {
                    this.faxField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("Email", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string[] Email
            {
                get
                {
                    return this.emailField;
                }
                set
                {
                    this.emailField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string CompanyUrl
            {
                get
                {
                    return this.companyUrlField;
                }
                set
                {
                    this.companyUrlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("CompanyContact", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public SupplierInformationCompanyContact[] CompanyContact
            {
                get
                {
                    return this.companyContactField;
                }
                set
                {
                    this.companyContactField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string LegalRegistrationNo
            {
                get
                {
                    return this.legalRegistrationNoField;
                }
                set
                {
                    this.legalRegistrationNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string Duns
            {
                get
                {
                    return this.dunsField;
                }
                set
                {
                    this.dunsField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class SupplierInformationRole
        {

            private RoleDescriptionEnum roleCodeField;

            private bool roleCodeFieldSpecified;

            private ReachRoleDescriptionEnum reachRoleField;

            private bool reachRoleFieldSpecified;

            private Phrase roleDescriptionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public RoleDescriptionEnum RoleCode
            {
                get
                {
                    return this.roleCodeField;
                }
                set
                {
                    this.roleCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool RoleCodeSpecified
            {
                get
                {
                    return this.roleCodeFieldSpecified;
                }
                set
                {
                    this.roleCodeFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public ReachRoleDescriptionEnum ReachRole
            {
                get
                {
                    return this.reachRoleField;
                }
                set
                {
                    this.reachRoleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ReachRoleSpecified
            {
                get
                {
                    return this.reachRoleFieldSpecified;
                }
                set
                {
                    this.reachRoleFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase RoleDescription
            {
                get
                {
                    return this.roleDescriptionField;
                }
                set
                {
                    this.roleDescriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class SupplierInformationAddress
        {

            private string visitingAddressLine1Field;

            private string visitingAddressLine2Field;

            private string visitingAddressLine3Field;

            private string visitingAddressPostCodeField;

            private string visitingAddressCityField;

            private string visitingCountryField;

            private string postAddressLine1Field;

            private string postAddressLine2Field;

            private string postAddressLine3Field;

            private string postCodeField;

            private string postCityField;

            private string postCountryField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string VisitingAddressLine1
            {
                get
                {
                    return this.visitingAddressLine1Field;
                }
                set
                {
                    this.visitingAddressLine1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string VisitingAddressLine2
            {
                get
                {
                    return this.visitingAddressLine2Field;
                }
                set
                {
                    this.visitingAddressLine2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string VisitingAddressLine3
            {
                get
                {
                    return this.visitingAddressLine3Field;
                }
                set
                {
                    this.visitingAddressLine3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string VisitingAddressPostCode
            {
                get
                {
                    return this.visitingAddressPostCodeField;
                }
                set
                {
                    this.visitingAddressPostCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string VisitingAddressCity
            {
                get
                {
                    return this.visitingAddressCityField;
                }
                set
                {
                    this.visitingAddressCityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string VisitingCountry
            {
                get
                {
                    return this.visitingCountryField;
                }
                set
                {
                    this.visitingCountryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string PostAddressLine1
            {
                get
                {
                    return this.postAddressLine1Field;
                }
                set
                {
                    this.postAddressLine1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string PostAddressLine2
            {
                get
                {
                    return this.postAddressLine2Field;
                }
                set
                {
                    this.postAddressLine2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string PostAddressLine3
            {
                get
                {
                    return this.postAddressLine3Field;
                }
                set
                {
                    this.postAddressLine3Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string PostCode
            {
                get
                {
                    return this.postCodeField;
                }
                set
                {
                    this.postCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string PostCity
            {
                get
                {
                    return this.postCityField;
                }
                set
                {
                    this.postCityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string PostCountry
            {
                get
                {
                    return this.postCountryField;
                }
                set
                {
                    this.postCountryField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class SupplierInformationCompanyContact
        {

            private string nameField;

            private string phoneField;

            private string faxField;

            private string urlField;

            private string emailField;

            private string nationalContactField;

            private string emailCompetentPersonField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string Phone
            {
                get
                {
                    return this.phoneField;
                }
                set
                {
                    this.phoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string Fax
            {
                get
                {
                    return this.faxField;
                }
                set
                {
                    this.faxField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string Url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string Email
            {
                get
                {
                    return this.emailField;
                }
                set
                {
                    this.emailField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string NationalContact
            {
                get
                {
                    return this.nationalContactField;
                }
                set
                {
                    this.nationalContactField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string EmailCompetentPerson
            {
                get
                {
                    return this.emailCompetentPersonField;
                }
                set
                {
                    this.emailCompetentPersonField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class EmergencyPhone
        {

            private string noField;

            private Phrase[] emergencyPhoneDescriptionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string No
            {
                get
                {
                    return this.noField;
                }
                set
                {
                    this.noField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("EmergencyPhoneDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] EmergencyPhoneDescription
            {
                get
                {
                    return this.emergencyPhoneDescriptionField;
                }
                set
                {
                    this.emergencyPhoneDescriptionField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class HazardIdentification
        {

            private Classification classificationField;

            private HazardIdentificationHazardLabelling hazardLabellingField;

            private OtherHazardsInfo otherHazardsInfoField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Classification Classification
            {
                get
                {
                    return this.classificationField;
                }
                set
                {
                    this.classificationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public HazardIdentificationHazardLabelling HazardLabelling
            {
                get
                {
                    return this.hazardLabellingField;
                }
                set
                {
                    this.hazardLabellingField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public OtherHazardsInfo OtherHazardsInfo
            {
                get
                {
                    return this.otherHazardsInfoField;
                }
                set
                {
                    this.otherHazardsInfoField = value;
                }
            }
        }

    /// <remarks/>

    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class HazardIdentificationHazardLabelling
        {

            private ClpLabellingInfo clpLabellingInfoField;

            private DpdDsdHazardLabelling dpdDsdHazardLabellingField;

            private Phrase[] additionalInformationField;

            private bool ecLabelField;

            private bool ecLabelFieldSpecified;

            private bool tactileWarningField;

            private bool tactileWarningFieldSpecified;

            private bool childResistantOpeningField;

            private bool childResistantOpeningFieldSpecified;

            private LabellingAccordingToOtherEuLegislation labellingAccordingToOtherEuLegislationField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public ClpLabellingInfo ClpLabellingInfo
            {
                get
                {
                    return this.clpLabellingInfoField;
                }
                set
                {
                    this.clpLabellingInfoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public DpdDsdHazardLabelling DpdDsdHazardLabelling
            {
                get
                {
                    return this.dpdDsdHazardLabellingField;
                }
                set
                {
                    this.dpdDsdHazardLabellingField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("AdditionalInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] AdditionalInformation
            {
                get
                {
                    return this.additionalInformationField;
                }
                set
                {
                    this.additionalInformationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool EcLabel
            {
                get
                {
                    return this.ecLabelField;
                }
                set
                {
                    this.ecLabelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool EcLabelSpecified
            {
                get
                {
                    return this.ecLabelFieldSpecified;
                }
                set
                {
                    this.ecLabelFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool TactileWarning
            {
                get
                {
                    return this.tactileWarningField;
                }
                set
                {
                    this.tactileWarningField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool TactileWarningSpecified
            {
                get
                {
                    return this.tactileWarningFieldSpecified;
                }
                set
                {
                    this.tactileWarningFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool ChildResistantOpening
            {
                get
                {
                    return this.childResistantOpeningField;
                }
                set
                {
                    this.childResistantOpeningField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ChildResistantOpeningSpecified
            {
                get
                {
                    return this.childResistantOpeningFieldSpecified;
                }
                set
                {
                    this.childResistantOpeningFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public LabellingAccordingToOtherEuLegislation LabellingAccordingToOtherEuLegislation
            {
                get
                {
                    return this.labellingAccordingToOtherEuLegislationField;
                }
                set
                {
                    this.labellingAccordingToOtherEuLegislationField = value;
                }
            }
        }

    /// <remarks/>

    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class ClpLabellingInfo
        {

            private HazardPictogram[] clpHazardPictogramField;

            private SignalWord clpSignalWordField;

            private HazardStatement[] clpHazardStatementField;

            private PrecautionaryStatement[] clpPrecautionaryStatementField;

            private SupplementalHazardInformation[] clpSupplementalHazardInformationField;

            private SpecialSupplementalLabelInfo[] clpSpecialSupplementalLabelInfoMixturesField;

            private Phrase[] clpAdditionalLabellingInfoField;

            private Phrase[] clpSpecialRulesOnPackagingField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ClpHazardPictogram", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public HazardPictogram[] ClpHazardPictogram
            {
                get
                {
                    return this.clpHazardPictogramField;
                }
                set
                {
                    this.clpHazardPictogramField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public SignalWord ClpSignalWord
            {
                get
                {
                    return this.clpSignalWordField;
                }
                set
                {
                    this.clpSignalWordField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ClpHazardStatement", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public HazardStatement[] ClpHazardStatement
            {
                get
                {
                    return this.clpHazardStatementField;
                }
                set
                {
                    this.clpHazardStatementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ClpPrecautionaryStatement", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public PrecautionaryStatement[] ClpPrecautionaryStatement
            {
                get
                {
                    return this.clpPrecautionaryStatementField;
                }
                set
                {
                    this.clpPrecautionaryStatementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ClpSupplementalHazardInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public SupplementalHazardInformation[] ClpSupplementalHazardInformation
            {
                get
                {
                    return this.clpSupplementalHazardInformationField;
                }
                set
                {
                    this.clpSupplementalHazardInformationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ClpSpecialSupplementalLabelInfoMixtures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public SpecialSupplementalLabelInfo[] ClpSpecialSupplementalLabelInfoMixtures
            {
                get
                {
                    return this.clpSpecialSupplementalLabelInfoMixturesField;
                }
                set
                {
                    this.clpSpecialSupplementalLabelInfoMixturesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ClpAdditionalLabellingInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ClpAdditionalLabellingInfo
            {
                get
                {
                    return this.clpAdditionalLabellingInfoField;
                }
                set
                {
                    this.clpAdditionalLabellingInfoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ClpSpecialRulesOnPackaging", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ClpSpecialRulesOnPackaging
            {
                get
                {
                    return this.clpSpecialRulesOnPackagingField;
                }
                set
                {
                    this.clpSpecialRulesOnPackagingField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class DpdDsdHazardLabelling
        {

            private HazardSymbolCodeEnum[] dpdDsdHazardSymbolField;

            private RiskPhrase[] dpdDsdRiskPhraseField;

            private SafetyPhrase[] dpdDsdSafetyPhraseField;

            private Phrase[] dpdDsdOtherLabellingInformationField;

            private Phrase[] dpdDsdStandardPhrasesForSpecialRisksField;

            private Phrase[] dpdDsdStandardPhrasesForSafetyPrecautionsField;

            private Phrase[] dpdDsdLabellingCommentsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("DpdDsdHazardSymbol", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public HazardSymbolCodeEnum[] DpdDsdHazardSymbol
            {
                get
                {
                    return this.dpdDsdHazardSymbolField;
                }
                set
                {
                    this.dpdDsdHazardSymbolField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("DpdDsdRiskPhrase", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public RiskPhrase[] DpdDsdRiskPhrase
            {
                get
                {
                    return this.dpdDsdRiskPhraseField;
                }
                set
                {
                    this.dpdDsdRiskPhraseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("DpdDsdSafetyPhrase", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public SafetyPhrase[] DpdDsdSafetyPhrase
            {
                get
                {
                    return this.dpdDsdSafetyPhraseField;
                }
                set
                {
                    this.dpdDsdSafetyPhraseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("DpdDsdOtherLabellingInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] DpdDsdOtherLabellingInformation
            {
                get
                {
                    return this.dpdDsdOtherLabellingInformationField;
                }
                set
                {
                    this.dpdDsdOtherLabellingInformationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("DpdDsdStandardPhrasesForSpecialRisks", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] DpdDsdStandardPhrasesForSpecialRisks
            {
                get
                {
                    return this.dpdDsdStandardPhrasesForSpecialRisksField;
                }
                set
                {
                    this.dpdDsdStandardPhrasesForSpecialRisksField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("DpdDsdStandardPhrasesForSafetyPrecautions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] DpdDsdStandardPhrasesForSafetyPrecautions
            {
                get
                {
                    return this.dpdDsdStandardPhrasesForSafetyPrecautionsField;
                }
                set
                {
                    this.dpdDsdStandardPhrasesForSafetyPrecautionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("DpdDsdLabellingComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] DpdDsdLabellingComments
            {
                get
                {
                    return this.dpdDsdLabellingCommentsField;
                }
                set
                {
                    this.dpdDsdLabellingCommentsField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class LabellingAccordingToOtherEuLegislation
        {

            private LabellingAccordingToOtherEuLegislationVocLabelling[] vocLabellingField;

            private Phrase[] detergentLabellingField;

            private Phrase[] aerosolLabellingField;

            private Phrase[] otherEuLabellingRequirementsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("VocLabelling", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public LabellingAccordingToOtherEuLegislationVocLabelling[] VocLabelling
            {
                get
                {
                    return this.vocLabellingField;
                }
                set
                {
                    this.vocLabellingField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("DetergentLabelling", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] DetergentLabelling
            {
                get
                {
                    return this.detergentLabellingField;
                }
                set
                {
                    this.detergentLabellingField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("AerosolLabelling", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] AerosolLabelling
            {
                get
                {
                    return this.aerosolLabellingField;
                }
                set
                {
                    this.aerosolLabellingField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("OtherEuLabellingRequirements", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] OtherEuLabellingRequirements
            {
                get
                {
                    return this.otherEuLabellingRequirementsField;
                }
                set
                {
                    this.otherEuLabellingRequirementsField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class LabellingAccordingToOtherEuLegislationVocLabelling
        {

            private Phrase productSubcategoryField;

            private UnitValue vocLimitForSubcategoryField;

            private UnitValue maxVocConcInMixtureField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase ProductSubcategory
            {
                get
                {
                    return this.productSubcategoryField;
                }
                set
                {
                    this.productSubcategoryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public UnitValue VocLimitForSubcategory
            {
                get
                {
                    return this.vocLimitForSubcategoryField;
                }
                set
                {
                    this.vocLimitForSubcategoryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public UnitValue MaxVocConcInMixture
            {
                get
                {
                    return this.maxVocConcInMixtureField;
                }
                set
                {
                    this.maxVocConcInMixtureField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class OtherHazardsInfo
        {

            private Phrase[] hazardDescriptionGeneralField;

            private Phrase[] physicochemicalEffectField;

            private Phrase[] healthEffectField;

            private Phrase[] environmentalEffectField;

            private Phrase[] effectsOfMisuseField;

            private Phrase[] otherHazardsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("HazardDescriptionGeneral", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] HazardDescriptionGeneral
            {
                get
                {
                    return this.hazardDescriptionGeneralField;
                }
                set
                {
                    this.hazardDescriptionGeneralField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("PhysicochemicalEffect", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] PhysicochemicalEffect
            {
                get
                {
                    return this.physicochemicalEffectField;
                }
                set
                {
                    this.physicochemicalEffectField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("HealthEffect", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] HealthEffect
            {
                get
                {
                    return this.healthEffectField;
                }
                set
                {
                    this.healthEffectField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("EnvironmentalEffect", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] EnvironmentalEffect
            {
                get
                {
                    return this.environmentalEffectField;
                }
                set
                {
                    this.environmentalEffectField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("EffectsOfMisuse", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] EffectsOfMisuse
            {
                get
                {
                    return this.effectsOfMisuseField;
                }
                set
                {
                    this.effectsOfMisuseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("OtherHazards", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] OtherHazards
            {
                get
                {
                    return this.otherHazardsField;
                }
                set
                {
                    this.otherHazardsField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class Composition
        {

            private object itemField;

            private Phrase[] compositionCommentsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("Mixture", typeof(CompositionMixture), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            [System.Xml.Serialization.XmlElement("Substance", typeof(Substance), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public object Item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("CompositionComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] CompositionComments
            {
                get
                {
                    return this.compositionCommentsField;
                }
                set
                {
                    this.compositionCommentsField = value;
                }
            }
        }
    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class CompositionMixture
        {

            private Component[] componentField;

            private Phrase[] descriptionOfTheMixtureField;

            private Phrase[] compositionCommentsField;

            private bool isDetergentField;

            private bool isDetergentFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("Component", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Component[] Component
            {
                get
                {
                    return this.componentField;
                }
                set
                {
                    this.componentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("DescriptionOfTheMixture", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] DescriptionOfTheMixture
            {
                get
                {
                    return this.descriptionOfTheMixtureField;
                }
                set
                {
                    this.descriptionOfTheMixtureField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("CompositionComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] CompositionComments
            {
                get
                {
                    return this.compositionCommentsField;
                }
                set
                {
                    this.compositionCommentsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool IsDetergent
            {
                get
                {
                    return this.isDetergentField;
                }
                set
                {
                    this.isDetergentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool IsDetergentSpecified
            {
                get
                {
                    return this.isDetergentFieldSpecified;
                }
                set
                {
                    this.isDetergentFieldSpecified = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class FirstAidMeasures
        {

            private DescriptionOfFirstAidMeasures descriptionOfFirstAidMeasuresField;

            private InformationToHealthProfessionals informationToHealthProfessionalsField;

            private MedicalAttentionAndSpecialTreatmentNeeded medicalAttentionAndSpecialTreatmentNeededField;

            private Phrase[] specificFirstAidEquipmentField;

            private Phrase[] firstAidCommentsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public DescriptionOfFirstAidMeasures DescriptionOfFirstAidMeasures
            {
                get
                {
                    return this.descriptionOfFirstAidMeasuresField;
                }
                set
                {
                    this.descriptionOfFirstAidMeasuresField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public InformationToHealthProfessionals InformationToHealthProfessionals
            {
                get
                {
                    return this.informationToHealthProfessionalsField;
                }
                set
                {
                    this.informationToHealthProfessionalsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public MedicalAttentionAndSpecialTreatmentNeeded MedicalAttentionAndSpecialTreatmentNeeded
            {
                get
                {
                    return this.medicalAttentionAndSpecialTreatmentNeededField;
                }
                set
                {
                    this.medicalAttentionAndSpecialTreatmentNeededField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("SpecificFirstAidEquipment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] SpecificFirstAidEquipment
            {
                get
                {
                    return this.specificFirstAidEquipmentField;
                }
                set
                {
                    this.specificFirstAidEquipmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("FirstAidComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] FirstAidComments
            {
                get
                {
                    return this.firstAidCommentsField;
                }
                set
                {
                    this.firstAidCommentsField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class DescriptionOfFirstAidMeasures
        {

            private Phrase[] generalInformationField;

            private Phrase[] firstAidInhalationField;

            private Phrase[] firstAidSkinField;

            private Phrase[] firstAidEyeField;

            private Phrase[] firstAidIngestionField;

            private Phrase[] personalProtectionFirstAiderField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("GeneralInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] GeneralInformation
            {
                get
                {
                    return this.generalInformationField;
                }
                set
                {
                    this.generalInformationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("FirstAidInhalation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] FirstAidInhalation
            {
                get
                {
                    return this.firstAidInhalationField;
                }
                set
                {
                    this.firstAidInhalationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("FirstAidSkin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] FirstAidSkin
            {
                get
                {
                    return this.firstAidSkinField;
                }
                set
                {
                    this.firstAidSkinField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("FirstAidEye", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] FirstAidEye
            {
                get
                {
                    return this.firstAidEyeField;
                }
                set
                {
                    this.firstAidEyeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("FirstAidIngestion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] FirstAidIngestion
            {
                get
                {
                    return this.firstAidIngestionField;
                }
                set
                {
                    this.firstAidIngestionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("PersonalProtectionFirstAider", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] PersonalProtectionFirstAider
            {
                get
                {
                    return this.personalProtectionFirstAiderField;
                }
                set
                {
                    this.personalProtectionFirstAiderField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class InformationToHealthProfessionals
        {

            private Phrase[] symptomsAndEffectsGeneralField;

            private Phrase[] acuteSymptomsAndEffectsField;

            private Phrase[] delayedSymptomsAndEffectsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("SymptomsAndEffectsGeneral", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] SymptomsAndEffectsGeneral
            {
                get
                {
                    return this.symptomsAndEffectsGeneralField;
                }
                set
                {
                    this.symptomsAndEffectsGeneralField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("AcuteSymptomsAndEffects", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] AcuteSymptomsAndEffects
            {
                get
                {
                    return this.acuteSymptomsAndEffectsField;
                }
                set
                {
                    this.acuteSymptomsAndEffectsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("DelayedSymptomsAndEffects", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] DelayedSymptomsAndEffects
            {
                get
                {
                    return this.delayedSymptomsAndEffectsField;
                }
                set
                {
                    this.delayedSymptomsAndEffectsField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class MedicalAttentionAndSpecialTreatmentNeeded
        {

            private Phrase[] medicalTreatmentField;

            private Phrase[] requiredClinicalTestingField;

            private Phrase[] requiredMedicalMonitoringField;

            private Phrase[] specificAntidotesField;

            private Phrase[] contraindicationsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("MedicalTreatment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] MedicalTreatment
            {
                get
                {
                    return this.medicalTreatmentField;
                }
                set
                {
                    this.medicalTreatmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("RequiredClinicalTesting", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] RequiredClinicalTesting
            {
                get
                {
                    return this.requiredClinicalTestingField;
                }
                set
                {
                    this.requiredClinicalTestingField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("RequiredMedicalMonitoring", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] RequiredMedicalMonitoring
            {
                get
                {
                    return this.requiredMedicalMonitoringField;
                }
                set
                {
                    this.requiredMedicalMonitoringField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("SpecificAntidotes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] SpecificAntidotes
            {
                get
                {
                    return this.specificAntidotesField;
                }
                set
                {
                    this.specificAntidotesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("Contraindications", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] Contraindications
            {
                get
                {
                    return this.contraindicationsField;
                }
                set
                {
                    this.contraindicationsField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class FireFightingMeasures
        {

            private ExtinguishingMedia extinguishingMediaField;

            private Phrase[] fireAndExplosionHazardsField;

            private Phrase[] hazardCombustionProdField;

            private Phrase[] fireFightingPrecautionsField;

            private Phrase[] fireFightingProceduresField;

            private Phrase[] specialProtectiveEquipmentForFirefightersField;

            private Phrase[] fireAndExplosionCommentsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public ExtinguishingMedia ExtinguishingMedia
            {
                get
                {
                    return this.extinguishingMediaField;
                }
                set
                {
                    this.extinguishingMediaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("FireAndExplosionHazards", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] FireAndExplosionHazards
            {
                get
                {
                    return this.fireAndExplosionHazardsField;
                }
                set
                {
                    this.fireAndExplosionHazardsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("HazardCombustionProd", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] HazardCombustionProd
            {
                get
                {
                    return this.hazardCombustionProdField;
                }
                set
                {
                    this.hazardCombustionProdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("FireFightingPrecautions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] FireFightingPrecautions
            {
                get
                {
                    return this.fireFightingPrecautionsField;
                }
                set
                {
                    this.fireFightingPrecautionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("FireFightingProcedures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] FireFightingProcedures
            {
                get
                {
                    return this.fireFightingProceduresField;
                }
                set
                {
                    this.fireFightingProceduresField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("SpecialProtectiveEquipmentForFirefighters", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] SpecialProtectiveEquipmentForFirefighters
            {
                get
                {
                    return this.specialProtectiveEquipmentForFirefightersField;
                }
                set
                {
                    this.specialProtectiveEquipmentForFirefightersField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("FireAndExplosionComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] FireAndExplosionComments
            {
                get
                {
                    return this.fireAndExplosionCommentsField;
                }
                set
                {
                    this.fireAndExplosionCommentsField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class ExtinguishingMedia
        {

            private Phrase[] mediaToBeUsedField;

            private Phrase[] mediaNotBeUsedField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("MediaToBeUsed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] MediaToBeUsed
            {
                get
                {
                    return this.mediaToBeUsedField;
                }
                set
                {
                    this.mediaToBeUsedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("MediaNotBeUsed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] MediaNotBeUsed
            {
                get
                {
                    return this.mediaNotBeUsedField;
                }
                set
                {
                    this.mediaNotBeUsedField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class AccidentalReleaseMeasures
        {

            private Phrase[] generalMeasuresField;

            private ForNonEmergencyPersonnel forNonEmergencyPersonnelField;

            private Phrase[] forEmergencyRespondersField;

            private Phrase[] environmentalPrecautionsField;

            private ContainmentAndCleaningUp containmentAndCleaningUpField;

            private Phrase[] referenceToOtherSectionsField;

            private Phrase[] additionalInformationField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("GeneralMeasures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] GeneralMeasures
            {
                get
                {
                    return this.generalMeasuresField;
                }
                set
                {
                    this.generalMeasuresField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public ForNonEmergencyPersonnel ForNonEmergencyPersonnel
            {
                get
                {
                    return this.forNonEmergencyPersonnelField;
                }
                set
                {
                    this.forNonEmergencyPersonnelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ForEmergencyResponders", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ForEmergencyResponders
            {
                get
                {
                    return this.forEmergencyRespondersField;
                }
                set
                {
                    this.forEmergencyRespondersField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("EnvironmentalPrecautions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] EnvironmentalPrecautions
            {
                get
                {
                    return this.environmentalPrecautionsField;
                }
                set
                {
                    this.environmentalPrecautionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public ContainmentAndCleaningUp ContainmentAndCleaningUp
            {
                get
                {
                    return this.containmentAndCleaningUpField;
                }
                set
                {
                    this.containmentAndCleaningUpField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ReferenceToOtherSections", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ReferenceToOtherSections
            {
                get
                {
                    return this.referenceToOtherSectionsField;
                }
                set
                {
                    this.referenceToOtherSectionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("AdditionalInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] AdditionalInformation
            {
                get
                {
                    return this.additionalInformationField;
                }
                set
                {
                    this.additionalInformationField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class ForNonEmergencyPersonnel
        {

            private Phrase[] personalPrecautionsField;

            private Phrase[] protectiveEquipmentField;

            private Phrase[] emergencyProceduresField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("PersonalPrecautions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] PersonalPrecautions
            {
                get
                {
                    return this.personalPrecautionsField;
                }
                set
                {
                    this.personalPrecautionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ProtectiveEquipment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ProtectiveEquipment
            {
                get
                {
                    return this.protectiveEquipmentField;
                }
                set
                {
                    this.protectiveEquipmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("EmergencyProcedures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] EmergencyProcedures
            {
                get
                {
                    return this.emergencyProceduresField;
                }
                set
                {
                    this.emergencyProceduresField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class ContainmentAndCleaningUp
        {

            private Phrase[] containmentField;

            private Phrase[] cleaningUpField;

            private Phrase[] otherInformationField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("Containment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] Containment
            {
                get
                {
                    return this.containmentField;
                }
                set
                {
                    this.containmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("CleaningUp", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] CleaningUp
            {
                get
                {
                    return this.cleaningUpField;
                }
                set
                {
                    this.cleaningUpField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("OtherInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] OtherInformation
            {
                get
                {
                    return this.otherInformationField;
                }
                set
                {
                    this.otherInformationField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class HandlingAndStorage
        {

            private SafeHandling safeHandlingField;

            private Phrase[] storagePrecautionsField;

            private Phrase[] conditionsToAvoidField;

            private ConditionsForSafeStorage conditionsForSafeStorageField;

            private SpecificEndUses specificEndUsesField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public SafeHandling SafeHandling
            {
                get
                {
                    return this.safeHandlingField;
                }
                set
                {
                    this.safeHandlingField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("StoragePrecautions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] StoragePrecautions
            {
                get
                {
                    return this.storagePrecautionsField;
                }
                set
                {
                    this.storagePrecautionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ConditionsToAvoid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ConditionsToAvoid
            {
                get
                {
                    return this.conditionsToAvoidField;
                }
                set
                {
                    this.conditionsToAvoidField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public ConditionsForSafeStorage ConditionsForSafeStorage
            {
                get
                {
                    return this.conditionsForSafeStorageField;
                }
                set
                {
                    this.conditionsForSafeStorageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public SpecificEndUses SpecificEndUses
            {
                get
                {
                    return this.specificEndUsesField;
                }
                set
                {
                    this.specificEndUsesField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class SafeHandling
        {

            private Phrase[] handlingPrecautionsField;

            private Phrase[] safeHandlingOfGasContainersField;

            private PrecautionaryMeasures precautionaryMeasuresField;

            private Phrase[] furtherInformationField;

            private Phrase[] commentsField;

            private Phrase[] generalOccupationalHygieneField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("HandlingPrecautions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] HandlingPrecautions
            {
                get
                {
                    return this.handlingPrecautionsField;
                }
                set
                {
                    this.handlingPrecautionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("SafeHandlingOfGasContainers", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] SafeHandlingOfGasContainers
            {
                get
                {
                    return this.safeHandlingOfGasContainersField;
                }
                set
                {
                    this.safeHandlingOfGasContainersField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public PrecautionaryMeasures PrecautionaryMeasures
            {
                get
                {
                    return this.precautionaryMeasuresField;
                }
                set
                {
                    this.precautionaryMeasuresField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("FurtherInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] FurtherInformation
            {
                get
                {
                    return this.furtherInformationField;
                }
                set
                {
                    this.furtherInformationField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("GeneralOccupationalHygiene", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] GeneralOccupationalHygiene
            {
                get
                {
                    return this.generalOccupationalHygieneField;
                }
                set
                {
                    this.generalOccupationalHygieneField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class PrecautionaryMeasures
        {

            private Phrase[] protectiveMeasuresField;

            private Phrase[] measuresToPreventFireField;

            private Phrase[] measuresToPreventAerosolAndDustField;

            private Phrase[] measuresToProtectEnvironmentField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ProtectiveMeasures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ProtectiveMeasures
            {
                get
                {
                    return this.protectiveMeasuresField;
                }
                set
                {
                    this.protectiveMeasuresField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("MeasuresToPreventFire", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] MeasuresToPreventFire
            {
                get
                {
                    return this.measuresToPreventFireField;
                }
                set
                {
                    this.measuresToPreventFireField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("MeasuresToPreventAerosolAndDust", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] MeasuresToPreventAerosolAndDust
            {
                get
                {
                    return this.measuresToPreventAerosolAndDustField;
                }
                set
                {
                    this.measuresToPreventAerosolAndDustField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("MeasuresToProtectEnvironment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] MeasuresToProtectEnvironment
            {
                get
                {
                    return this.measuresToProtectEnvironmentField;
                }
                set
                {
                    this.measuresToProtectEnvironmentField = value;
                }
            }
        }
    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class ConditionsForSafeStorage
        {

            private Phrase[] technicalMeasuresAndStorageConditionsField;

            private Phrase[] packagingContainerField;

            private Phrase[] requirementsForStorageRoomsAndVesselsField;

            private Phrase[] hintsOnStorageAssemblyField;

            private Phrase[] furtherInformationOnStorageConditionsField;

            private PhysChemUnitValue storageTemperatureField;

            private PhysChemUnitValue storagePressureField;

            private PhysChemUnitValue storageAirHumidityField;

            private StorageStability[] storageStabilityField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("TechnicalMeasuresAndStorageConditions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] TechnicalMeasuresAndStorageConditions
            {
                get
                {
                    return this.technicalMeasuresAndStorageConditionsField;
                }
                set
                {
                    this.technicalMeasuresAndStorageConditionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("PackagingContainer", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] PackagingContainer
            {
                get
                {
                    return this.packagingContainerField;
                }
                set
                {
                    this.packagingContainerField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("RequirementsForStorageRoomsAndVessels", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] RequirementsForStorageRoomsAndVessels
            {
                get
                {
                    return this.requirementsForStorageRoomsAndVesselsField;
                }
                set
                {
                    this.requirementsForStorageRoomsAndVesselsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("HintsOnStorageAssembly", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] HintsOnStorageAssembly
            {
                get
                {
                    return this.hintsOnStorageAssemblyField;
                }
                set
                {
                    this.hintsOnStorageAssemblyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("FurtherInformationOnStorageConditions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] FurtherInformationOnStorageConditions
            {
                get
                {
                    return this.furtherInformationOnStorageConditionsField;
                }
                set
                {
                    this.furtherInformationOnStorageConditionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public PhysChemUnitValue StorageTemperature
            {
                get
                {
                    return this.storageTemperatureField;
                }
                set
                {
                    this.storageTemperatureField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public PhysChemUnitValue StoragePressure
            {
                get
                {
                    return this.storagePressureField;
                }
                set
                {
                    this.storagePressureField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public PhysChemUnitValue StorageAirHumidity
            {
                get
                {
                    return this.storageAirHumidityField;
                }
                set
                {
                    this.storageAirHumidityField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("StorageStability", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public StorageStability[] StorageStability
            {
                get
                {
                    return this.storageStabilityField;
                }
                set
                {
                    this.storageStabilityField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class SpecificEndUses
        {

            private Phrase[] recommendationsField;

            private Phrase[] industrialSectorSpecificSolutionsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("Recommendations", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] Recommendations
            {
                get
                {
                    return this.recommendationsField;
                }
                set
                {
                    this.recommendationsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("IndustrialSectorSpecificSolutions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] IndustrialSectorSpecificSolutions
            {
                get
                {
                    return this.industrialSectorSpecificSolutionsField;
                }
                set
                {
                    this.industrialSectorSpecificSolutionsField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class StabilityReactivity
        {

            private Phrase[] reactivityDescriptionField;

            private Phrase[] stabilityDescriptionField;

            private Phrase[] hazardousReactionsField;

            private Phrase[] conditionsToAvoidField;

            private Phrase[] materialsToAvoidField;

            private Phrase[] hazardousDecompositionProductsField;

            private Phrase[] commentsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ReactivityDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ReactivityDescription
            {
                get
                {
                    return this.reactivityDescriptionField;
                }
                set
                {
                    this.reactivityDescriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("StabilityDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] StabilityDescription
            {
                get
                {
                    return this.stabilityDescriptionField;
                }
                set
                {
                    this.stabilityDescriptionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("HazardousReactions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] HazardousReactions
            {
                get
                {
                    return this.hazardousReactionsField;
                }
                set
                {
                    this.hazardousReactionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ConditionsToAvoid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ConditionsToAvoid
            {
                get
                {
                    return this.conditionsToAvoidField;
                }
                set
                {
                    this.conditionsToAvoidField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("MaterialsToAvoid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] MaterialsToAvoid
            {
                get
                {
                    return this.materialsToAvoidField;
                }
                set
                {
                    this.materialsToAvoidField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("HazardousDecompositionProducts", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] HazardousDecompositionProducts
            {
                get
                {
                    return this.hazardousDecompositionProductsField;
                }
                set
                {
                    this.hazardousDecompositionProductsField = value;
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

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class DisposalConsiderations
        {

            private object[] itemsField;

            private EuRequirements euRequirementsField;

            private Phrase[] commentsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("WasteTreatment", typeof(WasteTreatment), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            [System.Xml.Serialization.XmlElement("WasteTreatmentMethods", typeof(Phrase), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public object[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public EuRequirements EuRequirements
            {
                get
                {
                    return this.euRequirementsField;
                }
                set
                {
                    this.euRequirementsField = value;
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

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class WasteTreatment
        {

            private Phrase[] productWasteField;

            private Phrase[] packagingWasteField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ProductWaste", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ProductWaste
            {
                get
                {
                    return this.productWasteField;
                }
                set
                {
                    this.productWasteField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("PackagingWaste", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] PackagingWaste
            {
                get
                {
                    return this.packagingWasteField;
                }
                set
                {
                    this.packagingWasteField = value;
                }
            }
        }
    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class EuRequirements
        {

            private EuropeanWasteList europeanWasteListField;

            private Phrase[] euWasteRegulationsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public EuropeanWasteList EuropeanWasteList
            {
                get
                {
                    return this.europeanWasteListField;
                }
                set
                {
                    this.europeanWasteListField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("EuWasteRegulations", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] EuWasteRegulations
            {
                get
                {
                    return this.euWasteRegulationsField;
                }
                set
                {
                    this.euWasteRegulationsField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class EuropeanWasteList
        {

            private WasteListEntry[] eWLProductField;

            private WasteListEntry[] eWLPackingField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("EWLProduct", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public WasteListEntry[] EWLProduct
            {
                get
                {
                    return this.eWLProductField;
                }
                set
                {
                    this.eWLProductField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("EWLPacking", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public WasteListEntry[] EWLPacking
            {
                get
                {
                    return this.eWLPackingField;
                }
                set
                {
                    this.eWLPackingField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class TransportInformation
        {

            private bool dangerousGoodsAdrRidAdnImdgIcaoIataField;

            private bool dangerousGoodsAdrRidAdnImdgIcaoIataFieldSpecified;

            private UnNo unNoField;

            private ProperShippingName properShippingNameField;

            private HazardClassification transportHazardClassificationField;

            private PackingGroup packingGroupField;

            private EnvironmentalHazards environmentalHazardsField;

            private Phrase[] specialPrecautionUserField;

            private TransportInBulk transportInBulkField;

            private OtherTransportInformation otherTransportInformationField;

            private Phrase[] commentsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool DangerousGoodsAdrRidAdnImdgIcaoIata
            {
                get
                {
                    return this.dangerousGoodsAdrRidAdnImdgIcaoIataField;
                }
                set
                {
                    this.dangerousGoodsAdrRidAdnImdgIcaoIataField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool DangerousGoodsAdrRidAdnImdgIcaoIataSpecified
            {
                get
                {
                    return this.dangerousGoodsAdrRidAdnImdgIcaoIataFieldSpecified;
                }
                set
                {
                    this.dangerousGoodsAdrRidAdnImdgIcaoIataFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public UnNo UnNo
            {
                get
                {
                    return this.unNoField;
                }
                set
                {
                    this.unNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public ProperShippingName ProperShippingName
            {
                get
                {
                    return this.properShippingNameField;
                }
                set
                {
                    this.properShippingNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public HazardClassification TransportHazardClassification
            {
                get
                {
                    return this.transportHazardClassificationField;
                }
                set
                {
                    this.transportHazardClassificationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public PackingGroup PackingGroup
            {
                get
                {
                    return this.packingGroupField;
                }
                set
                {
                    this.packingGroupField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public EnvironmentalHazards EnvironmentalHazards
            {
                get
                {
                    return this.environmentalHazardsField;
                }
                set
                {
                    this.environmentalHazardsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("SpecialPrecautionUser", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] SpecialPrecautionUser
            {
                get
                {
                    return this.specialPrecautionUserField;
                }
                set
                {
                    this.specialPrecautionUserField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public TransportInBulk TransportInBulk
            {
                get
                {
                    return this.transportInBulkField;
                }
                set
                {
                    this.transportInBulkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public OtherTransportInformation OtherTransportInformation
            {
                get
                {
                    return this.otherTransportInformationField;
                }
                set
                {
                    this.otherTransportInformationField = value;
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

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class UnNo
        {

            private string unNoAdrRidAdnField;

            private string unNoImdgField;

            private string unNoIcaoField;

            private Phrase[] commentsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string UnNoAdrRidAdn
            {
                get
                {
                    return this.unNoAdrRidAdnField;
                }
                set
                {
                    this.unNoAdrRidAdnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string UnNoImdg
            {
                get
                {
                    return this.unNoImdgField;
                }
                set
                {
                    this.unNoImdgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string UnNoIcao
            {
                get
                {
                    return this.unNoIcaoField;
                }
                set
                {
                    this.unNoIcaoField = value;
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

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class ProperShippingName
        {

            private AdrRidAdn adrRidAdnField;

            private Imdg imdgField;

            private Icao icaoField;

            private Phrase[] properShippingNameCommentsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public AdrRidAdn AdrRidAdn
            {
                get
                {
                    return this.adrRidAdnField;
                }
                set
                {
                    this.adrRidAdnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Imdg Imdg
            {
                get
                {
                    return this.imdgField;
                }
                set
                {
                    this.imdgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Icao Icao
            {
                get
                {
                    return this.icaoField;
                }
                set
                {
                    this.icaoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ProperShippingNameComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ProperShippingNameComments
            {
                get
                {
                    return this.properShippingNameCommentsField;
                }
                set
                {
                    this.properShippingNameCommentsField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class AdrRidAdn
        {

            private Phrase properShippingNameEnglishAdrRidAdnField;

            private Phrase properShippingNameNationalAdrRidAdnField;

            private Phrase[] dangerReleasingSubstanceAdrRidAdnField;

            private Phrase[] dangerReleasingSubstanceNationalAdrRidAdnField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase ProperShippingNameEnglishAdrRidAdn
            {
                get
                {
                    return this.properShippingNameEnglishAdrRidAdnField;
                }
                set
                {
                    this.properShippingNameEnglishAdrRidAdnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase ProperShippingNameNationalAdrRidAdn
            {
                get
                {
                    return this.properShippingNameNationalAdrRidAdnField;
                }
                set
                {
                    this.properShippingNameNationalAdrRidAdnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("DangerReleasingSubstanceAdrRidAdn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] DangerReleasingSubstanceAdrRidAdn
            {
                get
                {
                    return this.dangerReleasingSubstanceAdrRidAdnField;
                }
                set
                {
                    this.dangerReleasingSubstanceAdrRidAdnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("DangerReleasingSubstanceNationalAdrRidAdn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] DangerReleasingSubstanceNationalAdrRidAdn
            {
                get
                {
                    return this.dangerReleasingSubstanceNationalAdrRidAdnField;
                }
                set
                {
                    this.dangerReleasingSubstanceNationalAdrRidAdnField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class Imdg
        {

            private Phrase properShippingNameEnglishImdgField;

            private Phrase[] dangerReleasingSubstanceImdgField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase ProperShippingNameEnglishImdg
            {
                get
                {
                    return this.properShippingNameEnglishImdgField;
                }
                set
                {
                    this.properShippingNameEnglishImdgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("DangerReleasingSubstanceImdg", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] DangerReleasingSubstanceImdg
            {
                get
                {
                    return this.dangerReleasingSubstanceImdgField;
                }
                set
                {
                    this.dangerReleasingSubstanceImdgField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class Icao
        {

            private Phrase properShippingNameEnglishIcaoField;

            private Phrase[] dangerReleasingSubstanceIcaoField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase ProperShippingNameEnglishIcao
            {
                get
                {
                    return this.properShippingNameEnglishIcaoField;
                }
                set
                {
                    this.properShippingNameEnglishIcaoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("DangerReleasingSubstanceIcao", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] DangerReleasingSubstanceIcao
            {
                get
                {
                    return this.dangerReleasingSubstanceIcaoField;
                }
                set
                {
                    this.dangerReleasingSubstanceIcaoField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class HazardClassification
        {

            private HazardClassificationAdrRidAdn adrRidAdnField;

            private HazardClassificationImdg imdgField;

            private HazardClassificationIcaoIata icaoIataField;

            private Phrase[] transportHazardClassificationCommentsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public HazardClassificationAdrRidAdn AdrRidAdn
            {
                get
                {
                    return this.adrRidAdnField;
                }
                set
                {
                    this.adrRidAdnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public HazardClassificationImdg Imdg
            {
                get
                {
                    return this.imdgField;
                }
                set
                {
                    this.imdgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public HazardClassificationIcaoIata IcaoIata
            {
                get
                {
                    return this.icaoIataField;
                }
                set
                {
                    this.icaoIataField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("TransportHazardClassificationComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] TransportHazardClassificationComments
            {
                get
                {
                    return this.transportHazardClassificationCommentsField;
                }
                set
                {
                    this.transportHazardClassificationCommentsField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class HazardClassificationAdrRidAdn
        {

            private Phrase classAdrRidAdnField;

            private Phrase classCodeAdrRidAdnField;

            private Phrase[] subsidiaryRiskAdrRidAdnField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase ClassAdrRidAdn
            {
                get
                {
                    return this.classAdrRidAdnField;
                }
                set
                {
                    this.classAdrRidAdnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase ClassCodeAdrRidAdn
            {
                get
                {
                    return this.classCodeAdrRidAdnField;
                }
                set
                {
                    this.classCodeAdrRidAdnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("SubsidiaryRiskAdrRidAdn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] SubsidiaryRiskAdrRidAdn
            {
                get
                {
                    return this.subsidiaryRiskAdrRidAdnField;
                }
                set
                {
                    this.subsidiaryRiskAdrRidAdnField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class HazardClassificationImdg
        {

            private Phrase classImdgField;

            private Phrase classCodeImdgField;

            private Phrase[] subsidiaryRiskImdgField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase ClassImdg
            {
                get
                {
                    return this.classImdgField;
                }
                set
                {
                    this.classImdgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase ClassCodeImdg
            {
                get
                {
                    return this.classCodeImdgField;
                }
                set
                {
                    this.classCodeImdgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("SubsidiaryRiskImdg", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] SubsidiaryRiskImdg
            {
                get
                {
                    return this.subsidiaryRiskImdgField;
                }
                set
                {
                    this.subsidiaryRiskImdgField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class HazardClassificationIcaoIata
        {

            private Phrase classIcaoIataField;

            private Phrase classCodeIcaoIataField;

            private Phrase[] subsidiaryRiskIcaoIataField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase ClassIcaoIata
            {
                get
                {
                    return this.classIcaoIataField;
                }
                set
                {
                    this.classIcaoIataField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase ClassCodeIcaoIata
            {
                get
                {
                    return this.classCodeIcaoIataField;
                }
                set
                {
                    this.classCodeIcaoIataField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("SubsidiaryRiskIcaoIata", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] SubsidiaryRiskIcaoIata
            {
                get
                {
                    return this.subsidiaryRiskIcaoIataField;
                }
                set
                {
                    this.subsidiaryRiskIcaoIataField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class PackingGroup
        {

            private PackingGroupEnum packingGroupAdrRidAdnField;

            private bool packingGroupAdrRidAdnFieldSpecified;

            private PackingGroupEnum packingGroupImdgField;

            private bool packingGroupImdgFieldSpecified;

            private PackingGroupEnum packingGroupIcaoIataField;

            private bool packingGroupIcaoIataFieldSpecified;

            private Phrase[] packingGroupCommentsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public PackingGroupEnum PackingGroupAdrRidAdn
            {
                get
                {
                    return this.packingGroupAdrRidAdnField;
                }
                set
                {
                    this.packingGroupAdrRidAdnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool PackingGroupAdrRidAdnSpecified
            {
                get
                {
                    return this.packingGroupAdrRidAdnFieldSpecified;
                }
                set
                {
                    this.packingGroupAdrRidAdnFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public PackingGroupEnum PackingGroupImdg
            {
                get
                {
                    return this.packingGroupImdgField;
                }
                set
                {
                    this.packingGroupImdgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool PackingGroupImdgSpecified
            {
                get
                {
                    return this.packingGroupImdgFieldSpecified;
                }
                set
                {
                    this.packingGroupImdgFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public PackingGroupEnum PackingGroupIcaoIata
            {
                get
                {
                    return this.packingGroupIcaoIataField;
                }
                set
                {
                    this.packingGroupIcaoIataField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool PackingGroupIcaoIataSpecified
            {
                get
                {
                    return this.packingGroupIcaoIataFieldSpecified;
                }
                set
                {
                    this.packingGroupIcaoIataFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("PackingGroupComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] PackingGroupComments
            {
                get
                {
                    return this.packingGroupCommentsField;
                }
                set
                {
                    this.packingGroupCommentsField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class EnvironmentalHazards
        {

            private bool environmHazardAccordAdrRidAdnField;

            private bool environmHazardAccordAdrRidAdnFieldSpecified;

            private EnvironmentalHazardsImdg imdgField;

            private bool environmHazardAccordIcaoIataField;

            private bool environmHazardAccordIcaoIataFieldSpecified;

            private Phrase[] environmentalHazardsDescriptionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool EnvironmHazardAccordAdrRidAdn
            {
                get
                {
                    return this.environmHazardAccordAdrRidAdnField;
                }
                set
                {
                    this.environmHazardAccordAdrRidAdnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool EnvironmHazardAccordAdrRidAdnSpecified
            {
                get
                {
                    return this.environmHazardAccordAdrRidAdnFieldSpecified;
                }
                set
                {
                    this.environmHazardAccordAdrRidAdnFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public EnvironmentalHazardsImdg Imdg
            {
                get
                {
                    return this.imdgField;
                }
                set
                {
                    this.imdgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool EnvironmHazardAccordIcaoIata
            {
                get
                {
                    return this.environmHazardAccordIcaoIataField;
                }
                set
                {
                    this.environmHazardAccordIcaoIataField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool EnvironmHazardAccordIcaoIataSpecified
            {
                get
                {
                    return this.environmHazardAccordIcaoIataFieldSpecified;
                }
                set
                {
                    this.environmHazardAccordIcaoIataFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("EnvironmentalHazardsDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] EnvironmentalHazardsDescription
            {
                get
                {
                    return this.environmentalHazardsDescriptionField;
                }
                set
                {
                    this.environmentalHazardsDescriptionField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class EnvironmentalHazardsImdg
        {

            private bool environmHazardAccordImdgField;

            private bool environmHazardAccordImdgFieldSpecified;

            private bool marinePollutantField;

            private bool marinePollutantFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool EnvironmHazardAccordImdg
            {
                get
                {
                    return this.environmHazardAccordImdgField;
                }
                set
                {
                    this.environmHazardAccordImdgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool EnvironmHazardAccordImdgSpecified
            {
                get
                {
                    return this.environmHazardAccordImdgFieldSpecified;
                }
                set
                {
                    this.environmHazardAccordImdgFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool MarinePollutant
            {
                get
                {
                    return this.marinePollutantField;
                }
                set
                {
                    this.marinePollutantField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool MarinePollutantSpecified
            {
                get
                {
                    return this.marinePollutantFieldSpecified;
                }
                set
                {
                    this.marinePollutantFieldSpecified = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class TransportInBulk
        {

            private bool transportInBulkValueField;

            private string productNameField;

            private Phrase[] shipTypeField;

            private Phrase[] pollutionCategoryField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool TransportInBulkValue
            {
                get
                {
                    return this.transportInBulkValueField;
                }
                set
                {
                    this.transportInBulkValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string ProductName
            {
                get
                {
                    return this.productNameField;
                }
                set
                {
                    this.productNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ShipType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ShipType
            {
                get
                {
                    return this.shipTypeField;
                }
                set
                {
                    this.shipTypeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("PollutionCategory", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] PollutionCategory
            {
                get
                {
                    return this.pollutionCategoryField;
                }
                set
                {
                    this.pollutionCategoryField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class OtherTransportInformation
        {

            private TransportHazardLabels transportHazardLabelsField;

            private Phrase[] otherTransportGeneralField;

            private AdrOtherInformation adrOtherInformationField;

            private Phrase[] ridOtherInfoField;

            private AdnOtherInformation adnOtherInformationField;

            private ImdgOtherInformation imdgOtherInformationField;

            private Phrase[] icaoIataOtherInfoField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public TransportHazardLabels TransportHazardLabels
            {
                get
                {
                    return this.transportHazardLabelsField;
                }
                set
                {
                    this.transportHazardLabelsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("OtherTransportGeneral", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] OtherTransportGeneral
            {
                get
                {
                    return this.otherTransportGeneralField;
                }
                set
                {
                    this.otherTransportGeneralField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public AdrOtherInformation AdrOtherInformation
            {
                get
                {
                    return this.adrOtherInformationField;
                }
                set
                {
                    this.adrOtherInformationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("RidOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] RidOtherInfo
            {
                get
                {
                    return this.ridOtherInfoField;
                }
                set
                {
                    this.ridOtherInfoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public AdnOtherInformation AdnOtherInformation
            {
                get
                {
                    return this.adnOtherInformationField;
                }
                set
                {
                    this.adnOtherInformationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public ImdgOtherInformation ImdgOtherInformation
            {
                get
                {
                    return this.imdgOtherInformationField;
                }
                set
                {
                    this.imdgOtherInformationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("IcaoIataOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] IcaoIataOtherInfo
            {
                get
                {
                    return this.icaoIataOtherInfoField;
                }
                set
                {
                    this.icaoIataOtherInfoField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class TransportHazardLabels
        {

            private Phrase[] adrRidAdnHazardLabelField;

            private Phrase[] imdgHazardLabelField;

            private Phrase[] icaoIataHazardLabelField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("AdrRidAdnHazardLabel", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] AdrRidAdnHazardLabel
            {
                get
                {
                    return this.adrRidAdnHazardLabelField;
                }
                set
                {
                    this.adrRidAdnHazardLabelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ImdgHazardLabel", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ImdgHazardLabel
            {
                get
                {
                    return this.imdgHazardLabelField;
                }
                set
                {
                    this.imdgHazardLabelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("IcaoIataHazardLabel", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] IcaoIataHazardLabel
            {
                get
                {
                    return this.icaoIataHazardLabelField;
                }
                set
                {
                    this.icaoIataHazardLabelField = value;
                }
            }
        }
    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class AdrOtherInformation
        {

            private Phrase[] adrOtherInfoField;

            private Phrase[] adrTunnelRestrictionCodeField;

            private Phrase[] adrLimitedQtyField;

            private Phrase[] adrTransportCategoryField;

            private Phrase adrHazardIdentificationNoField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("AdrOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] AdrOtherInfo
            {
                get
                {
                    return this.adrOtherInfoField;
                }
                set
                {
                    this.adrOtherInfoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("AdrTunnelRestrictionCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] AdrTunnelRestrictionCode
            {
                get
                {
                    return this.adrTunnelRestrictionCodeField;
                }
                set
                {
                    this.adrTunnelRestrictionCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("AdrLimitedQty", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] AdrLimitedQty
            {
                get
                {
                    return this.adrLimitedQtyField;
                }
                set
                {
                    this.adrLimitedQtyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("AdrTransportCategory", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] AdrTransportCategory
            {
                get
                {
                    return this.adrTransportCategoryField;
                }
                set
                {
                    this.adrTransportCategoryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase AdrHazardIdentificationNo
            {
                get
                {
                    return this.adrHazardIdentificationNoField;
                }
                set
                {
                    this.adrHazardIdentificationNoField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class AdnOtherInformation
        {

            private Phrase[] adnOtherInfoField;

            private Phrase[] adnSpecialProvisionsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("AdnOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] AdnOtherInfo
            {
                get
                {
                    return this.adnOtherInfoField;
                }
                set
                {
                    this.adnOtherInfoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("AdnSpecialProvisions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] AdnSpecialProvisions
            {
                get
                {
                    return this.adnSpecialProvisionsField;
                }
                set
                {
                    this.adnSpecialProvisionsField = value;
                }
            }
        }
    /// <remarks/>

    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class ImdgOtherInformation
        {

            private Phrase[] imdgOtherInfoField;

            private string[] imdgEmsCodeField;

            private Phrase[] imdgLimitedQtyField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ImdgOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ImdgOtherInfo
            {
                get
                {
                    return this.imdgOtherInfoField;
                }
                set
                {
                    this.imdgOtherInfoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ImdgEmsCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string[] ImdgEmsCode
            {
                get
                {
                    return this.imdgEmsCodeField;
                }
                set
                {
                    this.imdgEmsCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ImdgLimitedQty", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ImdgLimitedQty
            {
                get
                {
                    return this.imdgLimitedQtyField;
                }
                set
                {
                    this.imdgLimitedQtyField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class RegulatoryInfo
        {

            private SpecificProvisionsRelatedToProduct specificProvisionsRelatedToProductField;

            private NationalLegislation nationalLegislationField;

            private Phrase[] regulatoryInformationCommentsField;

            private DatasheetFeedDatasheetRegulatoryInfoChemicalSafetyAssessmentInfo chemicalSafetyAssessmentInfoField;

            private ChemicalSafetyReport chemicalSafetyReportField;

            private ExposureScenario exposureScenarioField;

            private Phrase[] regulatoryInfoAdditionalInfoField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public SpecificProvisionsRelatedToProduct SpecificProvisionsRelatedToProduct
            {
                get
                {
                    return this.specificProvisionsRelatedToProductField;
                }
                set
                {
                    this.specificProvisionsRelatedToProductField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalLegislation NationalLegislation
            {
                get
                {
                    return this.nationalLegislationField;
                }
                set
                {
                    this.nationalLegislationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("RegulatoryInformationComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] RegulatoryInformationComments
            {
                get
                {
                    return this.regulatoryInformationCommentsField;
                }
                set
                {
                    this.regulatoryInformationCommentsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public DatasheetFeedDatasheetRegulatoryInfoChemicalSafetyAssessmentInfo ChemicalSafetyAssessmentInfo
            {
                get
                {
                    return this.chemicalSafetyAssessmentInfoField;
                }
                set
                {
                    this.chemicalSafetyAssessmentInfoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public ChemicalSafetyReport ChemicalSafetyReport
            {
                get
                {
                    return this.chemicalSafetyReportField;
                }
                set
                {
                    this.chemicalSafetyReportField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public ExposureScenario ExposureScenario
            {
                get
                {
                    return this.exposureScenarioField;
                }
                set
                {
                    this.exposureScenarioField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("RegulatoryInfoAdditionalInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] RegulatoryInfoAdditionalInfo
            {
                get
                {
                    return this.regulatoryInfoAdditionalInfoField;
                }
                set
                {
                    this.regulatoryInfoAdditionalInfoField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class SpecificProvisionsRelatedToProduct
        {

            private SpecificProvisionsRelatedToProductEuLegislation euLegislationField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public SpecificProvisionsRelatedToProductEuLegislation EuLegislation
            {
                get
                {
                    return this.euLegislationField;
                }
                set
                {
                    this.euLegislationField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class SpecificProvisionsRelatedToProductEuLegislation
        {

            private AssessmentEnum assessedLegislationField;

            private bool assessedLegislationFieldSpecified;

            private Phrase[] euAuthorisationField;

            private Phrase[] euRestrictionsOnUseField;

            private Phrase[] restrictionsAccordingReachField;

            private Phrase[] detergentsField;

            private SpecificProvisionsRelatedToProductEuLegislationVoc vocField;

            private EuLegislationIndustrialEmissions industrialEmissionsField;

            private EuLegislationCertainFluorinatedGreenhouseGases certainFluorinatedGreenhouseGasesField;

            private Phrase[] otherEuLegislationField;

            private Phrase[] euRestrictionsOfOccupationField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public AssessmentEnum AssessedLegislation
            {
                get
                {
                    return this.assessedLegislationField;
                }
                set
                {
                    this.assessedLegislationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool AssessedLegislationSpecified
            {
                get
                {
                    return this.assessedLegislationFieldSpecified;
                }
                set
                {
                    this.assessedLegislationFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("EuAuthorisation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] EuAuthorisation
            {
                get
                {
                    return this.euAuthorisationField;
                }
                set
                {
                    this.euAuthorisationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("EuRestrictionsOnUse", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] EuRestrictionsOnUse
            {
                get
                {
                    return this.euRestrictionsOnUseField;
                }
                set
                {
                    this.euRestrictionsOnUseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("RestrictionsAccordingReach", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] RestrictionsAccordingReach
            {
                get
                {
                    return this.restrictionsAccordingReachField;
                }
                set
                {
                    this.restrictionsAccordingReachField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("Detergents", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] Detergents
            {
                get
                {
                    return this.detergentsField;
                }
                set
                {
                    this.detergentsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public SpecificProvisionsRelatedToProductEuLegislationVoc Voc
            {
                get
                {
                    return this.vocField;
                }
                set
                {
                    this.vocField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public EuLegislationIndustrialEmissions IndustrialEmissions
            {
                get
                {
                    return this.industrialEmissionsField;
                }
                set
                {
                    this.industrialEmissionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public EuLegislationCertainFluorinatedGreenhouseGases CertainFluorinatedGreenhouseGases
            {
                get
                {
                    return this.certainFluorinatedGreenhouseGasesField;
                }
                set
                {
                    this.certainFluorinatedGreenhouseGasesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("OtherEuLegislation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] OtherEuLegislation
            {
                get
                {
                    return this.otherEuLegislationField;
                }
                set
                {
                    this.otherEuLegislationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("EuRestrictionsOfOccupation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] EuRestrictionsOfOccupation
            {
                get
                {
                    return this.euRestrictionsOfOccupationField;
                }
                set
                {
                    this.euRestrictionsOfOccupationField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class SpecificProvisionsRelatedToProductEuLegislationVoc
        {

            private PercentageValue vocInPercentByWeightField;

            private UnitValue vocValueField;

            private Phrase[] vocRestrictionCommentsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public PercentageValue VocInPercentByWeight
            {
                get
                {
                    return this.vocInPercentByWeightField;
                }
                set
                {
                    this.vocInPercentByWeightField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public UnitValue VocValue
            {
                get
                {
                    return this.vocValueField;
                }
                set
                {
                    this.vocValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("VocRestrictionComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] VocRestrictionComments
            {
                get
                {
                    return this.vocRestrictionCommentsField;
                }
                set
                {
                    this.vocRestrictionCommentsField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class EuLegislationIndustrialEmissions
        {

            private PercentageValue vocInPercentByWeightField;

            private UnitValue vocValueField;

            private Phrase otherInformationField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public PercentageValue VocInPercentByWeight
            {
                get
                {
                    return this.vocInPercentByWeightField;
                }
                set
                {
                    this.vocInPercentByWeightField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public UnitValue VocValue
            {
                get
                {
                    return this.vocValueField;
                }
                set
                {
                    this.vocValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase OtherInformation
            {
                get
                {
                    return this.otherInformationField;
                }
                set
                {
                    this.otherInformationField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class EuLegislationCertainFluorinatedGreenhouseGases
        {

            private Phrase fluorinatedGreenhouseGasesMethodField;

            private Phrase[] fluorinatedGreenhouseGasesCommentsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase FluorinatedGreenhouseGasesMethod
            {
                get
                {
                    return this.fluorinatedGreenhouseGasesMethodField;
                }
                set
                {
                    this.fluorinatedGreenhouseGasesMethodField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("FluorinatedGreenhouseGasesComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] FluorinatedGreenhouseGasesComments
            {
                get
                {
                    return this.fluorinatedGreenhouseGasesCommentsField;
                }
                set
                {
                    this.fluorinatedGreenhouseGasesCommentsField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class NationalLegislation
        {

            private NationalExtensionAD nationalLegislationAndorraField;

            private NationalExtensionAL nationalLegislationAlbaniaField;

            private NationalExtensionAM nationalLegislationArmeniaField;

            private NationalExtensionAT nationalLegislationAustriaField;

            private NationalExtensionBA nationalLegislationBosniaAndHerzegovinaField;

            private NationalExtensionBE nationalLegislationBelgiumField;

            private NationalExtensionBG nationalLegislationBulgariaField;

            private NationalExtensionBY nationalLegislationBelarusField;

            private NationalExtensionCH nationalLegislationSwitzerlandField;

            private NationalExtensionCZ nationalLegislationCzechRepublicField;

            private NationalExtensionDE nationalLegislationGermanyField;

            private NationalExtensionDK nationalLegislationDemnarkField;

            private NationalExtensionEE nationalLegislationEstoniaField;

            private NationalExtensionES nationalLegislationSpainField;

            private NationalExtensionFI nationalLegislationFinlandField;

            private NationalExtensionFR nationalLegislationFranceField;

            private NationalExtensionGB nationalLegislationUnitedKingdomField;

            private NationalExtensionGE nationalLegislationGeorgiaField;

            private NationalExtensionGR nationalLegislationGreeceField;

            private NationalExtensionHR nationalLegislationCroatiaField;

            private NationalExtensionHU nationalLegislationHungaryField;

            private NationalExtensionIE nationalLegislationIrelandField;

            private NationalExtensionIS nationalLegislationIcelandField;

            private NationalExtensionIT nationalLegislationItalyField;

            private NationalExtensionKZ nationalLegislationKazakhstanField;

            private NationalExtensionLI nationalLegislationLiechtensteinField;

            private NationalExtensionLT nationalLegislationLithuaniaField;

            private NationalExtensionLU nationalLegislationLuxembourgField;

            private NationalExtensionLV nationalLegislationLatviaField;

            private NationalExtensionMC nationalLegislationMonacoField;

            private NationalExtensionMD nationalLegislationRepublicOfMoldovaField;

            private NationalExtensionME nationalLegislationMontenegroField;

            private NationalExtensionMK nationalLegislationTheFormerYugoslavRepublicOfMacedoniaField;

            private NationalExtensionMT nationalLegislationMaltaField;

            private NationalExtensionNL nationalLegislationNetherlandsField;

            private NationalExtensionNO nationalLegislationNorwayField;

            private NationalExtensionPL nationalLegislationPolandField;

            private NationalExtensionPT nationalLegislationPortugalField;

            private NationalExtensionRO nationalLegislationRomaniaField;

            private NationalExtensionRS nationalLegislationSerbiaField;

            private NationalExtensionRU nationalLegislationRussianFederationField;

            private NationalExtensionSE nationalLegislationSwedenField;

            private NationalExtensionSI nationalLegislationSloveniaField;

            private NationalExtensionSK nationalLegislationSlovakiaField;

            private NationalExtensionSM nationalLegislationSanMarinoField;

            private NationalExtensionTR nationalLegislationTurkeyField;

            private NationalExtensionUA nationalLegislationUkraineField;

            private NationalExtensionUZ nationalLegislationUzbekistanField;

            private NationalExtensionVA nationalLegislationVaticanCityStateField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionAD NationalLegislationAndorra
            {
                get
                {
                    return this.nationalLegislationAndorraField;
                }
                set
                {
                    this.nationalLegislationAndorraField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionAL NationalLegislationAlbania
            {
                get
                {
                    return this.nationalLegislationAlbaniaField;
                }
                set
                {
                    this.nationalLegislationAlbaniaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionAM NationalLegislationArmenia
            {
                get
                {
                    return this.nationalLegislationArmeniaField;
                }
                set
                {
                    this.nationalLegislationArmeniaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionAT NationalLegislationAustria
            {
                get
                {
                    return this.nationalLegislationAustriaField;
                }
                set
                {
                    this.nationalLegislationAustriaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionBA NationalLegislationBosniaAndHerzegovina
            {
                get
                {
                    return this.nationalLegislationBosniaAndHerzegovinaField;
                }
                set
                {
                    this.nationalLegislationBosniaAndHerzegovinaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionBE NationalLegislationBelgium
            {
                get
                {
                    return this.nationalLegislationBelgiumField;
                }
                set
                {
                    this.nationalLegislationBelgiumField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionBG NationalLegislationBulgaria
            {
                get
                {
                    return this.nationalLegislationBulgariaField;
                }
                set
                {
                    this.nationalLegislationBulgariaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionBY NationalLegislationBelarus
            {
                get
                {
                    return this.nationalLegislationBelarusField;
                }
                set
                {
                    this.nationalLegislationBelarusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionCH NationalLegislationSwitzerland
            {
                get
                {
                    return this.nationalLegislationSwitzerlandField;
                }
                set
                {
                    this.nationalLegislationSwitzerlandField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionCZ NationalLegislationCzechRepublic
            {
                get
                {
                    return this.nationalLegislationCzechRepublicField;
                }
                set
                {
                    this.nationalLegislationCzechRepublicField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionDE NationalLegislationGermany
            {
                get
                {
                    return this.nationalLegislationGermanyField;
                }
                set
                {
                    this.nationalLegislationGermanyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionDK NationalLegislationDemnark
            {
                get
                {
                    return this.nationalLegislationDemnarkField;
                }
                set
                {
                    this.nationalLegislationDemnarkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionEE NationalLegislationEstonia
            {
                get
                {
                    return this.nationalLegislationEstoniaField;
                }
                set
                {
                    this.nationalLegislationEstoniaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionES NationalLegislationSpain
            {
                get
                {
                    return this.nationalLegislationSpainField;
                }
                set
                {
                    this.nationalLegislationSpainField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionFI NationalLegislationFinland
            {
                get
                {
                    return this.nationalLegislationFinlandField;
                }
                set
                {
                    this.nationalLegislationFinlandField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionFR NationalLegislationFrance
            {
                get
                {
                    return this.nationalLegislationFranceField;
                }
                set
                {
                    this.nationalLegislationFranceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionGB NationalLegislationUnitedKingdom
            {
                get
                {
                    return this.nationalLegislationUnitedKingdomField;
                }
                set
                {
                    this.nationalLegislationUnitedKingdomField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionGE NationalLegislationGeorgia
            {
                get
                {
                    return this.nationalLegislationGeorgiaField;
                }
                set
                {
                    this.nationalLegislationGeorgiaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionGR NationalLegislationGreece
            {
                get
                {
                    return this.nationalLegislationGreeceField;
                }
                set
                {
                    this.nationalLegislationGreeceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionHR NationalLegislationCroatia
            {
                get
                {
                    return this.nationalLegislationCroatiaField;
                }
                set
                {
                    this.nationalLegislationCroatiaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionHU NationalLegislationHungary
            {
                get
                {
                    return this.nationalLegislationHungaryField;
                }
                set
                {
                    this.nationalLegislationHungaryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionIE NationalLegislationIreland
            {
                get
                {
                    return this.nationalLegislationIrelandField;
                }
                set
                {
                    this.nationalLegislationIrelandField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionIS NationalLegislationIceland
            {
                get
                {
                    return this.nationalLegislationIcelandField;
                }
                set
                {
                    this.nationalLegislationIcelandField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionIT NationalLegislationItaly
            {
                get
                {
                    return this.nationalLegislationItalyField;
                }
                set
                {
                    this.nationalLegislationItalyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionKZ NationalLegislationKazakhstan
            {
                get
                {
                    return this.nationalLegislationKazakhstanField;
                }
                set
                {
                    this.nationalLegislationKazakhstanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionLI NationalLegislationLiechtenstein
            {
                get
                {
                    return this.nationalLegislationLiechtensteinField;
                }
                set
                {
                    this.nationalLegislationLiechtensteinField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionLT NationalLegislationLithuania
            {
                get
                {
                    return this.nationalLegislationLithuaniaField;
                }
                set
                {
                    this.nationalLegislationLithuaniaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionLU NationalLegislationLuxembourg
            {
                get
                {
                    return this.nationalLegislationLuxembourgField;
                }
                set
                {
                    this.nationalLegislationLuxembourgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionLV NationalLegislationLatvia
            {
                get
                {
                    return this.nationalLegislationLatviaField;
                }
                set
                {
                    this.nationalLegislationLatviaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionMC NationalLegislationMonaco
            {
                get
                {
                    return this.nationalLegislationMonacoField;
                }
                set
                {
                    this.nationalLegislationMonacoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionMD NationalLegislationRepublicOfMoldova
            {
                get
                {
                    return this.nationalLegislationRepublicOfMoldovaField;
                }
                set
                {
                    this.nationalLegislationRepublicOfMoldovaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionME NationalLegislationMontenegro
            {
                get
                {
                    return this.nationalLegislationMontenegroField;
                }
                set
                {
                    this.nationalLegislationMontenegroField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionMK NationalLegislationTheFormerYugoslavRepublicOfMacedonia
            {
                get
                {
                    return this.nationalLegislationTheFormerYugoslavRepublicOfMacedoniaField;
                }
                set
                {
                    this.nationalLegislationTheFormerYugoslavRepublicOfMacedoniaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionMT NationalLegislationMalta
            {
                get
                {
                    return this.nationalLegislationMaltaField;
                }
                set
                {
                    this.nationalLegislationMaltaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionNL NationalLegislationNetherlands
            {
                get
                {
                    return this.nationalLegislationNetherlandsField;
                }
                set
                {
                    this.nationalLegislationNetherlandsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionNO NationalLegislationNorway
            {
                get
                {
                    return this.nationalLegislationNorwayField;
                }
                set
                {
                    this.nationalLegislationNorwayField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionPL NationalLegislationPoland
            {
                get
                {
                    return this.nationalLegislationPolandField;
                }
                set
                {
                    this.nationalLegislationPolandField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionPT NationalLegislationPortugal
            {
                get
                {
                    return this.nationalLegislationPortugalField;
                }
                set
                {
                    this.nationalLegislationPortugalField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionRO NationalLegislationRomania
            {
                get
                {
                    return this.nationalLegislationRomaniaField;
                }
                set
                {
                    this.nationalLegislationRomaniaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionRS NationalLegislationSerbia
            {
                get
                {
                    return this.nationalLegislationSerbiaField;
                }
                set
                {
                    this.nationalLegislationSerbiaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionRU NationalLegislationRussianFederation
            {
                get
                {
                    return this.nationalLegislationRussianFederationField;
                }
                set
                {
                    this.nationalLegislationRussianFederationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionSE NationalLegislationSweden
            {
                get
                {
                    return this.nationalLegislationSwedenField;
                }
                set
                {
                    this.nationalLegislationSwedenField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionSI NationalLegislationSlovenia
            {
                get
                {
                    return this.nationalLegislationSloveniaField;
                }
                set
                {
                    this.nationalLegislationSloveniaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionSK NationalLegislationSlovakia
            {
                get
                {
                    return this.nationalLegislationSlovakiaField;
                }
                set
                {
                    this.nationalLegislationSlovakiaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionSM NationalLegislationSanMarino
            {
                get
                {
                    return this.nationalLegislationSanMarinoField;
                }
                set
                {
                    this.nationalLegislationSanMarinoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionTR NationalLegislationTurkey
            {
                get
                {
                    return this.nationalLegislationTurkeyField;
                }
                set
                {
                    this.nationalLegislationTurkeyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionUA NationalLegislationUkraine
            {
                get
                {
                    return this.nationalLegislationUkraineField;
                }
                set
                {
                    this.nationalLegislationUkraineField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionUZ NationalLegislationUzbekistan
            {
                get
                {
                    return this.nationalLegislationUzbekistanField;
                }
                set
                {
                    this.nationalLegislationUzbekistanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public NationalExtensionVA NationalLegislationVaticanCityState
            {
                get
                {
                    return this.nationalLegislationVaticanCityStateField;
                }
                set
                {
                    this.nationalLegislationVaticanCityStateField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class DatasheetFeedDatasheetRegulatoryInfoChemicalSafetyAssessmentInfo
        {

            private bool chemicalSafetyAssessmentCarriedOutField;

            private bool chemicalSafetyAssessmentCarriedOutFieldSpecified;

            private Phrase[] chemicalSafetyAssessmentField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool ChemicalSafetyAssessmentCarriedOut
            {
                get
                {
                    return this.chemicalSafetyAssessmentCarriedOutField;
                }
                set
                {
                    this.chemicalSafetyAssessmentCarriedOutField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ChemicalSafetyAssessmentCarriedOutSpecified
            {
                get
                {
                    return this.chemicalSafetyAssessmentCarriedOutFieldSpecified;
                }
                set
                {
                    this.chemicalSafetyAssessmentCarriedOutFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ChemicalSafetyAssessment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ChemicalSafetyAssessment
            {
                get
                {
                    return this.chemicalSafetyAssessmentField;
                }
                set
                {
                    this.chemicalSafetyAssessmentField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class ChemicalSafetyReport
        {

            private bool csrRequiredField;

            private bool csrRequiredFieldSpecified;

            private Phrase[] csrLocationField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool CsrRequired
            {
                get
                {
                    return this.csrRequiredField;
                }
                set
                {
                    this.csrRequiredField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool CsrRequiredSpecified
            {
                get
                {
                    return this.csrRequiredFieldSpecified;
                }
                set
                {
                    this.csrRequiredFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("CsrLocation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] CsrLocation
            {
                get
                {
                    return this.csrLocationField;
                }
                set
                {
                    this.csrLocationField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class ExposureScenario
        {

            private bool mixtureExposureScenarioInAnnexField;

            private bool mixtureExposureScenarioInAnnexFieldSpecified;

            private Phrase[] exposureScenarioCommentsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool MixtureExposureScenarioInAnnex
            {
                get
                {
                    return this.mixtureExposureScenarioInAnnexField;
                }
                set
                {
                    this.mixtureExposureScenarioInAnnexField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool MixtureExposureScenarioInAnnexSpecified
            {
                get
                {
                    return this.mixtureExposureScenarioInAnnexFieldSpecified;
                }
                set
                {
                    this.mixtureExposureScenarioInAnnexFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ExposureScenarioComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ExposureScenarioComments
            {
                get
                {
                    return this.exposureScenarioCommentsField;
                }
                set
                {
                    this.exposureScenarioCommentsField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class OtherInformation
        {

            private Phrase[] manufacturersNotesField;

            private RiskPhrase[] relevantRiskPhrasesField;

            private HazardStatement[] relevantHazardStatementsField;

            private ClassificationAccordingClp classificationAccordingClpField;

            private Phrase[] educationalRecommendationsField;

            private Phrase[] recommendedRestrictionField;

            private Phrase[] furtherInformationField;

            private Phrase[] mainInformationSourceField;

            private Phrase[] abbreviationsAndAcronymsUsedField;

            private RevisionInformation revisionInformationField;

            private Phrase[] qualityAssuranceStatementField;

            private Phrase[] sdsStatusField;

            private Phrase[] responsibleOwnerSdsField;

            private PreparedBy sdsPreparedByField;

            private Phrase[] commentsField;

            private PositiveEcolabelling[] positiveEcolabellingField;

            private Phrase[] contentsOrIndexOfAnnexedEsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ManufacturersNotes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ManufacturersNotes
            {
                get
                {
                    return this.manufacturersNotesField;
                }
                set
                {
                    this.manufacturersNotesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("RelevantRiskPhrases", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public RiskPhrase[] RelevantRiskPhrases
            {
                get
                {
                    return this.relevantRiskPhrasesField;
                }
                set
                {
                    this.relevantRiskPhrasesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("RelevantHazardStatements", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public HazardStatement[] RelevantHazardStatements
            {
                get
                {
                    return this.relevantHazardStatementsField;
                }
                set
                {
                    this.relevantHazardStatementsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public ClassificationAccordingClp ClassificationAccordingClp
            {
                get
                {
                    return this.classificationAccordingClpField;
                }
                set
                {
                    this.classificationAccordingClpField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("EducationalRecommendations", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] EducationalRecommendations
            {
                get
                {
                    return this.educationalRecommendationsField;
                }
                set
                {
                    this.educationalRecommendationsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("RecommendedRestriction", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] RecommendedRestriction
            {
                get
                {
                    return this.recommendedRestrictionField;
                }
                set
                {
                    this.recommendedRestrictionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("FurtherInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] FurtherInformation
            {
                get
                {
                    return this.furtherInformationField;
                }
                set
                {
                    this.furtherInformationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("MainInformationSource", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] MainInformationSource
            {
                get
                {
                    return this.mainInformationSourceField;
                }
                set
                {
                    this.mainInformationSourceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("AbbreviationsAndAcronymsUsed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] AbbreviationsAndAcronymsUsed
            {
                get
                {
                    return this.abbreviationsAndAcronymsUsedField;
                }
                set
                {
                    this.abbreviationsAndAcronymsUsedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public RevisionInformation RevisionInformation
            {
                get
                {
                    return this.revisionInformationField;
                }
                set
                {
                    this.revisionInformationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("QualityAssuranceStatement", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] QualityAssuranceStatement
            {
                get
                {
                    return this.qualityAssuranceStatementField;
                }
                set
                {
                    this.qualityAssuranceStatementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("SdsStatus", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] SdsStatus
            {
                get
                {
                    return this.sdsStatusField;
                }
                set
                {
                    this.sdsStatusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ResponsibleOwnerSds", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ResponsibleOwnerSds
            {
                get
                {
                    return this.responsibleOwnerSdsField;
                }
                set
                {
                    this.responsibleOwnerSdsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public PreparedBy SdsPreparedBy
            {
                get
                {
                    return this.sdsPreparedByField;
                }
                set
                {
                    this.sdsPreparedByField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("PositiveEcolabelling", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public PositiveEcolabelling[] PositiveEcolabelling
            {
                get
                {
                    return this.positiveEcolabellingField;
                }
                set
                {
                    this.positiveEcolabellingField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ContentsOrIndexOfAnnexedEs", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ContentsOrIndexOfAnnexedEs
            {
                get
                {
                    return this.contentsOrIndexOfAnnexedEsField;
                }
                set
                {
                    this.contentsOrIndexOfAnnexedEsField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class ClassificationAccordingClp
        {

            private ClassificationAccordingClpClpHazardClassification[] clpHazardClassificationField;

            private Phrase[] clpClassificationCommentsField;

            private Phrase[] clpClassificationNotesField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ClpHazardClassification", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public ClassificationAccordingClpClpHazardClassification[] ClpHazardClassification
            {
                get
                {
                    return this.clpHazardClassificationField;
                }
                set
                {
                    this.clpHazardClassificationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ClpClassificationComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ClpClassificationComments
            {
                get
                {
                    return this.clpClassificationCommentsField;
                }
                set
                {
                    this.clpClassificationCommentsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("ClpClassificationNotes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] ClpClassificationNotes
            {
                get
                {
                    return this.clpClassificationNotesField;
                }
                set
                {
                    this.clpClassificationNotesField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class ClassificationAccordingClpClpHazardClassification
        {

            private HazardClassCategoryEnum clpHazardClassCategoryField;

            private HazardStatement clpHazardStatementField;

            private Phrase clpClassificationProcedureField;

            private ClpHazardClassificationMultiplyingFactor multiplyingFactorField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public HazardClassCategoryEnum ClpHazardClassCategory
            {
                get
                {
                    return this.clpHazardClassCategoryField;
                }
                set
                {
                    this.clpHazardClassCategoryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public HazardStatement ClpHazardStatement
            {
                get
                {
                    return this.clpHazardStatementField;
                }
                set
                {
                    this.clpHazardStatementField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase ClpClassificationProcedure
            {
                get
                {
                    return this.clpClassificationProcedureField;
                }
                set
                {
                    this.clpClassificationProcedureField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public ClpHazardClassificationMultiplyingFactor MultiplyingFactor
            {
                get
                {
                    return this.multiplyingFactorField;
                }
                set
                {
                    this.multiplyingFactorField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class ClpHazardClassificationMultiplyingFactor
        {

            private string factorValueField;

            private Phrase[] factorCommentsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string FactorValue
            {
                get
                {
                    return this.factorValueField;
                }
                set
                {
                    this.factorValueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("FactorComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] FactorComments
            {
                get
                {
                    return this.factorCommentsField;
                }
                set
                {
                    this.factorCommentsField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class RevisionInformation
        {

            private string revisionNoField;

            private Phrase revisionCommentsField;

            private Phrase[] revisionResponsibleField;

            private System.DateTime lastUpdateDateField;

            private bool lastUpdateDateFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string RevisionNo
            {
                get
                {
                    return this.revisionNoField;
                }
                set
                {
                    this.revisionNoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase RevisionComments
            {
                get
                {
                    return this.revisionCommentsField;
                }
                set
                {
                    this.revisionCommentsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("RevisionResponsible", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public Phrase[] RevisionResponsible
            {
                get
                {
                    return this.revisionResponsibleField;
                }
                set
                {
                    this.revisionResponsibleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
            public System.DateTime LastUpdateDate
            {
                get
                {
                    return this.lastUpdateDateField;
                }
                set
                {
                    this.lastUpdateDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool LastUpdateDateSpecified
            {
                get
                {
                    return this.lastUpdateDateFieldSpecified;
                }
                set
                {
                    this.lastUpdateDateFieldSpecified = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class PreparedBy
        {

            private string nameField;

            private string phoneField;

            private string[] emailField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string Phone
            {
                get
                {
                    return this.phoneField;
                }
                set
                {
                    this.phoneField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("Email", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string[] Email
            {
                get
                {
                    return this.emailField;
                }
                set
                {
                    this.emailField = value;
                }
            }
        }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public class PositiveEcolabelling
        {

            private string ecoLabelNameField;

            private System.DateTime expirationDateField;

            private bool expirationDateFieldSpecified;

            private string licenceNoField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string EcoLabelName
            {
                get
                {
                    return this.ecoLabelNameField;
                }
                set
                {
                    this.ecoLabelNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
            public System.DateTime ExpirationDate
            {
                get
                {
                    return this.expirationDateField;
                }
                set
                {
                    this.expirationDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool ExpirationDateSpecified
            {
                get
                {
                    return this.expirationDateFieldSpecified;
                }
                set
                {
                    this.expirationDateFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string LicenceNo
            {
                get
                {
                    return this.licenceNoField;
                }
                set
                {
                    this.licenceNoField = value;
                }
            }
        }
    }
