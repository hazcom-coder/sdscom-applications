using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
}
