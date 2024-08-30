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
    public partial class frmDepartment : DevExpress.XtraEditors.XtraForm
    {
        public frmDepartment()
        {
            InitializeComponent();
            LoadListDepartment();
        }

        void LoadListDepartment()
        {
            DataTable dt = DepartmentDAO.Instance.ListDepartment();
            gcDepartment.DataSource = dt;
        }
    }
}