using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserData.mdf;Integrated Security=True");
        con.Open();
        string str = "select Count(*) from Admin where Email='"+TextBox1.Text+"'and Password='"+TextBox2.Text+"'";
        SqlCommand cmd = new SqlCommand(str, con);
        int i;
        i = Convert.ToInt16(cmd.ExecuteScalar());
        if (i==1)
        {
            Session["AdminEmail"] = TextBox1.Text;
            Response.Redirect("AdminProfile.aspx");
        }
        else
        {
            Label1.Text = "Incorrect Email or Password...!";
        }
        TextBox1.Text = "";
        TextBox2.Text = "";



    //    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserData.mdf;Integrated Security=True");

    //    string str = "select Count(*) from register where Email='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";

    //    SqlCommand cmd = new SqlCommand(str, con);
    //    con.Open();

    //    int i;

    //    i = Convert.ToInt16(cmd.ExecuteScalar());

    //    if (i == 1)
    //    {
    //        // Label1.Text = "Login successful..!";

    //        Session["Email"] = TextBox1.Text;
    //        Response.Redirect("User_Profile.aspx");
    //    }
    //    else
    //    {
    //        Label1.Text = "Invalid Email Or Password..!";
    //    }
    //    TextBox1.Text = "";
    //    TextBox2.Text = "";
    //}
}

    //protected void Button2_Click(object sender, EventArgs e)
    //{
        
    //    SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserData.mdf;Integrated Security=True");
    //    con1.Open();
    //    string str1 = "insert into Admin(Email,Password)values('" + TextBox1.Text + "','" + TextBox2.Text + "')";
    //    SqlCommand cmd1 = new SqlCommand(str1, con1);
    //    cmd1.ExecuteNonQuery();
    //    Label1.Text = "record inserted...!";



    //    //SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserData.mdf;Integrated Security=True");
        
    //    //string str1 = "insert into register(Name,Email,Phone,Password)values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
    //    //SqlCommand cmd1 = new SqlCommand(str1, con1);
    //    //con1.Open();
    //    //cmd1.ExecuteNonQuery();
    //    //Label1.Text = "record inserted";

    //    TextBox1.Text = "";
    //}
}