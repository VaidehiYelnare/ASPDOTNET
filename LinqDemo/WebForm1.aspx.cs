using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqQueryDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private object dbContext;

        protected void Page_Load(object sender, EventArgs e)
        {
            //GetData();
        }

        private void GetData()
        {
            SampleDataContext dbContext = new SampleDataContext();
            GridView1.DataSource = dbContext.Employees;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  GetData();
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            GetData();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            using (SampleDataContext dbContext = new SampleDataContext())
            {
                Employee obj = new Employee
                {
                    ID         =  6,
                    FirstName  = "Shravani",
                    LastName   = "Deshpande",
                    Gender     = "Female", 
                    DeptID     = 3,       
                    Salary     = 66000
                };
                dbContext.Employees.InsertOnSubmit(obj);
                dbContext.SubmitChanges();

            }//end of using
            GetData();
        }//end of btnInsert

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SampleDataContext dbContext = new SampleDataContext())
            {
                Employee obj1 = dbContext.Employees.SingleOrDefault(update => update.ID == 5);
                obj1.Salary = 65500;
                dbContext.SubmitChanges();
            }//end of using
            GetData();
        }//end of btnUpdate

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (SampleDataContext dbContext = new SampleDataContext())
            {
                Employee obj2 = dbContext.Employees.SingleOrDefault(delete => delete.ID == 5);
                dbContext.Employees.DeleteOnSubmit(obj2);
                dbContext.SubmitChanges();
            }//end of using
            GetData();
        }
    }
}