using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SDSCom.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class User
    {
        /// <summary>
        /// 
        /// </summary>
        public User()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        
        public bool IsAdmin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [EmailAddress]
        public string Email { get; set; }


    }
}
