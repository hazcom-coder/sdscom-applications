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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class DatasheetFeed
    {

        private Datasheet datasheetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Datasheet Datasheet
        {
            get
            {
                return this.datasheetField;
            }
            set
            {
                this.datasheetField = value;
            }
        }
    }
}
