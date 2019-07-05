using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class AllView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserData.mdf;Integrated Security=True");

        string str = "select * from register";

        SqlCommand cmd = new SqlCommand(str,con);

        con.Open();

        SqlDataReader dr;

        dr = cmd.ExecuteReader();

        GridView3.DataSource = dr;
        GridView3.DataBind();
    }
}