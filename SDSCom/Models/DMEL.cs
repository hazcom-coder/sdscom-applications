﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class DMEL
    {
        private EffectLevelGroupEnum groupField;

        private EffectLevelTypeEnum exposureRouteFrequencyAndEffectField;

        private UnitValue dmelValueField;

        private Phrase referenceField;

        private Phrase[] commentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EffectLevelGroupEnum Group
        {
            get
            {
                return this.groupField;
            }
            set
            {
                this.groupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EffectLevelTypeEnum ExposureRouteFrequencyAndEffect
        {
            get
            {
                return this.exposureRouteFrequencyAndEffectField;
            }
            set
            {
                this.exposureRouteFrequencyAndEffectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue DmelValue
        {
            get
            {
                return this.dmelValueField;
            }
            set
            {
                this.dmelValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
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
}
