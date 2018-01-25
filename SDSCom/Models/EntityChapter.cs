using System;
using Npgsql;
using NpgsqlTypes;
using ServiceStack.DataAnnotations;

namespace SDSCom.Models
{
    public class EntityChapter
    {
        public EntityChapter()
        {

        }

        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

        [Required]
        public long EntityId { get; set; }

        [StringLength(100)]
        [Required]
        public string ChapterName { get; set; }

        [CustomField("json")]
        public string Data { get; set; }

        [Required]
        public DateTime DateStamp { get; set; }

        [Required]
        public int UserId { get; set; }


    }
}
