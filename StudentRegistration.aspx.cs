using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WorkMethods
{
    public partial class StudentRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RollNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

      

        protected void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source       = ROHIT;
                                                     Initial Catalog  = demoDB;
                                                     User ID          = sa;
                                                     Password         = password$123; 
                                                   ");
        
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("INSERT INTO StudentTable VALUES('" + RollNoTextBox.Text + "','" + StudentTextBox.Text + "','" + AddressTextBox.Text + "','" + EmailIDTextBox.Text + "')", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);    
        }
    }
}