using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default2 : System.Web.UI.Page
{

    SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

    SqlCommand cmd = new SqlCommand();
        
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        cmd = new SqlCommand("insert into mytbl values('"+TextBox1.Text+"','"+TextBox2.Text+"')", sqlcon);
        sqlcon.Open();
        cmd.ExecuteNonQuery();
        sqlcon.Close();

        Response.Write("done");

    }
}