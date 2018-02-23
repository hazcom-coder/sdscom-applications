using System;
using System.Collections.Generic;
using System.IO;

namespace SDSCom
{
    public partial class SDSComApp
    {
        //various helper methods for app-wide use

        public string GetConnectionString()
        {
            string retVal = string.Empty;
            using (StreamReader sr = new StreamReader("files/connection.txt"))
            {
                retVal = sr.ReadToEnd();
            }
            return retVal;
        }
    }
}
