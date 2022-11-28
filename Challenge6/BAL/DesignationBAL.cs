using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Challenge6.BAL
{
    public class DesignationBAL
    {
        DAL.DesignationDAL objdeptdl = new DAL.DesignationDAL();

        private string _designation;
        private int _desigid;
        private int _deptid;

        public int desigid
        {
            get { return _desigid; }
            set { _desigid = value; }
        }

        public string Designation
        {
            get { return _designation; }
            set { _designation = value; }
        }
        public int deptid
        {
            get { return _deptid; }
            set { _deptid = value; }
        }
        public DataTable DesignationValues()
        {
            return objdeptdl.Designation_list();
        }
        public int insertDesignation()
        {
            return objdeptdl.DesignationInsert(this);
        }
        public DataTable viewDesgn()
        {
            return objdeptdl.viewDesignation();
        }
        public int updatedesgn()
        {
            return objdeptdl.Designationupdate(this);
        }
        public int Deletedesgn()
        {
            return objdeptdl.Designationdelete(this);
        }
    }
}