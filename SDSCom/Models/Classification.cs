using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Classification
    {
        public ClpClassification ClpClassification {get; set;}

        public ClassificationDpdDsdClassification DpdDsdClassification {get; set;}       

        public List<Phrase> SimpleClassificationDescription {get; set;} 

        public List<Phrase> ClassificationAdditionalInformation {get; set;}       
    }
}
