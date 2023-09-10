using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Expressions;

namespace CRUD_DEMO
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GridView1.DataSource = SqlDataSource1;
                GridView1.DataBind();
            }
          
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
            Label8.Text = "";
            GridView1.EditRowStyle.BackColor = System.Drawing.Color.Green;
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

            GridView1.EditIndex = -1;
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
            Label8.Text = "";
         
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label  ID = GridView1.Rows[e.RowIndex].FindControl("Label9") as Label;
          
    
            TextBox firstname = GridView1.Rows[e.RowIndex].FindControl("TextBox1") as TextBox;

            TextBox middlename = GridView1.Rows[e.RowIndex].FindControl("TextBox2") as TextBox;

            TextBox lastname = GridView1.Rows[e.RowIndex].FindControl("TextBox3") as TextBox;

            DropDownList gender = GridView1.Rows[e.RowIndex].FindControl("DropDownList5") as DropDownList;

            TextBox address = GridView1.Rows[e.RowIndex].FindControl("TextBox4") as TextBox;

            TextBox clas_s = GridView1.Rows[e.RowIndex].FindControl("TextBox5") as TextBox;


            string myconnect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\CRUD_DEMO\\CRUD_DEMO\\App_Data\\Databasecrud.mdf;Integrated Security=True";
            string updata = "update student set firstname='"+firstname.Text+"',middlename='"+middlename.Text+"',lastname='"+lastname.Text+"',gender='"+gender.SelectedValue+"',address='"+address.Text+"',class='"+clas_s.Text+"' where Id='"+Convert.ToInt32(ID.Text)+"'";          

            SqlConnection con = new SqlConnection(myconnect);
            con.Open();
            SqlCommand cmd = new SqlCommand
            {
                CommandText = updata,
                Connection = con
            };
            cmd.ExecuteNonQuery();
            Label8.Text = "Row data has been updated successfully.";
            GridView1.EditIndex = -1;
            SqlDataSource1.DataBind();
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            TextBox studentid = GridView1.FooterRow.FindControl("TextBox7") as TextBox;

            TextBox firstname = GridView1.FooterRow.FindControl("TextBox8") as TextBox;

            TextBox middlename = GridView1.FooterRow.FindControl("TextBox9") as TextBox;

            TextBox lastname = GridView1.FooterRow.FindControl("TextBox10") as TextBox;

            DropDownList gender = GridView1.FooterRow.FindControl("DropDownList6") as DropDownList;

            TextBox address = GridView1.FooterRow.FindControl("TextBox11") as TextBox;

            TextBox clas_s = GridView1.FooterRow.FindControl("TextBox12") as TextBox;


            string myconnect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\CRUD_DEMO\\CRUD_DEMO\\App_Data\\Databasecrud.mdf;Integrated Security=True";
            string updata = "insert into student (Id,firstname,middlename,lastname,gender,address,class) values('"+studentid.Text+"','" + firstname.Text+"','"+middlename.Text+"','"+lastname.Text+"','"+gender.SelectedValue+"','"+address.Text+"','"+clas_s.Text+"')";        

            SqlConnection con = new SqlConnection(myconnect);
            con.Open();
            SqlCommand cmd = new SqlCommand
            {
                CommandText = updata,
                Connection = con
            };
            cmd.ExecuteNonQuery();
            Label8.Text = "Row data has been inserted successfully.";
            GridView1.EditIndex = -1;
            SqlDataSource1.DataBind();
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label studentid = GridView1.Rows[e.RowIndex].FindControl("Label7") as Label;

            string myconnect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\CRUD_DEMO\\CRUD_DEMO\\App_Data\\Databasecrud.mdf;Integrated Security=True";
            string updata = "delete from student where Id ='"+studentid.Text+"' ";

            SqlConnection con = new SqlConnection(myconnect);
            con.Open();
            SqlCommand cmd = new SqlCommand
            {
                CommandText = updata,
                Connection = con
            };
            cmd.ExecuteNonQuery();
            Label8.Text = "Row data has been deleted successfully.";
            GridView1.EditIndex = -1;
            SqlDataSource1.DataBind();
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox13.Text!="")
            {
                MaleRadioButton.Checked = false;
                FemaleRadioButton.Checked = false;
                OthersRadioButton.Checked = false;
                SearchbyId();
            }
            else if (MaleRadioButton.Checked ==true)
            {
                
                Searchbymale();
            }
            else if (FemaleRadioButton.Checked == true)
            {
                 
                Searchbyfemale();
            }
            else if(OthersRadioButton.Checked == true)
            {   
                 
                SearchbyOthers();   
            }
            else
            {
                
            ClientScript.RegisterStartupScript(this.GetType(), "prompt", "var value = prompt('Data could not inserted successfully.'); storeinput(value);", true);
    
            }
        

        }
        
        void Searchbymale()
        {

            string myconnect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\CRUD_DEMO\\CRUD_DEMO\\App_Data\\Databasecrud.mdf;Integrated Security=True";
            string updata = "select *from student where gender = @male ";

            SqlConnection con = new SqlConnection(myconnect);
            con.Open();
            SqlDataAdapter dta = new SqlDataAdapter(updata, con);
            dta.SelectCommand.Parameters.AddWithValue("@male", MaleRadioButton.Text);
            DataTable data = new DataTable();   
            dta.Fill(data);
            GridView1.DataSource= data;
            GridView1.DataBind();
            Label8.Text = "Row data has been  displayed with gender male only successfully.";

        }
        void Searchbyfemale()
        {

            string myconnect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\CRUD_DEMO\\CRUD_DEMO\\App_Data\\Databasecrud.mdf;Integrated Security=True";
            string updata = "select *from student where gender = @female ";

            SqlConnection con = new SqlConnection(myconnect);
            con.Open();
            SqlDataAdapter dta = new SqlDataAdapter(updata, con);
            dta.SelectCommand.Parameters.AddWithValue("@female", FemaleRadioButton.Text);
            DataTable data = new DataTable();
            dta.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
            Label8.Text = "Row data has been  displayed with gender female only successfully.";

        }
        void SearchbyOthers()
        {

            string myconnect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\CRUD_DEMO\\CRUD_DEMO\\App_Data\\Databasecrud.mdf;Integrated Security=True";
            string updata = "select *from student where gender = @others ";

            SqlConnection con = new SqlConnection(myconnect);
            con.Open();
            SqlDataAdapter dta = new SqlDataAdapter(updata, con);
            dta.SelectCommand.Parameters.AddWithValue("@others", OthersRadioButton.Text);
            DataTable data = new DataTable();
            dta.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
            Label8.Text = "Row data has been  displayed with gender others only successfully.";

        }
        void SearchbyId()
        {
            string myconnect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\CRUD_DEMO\\CRUD_DEMO\\App_Data\\Databasecrud.mdf;Integrated Security=True";
            string updata = "select *from student where Id ='"+Convert.ToInt32(TextBox13.Text)+"' ";

            SqlConnection con = new SqlConnection(myconnect);
            con.Open();
            SqlDataAdapter dta = new SqlDataAdapter(updata, con);
            dta.SelectCommand.Parameters.AddWithValue("@id",Convert.ToInt32(TextBox13.Text));
            DataTable data = new DataTable();
            dta.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
            Label8.Text = "Row data has been  displayed with id only successfully.";
          
        }

        protected void TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string myconnect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\source\\repos\\CRUD_DEMO\\CRUD_DEMO\\App_Data\\Databasecrud.mdf;Integrated Security=True";
            string updata = "select *from student ";

            SqlConnection con = new SqlConnection(myconnect);
            con.Open();
            SqlCommand cmd = new SqlCommand
            {
                CommandText = updata,
                Connection = con
            };
            cmd.ExecuteNonQuery();
            Label8.Text = "ALL data has been  displayed successfully.";
            GridView1.EditIndex = -1;
            SqlDataSource2.DataBind();
            GridView1.DataSource = SqlDataSource2;
            GridView1.DataBind();
        }

        protected void FemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(FemaleRadioButton.Checked)
            {
                TextBox13.Text = "";    
             }
        }

        protected void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MaleRadioButton.Checked)
            {
                TextBox13.Text = "";
            }
        }

        protected void OthersRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OthersRadioButton.Checked)
            {
                TextBox13.Text = "";
            }
        }
    }
}