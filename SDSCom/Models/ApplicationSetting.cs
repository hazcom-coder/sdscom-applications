using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


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
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Area")]
        public string Area { get; set; }

        /// <summary>
        /// 
        /// </summary>   
        [Display(Name = "Setting")]
        public string Setting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Data Value")]
        public string DataValue { get; set; }
    }
}
