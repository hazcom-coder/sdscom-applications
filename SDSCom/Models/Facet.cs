using System;
using Npgsql;
using NpgsqlTypes;
using ServiceStack.DataAnnotations;

namespace SDSCom.Models
{
    public class Facet
    {
        public Facet()
        {

        }

        [StringLength(100)]
        [Required]
        public string ParentPath { get; set; }

        [Required]
        public int ParentId { get; set; }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        [PrimaryKey]
        public int Id { get; set; }

        [StringLength(10)]
        [Required]
        public string MinOccurs { get; set; }

        [StringLength(10)]
        [Required]
        public string MaxOccurs { get; set; }

        [StringLength(50)]
        [Required]
        public string DataType { get; set; }

        [Required]
        public DateTime DateStamp { get; set; }

        [Required]
        public string SDSComVersion { get; set; }

        [Required]
        public string SchemaFileName { get; set; }

        public string Comments { get; set; }

        public int MaxSize { get; set; }

    }

}
