using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

namespace WorkMethods
{
    public partial class StudentRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            if (!this.IsPostBack)
            {
               

                DataTable dt = this.GetData();
                StringBuilder html = new StringBuilder();
                html.Append("<TABLE BORDER = '1'>");

                //header row
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<th>");
                    html.Append(column.ColumnName);
                    html.Append("</th>");
                }
                html.Append("</tr>");

                //data rows
                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<tr>");
                    foreach (DataColumn column in dt.Columns)
                    {
                        html.Append("<td>");
                        html.Append(row[column.ColumnName]);
                        html.Append("</td>");
                    }
                    html.Append("</tr>");
                }

                html.Append("</TABLE>");
                PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });

            }//end of if
        }

        protected void RollNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }



        protected void DeleteButton_Click(object sender, EventArgs e)
        {

            /* SqlDataAdapter sqlAdapter = new SqlDataAdapter();
            DataTable dta = new DataTable("DELETE FROM StudentTable WHERE RollNo = '25' ",conn);
            sqlAdapter.Fill(dta);*/
            SqlConnection conn = new SqlConnection(@"Data Source           = ROHIT;
                                                     Initial Catalog   = demoDB;
                                                     User ID           = sa;
                                                     Password          = password$123; 
                                              ");
            conn.Open();
            string delete = "DELETE FROM StudentTable WHERE RollNo = '" + this.RollNoTextBox.Text + "'";
            SqlCommand cmd = new SqlCommand(delete, conn);
            int m = cmd.ExecuteNonQuery();
            conn.Close();


        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            RollNoTextBox.Text  = " ";
            StudentTextBox.Text = " ";
            AddressTextBox.Text = " ";
            EmailIDTextBox.Text = " ";
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {

            /*SqlDataAdapter sqlAdapter = new SqlDataAdapter("INSERT INTO StudentTable VALUES('" + RollNoTextBox.Text + "','" + StudentTextBox.Text + "','" + AddressTextBox.Text + "','" + EmailIDTextBox.Text + "')", conn);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);    */
            SqlConnection conn = new SqlConnection(@"Data Source       = ROHIT;
                                                     Initial Catalog   = demoDB;
                                                     User ID           = sa;
                                                     Password          = password$123; 
                                                  ");
            conn.Open();
            string insert = "INSERT INTO StudentTable VALUES('" + RollNoTextBox.Text + "','" + StudentTextBox.Text + "','" + AddressTextBox.Text + "','" + EmailIDTextBox.Text + "')";
            SqlCommand cmd = new SqlCommand(insert, conn);
            int m = cmd.ExecuteNonQuery();
            conn.Close();
        }

        private DataTable GetData()
        {
            string constr = "";
             constr = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            
            using (SqlConnection conn = new SqlConnection(constr)) {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM StudentTable"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = conn;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

    }
}