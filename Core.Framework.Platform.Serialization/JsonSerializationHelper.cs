/*
 * Created by SharpDevelop.
 * User: tharu.raju.melath
 * Date: 11/1/2016
 * Time: 4:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
namespace Core.Framework.Platform.Serialization
{
	/// <summary>
	/// Description of JsonSerializationHelper, Takes any Custom class to be Serialized/Deserialized
	/// </summary>
	[DataContract]
	public class JsonSerializationHelper<T> where T : class , new()
	{
		/// <summary>
		/// Input to this DeserializeJsonFromFile is SerializationEntity which consists of FilePath, FileExtention etc
		/// And returns the Type of the Custom Class (Deserialized using the FilePath and FileExtension Mapped in 
		/// the SerializationEntity).
		/// </summary>
		/// <param name="pobjSerializationEntity"></param>
		/// <returns></returns>
		 public static T DeserializeJsonFromFile(SerializationEntity pobjSerializationEntity)
		 {
		 	
		 	T t = default(T);
			string lstrActualFilePath = pobjSerializationEntity.FilePath.Trim() + "." + pobjSerializationEntity.FileExtension;
			if(File.Exists(lstrActualFilePath))
			{
				StreamReader ss  = new StreamReader(lstrActualFilePath);
				string str = ss.ReadToEnd(); 			
			    MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(str));					
			    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
			    t  = (T)ser.ReadObject(ms);
			    ss.Close();
			    ms.Close(); 
			}
			else
			{
				if (string.IsNullOrEmpty(pobjSerializationEntity.FilePath))
                     throw new ArgumentException("Source :DeserializeJsonFromFile,FilePath cannot be Empty ,Kindly Specify a Valid File Path.");
                else
                	 throw new ArgumentException("Source :DeserializeJsonFromFile,File Doesnt Exist!!!" );
			}
			return t; 
		 }


	}
}
