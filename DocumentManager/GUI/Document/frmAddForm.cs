using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class frmAddForm : DevExpress.XtraEditors.XtraForm
    {
        private string docNo;
        private string rev;

        public int RowCountToSend;
        public frmAddForm(string docNo, string rev)
        {
            this.docNo = docNo;
            this.rev = rev;
            InitializeComponent();

        }

        private void gcAddForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            gcAddForm.DataSource = FormDAO.Instance.GetListFormByDocNoAndRev(docNo, rev);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string filePath = Helpers.OpenFileAndGetPath();
            if(!string.IsNullOrEmpty(filePath))
            {
                string fileName = Helpers.GetFileName(filePath);
                //int y = gvAddForm.FocusedRowHandle; // lấy ra vị trí cột trong hàng click
                gvAddForm.SetRowCellValue(gvAddForm.FocusedRowHandle, gvAddForm.Columns["Form"], fileName);
                string fileUpload = Path.Combine(Helpers._folderFileUpload, fileName);
                File.Copy(filePath, fileUpload, true);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                gvAddForm.AddNewRow();
                gvAddForm.Focus();
                //gvData.FocusedRowHandle = GridControl.NewItemRowHandle;
                //gvData.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
                gvAddForm.FocusedRowHandle = GridControl.NewItemRowHandle;
                gvAddForm.ShowEditor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowHandle = gvAddForm.FocusedRowHandle; // Lấy chỉ số của hàng đang được chọn

                if (selectedRowHandle >= 0)
                {
                    gvAddForm.DeleteRow(selectedRowHandle); // Xóa hàng được chọn
                }
                else
                {
                    MessageBox.Show("Hãy chọn một hàng để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gvAddForm.RowCount; i++)
            {
                DataRow row = gvAddForm.GetDataRow(i);
                if (row.RowState == DataRowState.Added)
                {
                    if (string.IsNullOrEmpty(Convert.ToString(row["Name"])))
                    {
                        MessageBox.Show("Nhập tên Form!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrEmpty(Convert.ToString(row["Form"])))
                    {
                        MessageBox.Show("Chọn File Form!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            // Xóa dữ liệu nếu có
            FormDAO.Instance.DeleteFormByDocNumAndRev(docNo, rev);

            // Insert data
            for (int i = 0;i < gvAddForm.RowCount; i++)
            {
                DataRow row = gvAddForm.GetDataRow(i);
                string name = Convert.ToString(row["Name"]);
                string form = Convert.ToString(row["Form"]);
                FormDAO.Instance.InsertForm(docNo, rev, name, form);
            }

            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RowCountToSend = gvAddForm.RowCount; // truyền dữ liệu sang form cha
            this.Close();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
        }

        
    }
}