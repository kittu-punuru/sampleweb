using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        void filldata()
        {
            SqlConnection con = new SqlConnection("data source=SHASHANK\\SQLEXPRESS;user id=sa;password=prkr;database=emp");
            SqlDataAdapter da = new SqlDataAdapter("select * from employee", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "employee");
            DataList1.DataSource = ds;
            DataList1.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                filldata();
            }
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=SHASHANK\\SQLEXPRESS;user id=sa;password=prkr;database=emp");
            con.Open();
            string query = "delete from employee where eno='" + e.CommandArgument.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            filldata();


        }

    }
}