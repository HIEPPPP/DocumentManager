using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.DAO
{
    public class DeploymentContextDAO
    {
        private static DeploymentContextDAO instance;
        public static DeploymentContextDAO Instance
        {
            get { if (instance == null) instance = new DeploymentContextDAO(); return instance; }
            private set { instance = value; }
        }
        private DeploymentContextDAO() { }

        public int InsertContext(string docNo, int rev, string context, string deploymentSection)
        {
            string query = @"INSERT INTO DeploymentContex(DocNo, Rev, Context, DeploymentSection) 
                            VALUES( @docNo , @rev, @context , @deploymentSection)";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { docNo, rev, context, deploymentSection });
            return data;
        }

        public DataTable GetListContextByDocNoAndRev(string docNo, int rev)
        {
            string query = $"SELECT * FROM DeploymentContext WHERE DocNo = {docNo} AND Rev = {rev}";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        } 
    }
}
