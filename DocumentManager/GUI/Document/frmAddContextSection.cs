using DevExpress.XtraEditors;
using DocumentManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentManager.GUI.Document
{
    public partial class frmAddContextSection : DevExpress.XtraEditors.XtraForm
    {
        private string docNo;
        private string rev;

        public frmAddContextSection(string docNo, string rev)
        {
            this.docNo = docNo;
            this.rev = rev;
            InitializeComponent();
        }

        public void LoadContext() 
        {
            //gvContextSection.DataSource = DeploymentContextDAO.Instance.GetListContextByDocNoAndRev(docNo, rev);
        }
    }
}