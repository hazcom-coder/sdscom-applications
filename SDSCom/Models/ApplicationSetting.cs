using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace SDSCom.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplicationSetting
    {
        /// <summary>
        /// 
        /// </summary>
        [AutoIncrement]
        [PrimaryKey]
        [Required]
        public long ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(50)]
        [Required]
        public string Area { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(100)]
        [Required]
        public string Setting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(2000)]
        [Required]
        public string DataValue { get; set; }
    }
}
