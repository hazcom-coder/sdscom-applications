using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class TaLuft
    {

        private UnitValue weightFractionField;

        private Phrase[] classOrClassesField;

        private Phrase noField;

        private Phrase[] remarkField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue WeightFraction
        {
            get
            {
                return this.weightFractionField;
            }
            set
            {
                this.weightFractionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ClassOrClasses", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] ClassOrClasses
        {
            get
            {
                return this.classOrClassesField;
            }
            set
            {
                this.classOrClassesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase No
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
        [System.Xml.Serialization.XmlElement("Remark", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Remark
        {
            get
            {
                return this.remarkField;
            }
            set
            {
                this.remarkField = value;
            }
        }
    }
}
