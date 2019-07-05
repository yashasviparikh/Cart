using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class Product_Display : System.Web.UI.Page
{
    SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserData.mdf;Integrated Security=True");
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack==false)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserData.mdf;Integrated Security=True");
            con1.Open();
            string str1 = "select * from Product";
            SqlCommand cmd1 = new SqlCommand(str1, con1);
            SqlDataReader dr1;
            dr1=cmd1.ExecuteReader();
            DataList1.DataSource = dr1;
            DataList1.DataBind();

            con1.Close();
        }

    }

    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void event1(object source, DataListCommandEventArgs e)
    {
        if(e.CommandName=="Addtocart")
        {
            string str = "insert into AddToCart(ProductId)values('" + Convert.ToString(e.CommandArgument.ToString()) + "')";
            con1.Open();
            SqlCommand cmd2 = new SqlCommand(str, con1);
            cmd2.ExecuteNonQuery();
            //con1.Close();
            Response.Redirect("cart.aspx");
        }
    }
}