﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = (string)Session["AdminEmail"];

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddCatagory.aspx");
    }
}