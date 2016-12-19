using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AddOrModifyUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = ReturnConnectionString();
                SqlConnection con = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("sp_insUserDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("Education", txtEducation.Text);
                cmd.Parameters.AddWithValue("Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("UserName", txtUserName.Text);
                cmd.Parameters.AddWithValue("Password", txtPassword.Text);
                con.Open();
                int k = cmd.ExecuteNonQuery();
                if(k != 0)
                {
                    lblMessage.Text = "A new User have been created , Try login with the credentials";
                }
                else
                {
                    lblMessage.Text = "Unable to Add User,Sorry Try Again later";
                }
                con.Close();  
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Unable to Add User,Sorry Try Again later";
            }
        }

        private string ReturnConnectionString()
        {
            var appSettings = ConfigurationManager.AppSettings;
            string lstrFileName = appSettings["DBConnString"];
            return lstrFileName;
        }

        protected void lnkWeatherpage_Click(object sender, EventArgs e)
        {
            Response.Redirect("DisplayWeather.aspx");
        }
    }
}