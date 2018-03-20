using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class Substance
    {  
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SubstanceName {get; set;}
      
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CasNo  {get; set;}
       

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IndexNo {get; set;}
       
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AuthorisationNo {get; set;}
       
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EcNo {get; set;}
       
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ReachRegNo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<string> ReachRegNo {get; set;}
       
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ReachRegNoComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ReachRegNoComments {get; set;}
       
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IdNoCLInventory {get; set;}
       
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Synonym", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<string> Synonym {get; set;}
      
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Formula {get; set;}
      
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IupacName {get; set;}
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ProductNameInSection2 {get; set;}
      
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ProductNameInSection3 {get; set;}
       
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ProductNameInSection8 {get; set;}
       
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NameDetergentsRegulation {get; set;}
      
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("SubstanceAdditionalInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> SubstanceAdditionalInformation {get; set;}
       
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("HazardousImpurities", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> HazardousImpurities {get; set;}
       
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("Stabilizer", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> Stabilizer {get; set;}      

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ChemicalPurity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ChemicalPurity {get; set;}      

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ChemicalProperties", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List<Phrase> ChemicalProperties {get; set;}
    }
}
