using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Challenge6
{
    public partial class DesignationEg : System.Web.UI.Page
    {
        BAL.DesignationBAL objdptbl = new BAL.DesignationBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dept_bind();
                GridView1.DataSource = objdptbl.viewDesgn();
                GridView1.DataBind();
            }
        }
        public void dept_bind()
        {
            DataTable prod = objdptbl.DesignationValues();
            ddldepartment.DataSource = objdptbl.DesignationValues();
            ddldepartment.DataTextField = "deptName";
            ddldepartment.DataValueField = "deptid";
            ddldepartment.DataBind();
            ddldepartment.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objdptbl.Designation = txtdesignation.Text;
            objdptbl.deptid = Convert.ToInt32(ddldepartment.SelectedIndex);

            int i = objdptbl.insertDesignation();
            GridView1.DataSource = objdptbl.viewDesgn();
            GridView1.DataBind();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objdptbl.viewDesgn();
            GridView1.DataBind();
        }
        protected void Gridview1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());

            objdptbl.desigid = id;
            int i = objdptbl.Deletedesgn();
            GridView1.DataSource = objdptbl.viewDesgn();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox txt = new TextBox();
            txt = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];

            objdptbl.desigid = id;
            objdptbl.Designation = txt.Text;
            int i = objdptbl.updatedesgn();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objdptbl.viewDesgn();
            GridView1.DataBind();
        }
        protected void Gridview1_RowCancelEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = objdptbl.viewDesgn();
            GridView1.DataBind();
        }
    }
}
    