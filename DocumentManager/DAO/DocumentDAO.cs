using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.DAO
{
    public class DocumentDAO
    {
        private static DocumentDAO instance;
        public static DocumentDAO Instance 
        { 
            get { if (instance == null) instance = new DocumentDAO(); return instance; }
            private set { instance = value; }
        }

        private DocumentDAO() { }

        public DataTable GetListDocument()
        {
            string query = "SELECT * FROM Document";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetListNumberDocByDocNum(string id)
        {
            string query = $"SELECT NumberDoc FROM Document WHERE NumberDoc = '{id}'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetListDocNoByLevelDoc(string level)
        {
                
            string query = $"SELECT NumberDoc FROM Document WHERE LevelDoc = '{level}'";
            
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
