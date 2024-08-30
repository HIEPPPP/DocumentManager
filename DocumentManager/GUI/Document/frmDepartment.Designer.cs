namespace DocumentManager.GUI.Document
{
    partial class frmDepartment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gcDepartment = new DevExpress.XtraGrid.GridControl();
            this.gvDepartment = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.colName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colConnectorF1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colConnectorF2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTerminal = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.gcDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // gcDepartment
            // 
            this.gcDepartment.Location = new System.Drawing.Point(13, 13);
            this.gcDepartment.MainView = this.gvDepartment;
            this.gcDepartment.Name = "gcDepartment";
            this.gcDepartment.Size = new System.Drawing.Size(570, 309);
            this.gcDepartment.TabIndex = 1;
            this.gcDepartment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDepartment});
            // 
            // gvDepartment
            // 
            this.gvDepartment.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDepartment.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDepartment.Appearance.Row.Options.UseTextOptions = true;
            this.gvDepartment.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDepartment.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.gvDepartment.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colName,
            this.colConnectorF1,
            this.colConnectorF2,
            this.colTerminal});
            this.gvDepartment.GridControl = this.gcDepartment;
            this.gvDepartment.Name = "gvDepartment";
            this.gvDepartment.OptionsSelection.MultiSelect = true;
            this.gvDepartment.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // colName
            // 
            this.colName.Caption = "Bộ phận";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.UnboundDataType = typeof(bool);
            this.colName.Visible = true;
            // 
            // colConnectorF1
            // 
            this.colConnectorF1.Caption = "ConnectorF1";
            this.colConnectorF1.FieldName = "ConnectorF1";
            this.colConnectorF1.Name = "colConnectorF1";
            this.colConnectorF1.Visible = true;
            // 
            // colConnectorF2
            // 
            this.colConnectorF2.Caption = "ConnectorF2";
            this.colConnectorF2.FieldName = "ConnectorF2";
            this.colConnectorF2.Name = "colConnectorF2";
            this.colConnectorF2.Visible = true;
            // 
            // colTerminal
            // 
            this.colTerminal.Caption = "Terminal";
            this.colTerminal.FieldName = "Terminal";
            this.colTerminal.Name = "colTerminal";
            this.colTerminal.Visible = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.colName);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 75;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Mảng sản xuất";
            this.gridBand2.Columns.Add(this.colConnectorF1);
            this.gridBand2.Columns.Add(this.colTerminal);
            this.gridBand2.Columns.Add(this.colConnectorF2);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 225;
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 406);
            this.Controls.Add(this.gcDepartment);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDepartment";
            this.Text = "frmDepartment";
            ((System.ComponentModel.ISupportInitialize)(this.gcDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gcDepartment;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gvDepartment;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colConnectorF1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTerminal;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colConnectorF2;
    }
}