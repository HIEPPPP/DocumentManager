using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.DAO
{
    public class DepartmentDAO
    {
        private static DepartmentDAO instance;

        public static DepartmentDAO Instance
        {
            get 
            {
                if (instance == null) instance = new DepartmentDAO();
                        return instance; 
            }
            set => instance = value;
        }

        private DepartmentDAO() { }

        public DataTable ListDepartment()
        {
            string query = "SELECT * FROM DEPARTMENT";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        
    }
}
