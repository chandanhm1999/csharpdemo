using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static SchoolManagementSystem.Models.CommonFn;

namespace SchoolManagementSystem.Admin
{
    public partial class ClassFees : System.Web.UI.Page //class //interanal 

    {
        Commonfnx fn = new Commonfnx();
        protected void Page_Load(object sender, EventArgs e) //access specifier
        {
            if(IsPostBack) //postback
            {
                GetClass();
                GetFees();
            }
        }

        private void GetClass() //private function 
        {
            DataTable dt = fn.Fetch("Select * from Class");
            ddlClass.DataSource = dt;
            ddlClass.DataTextField = "ClassName";
            ddlClass.DataValueField = "ClassId";
            ddlClass.DataBind();
            ddlClass.Items.Insert(0, "Select Class");
        }

        protected void btnAdd_Click(object sender, EventArgs e) //accessspecifer returnType functionName parameters 
        {
            try
            {
                string classVal = ddlClass.SelectedItem.Text;
                DataTable dt = fn.Fetch("Select * from Fees where ClassId = '" + ddlClass.SelectedItem.Value + "' ");
                if (dt.Rows.Count == 0)
                {
                    string query = "Insert into Fees values('"+ddlClass.SelectedItem.Value+"','" + txtFeeAmounts.Text.Trim() + "')";
                    fn.Query(query);
                    lblMsg.Text = "Inserted Successfully!";
                    lblMsg.CssClass = "alert alert-success";
                    ddlClass.SelectedIndex = 0;
                    txtFeeAmounts.Text = string.Empty;
                    GetFees();
                }
                else
                {
                    lblMsg.Text = "Entered Fees already exists for <b>'"+classVal+"'</b>!";
                    lblMsg.CssClass = "alert alert-danger";
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>Message");
            }
        }

        private void GetFees()
        {
            DataTable dt = fn.Fetch("Select * from Fees");
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}
