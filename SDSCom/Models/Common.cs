using System.Collections.Generic;

namespace SDSCom.Models
{
    /// <summary>
    /// 
    /// </summary>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class RegulationsRelatedToCountryOrRegion
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CountryCodeEnum RegulationsRelatedToCountryOrRegionCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase RegulationsRelatedToCountryOrRegionName { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class LegalDocument
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LegalDocumentFileName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime LegalDocumentPrintDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LegalDocumentPrintDateSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LegalDocumentSignature { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class Extension
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ExtensionIssuerId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ExtensionName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ExtensionValue { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class RelatedDocuments
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FileName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Description { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class IdentificationSubstPrep
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime IssueDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime RevisionDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RevisionDateSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VersionNo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SpecificationNo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ItemNo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<string> ItemNo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProductNo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<ProductNo> ProductNo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProductIdentity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<IdentificationSubstPrepProductIdentity> ProductIdentity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<InformationOnTheSds> InformationOnTheSds { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ProductDiscontinuedFromMarket { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductDiscontinuedFromMarketSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public IdentificationSubstPrepRelevantIdentifiedUse RelevantIdentifiedUse { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public IdentificationSubstPrepUseAdvisedAgainst UseAdvisedAgainst { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ChemicalUsedByTheGeneralPublic ChemicalUsedByTheGeneralPublic { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("UseOfChemicalComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> UseOfChemicalComments { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SupplierInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<IdentificationSubstPrepSupplierInformation> SupplierInformation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EmergencyPhone", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<EmergencyPhone> EmergencyPhone { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InternalSdsId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("IdentificationComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> IdentificationComments { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ProductNo
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UserId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProductNoUser", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<string> ProductNoUser { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class IdentificationSubstPrepProductIdentity
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TradeName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Synonym", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<string> Synonym { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProductGtin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<ProductGtin> ProductGtin { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ProductDefinition { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class InformationOnTheSds
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SdsNotLegallyRequired", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> SdsNotLegallyRequired { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<CompleteSdsWithEsIncorporated> CompleteSdsWithEsIncorporated { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime DistributionStoppedDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DistributionStoppedDateSpecified { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class CompleteSdsWithEsIncorporated
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ExtendedSdsWithEsIncorporated { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ExtendedSdsWithEsIncorporatedComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ExtendedSdsWithEsIncorporatedComments { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class IdentificationSubstPrepRelevantIdentifiedUse
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("IdentifiedUse", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<IdentificationSubstPrepRelevantIdentifiedUseIdentifiedUse> IdentifiedUse { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProductType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ProductType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProductFunction", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<RelevantIdentifiedUseProductFunction> ProductFunction { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class IdentificationSubstPrepRelevantIdentifiedUseIdentifiedUse
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SectorOfUse", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<SectorOfUse> SectorOfUse { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProductCategory", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<ProductCategory> ProductCategory { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProcessCategory", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<ProcessCategory> ProcessCategory { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EnvironmentalReleaseCategory", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<EnvironmentalReleaseCategory> EnvironmentalReleaseCategory { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SpecificEnvironmentalReleaseCategory", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<SpecificEnvironmentalReleaseCategory> SpecificEnvironmentalReleaseCategory { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ArticleCategoryNoIntendedRelease", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<ArticleCategory> ArticleCategoryNoIntendedRelease { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ArticleCategoryWithIntendedRelease", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<ArticleCategory> ArticleCategoryWithIntendedRelease { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("CorrespondingExposureScenario", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<CorrespondingEs> CorrespondingExposureScenario { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string IdentifiedUseId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool PrintAsAttachment { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class EnvironmentalReleaseCategory
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EnvironmentalReleaseCategoryCodeEnum ErcCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ErcCodeSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ErcFulltext { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class SpecificEnvironmentalReleaseCategory
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SpercCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase SpercFulltext { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class RelevantIdentifiedUseProductFunction
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProductFunctionDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ProductFunctionDescription { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProductFunctionCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ProductFunctionCode { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class IdentificationSubstPrepUseAdvisedAgainst
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("NotToBeUsedIn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UseAdvisedAgainstNotToBeUsedIn[] NotToBeUsedIn { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OtherUseAdvisedAgainst", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> OtherUseAdvisedAgainst { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class UseAdvisedAgainstNotToBeUsedIn
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SectorOfUse", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<SectorOfUse> SectorOfUse { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProductCategory", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<ProductCategory> ProductCategory { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProcessCategory", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<ProcessCategory> ProcessCategory { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ArticleCategoryNoIntendedRelease", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<ArticleCategory> ArticleCategoryNoIntendedRelease { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ArticleCategoryWithIntendedRelease", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ArticleCategory[] ArticleCategoryWithIntendedRelease { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string IdentifiedUseId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool PrintAsAttachment { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ChemicalUsedByTheGeneralPublic
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool CanBeUsedByTheGeneralPublic { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CanBeUsedByTheGeneralPublicSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool UsedByTheGeneralPublicOnly { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UsedByTheGeneralPublicOnlySpecified { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class IdentificationSubstPrepSupplierInformation
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SupplierInformationRole Role { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CountryCodeEnum Country { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountrySpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SupplierInformationAddress Address { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Phone", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] Phone { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Fax", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] Fax { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Email", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] Email { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CompanyUrl { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("CompanyContact", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SupplierInformationCompanyContact[] CompanyContact { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LegalRegistrationNo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Duns { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class SupplierInformationRole
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RoleDescriptionEnum RoleCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RoleCodeSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ReachRoleDescriptionEnum ReachRole { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReachRoleSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase RoleDescription { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class SupplierInformationAddress
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VisitingAddressLine1 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VisitingAddressLine2 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VisitingAddressLine3 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VisitingAddressPostCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VisitingAddressCity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VisitingCountry { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PostAddressLine1 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PostAddressLine2 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PostAddressLine3 { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PostCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PostCity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PostCountry { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class SupplierInformationCompanyContact
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Phone { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Fax { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Url { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Email { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NationalContact { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EmailCompetentPerson { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class EmergencyPhone
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string No { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EmergencyPhoneDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> EmergencyPhoneDescription { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class HazardIdentification
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Classification Classification { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HazardIdentificationHazardLabelling HazardLabelling { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OtherHazardsInfo OtherHazardsInfo { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class HazardIdentificationHazardLabelling
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClpLabellingInfo ClpLabellingInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DpdDsdHazardLabelling DpdDsdHazardLabelling { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AdditionalInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> AdditionalInformation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool EcLabel { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EcLabelSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool TactileWarning { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TactileWarningSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ChildResistantOpening { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChildResistantOpeningSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LabellingAccordingToOtherEuLegislation LabellingAccordingToOtherEuLegislation { get; set; }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ClpLabellingInfo
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ClpHazardPictogram", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HazardPictogram[] ClpHazardPictogram { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SignalWord ClpSignalWord { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ClpHazardStatement", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<HazardStatement> ClpHazardStatement { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ClpPrecautionaryStatement", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<PrecautionaryStatement> ClpPrecautionaryStatement { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ClpSupplementalHazardInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<SupplementalHazardInformation> ClpSupplementalHazardInformation { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ClpSpecialSupplementalLabelInfoMixtures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<SpecialSupplementalLabelInfo> ClpSpecialSupplementalLabelInfoMixtures { get; set; }


        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ClpAdditionalLabellingInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ClpAdditionalLabellingInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ClpSpecialRulesOnPackaging", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ClpSpecialRulesOnPackaging { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class DpdDsdHazardLabelling
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DpdDsdHazardSymbol", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<HazardSymbolCodeEnum> DpdDsdHazardSymbol { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DpdDsdRiskPhrase", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<RiskPhrase> DpdDsdRiskPhrase { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DpdDsdSafetyPhrase", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<SafetyPhrase> DpdDsdSafetyPhrase { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DpdDsdOtherLabellingInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> DpdDsdOtherLabellingInformation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DpdDsdStandardPhrasesForSpecialRisks", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> DpdDsdStandardPhrasesForSpecialRisks { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DpdDsdStandardPhrasesForSafetyPrecautions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> DpdDsdStandardPhrasesForSafetyPrecautions { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DpdDsdLabellingComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> DpdDsdLabellingComments { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class LabellingAccordingToOtherEuLegislation
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("VocLabelling", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<LabellingAccordingToOtherEuLegislationVocLabelling> VocLabelling { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DetergentLabelling", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> DetergentLabelling { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AerosolLabelling", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> AerosolLabelling { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OtherEuLabellingRequirements", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> OtherEuLabellingRequirements { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class LabellingAccordingToOtherEuLegislationVocLabelling
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ProductSubcategory { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue VocLimitForSubcategory { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue MaxVocConcInMixture { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class OtherHazardsInfo
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("HazardDescriptionGeneral", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> HazardDescriptionGeneral { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PhysicochemicalEffect", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> PhysicochemicalEffect { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("HealthEffect", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> HealthEffect { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EnvironmentalEffect", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> EnvironmentalEffect { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EffectsOfMisuse", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> EffectsOfMisuse { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OtherHazards", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> OtherHazards { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class Composition
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Mixture", typeof(CompositionMixture), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElement("Substance", typeof(Substance), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object Item { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("CompositionComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> CompositionComments { get; set; }

    }
    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class CompositionMixture
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Component", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Component> Component { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DescriptionOfTheMixture", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> DescriptionOfTheMixture { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("CompositionComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> CompositionComments { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool IsDetergent { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsDetergentSpecified { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class FirstAidMeasures
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DescriptionOfFirstAidMeasures DescriptionOfFirstAidMeasures { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InformationToHealthProfessionals InformationToHealthProfessionals { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MedicalAttentionAndSpecialTreatmentNeeded MedicalAttentionAndSpecialTreatmentNeeded { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SpecificFirstAidEquipment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> SpecificFirstAidEquipment { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("FirstAidComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> FirstAidComments { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class DescriptionOfFirstAidMeasures
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("GeneralInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> GeneralInformation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("FirstAidInhalation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> FirstAidInhalation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("FirstAidSkin", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> FirstAidSkin { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("FirstAidEye", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> FirstAidEye { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("FirstAidIngestion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> FirstAidIngestion { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PersonalProtectionFirstAider", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> PersonalProtectionFirstAider { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class InformationToHealthProfessionals
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SymptomsAndEffectsGeneral", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> SymptomsAndEffectsGeneral { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AcuteSymptomsAndEffects", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> AcuteSymptomsAndEffects { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DelayedSymptomsAndEffects", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> DelayedSymptomsAndEffects { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class MedicalAttentionAndSpecialTreatmentNeeded
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("MedicalTreatment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> MedicalTreatment { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RequiredClinicalTesting", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> RequiredClinicalTesting { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RequiredMedicalMonitoring", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> RequiredMedicalMonitoring { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SpecificAntidotes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> SpecificAntidotes { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Contraindications", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> Contraindications { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class FireFightingMeasures
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExtinguishingMedia ExtinguishingMedia { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("FireAndExplosionHazards", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> FireAndExplosionHazards { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("HazardCombustionProd", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> HazardCombustionProd { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("FireFightingPrecautions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> FireFightingPrecautions { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("FireFightingProcedures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> FireFightingProcedures { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SpecialProtectiveEquipmentForFirefighters", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> SpecialProtectiveEquipmentForFirefighters { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("FireAndExplosionComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> FireAndExplosionComments { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ExtinguishingMedia
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("MediaToBeUsed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> MediaToBeUsed { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("MediaNotBeUsed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> MediaNotBeUsed { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class AccidentalReleaseMeasures
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("GeneralMeasures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> GeneralMeasures { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ForNonEmergencyPersonnel ForNonEmergencyPersonnel { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ForEmergencyResponders", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ForEmergencyResponders { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EnvironmentalPrecautions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> EnvironmentalPrecautions { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ContainmentAndCleaningUp ContainmentAndCleaningUp { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ReferenceToOtherSections", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ReferenceToOtherSections { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AdditionalInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> AdditionalInformation { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ForNonEmergencyPersonnel
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PersonalPrecautions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> PersonalPrecautions { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProtectiveEquipment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ProtectiveEquipment { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EmergencyProcedures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> EmergencyProcedures { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ContainmentAndCleaningUp
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Containment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> Containment { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("CleaningUp", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> CleaningUp { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OtherInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> OtherInformation { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class HandlingAndStorage
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SafeHandling SafeHandling { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("StoragePrecautions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> StoragePrecautions { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ConditionsToAvoid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ConditionsToAvoid { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ConditionsForSafeStorage ConditionsForSafeStorage { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SpecificEndUses SpecificEndUses { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class SafeHandling
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("HandlingPrecautions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> HandlingPrecautions { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SafeHandlingOfGasContainers", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> SafeHandlingOfGasContainers { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PrecautionaryMeasures PrecautionaryMeasures { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("FurtherInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> FurtherInformation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Comments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> Comments { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("GeneralOccupationalHygiene", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> GeneralOccupationalHygiene { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PrecautionaryMeasures
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProtectiveMeasures", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ProtectiveMeasures { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("MeasuresToPreventFire", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> MeasuresToPreventFire { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("MeasuresToPreventAerosolAndDust", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> MeasuresToPreventAerosolAndDust { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("MeasuresToProtectEnvironment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> MeasuresToProtectEnvironment { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ConditionsForSafeStorage
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("TechnicalMeasuresAndStorageConditions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> TechnicalMeasuresAndStorageConditions { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PackagingContainer", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> PackagingContainer { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RequirementsForStorageRoomsAndVessels", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> RequirementsForStorageRoomsAndVessels { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("HintsOnStorageAssembly", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> HintsOnStorageAssembly { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("FurtherInformationOnStorageConditions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> FurtherInformationOnStorageConditions { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue StorageTemperature { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue StoragePressure { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue StorageAirHumidity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("StorageStability", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<StorageStability> StorageStability { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class SpecificEndUses
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Recommendations", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> Recommendations { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("IndustrialSectorSpecificSolutions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> IndustrialSectorSpecificSolutions { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class StabilityReactivity
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ReactivityDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ReactivityDescription { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("StabilityDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> StabilityDescription { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("HazardousReactions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> HazardousReactions { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ConditionsToAvoid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ConditionsToAvoid { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("MaterialsToAvoid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> MaterialsToAvoid { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("HazardousDecompositionProducts", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> HazardousDecompositionProducts { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Comments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> Comments { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class DisposalConsiderations
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("WasteTreatment", typeof(WasteTreatment), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElement("WasteTreatmentMethods", typeof(Phrase), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object[] Items { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EuRequirements EuRequirements { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Comments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> Comments { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class WasteTreatment
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProductWaste", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ProductWaste { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PackagingWaste", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> PackagingWaste { get; set; }
    }
    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class EuRequirements
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EuropeanWasteList EuropeanWasteList { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EuWasteRegulations", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> EuWasteRegulations { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class EuropeanWasteList
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EWLProduct", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WasteListEntry[] EWLProduct { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EWLPacking", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WasteListEntry[] EWLPacking { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class TransportInformation
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool DangerousGoodsAdrRidAdnImdgIcaoIata { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DangerousGoodsAdrRidAdnImdgIcaoIataSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnNo UnNo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProperShippingName ProperShippingName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HazardClassification TransportHazardClassification { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PackingGroup PackingGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EnvironmentalHazards EnvironmentalHazards { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SpecialPrecautionUser", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> SpecialPrecautionUser { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransportInBulk TransportInBulk { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OtherTransportInformation OtherTransportInformation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Comments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> Comments { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class UnNo
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UnNoAdrRidAdn { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UnNoImdg { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UnNoIcao { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Comments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> Comments { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ProperShippingName
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AdrRidAdn AdrRidAdn { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Imdg Imdg { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Icao Icao { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ProperShippingNameComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ProperShippingNameComments { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class AdrRidAdn
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ProperShippingNameEnglishAdrRidAdn { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ProperShippingNameNationalAdrRidAdn { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DangerReleasingSubstanceAdrRidAdn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> DangerReleasingSubstanceAdrRidAdn { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DangerReleasingSubstanceNationalAdrRidAdn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> DangerReleasingSubstanceNationalAdrRidAdn { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class Imdg
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ProperShippingNameEnglishImdg { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DangerReleasingSubstanceImdg", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> DangerReleasingSubstanceImdg { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class Icao
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ProperShippingNameEnglishIcao { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("DangerReleasingSubstanceIcao", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> DangerReleasingSubstanceIcao { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class HazardClassification
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HazardClassificationAdrRidAdn AdrRidAdn { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HazardClassificationImdg Imdg { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HazardClassificationIcaoIata IcaoIata { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("TransportHazardClassificationComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> TransportHazardClassificationComments { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class HazardClassificationAdrRidAdn
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ClassAdrRidAdn { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ClassCodeAdrRidAdn { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SubsidiaryRiskAdrRidAdn", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> SubsidiaryRiskAdrRidAdn { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class HazardClassificationImdg
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ClassImdg { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ClassCodeImdg { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SubsidiaryRiskImdg", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> SubsidiaryRiskImdg { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class HazardClassificationIcaoIata
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ClassIcaoIata { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ClassCodeIcaoIata { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SubsidiaryRiskIcaoIata", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> SubsidiaryRiskIcaoIata { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PackingGroup
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PackingGroupEnum PackingGroupAdrRidAdn { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PackingGroupAdrRidAdnSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PackingGroupEnum PackingGroupImdg { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PackingGroupImdgSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PackingGroupEnum PackingGroupIcaoIata { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PackingGroupIcaoIataSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PackingGroupComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> PackingGroupComments { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class EnvironmentalHazards
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool EnvironmHazardAccordAdrRidAdn { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnvironmHazardAccordAdrRidAdnSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EnvironmentalHazardsImdg Imdg { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool EnvironmHazardAccordIcaoIata { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnvironmHazardAccordIcaoIataSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EnvironmentalHazardsDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> EnvironmentalHazardsDescription { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class EnvironmentalHazardsImdg
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool EnvironmHazardAccordImdg { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnvironmHazardAccordImdgSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool MarinePollutant { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MarinePollutantSpecified { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class TransportInBulk
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool TransportInBulkValue { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ProductName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ShipType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ShipType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PollutionCategory", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> PollutionCategory { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class OtherTransportInformation
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransportHazardLabels TransportHazardLabels { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OtherTransportGeneral", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> OtherTransportGeneral { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AdrOtherInformation AdrOtherInformation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RidOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> RidOtherInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AdnOtherInformation AdnOtherInformation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImdgOtherInformation ImdgOtherInformation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("IcaoIataOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> IcaoIataOtherInfo { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class TransportHazardLabels
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AdrRidAdnHazardLabel", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> AdrRidAdnHazardLabel { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ImdgHazardLabel", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ImdgHazardLabel { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("IcaoIataHazardLabel", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> IcaoIataHazardLabel { get; set; }

    }
    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class AdrOtherInformation
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AdrOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> AdrOtherInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AdrTunnelRestrictionCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> AdrTunnelRestrictionCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AdrLimitedQty", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> AdrLimitedQty { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AdrTransportCategory", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> AdrTransportCategory { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase AdrHazardIdentificationNo { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class AdnOtherInformation
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AdnOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> AdnOtherInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AdnSpecialProvisions", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> AdnSpecialProvisions { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ImdgOtherInformation
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ImdgOtherInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ImdgOtherInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ImdgEmsCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] ImdgEmsCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ImdgLimitedQty", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ImdgLimitedQty { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class RegulatoryInfo
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SpecificProvisionsRelatedToProduct SpecificProvisionsRelatedToProduct { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalLegislation NationalLegislation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RegulatoryInformationComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> RegulatoryInformationComments { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DatasheetFeedDatasheetRegulatoryInfoChemicalSafetyAssessmentInfo ChemicalSafetyAssessmentInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ChemicalSafetyReport ChemicalSafetyReport { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExposureScenario ExposureScenario { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RegulatoryInfoAdditionalInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> RegulatoryInfoAdditionalInfo { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class SpecificProvisionsRelatedToProduct
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SpecificProvisionsRelatedToProductEuLegislation EuLegislation { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class SpecificProvisionsRelatedToProductEuLegislation
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AssessmentEnum AssessedLegislation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AssessedLegislationSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EuAuthorisation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> EuAuthorisation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EuRestrictionsOnUse", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> EuRestrictionsOnUse { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RestrictionsAccordingReach", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> RestrictionsAccordingReach { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Detergents", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> Detergents { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SpecificProvisionsRelatedToProductEuLegislationVoc Voc { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EuLegislationIndustrialEmissions IndustrialEmissions { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EuLegislationCertainFluorinatedGreenhouseGases CertainFluorinatedGreenhouseGases { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("OtherEuLegislation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> OtherEuLegislation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EuRestrictionsOfOccupation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> EuRestrictionsOfOccupation { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class SpecificProvisionsRelatedToProductEuLegislationVoc
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PercentageValue VocInPercentByWeight { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue VocValue { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("VocRestrictionComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> VocRestrictionComments { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class EuLegislationIndustrialEmissions
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PercentageValue VocInPercentByWeight { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue VocValue { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase OtherInformation { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class EuLegislationCertainFluorinatedGreenhouseGases
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase FluorinatedGreenhouseGasesMethod { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("FluorinatedGreenhouseGasesComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> FluorinatedGreenhouseGasesComments { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class NationalLegislation
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionAD NationalLegislationAndorra { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionAL NationalLegislationAlbania { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionAM NationalLegislationArmenia { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionAT NationalLegislationAustria { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionBA NationalLegislationBosniaAndHerzegovina { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionBE NationalLegislationBelgium { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionBG NationalLegislationBulgaria { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionBY NationalLegislationBelarus { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionCH NationalLegislationSwitzerland { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionCZ NationalLegislationCzechRepublic { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionDE NationalLegislationGermany { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionDK NationalLegislationDemnark { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionEE NationalLegislationEstonia { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionES NationalLegislationSpain { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionFI NationalLegislationFinland { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionFR NationalLegislationFrance { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionGB NationalLegislationUnitedKingdom { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionGE NationalLegislationGeorgia { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionGR NationalLegislationGreece { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionHR NationalLegislationCroatia { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionHU NationalLegislationHungary { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionIE NationalLegislationIreland { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionIS NationalLegislationIceland { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionIT NationalLegislationItaly { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionKZ NationalLegislationKazakhstan { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionLI NationalLegislationLiechtenstein { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionLT NationalLegislationLithuania { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionLU NationalLegislationLuxembourg { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionLV NationalLegislationLatvia { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionMC NationalLegislationMonaco { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionMD NationalLegislationRepublicOfMoldova { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionME NationalLegislationMontenegro { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionMK NationalLegislationTheFormerYugoslavRepublicOfMacedonia { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionMT NationalLegislationMalta { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionNL NationalLegislationNetherlands { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionNO NationalLegislationNorway { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionPL NationalLegislationPoland { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionPT NationalLegislationPortugal { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionRO NationalLegislationRomania { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionRS NationalLegislationSerbia { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionRU NationalLegislationRussianFederation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionSE NationalLegislationSweden { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionSI NationalLegislationSlovenia { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionSK NationalLegislationSlovakia { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionSM NationalLegislationSanMarino { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionTR NationalLegislationTurkey { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionUA NationalLegislationUkraine { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionUZ NationalLegislationUzbekistan { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public NationalExtensionVA NationalLegislationVaticanCityState { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class DatasheetFeedDatasheetRegulatoryInfoChemicalSafetyAssessmentInfo
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ChemicalSafetyAssessmentCarriedOut { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChemicalSafetyAssessmentCarriedOutSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ChemicalSafetyAssessment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ChemicalSafetyAssessment { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ChemicalSafetyReport
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool CsrRequired { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CsrRequiredSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("CsrLocation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> CsrLocation { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ExposureScenario
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool MixtureExposureScenarioInAnnex { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MixtureExposureScenarioInAnnexSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ExposureScenarioComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ExposureScenarioComments { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class OtherInformation
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ManufacturersNotes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ManufacturersNotes { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RelevantRiskPhrases", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<RiskPhrase> RelevantRiskPhrases { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RelevantHazardStatements", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HazardStatement[] RelevantHazardStatements { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClassificationAccordingClp ClassificationAccordingClp { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("EducationalRecommendations", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> EducationalRecommendations { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RecommendedRestriction", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> RecommendedRestriction { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("FurtherInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> FurtherInformation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("MainInformationSource", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> MainInformationSource { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("AbbreviationsAndAcronymsUsed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> AbbreviationsAndAcronymsUsed { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RevisionInformation RevisionInformation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("QualityAssuranceStatement", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> QualityAssuranceStatement { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SdsStatus", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> SdsStatus { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ResponsibleOwnerSds", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ResponsibleOwnerSds { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PreparedBy SdsPreparedBy { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Comments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> Comments { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("PositiveEcolabelling", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PositiveEcolabelling[] PositiveEcolabelling { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ContentsOrIndexOfAnnexedEs", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ContentsOrIndexOfAnnexedEs { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ClassificationAccordingClp
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ClpHazardClassification", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClassificationAccordingClpClpHazardClassification[] ClpHazardClassification { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ClpClassificationComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ClpClassificationComments { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ClpClassificationNotes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ClpClassificationNotes { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ClassificationAccordingClpClpHazardClassification
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HazardClassCategoryEnum ClpHazardClassCategory { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HazardStatement ClpHazardStatement { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase ClpClassificationProcedure { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClpHazardClassificationMultiplyingFactor MultiplyingFactor { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ClpHazardClassificationMultiplyingFactor
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FactorValue { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("FactorComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> FactorComments { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class RevisionInformation
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RevisionNo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase RevisionComments { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RevisionResponsible", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> RevisionResponsible { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime LastUpdateDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastUpdateDateSpecified { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PreparedBy
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Phone { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Email", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<string> Email { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class PositiveEcolabelling
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EcoLabelName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime ExpirationDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpirationDateSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LicenceNo { get; set; }
    }
}
