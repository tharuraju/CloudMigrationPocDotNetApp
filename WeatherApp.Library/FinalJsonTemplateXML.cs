using System;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace WeatherApp.Library
{
    /// <summary>
    /// Description of FinalJsonTemplate.
    /// </summary>
    [XmlRoot("WheatherAppXML")]
    public class FinalJsonTemplate
    {

        [XmlElementAttribute("Credentials")]
        public FinalJsonTemplates FinalTemplate
        {
            get;
            set;
        }

    }
    public class FinalJsonTemplates
    {

        [XmlElementAttribute("applicationType")]
        public string applicationType
        { get; set; }

        [XmlElementAttribute("applicationId")]
        public string applicationId
        { get; set; }

        [XmlElementAttribute("runtime")]
        public string runtime
        { get; set; }

        [XmlElementAttribute("middleware")]
        public string middleware
        { get; set; }

        [XmlElementAttribute("middlewareVersion")]
        public string middlewareVersion
        { get; set; }


        [XmlElementAttribute("dataBase")]
        public string dataBase
        { get; set; }


        [XmlElementAttribute("dataBaseVersion")]
        public string dataBaseVersion
        { get; set; }


        [XmlElementAttribute("applicationServer")]
        public string applicationServer
        { get; set; }


        [XmlElementAttribute("applicationServerVersion")]
        public string applicationServerVersion
        { get; set; }
    }
}
