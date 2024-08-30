using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.DAO
{
    public class FormDAO
    {
        private static FormDAO instance;

        public static FormDAO Instance 
        {
            get { if (instance == null) instance = new FormDAO(); return instance; } 
            private set => instance = value; 
        }
        private FormDAO() { }

        public DataTable GetListForm()
        {
            string query = "SELECT * FROM FORM";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetListFormByDocNoAndRev(string docNum, string rev)
        {
            string query = $"SELECT * FROM FORM WHERE NumberDoc = '{docNum}' AND Rev = '{rev}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int DeleteFormByDocNumAndRev(string docNum, string rev) 
        {
            string query = $"DELETE Form WHERE NumberDoc = '{docNum}' AND Rev = '{rev}'";
            int dt = DataProvider.Instance.ExecuteNonQuery(query);
            return dt;
        }

        public int InsertForm(string numDo, string rev, string name, string form)
        {
            string query = @"INSERT INTO Form(NumberDoc, Rev, Name, Form)
                            VALUES( @numDo , @rev , @name , @form )";
            int dt = DataProvider.Instance.ExecuteNonQuery(query, new object[] {numDo, rev, name, form});
            return dt;
        }

    }
}
