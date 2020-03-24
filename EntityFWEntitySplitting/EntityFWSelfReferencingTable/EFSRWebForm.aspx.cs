using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFWSelfReferencingTable
{
    public partial class EFSRWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            employeeDBContext.Database.CommandTimeout = 540;

            GridView1.DataSource = employeeDBContext.Employees.Select(emp => new
            {
                emp.EmployeeName,
                ManagerName = emp.Manager == null ? "SuperBoss" : emp.Manager.EmployeeName
            }).ToList();

            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}