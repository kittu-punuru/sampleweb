using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load()
        {
            if (IsPostBack == false)
            {
                SqlConnection con = new SqlConnection("data source=SHASHANK\\SQLEXPRESS;database=student;integrated security=yes");
                con.Open();
                SqlCommand cmd = new SqlCommand("select itype from itemmaster", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DropDownList1.Items.Add(dr[0].ToString());
                    }
                }
                con.Close();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        
        {
            DropDownList2.Items.Clear();
            SqlConnection con = new SqlConnection("data source=SHASHANK\\SQLEXPRESS;database=student;integrated security=yes");
            con.Open();
            string query = "select i.iname from itemmaster m inner join itemtype i on m.itypeid=i.itypeid where m.itype='" + DropDownList1.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    DropDownList2.Items.Add(dr[0].ToString());
                }
            }
            con.Close();
         
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=SHASHANK\\SQLEXPRESS;database=student;integrated security=yes");
            con.Open();
            string query = "select ino,iname,qty,price from itemtype where iname='"+DropDownList2.SelectedItem.ToString()+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            
            con.Close();
         
        }
    }
}