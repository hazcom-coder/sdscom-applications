using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class FlashPoint
    {
        private PhysChemUnitValue valueField;

        private Phrase[] evaluationField;

        private Phrase[] valueCommentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue Value
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
        [System.Xml.Serialization.XmlElement("Evaluation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Evaluation
        {
            get
            {
                return this.evaluationField;
            }
            set
            {
                this.evaluationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ValueComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ValueComments
        {
            get
            {
                return this.valueCommentsField;
            }
            set
            {
                this.valueCommentsField = value;
            }
        }
    }


}
