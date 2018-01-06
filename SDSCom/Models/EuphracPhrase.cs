using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDSCom.Models
{
    /// <remarks/>
	public class EuphracPhrase
	{
        /// <remarks/>
		public EuphracPhrase(){}
        /// <remarks/>
		public string EuPhraCStructureCode {get; set;}
        /// <remarks/>
        public string Region {get; set;}
        /// <remarks/>
		public string EuPhraCPhraseID {get; set;}
        /// <remarks/>
		public string English {get; set;}
        /// <remarks/>
		public string German {get; set;}
        /// <remarks/>
		public string RevisionDate {get; set;}
        /// <remarks/>
		public string Source {get; set;}
        /// <remarks/>
        public string Owner { get; set; }
    }
}