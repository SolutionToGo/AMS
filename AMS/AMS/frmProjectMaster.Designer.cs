namespace AMS
{
    partial class frmProjectMaster
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
            this.gcSubTask = new DevExpress.XtraGrid.GridControl();
            this.gvSubTask = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProjectID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserInfoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbTask = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.IsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcSubTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTask)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSubTask
            // 
            this.gcSubTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSubTask.Location = new System.Drawing.Point(0, 0);
            this.gcSubTask.MainView = this.gvSubTask;
            this.gcSubTask.Name = "gcSubTask";
            this.gcSubTask.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbTask});
            this.gcSubTask.Size = new System.Drawing.Size(1037, 702);
            this.gcSubTask.TabIndex = 0;
            this.gcSubTask.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSubTask});
            // 
            // gvSubTask
            // 
            this.gvSubTask.Appearance.GroupFooter.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvSubTask.Appearance.GroupFooter.Options.UseFont = true;
            this.gvSubTask.Appearance.GroupPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvSubTask.Appearance.GroupPanel.Options.UseFont = true;
            this.gvSubTask.Appearance.GroupRow.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvSubTask.Appearance.GroupRow.Options.UseFont = true;
            this.gvSubTask.Appearance.HeaderPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvSubTask.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvSubTask.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.gvSubTask.Appearance.Row.Options.UseFont = true;
            this.gvSubTask.Appearance.TopNewRow.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.gvSubTask.Appearance.TopNewRow.Options.UseFont = true;
            this.gvSubTask.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProjectID,
            this.ProjectName,
            this.UserInfoID,
            this.IsActive});
            this.gvSubTask.GridControl = this.gcSubTask;
            this.gvSubTask.Name = "gvSubTask";
            this.gvSubTask.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvSubTask.OptionsView.ShowGroupPanel = false;
            this.gvSubTask.OptionsView.ShowIndicator = false;
            this.gvSubTask.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvTask_InitNewRow);
            this.gvSubTask.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvTask_RowUpdated);
            // 
            // ProjectID
            // 
            this.ProjectID.Caption = "ProjectID";
            this.ProjectID.FieldName = "ProjectID";
            this.ProjectID.Name = "ProjectID";
            // 
            // ProjectName
            // 
            this.ProjectName.Caption = "ProjectName";
            this.ProjectName.FieldName = "ProjectName";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Visible = true;
            this.ProjectName.VisibleIndex = 0;
            this.ProjectName.Width = 342;
            // 
            // UserInfoID
            // 
            this.UserInfoID.Caption = "Project Lead";
            this.UserInfoID.ColumnEdit = this.cmbTask;
            this.UserInfoID.FieldName = "UserInfoID";
            this.UserInfoID.Name = "UserInfoID";
            this.UserInfoID.Visible = true;
            this.UserInfoID.VisibleIndex = 1;
            this.UserInfoID.Width = 342;
            // 
            // cmbTask
            // 
            this.cmbTask.AutoHeight = false;
            this.cmbTask.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTask.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserInfoID", "UserInfoID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "Employee ID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Employee Name")});
            this.cmbTask.Name = "cmbTask";
            // 
            // IsActive
            // 
            this.IsActive.Caption = "Is Active";
            this.IsActive.FieldName = "IsActive";
            this.IsActive.Name = "IsActive";
            this.IsActive.Visible = true;
            this.IsActive.VisibleIndex = 2;
            this.IsActive.Width = 84;
            // 
            // frmProjectMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 702);
            this.Controls.Add(this.gcSubTask);
            this.Name = "frmProjectMaster";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project";
            this.Load += new System.EventHandler(this.frmSubTaskMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcSubTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcSubTask;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSubTask;
        private DevExpress.XtraGrid.Columns.GridColumn ProjectID;
        private DevExpress.XtraGrid.Columns.GridColumn ProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn UserInfoID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cmbTask;
        private DevExpress.XtraGrid.Columns.GridColumn IsActive;
    }
}