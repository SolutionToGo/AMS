namespace AMS
{
    partial class frmWorkType
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
            this.gcWorkType = new DevExpress.XtraGrid.GridControl();
            this.gvWorkType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.WorkTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WorkTypedescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubTaskID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbSubTask = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcWorkType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubTask)).BeginInit();
            this.SuspendLayout();
            // 
            // gcWorkType
            // 
            this.gcWorkType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcWorkType.Location = new System.Drawing.Point(0, 0);
            this.gcWorkType.MainView = this.gvWorkType;
            this.gcWorkType.Name = "gcWorkType";
            this.gcWorkType.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbSubTask});
            this.gcWorkType.Size = new System.Drawing.Size(727, 702);
            this.gcWorkType.TabIndex = 0;
            this.gcWorkType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvWorkType});
            // 
            // gvWorkType
            // 
            this.gvWorkType.Appearance.GroupFooter.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvWorkType.Appearance.GroupFooter.Options.UseFont = true;
            this.gvWorkType.Appearance.GroupPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvWorkType.Appearance.GroupPanel.Options.UseFont = true;
            this.gvWorkType.Appearance.GroupRow.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvWorkType.Appearance.GroupRow.Options.UseFont = true;
            this.gvWorkType.Appearance.HeaderPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvWorkType.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvWorkType.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.gvWorkType.Appearance.Row.Options.UseFont = true;
            this.gvWorkType.Appearance.TopNewRow.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.gvWorkType.Appearance.TopNewRow.Options.UseFont = true;
            this.gvWorkType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.WorkTypeID,
            this.WorkTypedescription,
            this.SubTaskID});
            this.gvWorkType.GridControl = this.gcWorkType;
            this.gvWorkType.Name = "gvWorkType";
            this.gvWorkType.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvWorkType.OptionsView.ShowGroupPanel = false;
            this.gvWorkType.OptionsView.ShowIndicator = false;
            this.gvWorkType.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvTask_InitNewRow);
            this.gvWorkType.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvTask_RowUpdated);
            // 
            // WorkTypeID
            // 
            this.WorkTypeID.Caption = "WorkTypeID";
            this.WorkTypeID.FieldName = "WorkTypeID";
            this.WorkTypeID.Name = "WorkTypeID";
            // 
            // WorkTypedescription
            // 
            this.WorkTypedescription.Caption = "Work Type";
            this.WorkTypedescription.FieldName = "WorkTypedescription";
            this.WorkTypedescription.Name = "WorkTypedescription";
            this.WorkTypedescription.Visible = true;
            this.WorkTypedescription.VisibleIndex = 0;
            // 
            // SubTaskID
            // 
            this.SubTaskID.Caption = "Sub Task";
            this.SubTaskID.ColumnEdit = this.cmbSubTask;
            this.SubTaskID.FieldName = "SubTaskID";
            this.SubTaskID.Name = "SubTaskID";
            this.SubTaskID.Visible = true;
            this.SubTaskID.VisibleIndex = 1;
            // 
            // cmbSubTask
            // 
            this.cmbSubTask.AutoHeight = false;
            this.cmbSubTask.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSubTask.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubTaskID", "SubTaskID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubTaskDescription", "Sub Task")});
            this.cmbSubTask.Name = "cmbSubTask";
            // 
            // frmWorkType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 702);
            this.Controls.Add(this.gcWorkType);
            this.Name = "frmWorkType";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Type";
            this.Load += new System.EventHandler(this.frmSubTaskMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcWorkType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcWorkType;
        private DevExpress.XtraGrid.Views.Grid.GridView gvWorkType;
        private DevExpress.XtraGrid.Columns.GridColumn WorkTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn WorkTypedescription;
        private DevExpress.XtraGrid.Columns.GridColumn SubTaskID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cmbSubTask;
    }
}