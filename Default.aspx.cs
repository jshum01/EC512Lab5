using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    //Test comment
    

    protected void Page_Load(object sender, EventArgs e)
    {
      
         
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            DataSourceSelectArguments args = new DataSourceSelectArguments();
            DataView view = (DataView)SqlDataSource1.Select(args);
            DataTable dt = view.ToTable();
            int columnNumber = 0;  //Currency Column 
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][columnNumber].ToString() == ListBox1.SelectedValue)
                {
                    decimal dollars = Convert.ToDecimal(TextBox1.Text);
                    decimal rate = Convert.ToDecimal(dt.Rows[i][1]);
                    decimal amount = dollars * rate;
                    Label1.Text = amount.ToString("f2");
                    Label1.Visible = true;
                    Label2.Text = "";
                    Label3.Text = "";
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    break;
                }
            }
              
        }
        catch (FormatException)
        {
            Label1.Text = "Error";
            Label1.Visible = true;
            Label2.Text = "";
            Label3.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
       try
        {
            DataSourceSelectArguments args = new DataSourceSelectArguments();
            DataView view = (DataView)SqlDataSource1.Select(args);
            DataTable dt = view.ToTable();
            int columnNumber = 0;  //Currency Column 
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][columnNumber].ToString() == ListBox1.SelectedValue)
                {
                    Label3.Text = dt.Rows[i][1].ToString();
                    Label3.Visible = true;
                    Label1.Text = "";
                    Label2.Text = "";
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                }
            }               
        }
        catch (FormatException)
        {
            Label3.Text = "Error";
            Label3.Visible = true;
            Label1.Text = "";
            Label2.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (ListBox1.SelectedItem != null)
        {
            SqlDataSource1.Delete();
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            if (TextBox2.Text != "" && TextBox3.Text != "" && float.Parse(TextBox3.Text) > 0)
            {
                SqlDataSource1.Insert();
                Label2.Text = "Success";
                Label2.Visible = true;
                Label1.Text = "";
                Label3.Text = "";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";

            }
            else
            {
                Label2.Text = "Failure";
                Label2.Visible = true;
                Label1.Text = "";
                Label3.Text = "";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
            }
        }
        catch 
        {
            Label2.Text = "Failure";
            Label2.Visible = true;
            Label1.Text = "";
            Label3.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        if (TextBox4.Text != "" && Convert.ToSingle(TextBox4.Text) > 0)
        {
            SqlDataSource1.Update();
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

        }
    }
}