﻿using System;
using Npgsql;
using NpgsqlTypes;

namespace SDSCom.Models
{
    public class DataSheetFeedImport
    {
        public DataSheetFeedImport()
        {

        }

        public long Id { get; set; }

        public string FileName { get; set; }

        public string FileContent { get; set; }

        public DateTime DateStamp { get; set; }

        public int UserId { get; set; }

        public bool IsValid { get; set; }

        public string ValidationMessage { get; set; }
    }
}
