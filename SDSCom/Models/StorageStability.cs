using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <remarks/>
    public class StorageStability
    {

        private UnitValue storageTemperatureField;

        private UnitValue pressureField;

        private UnitValue maximumStoragePeriodField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue StorageTemperature
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
        public UnitValue Pressure
        {
            get
            {
                return this.pressureField;
            }
            set
            {
                this.pressureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue MaximumStoragePeriod
        {
            get
            {
                return this.maximumStoragePeriodField;
            }
            set
            {
                this.maximumStoragePeriodField = value;
            }
        }
    }
}
