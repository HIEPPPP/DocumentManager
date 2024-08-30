using DevExpress.DocumentServices.ServiceModel.DataContracts;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DocumentManager.DAO;
using DocumentManager.GUI.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentManager.GUI
{
    public partial class frmDocumentMST : DevExpress.XtraEditors.XtraForm
    {
        public frmDocumentMST()
        {
            InitializeComponent();
            LoadListDocument();
        }

        void LoadListDocument()
        {
            DataTable dt = DocumentDAO.Instance.GetListDocument();
            gcDocument.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddDocument frmAddDocument = new frmAddDocument();
            frmAddDocument.ShowDialog();
        }

        private void frmDocumentMST_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmAddDocument frmAdd = new frmAddDocument();
            frmAdd.ShowDialog();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void gcDocument_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                // Thông tin cụ thể về các sự kiện với chuột
                DXMouseEventArgs ea = e as DXMouseEventArgs;
                GridView view = sender as GridView;
                // Xác định thông tin về vị trí nhấp chuột
                GridHitInfo info = view.CalcHitInfo(ea.Location);

                if (info.InRow || info.InRowCell)
                {
                    string colCaption = info.Column?.GetCaption() ?? "N/A";

                    // Sử dụng Dictionary để ánh xạ tiêu đề cột với hành động
                    var columnActions = new Dictionary<string, Action>
            {
                //{ "Bộ phận chưa hoàn thành triển khai", OpenDeploymentStatusForm },
                //{ "Form", OpenListForm },
                //{ "Rev", OpenDocumentRevHistoryForm },
                //{ "File tài liệu", OpenDocumentFile }
            };

                    // Thực hiện hành động dựa trên tiêu đề cột
                    if (columnActions.ContainsKey(colCaption))
                    {
                        columnActions[colCaption]();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gvDocument_RowCountChanged(object sender, EventArgs e)
        {
            txtRecord.Text = gvDocument.RowCount.ToString();
        }

        //private void OpenDeploymentStatusForm()
        //{
        //    string Document_No = Convert.ToString(gvData.GetFocusedRowCellValue("DOCUMENT_NO"));
        //    string Rev = Convert.ToString(gvData.GetFocusedRowCellValue("REV"));
        //    FRM_DEPLOYMENT_STATUS f = new FRM_DEPLOYMENT_STATUS(Document_No, Rev);
        //    if (f.ShowDialog() == DialogResult.OK)
        //    {
        //        LoadData();
        //    }
        //}

        //private void OpenListForm()
        //{
        //    string Document_No = Convert.ToString(gvData.GetFocusedRowCellValue("DOCUMENT_NO"));
        //    string Rev = Convert.ToString(gvData.GetFocusedRowCellValue("REV"));
        //    FRM_LIST_FORM f = new FRM_LIST_FORM(Document_No, Rev);
        //    f.ShowDialog();
        //}

        //private void OpenDocumentRevHistoryForm()
        //{
        //    string Document_No = Convert.ToString(gvData.GetFocusedRowCellValue("DOCUMENT_NO"));
        //    FRM_DOCUMENT_REV_HISTORY f = new FRM_DOCUMENT_REV_HISTORY(Document_No);
        //    f.ShowDialog();
        //}

        //private void OpenDocumentFile()
        //{
        //    string filePath = Convert.ToString(gvData.GetFocusedRowCellValue("FILE_DOCUMENT"));
        //    if (!string.IsNullOrEmpty(filePath))
        //    {
        //        System.Diagnostics.Process.Start(Constaint._folderFileUpload + filePath);
        //    }
        //}
    }
}