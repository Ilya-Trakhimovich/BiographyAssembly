using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson21
{
    public class InfoMetadataAttribute : Attribute
    {
        public string PathToSerializedFile { get;set; }
        public string SerializedFileName { get; set; }
    }
}
