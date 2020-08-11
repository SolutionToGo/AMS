namespace AMS
{
    partial class frmProjectWorkType
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
            this.gcTask = new DevExpress.XtraGrid.GridControl();
            this.gvTask = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProjectWorkTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WorkTypeDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTask)).BeginInit();
            this.SuspendLayout();
            // 
            // gcTask
            // 
            this.gcTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTask.Location = new System.Drawing.Point(0, 0);
            this.gcTask.MainView = this.gvTask;
            this.gcTask.Name = "gcTask";
            this.gcTask.Size = new System.Drawing.Size(620, 702);
            this.gcTask.TabIndex = 0;
            this.gcTask.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTask});
            // 
            // gvTask
            // 
            this.gvTask.Appearance.GroupFooter.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvTask.Appearance.GroupFooter.Options.UseFont = true;
            this.gvTask.Appearance.GroupPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvTask.Appearance.GroupPanel.Options.UseFont = true;
            this.gvTask.Appearance.GroupRow.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvTask.Appearance.GroupRow.Options.UseFont = true;
            this.gvTask.Appearance.HeaderPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvTask.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTask.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.gvTask.Appearance.Row.Options.UseFont = true;
            this.gvTask.Appearance.TopNewRow.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.gvTask.Appearance.TopNewRow.Options.UseFont = true;
            this.gvTask.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProjectWorkTypeID,
            this.WorkTypeDescription});
            this.gvTask.GridControl = this.gcTask;
            this.gvTask.Name = "gvTask";
            this.gvTask.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvTask.OptionsView.ShowGroupPanel = false;
            this.gvTask.OptionsView.ShowIndicator = false;
            this.gvTask.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvTask_InitNewRow);
            this.gvTask.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvTask_RowUpdated);
            // 
            // ProjectWorkTypeID
            // 
            this.ProjectWorkTypeID.Caption = "ProjectWorkTypeID";
            this.ProjectWorkTypeID.Name = "ProjectWorkTypeID";
            // 
            // WorkTypeDescription
            // 
            this.WorkTypeDescription.Caption = "Work Type";
            this.WorkTypeDescription.FieldName = "WorkTypeDescription";
            this.WorkTypeDescription.Name = "WorkTypeDescription";
            this.WorkTypeDescription.Visible = true;
            this.WorkTypeDescription.VisibleIndex = 0;
            // 
            // frmProjectWorkType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 702);
            this.Controls.Add(this.gcTask);
            this.Name = "frmProjectWorkType";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Work Type";
            this.Load += new System.EventHandler(this.frmTaskMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcTask;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTask;
        private DevExpress.XtraGrid.Columns.GridColumn ProjectWorkTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn WorkTypeDescription;
    }
}