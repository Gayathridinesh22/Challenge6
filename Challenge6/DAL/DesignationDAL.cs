using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
namespace Challenge6.DAL
{
    public class DesignationDAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public DesignationDAL()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection Getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public DataTable Designation_list()
        {
            string qry = "select * from Department";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }
        public int DesignationInsert(BAL.DesignationBAL obj)
        {
            string qry = "insert into Challenge6 values('" + obj.Designation + "','" + obj.deptid + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable viewDesignation()
        {
            string s = "select d.deptName,c.desigId,c.desigName from Challenge6 c inner join Department d on d.deptid=c.deptid";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int Designationupdate(BAL.DesignationBAL obj)
        {
            string s = "update Challenge6 set desigName='" + obj.Designation + "' where desigId='" + obj.desigid + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public int Designationdelete(BAL.DesignationBAL obj)
        {
            string s = "delete from Challenge6 where desigId='" + obj.desigid + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
    }
}