using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SDSCom.Models 
{
    /// <summary>
    /// Base object for sDSCom applications. this type includes Products and Components
    /// </summary>
    
    public class Entity 
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// 
        
        public int UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DateStamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        
        public string EntityName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OtherId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        
        public bool Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int EntityType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double VersionNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SchemaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Properties  { get; set; }

    }

    /// <summary>
    /// 
    /// </summary>
    public class EntityType
    {
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EntityTypeName { get; set; }
    }

    public enum EntityStatusEnum
    {
        New = 0,

        Draft = 1,

        Active = 2,

        Inactive = 3
    }
}
