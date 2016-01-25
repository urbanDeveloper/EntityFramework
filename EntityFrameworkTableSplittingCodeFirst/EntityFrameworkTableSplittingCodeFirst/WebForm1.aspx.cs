using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
//Entity Splitting refers to mapping an entity to two or more tables when the tables share a common key. 
// The main reason for splitting tables and useful becuase when you want to delay the loading of some properties with large data when using lazy loading.
//lazy loading is where you delay the loading of an object until the point where we need it. 
namespace EntityFrameworkTableSplittingCodeFirst
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                GridView1.DataSource = GetEmployeeDataIncludingContactDetails();
            }
            else 
            {
                GridView1.DataSource = GetEmployeeData();
            }
            GridView1.DataBind();
        }

        private DataTable GetEmployeeDataIncludingContactDetails()
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();

            List<Employee> employees = employeeDBContext.Employees.Include("EmployeeContactDetail").ToList();

            DataTable dt = new DataTable();
            DataColumn[] datacolumns = {new DataColumn("EmployeeID"), new DataColumn("FirstName"),
                                           new DataColumn("LastName"),new DataColumn("Gender"),
                                           new DataColumn("Email"), new DataColumn("Mobile"),
                                           new DataColumn("LandLine")};
            dt.Columns.AddRange(datacolumns);

            foreach(Employee employee in employees)
            {
                DataRow dr = dt.NewRow();
                dr["EmployeeId"] = employee.EmployeeId;
                dr["FirstName"] = employee.FirstName;
                dr["LastName"] = employee.LastName;
                dr["Gender"] = employee.Gender;
                dr["Email"] = employee.EmployeeContactDetail.Email;
                dr["Mobile"] = employee.EmployeeContactDetail.Mobile;
                dr["LandLine"] = employee.EmployeeContactDetail.LandLine;

                dt.Rows.Add(dr);

            }

            return dt;
        }

        private DataTable GetEmployeeData()
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();

            List<Employee> employees = employeeDBContext.Employees.ToList();

            DataTable dt = new DataTable();
            DataColumn[] datacolumns = {new DataColumn("EmployeeID"), new DataColumn("FirstName"),
                                           new DataColumn("LastName"),new DataColumn("Gender")};
            dt.Columns.AddRange(datacolumns);

            foreach (Employee employee in employees)
            {
                DataRow dr = dt.NewRow();
                dr["EmployeeId"] = employee.EmployeeId;
                dr["FirstName"] = employee.FirstName;
                dr["LastName"] = employee.LastName;
                dr["Gender"] = employee.Gender;

                dt.Rows.Add(dr);

            }

            return dt;
        }
    }
}