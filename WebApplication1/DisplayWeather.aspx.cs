using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DisplayWeather : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                divAllTemp.Visible = true;
                divSingleTemparature.Visible = false;
            }
        }

        protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            divSingleTemparature.Visible = true;
            lblDisplay.Text = "Location Selected : " + ddlLocation.SelectedItem.Text;
            string cityName = string.Empty;
            string Temperature = string.Empty;
            string TemperatureStatus = string.Empty;
            if(ddlLocation.SelectedItem.Value.ToUpper() == "ALL")
            {
                divAllTemp.Visible = true;
                divSingleTemparature.Visible = false;
                return;
            }                  
            else if(ddlLocation.SelectedItem.Value.ToUpper() == "B")
            {
               
                cityName = "bangalore";
                Temperature = "21 C";
                TemperatureStatus = "Mild";

            }                   
            else if (ddlLocation.SelectedItem.Value.ToUpper() == "M")
            {
                
                cityName = "Mumbai";
                Temperature = "15 C";
                TemperatureStatus = "Cold";
            }
            else if (ddlLocation.SelectedItem.Value.ToUpper() == "C")
            {
                cityName = "Chennai";
                Temperature = "37 C";
                TemperatureStatus = "Sunny";

            }
            else if (ddlLocation.SelectedItem.Value.ToUpper() == "D")
            {
               
                cityName = "Delhi";
                Temperature = "40 C";
                TemperatureStatus = "Hot";
            }
            divAllTemp.Visible = false;
            divSingleTemparature.Visible = true;
            lblCityName.Text = cityName;
            lblTemperature.Text = Temperature;
            lblTemperatureStatus.Text = TemperatureStatus;

        }

        protected void lnkAddNewUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}