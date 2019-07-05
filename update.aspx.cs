using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = E:\WEBMYNE-.NET_INTERN\Update user profile\Update user profile\App_Data\UserData.mdf; Integrated Security = True");
            string str = "select * from register where Email='" + Session["Email"] + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TextBox1.Text = (string)dr["Name"];
                TextBox2.Text = (string)dr["Email"];
                TextBox3.Text = (string)dr["Phone"];
                TextBox4.Text = (string)dr["Password"];

            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //SqlConnection con1=new SqlConnection(@"")
        SqlConnection con1 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = E:\WEBMYNE-.NET_INTERN\Update user profile\Update user profile\App_Data\UserData.mdf; Integrated Security = True");
        con1.Open();
        string str1= "update register set Name='" + TextBox1.Text + "',Email='" + TextBox2.Text + "',Phone='" + TextBox3.Text + "',Password='" + TextBox4.Text+"' where Email='"+Session["Email"]+"'";

        SqlCommand com1 = new SqlCommand(str1, con1);
        com1.ExecuteNonQuery();
        Label1.Text = "Recored updated";

    }

    
}