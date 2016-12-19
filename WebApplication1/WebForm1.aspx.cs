using Core.Framework.Platform.Serialization;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeatherApp.Library.Entities;
 

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                 //CODE COMMENTED BY TR..
               /*
                var appSettings = ConfigurationManager.AppSettings;
                string FileName = appSettings["FileName"];
                SerializationEntity lobjSerializationEntity = new SerializationEntity();
                lobjSerializationEntity.FileExtension = "XML";
                lobjSerializationEntity.FilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileName);//@"C:\Users\tharu.raju.melath\CloudUtilityFiles\XMLFinal\XMLFinal\WTM";System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                WeatherApp.Library.Entities.WeatherAppEntityFromXML lobjWappCredentials = XMLSerializationHelper<WeatherAppEntityFromXML>.DeserializeFromXmlFile(lobjSerializationEntity);
                Session["WeatherAppEntityFromXML"] = lobjWappCredentials;
                
                */
            } 
        }

        protected void kdav_Click(object sender, EventArgs e)
        {
             
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string connString = ReturnConnectionString();
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("sp_getUserDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("UserName", txtUserName.Text);
            cmd.Parameters.AddWithValue("Password", txtPassword.Text);

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet("TimeRanges");
            da.Fill(ds);

            if(ds != null && ds.Tables[0].Rows.Count > 0)
            {
                Response.Redirect("DisplayWeather.aspx");
            }
            else
            {
                lblMessage.Text = "Not a Valid UserName/Password !!";
            }
           /* 
            WeatherApp.Library.Entities.WeatherAppEntityFromXML lobjWappCredentials = Session["WeatherAppEntityFromXML"] as WeatherApp.Library.Entities.WeatherAppEntityFromXML;
            if(lobjWappCredentials != null)
            {
                if(txtPassword.Text.Trim().ToUpper().Equals(lobjWappCredentials.FinalTemplate.Password.ToUpper()) && 
                    txtUserName.Text.Trim().ToUpper().Equals(lobjWappCredentials.FinalTemplate.UserName.ToUpper()))
                {
                    Response.Redirect("DisplayWeather.aspx");
                }
                else
                {
                    lblMessage.Text = "Not a Valid UserName/Password !!";
                }
            }            
            */
        }

        private string ReturnConnectionString()
        {
            var appSettings = ConfigurationManager.AppSettings;
            string lstrFileName = appSettings["DBConnString"];
            return lstrFileName;
        }
    }
}