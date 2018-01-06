using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

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
        [AutoIncrement]
        [PrimaryKey]
        public long ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// 
        [System.ComponentModel.DataAnnotations.Required]
        public int UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DateStamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Required]
        [StringLength(1000, MinimumLength = 3)]
        public string EntityName { get; set; }

        /// <summary>
        /// 
        /// </summary>
       [StringLength(100)]
        public string OtherId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Required]
        public bool Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Required]
        public int EntityType { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class EntityType
    {
        /// <summary>
        /// 
        /// </summary>
        [AutoIncrement]
        [PrimaryKey]
        public int ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [System.ComponentModel.DataAnnotations.Required]
        [StringLength(50, MinimumLength = 3)]
        public string EntityTypeName { get; set; }
    }
}
