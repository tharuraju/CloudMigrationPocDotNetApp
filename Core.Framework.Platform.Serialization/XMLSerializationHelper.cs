/*
 * Created by SharpDevelop.
 * User: tharu.raju.melath
 * Date: 10/19/2016
 * Time: 3:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.IO;


namespace Core.Framework.Platform.Serialization
{
	/// <summary>
	///  Description of XMLSerializationHelper, Takes any Custom class to be Serialized/Deserialized
	/// </summary>
	public class XMLSerializationHelper<T> where T : class ,new()
	{
		/// <summary>
		/// Input to this Custom Class, is SerializationEntity which consists of FilePath, FileExtention etc ,
		/// And Returns the Type of the Custom Class (Deserialized from the FilePath and FileExtension Mapped in 
        /// the SerializationEntity)		
		/// </summary>
		/// <param name="pobjSerializationEntity"></param>
		/// <returns></returns>
		public static T DeserializeFromXmlFile(SerializationEntity pobjSerializationEntity)
         {	
			//Console.WriteLine("Entered DeserializeFromXmlFile Method ");
			T t = default(T);
			try
			{
				string lstrActualFilePath = pobjSerializationEntity.FilePath.Trim() + "." + pobjSerializationEntity.FileExtension;
				//Console.WriteLine("Actual File Path -- " + lstrActualFilePath);
				if(File.Exists(lstrActualFilePath))
				{
					XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
					TextReader textReader = new StreamReader(lstrActualFilePath);
					t = (T)xmlSerializer.Deserialize(textReader);				 
					textReader.Close();
                   	//Console.WriteLine("Finished DeserializeFromXmlFile Method ");				
				}
				else
				{
					if (string.IsNullOrEmpty(pobjSerializationEntity.FilePath ))
	                     throw new ArgumentException("Source :XMLSerializationHelper,FilePath cannot be Empty ,Kindly Specify a Valid File Path.");
	                else
	                	 throw new ArgumentException("Source :XMLSerializationHelper,File Doesnt Exist!!!" );
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine("Exception from DeserializeFromXmlFile Method: " +ex.StackTrace);
			}
			//Console.ReadKey();
		
			return t;
         }
		
	}
	
	 
}
	
	

