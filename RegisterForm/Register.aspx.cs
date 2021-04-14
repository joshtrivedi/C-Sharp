using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegisterForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string values = " ";
            values += $"Name : {Name.Value} <br />";
            values += $"Phone : {Phone.Value} <br />";
            string gender = "N/A";
            if (RadioMale.Checked)
                gender = "Gender : Male <br />";
            else if (RadioFemale.Checked)
                gender = "Gender : Female <br />";
            values += gender;
            values += $"Branch : {BranchDropDown.SelectedValue} <br />";
            values += "Subjects : <br />";
            //values += "Gender : ";
            string subjects = "";
            if (dotNet.Checked)
            {
                subjects += ".NET <br />";
            }
            if (CC.Checked)
            {
                subjects += "CC <br />";
            }
            if (ML.Checked)
            {
                subjects += "ML <br />";
            }
            if (VLSI.Checked)
            {
                subjects += "VLSI <br />";
            }
            values += subjects;
            Result.Text = values;
        }
    }
}