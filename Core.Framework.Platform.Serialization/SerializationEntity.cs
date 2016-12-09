/*
 * Created by SharpDevelop.
 * User: tharu.raju.melath
 * Date: 11/1/2016
 * Time: 3:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Core.Framework.Platform.Serialization
{
	/// <summary>
	/// Description of SerializationEntity.
	/// </summary>
	[DataContract]
	public class SerializationEntity
	{
		  #region private variables
		  private string mstrFilePath = string.Empty;
		  private string mstrFileName = string.Empty;
		  private string mstrFileExtension = string.Empty;
		  
		  #endregion
		  
		  #region public variables
		  [DataMember]
		  public string FilePath 
		  {
		  	get {return mstrFilePath;}
		  	set {mstrFilePath = value;}
		  	
		  }
		  
		  [DataMember]
		  public string FileName
		  {
		  	get  {return mstrFileName;}
		  	set { mstrFileName = value;}
		  } 
		  
		  [DataMember]
		  public string FileExtension
		  {
		  	get { return  mstrFileExtension;}
		  	set { mstrFileExtension = value;}
		  }
		  #endregion
	}
	
	[DataContract]
	public class FileMapper
	{
		#region private variables
		  private List<SerializationEntity> mobjSerializationEntityList = new List<SerializationEntity>();
		#endregion
		
		#region public variables
		 [DataMember]
		 public List<SerializationEntity> SerializationEntityList
		 {
		 	get { return mobjSerializationEntityList;}
		 	set { mobjSerializationEntityList = value;}
		 }
		#endregion
	}
}
