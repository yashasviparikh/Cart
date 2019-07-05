using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            Databind();
            count_total();
        }
    }
    public void Databind()
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserData.mdf;Integrated Security=True");
        con.Open();
        string str = "select ap.*,ac.* from AddToCart ac join Product ap on ac.ProductId=ap.Product_Id";
        SqlCommand cmd = new SqlCommand(str, con);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        DataList1.DataSource = dr;
        DataList1.DataBind();
        con.Close();

    }

    public void count_total()
    {
        int cnt = 0;
        Label1.Text = "";
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserData.mdf;Integrated Security=True");
        con1.Open();
        string str1 = "select ap.*,ac.* from AddToCart ac join Product ap on ac.ProductId=ap.Product_Id";
        SqlCommand cmd1 = new SqlCommand(str1, con1);
        SqlDataReader dr1;

        dr1 = cmd1.ExecuteReader();
        while (dr1.Read())
        {
            cnt = (cnt + Convert.ToInt32(dr1["Price"].ToString()));
        }
        Label1.Text = cnt.ToString();
        con1.Close();

    }

    protected void event2(object source, DataListCommandEventArgs e)
    {
        if(e.CommandName=="Removeproduct")
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserData.mdf;Integrated Security=True");
            con2.Open();
            string str2="Delete from AddToCart where AddToCartId='"+Convert.ToUInt32(e.CommandArgument.ToString())+"'";
            SqlCommand cmd2 = new SqlCommand(str2, con2);
            cmd2.ExecuteNonQuery();
            Response.Write("<script>alert('Product Removed...!')</script>");
            con2.Close();
            Databind();
            count_total();

        }
    }
}