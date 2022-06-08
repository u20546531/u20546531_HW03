using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWA3.Models
{
    public class FileModel
    {
       public int id { get; set; }
       public string FileName { get; set; }
        public string Link { get; set; }
        public string type { get; set; }
       public string path { get; set; }
    }
}