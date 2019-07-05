using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserData.mdf;Integrated Security=True");

            string str = "select * from Catagory_Name";

            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();

            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            DropDownList1.DataSource = dr;
            DropDownList1.DataTextField = "Catagory_Name";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        FileUpload1.SaveAs(Server.MapPath(".") + "\\Product_Images\\" + FileUpload1.FileName);
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserData.mdf;Integrated Security=True");

        string str = "insert into Product(Category_Name,Product_Name,Price,Short_desc,Long_desc,Images)values('"+DropDownList1.SelectedItem.Text+"','"+txt_PName.Text+"','"+txt_Price.Text+"','"+txt_Short.Text+"','"+txt_Long.Text+"','"+FileUpload1.FileName+"')";

        SqlCommand cmd = new SqlCommand(str, con);
        con.Open();
        cmd.ExecuteNonQuery();
       
    }
}