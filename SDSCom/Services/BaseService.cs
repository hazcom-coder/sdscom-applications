﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.IO;
using Serilog;
using System.Xml;
using System.Xml.Serialization;

namespace SDSCom.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseService
    {
        private readonly SDSComContext db;
        private IMemoryCache cache;

        public const int DATASHEET_ID = 1;      //  Datasheet
        public const int CHAPTER_0_ID = 2;      //"InformationFromExportingSystem"
        public const int CHAPTER_1_ID = 26;     //"IdentificationSubstPrep"
        public const int CHAPTER_2_ID = 116;    //"HazardIdentification"
        public const int CHAPTER_3_ID = 155;    //"Composition"
        public const int CHAPTER_4_ID = 163;    //"FirstAidMeasures"
        public const int CHAPTER_5_ID = 183;    //"FireFightingMeasures"
        public const int CHAPTER_6_ID = 193;    //"AccidentalReleaseMeasures"
        public const int CHAPTER_7_ID = 207;    //"HandlingAndStorage"
        public const int CHAPTER_8_ID = 234;    //"ExposureControlPersonalProtection"
        public const int CHAPTER_9_ID = 235;    //"PhysicalChemicalProperties"
        public const int CHAPTER_10_ID = 236;   //"StabilityReactivity"
        public const int CHAPTER_11_ID = 244;   //"ToxicologicalInformation"
        public const int CHAPTER_12_ID = 245;   //"EcologicalInformation"
        public const int CHAPTER_13_ID = 246;   //"DisposalConsiderations"
        public const int CHAPTER_14_ID = 257;   //"TransportInformation"
        public const int CHAPTER_15_ID = 331;   //"RegulatoryInfo"
        public const int CHAPTER_16_ID = 413;   //"OtherInformation"


        /// <summary>
        /// 
        /// </summary>
        public BaseService(SDSComContext _db, IMemoryCache _cache)
        {
            db = _db;
            cache = _cache;
        } 
        public string ReadFile(string importPath)
        {
            string ret = string.Empty;

            try
            {
                using (StreamReader sr = new StreamReader(importPath))
                {
                    ret = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Log.Error(e, "Import>ReadFile: File Name:" + importPath);
            }

            return ret;
        }
 

        public T Deserialize<T>(string input) where T : class
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }

        public string Serialize<T>(T ObjectToSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, ObjectToSerialize);
                return textWriter.ToString();
            }
        }

        

        #region caching

        public void SaveToCache<T>(string key, T item)
        { 
            cache.Set<T>(key, item);            
        }

        public T GetFromCache<T>(string key)
        {
            return cache.Get<T>(key);
        }

        #endregion
    }
}
