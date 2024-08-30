using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            LoadFormDocument();
        }

        void LoadFormDocument()
        {
            frmDocumentMST frmDocumentMST = new frmDocumentMST();
            frmDocumentMST.MdiParent = this;
            frmDocumentMST.Show();
        }

        private void barListDoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            var existForm = CheckForm(typeof(frmDocumentMST));
            if (existForm == null)
            {
                frmDocumentMST frmDocumentMST = new frmDocumentMST();
                frmDocumentMST.MdiParent = this;
                frmDocumentMST.Show();
            }
            else
            {
                existForm.Activate();
            }
        }

        private Form CheckForm(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void barAddDoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAddDocument frmAddDocument = new frmAddDocument();   
            frmAddDocument.ShowDialog();
        }
    }
}