using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace WebApplication11
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        void filldata()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            SqlDataAdapter da = new SqlDataAdapter("select * from employee", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "employee");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void Page_Load()
        {
            if (IsPostBack == false)
            {
                filldata();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

      
    }
}