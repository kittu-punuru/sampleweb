using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

 protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
   {
            int a;
            int b;
            int c;

        if (DropDownList1.SelectedIndex == 0)
    {
    a = int.Parse(TextBox1.Text);
    b = int.Parse(TextBox2.Text);
    c = a + b;
    DropDownList2.Items.Add(c.ToString());
    }
    if (DropDownList1.SelectedIndex == 1)
    {
    a = int.Parse(TextBox1.Text);
    b = int.Parse(TextBox2.Text);
    c = a - b;
    DropDownList2.Items.Add (c.ToString());
        }
    if (DropDownList1.SelectedIndex == 2)
    {
        a = int.Parse(TextBox1.Text);
        b = int.Parse(TextBox2.Text);
        c = a * b;
         DropDownList2.Items.Add(c.ToString());
    }
    if (DropDownList1.SelectedIndex == 3)
    {
        a = int.Parse(TextBox1.Text);
        b = int.Parse(TextBox2.Text);
        c = a / b;
         DropDownList2.Items.Add( c.ToString());
    }
    
   
    if (DropDownList1.SelectedIndex == 4)
    {
    a = int.Parse(TextBox1.Text);
    b = int.Parse(TextBox2.Text);
    c = a % b;
 DropDownList2.Items.Add( c.ToString());
    }
  }
        
 }
}