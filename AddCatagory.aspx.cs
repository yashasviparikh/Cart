using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class AddCatagory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserData.mdf;Integrated Security=True");
        con.Open();
        string str="insert into Catagory_Name(Catagory_Name)values('"+TextBox1.Text+"')";
        SqlCommand cmd = new SqlCommand(str,con);
        cmd.ExecuteNonQuery();
        Label1.Text = "catagory added...!";
        TextBox1.Text = "";
    }
}