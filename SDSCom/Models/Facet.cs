using System;
using Npgsql;
using NpgsqlTypes;

namespace SDSCom.Models
{
    public class Facet
    {
        public Facet()
        {

        }

        public string ParentPath { get; set; }

        public int ParentId { get; set; }

        public string Name { get; set; }

        public int Id { get; set; }

        public string MinOccurs { get; set; }

        public string MaxOccurs { get; set; }

        public string DataType { get; set; }

        public DateTime DateStamp { get; set; }

        public string SDSComVersion { get; set; }

        public string SchemaFileName { get; set; }

        public string Comments { get; set; }

        public int MaxSize { get; set; }

    }

}
