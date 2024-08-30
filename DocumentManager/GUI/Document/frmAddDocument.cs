using DevExpress.Office.Crypto;
using DevExpress.XtraEditors;
using DocumentManager.DAO;
using DocumentManager.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentManager.GUI.Document
{
    public partial class frmAddDocument : DevExpress.XtraEditors.XtraForm
    {

        public frmAddDocument()
        {
            InitializeComponent();
        }        

        
        private void cbDocLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLevel = cbDocLevel.Text;

            switch (selectedLevel)
            {
                case "A":
                    cbLevelHighDoc.Text = "A";
                    cbLevelHighDoc.ReadOnly = true;
                    break;
                case "B":
                    cbLevelHighDoc.ReadOnly = false;
                    cbLevelHighDoc.Properties.DataSource = DocumentDAO.Instance.GetListDocNoByLevelDoc("A");
                    cbLevelHighDoc.Properties.DisplayMember = "NumberDoc";
                    cbLevelHighDoc.Properties.ValueMember = "NumberDoc"; 
                    break;
                default:
                    cbLevelHighDoc.ReadOnly = false;
                    cbLevelHighDoc.Properties.DataSource = DocumentDAO.Instance.GetListDocNoByLevelDoc("B");
                    cbLevelHighDoc.Properties.DisplayMember = "NumberDoc";
                    cbLevelHighDoc.Properties.ValueMember = "NumberDoc"; 
                    break;
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Helpers.OpenFileAndGetPath();
                if (!string.IsNullOrEmpty(filePath))
                {
                    string fileName = Helpers.GetFileName(filePath);
                    txtFile.Text = fileName;
                }    
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmAddForm frmAddForm = new frmAddForm(txtNumberDoc.Text, txtRev.Text);
            frmAddForm.ShowDialog();

            string formCount = Convert.ToString(frmAddForm.RowCountToSend);

            txtForm.Text = formCount + " Form đã được chọn";

        }

        private void txtNumberDoc_Leave(object sender, EventArgs e)
        {
            DataTable numberDoc = DocumentDAO.Instance.GetListNumberDocByDocNum(txtNumberDoc.Text);
            if (numberDoc.Rows.Count > 0) 
            {
                MessageBox.Show("Số quản lý tài liệu đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumberDoc.Text = "";
                txtNumberDoc.Focus();
                return;
            }
        }

        private void txtContextDetail_Click(object sender, EventArgs e)
        {

        }
    }
}