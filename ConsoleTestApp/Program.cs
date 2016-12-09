using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Framework.Platform.Serialization;
using WeatherApp.Library.Entities;
using System.Xml.Serialization;
using System.IO;
using WeatherApp.Library;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SerializationEntity lobjSerializationEntity = new SerializationEntity();
            lobjSerializationEntity.FileExtension = "XML";
            lobjSerializationEntity.FilePath = @"C:\Users\tharu.raju.melath\CloudUtilityFiles\XMLFinal\XMLFinal\WTM";
            WeatherAppEntityFromXML lobjWappCredentials = XMLSerializationHelper<WeatherAppEntityFromXML>.DeserializeFromXmlFile(lobjSerializationEntity);
            //WeatherAppEntityFromXML lobjWappCredentials = GetDependenciesFromXML();
            //FinalJsonTemplate lobjFinalJson = GetDependenciesForFinalJson(); 
            Console.ReadKey();
        }        
    }
}
