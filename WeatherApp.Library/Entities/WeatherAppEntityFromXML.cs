using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace WeatherApp.Library.Entities
{
   [XmlRoot("WheatherAppXML")]
    public class WeatherAppEntityFromXML
    {
        

        [XmlElementAttribute("Credentials")]
        public WheatherAppCredentialsCredentials FinalTemplate
        {
            get;
            set;
        }
    }

    public  class WheatherAppCredentialsCredentials 
    {
    
        private string userNameField;    
        private string passwordField;


        [XmlElementAttribute("username")]
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }

        [XmlElementAttribute("password")]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
    }
}
