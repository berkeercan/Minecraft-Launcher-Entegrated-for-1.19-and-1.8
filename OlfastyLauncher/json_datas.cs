using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlfastyLauncher
{
    //VERSION
    public class _version
    {
        public versions_[] versions { get; set; }
    }
    public class versions_
    {
        public string id { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }
    //LIBRARY
    public class lbget
    {
        public Library_[] libraries { get; set; }
        public asset_ assetIndex { get; set; }
    }
    public class Library_
    {
        public Downloads_ downloads { get; set; }
        public Artifact_ artifact { get; set; }

        public Classifiers_ classifiers { get; set; }
    }
    public class Downloads_
    {
        public Artifact_ artifact { get; set; }
        public Classifiers_ classifiers { get; set; }
    }
    public class Artifact_
    {
        public string path { get; set; }
        public int size { get; set; }
        public string url { get; set; }
    }
    public class Classifiers_
    {
        [JsonProperty("natives-windows")]
        public nativ_ nativeswindows { get; set; }

        public nativ_ windows { get; set; }
        [JsonProperty("natives-windows-64")]
        public nativ_ nativeswindows2 { get; set; }

    }
    public class nativ_
    {
        public string url { get; set; }
    }
    public class asset_
    {
        public string url { get; set; }
        public string id { get; set; }
    }
}
