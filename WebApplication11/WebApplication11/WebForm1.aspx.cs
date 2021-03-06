﻿using System;
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
    public partial class WebForm1 : System.Web.UI.Page
    {
        void filldata()
        {
            SqlConnection con = new SqlConnection (ConfigurationManager.ConnectionStrings["constr"].ToString());
            SqlDataAdapter da = new SqlDataAdapter("select * from employee", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "employee");
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
        void deleterecord(int empno)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            string query="delete from employee where eno='"+empno+"'";
            SqlCommand cmd=new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                filldata();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
          foreach(GridViewRow row in GridView1.Rows)
          {
              CheckBox c1 = (CheckBox)row.FindControl("CheckBox1");
              if(c1.Checked==true)
              {
                  Label l1 = (Label)row.FindControl("Label1");
                  int eno = int.Parse(l1.Text);
                  deleterecord(eno);
                  filldata();
              }
          }
        }
    }
}