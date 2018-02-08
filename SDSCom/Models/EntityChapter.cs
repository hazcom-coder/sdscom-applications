using System;
using Npgsql;
using NpgsqlTypes;
using System.ComponentModel.DataAnnotations;

namespace SDSCom.Models
{
    public class EntityChapter
    {
        public EntityChapter()
        {

        }

        [Key]
        public int Id { get; set; }

        public long EntityId { get; set; }

        public string ChapterName { get; set; }

        public string Data { get; set; }

        public DateTime DateStamp { get; set; }

        public int UserId { get; set; }


    }
}
