using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    public class ClpClassification
    {

        public List<ClpHazardClassification> ClpHazardClassification {get; set;}
      
        public List<Phrase> ClpClassificationComments {get; set;}       

        public List<Phrase> ClpClassificationNotes {get; set;}      
    }

    public class ClpHazardClassification
    {
        public HazardClassCategoryEnum ClpHazardClassCategory {get; set;}

        public List<HazardStatement> ClpHazardStatement {get; set;}

        public Phrase ClpClassificationProcedure {get; set;}
       
       public MultiplyingFactor MultiplyingFactor {get; set;}
    }

    /// <summary>
    /// 
    /// </summary>
    public class HazardStatement
    {
        public HazardStatementEnum PhraseCode {get; set;}

        public string FullText {get; set;}

        public List<MergePhrase> MergePhrase {get; set;}

        public string PhraseId {get; set;}
       
        public string PhraseCatalogueId {get; set;}
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public class ClassificationDpdDsdClassification
    {
        public List<DPDHazardClassification> DpdDsdHazardClassification {get; set;}

        public List<Phrase> DpdDsdClassificationComments {get; set;}

         public List<Phrase> DpdDsdClassificationNotes {get; set;}
    }

    public class DPDHazardClassification
    {
        public ClassificationCategoryEnum DpdDsdClassificationCategory {get; set;}

        public bool DpdDsdClassificationCategorySpecified {get; set;}

         public List<RiskPhrase> DpdDsdRiskPhrase {get; set;}
        public DpdDsdHazardClassificationMultiplyingFactor MultiplyingFactor {get; set;}
    }
}
