using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Registration_page : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserData.mdf;Integrated Security=True");

        string str = "select Count(*) from register where Email='" + TextBox2.Text + "'";

        SqlCommand cmd = new SqlCommand(str, con);
        con.Open();

        int i;

        i = Convert.ToInt16(cmd.ExecuteScalar());

        if (i == 1)
        {

            Label1.Text = "User already exists...!";
        }
        else
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserData.mdf;Integrated Security=True");
            //new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Students.mdf;Integrated Security=True");
            string str1 = "insert into register(Name,Email,Phone,Password)values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
            SqlCommand cmd1 = new SqlCommand(str1, con1);
            con1.Open();
            cmd1.ExecuteNonQuery();
            Label1.Text = "record inserted";

            TextBox1.Text = "";
        }
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";








    }
}
