namespace AMS
{
    partial class frmAddProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProject));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cmbProjectLead = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.gcRatings = new DevExpress.XtraGrid.GridControl();
            this.gvRatings = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDescription = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProjectName = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjectLead.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRatings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRatings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.layoutControl1.Appearance.Control.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlDisabled.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.layoutControl1.Appearance.ControlDisabled.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlDropDown.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.layoutControl1.Appearance.ControlDropDown.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlDropDownHeader.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.layoutControl1.Appearance.ControlDropDownHeader.Options.UseFont = true;
            this.layoutControl1.Controls.Add(this.cmbProjectLead);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.gcRatings);
            this.layoutControl1.Controls.Add(this.cmbProjectName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1081, 167, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1169, 697);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cmbProjectLead
            // 
            this.cmbProjectLead.Location = new System.Drawing.Point(668, 4);
            this.cmbProjectLead.Name = "cmbProjectLead";
            this.cmbProjectLead.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProjectLead.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserInfoID", "UserInfoID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Employee Name")});
            this.cmbProjectLead.Properties.NullText = "";
            this.cmbProjectLead.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbProjectLead.Size = new System.Drawing.Size(497, 24);
            this.cmbProjectLead.StyleController = this.layoutControl1;
            this.cmbProjectLead.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(946, 655);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(219, 38);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(719, 655);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(223, 38);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gcRatings
            // 
            this.gcRatings.Location = new System.Drawing.Point(4, 32);
            this.gcRatings.MainView = this.gvRatings;
            this.gcRatings.Name = "gcRatings";
            this.gcRatings.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtDescription});
            this.gcRatings.Size = new System.Drawing.Size(1161, 619);
            this.gcRatings.TabIndex = 7;
            this.gcRatings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRatings});
            // 
            // gvRatings
            // 
            this.gvRatings.Appearance.HeaderPanel.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.gvRatings.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvRatings.Appearance.Row.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.gvRatings.Appearance.Row.Options.UseFont = true;
            this.gvRatings.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvRatings.GridControl = this.gcRatings;
            this.gvRatings.Name = "gvRatings";
            this.gvRatings.OptionsCustomization.AllowFilter = false;
            this.gvRatings.OptionsCustomization.AllowGroup = false;
            this.gvRatings.OptionsCustomization.AllowRowSizing = true;
            this.gvRatings.OptionsCustomization.AllowSort = false;
            this.gvRatings.OptionsView.RowAutoHeight = true;
            this.gvRatings.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "CriteriaID";
            this.gridColumn1.FieldName = "CriteriaID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "CriteriaName";
            this.gridColumn2.FieldName = "CriteriaName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Description";
            this.gridColumn3.ColumnEdit = this.txtDescription;
            this.gridColumn3.FieldName = "Description";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Name = "txtDescription";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "SA";
            this.gridColumn4.FieldName = "SA";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Comments";
            this.gridColumn5.ColumnEdit = this.txtDescription;
            this.gridColumn5.FieldName = "Comments";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // cmbProjectName
            // 
            this.cmbProjectName.Location = new System.Drawing.Point(86, 4);
            this.cmbProjectName.Name = "cmbProjectName";
            this.cmbProjectName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProjectName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProjectID", "ProjectID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProjectName", "Project Name")});
            this.cmbProjectName.Properties.NullText = "";
            this.cmbProjectName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbProjectName.Size = new System.Drawing.Size(496, 24);
            this.cmbProjectName.StyleController = this.layoutControl1;
            this.cmbProjectName.TabIndex = 1;
            // 
            // Root
            // 
            this.Root.AppearanceItemCaption.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.Root.AppearanceItemCaption.Options.UseFont = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(1169, 697);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gcRatings;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1165, 623);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cmbProjectName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(582, 28);
            this.layoutControlItem2.Text = "Project Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(79, 18);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnCancel;
            this.layoutControlItem6.Location = new System.Drawing.Point(715, 651);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(227, 42);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnSave;
            this.layoutControlItem7.Location = new System.Drawing.Point(942, 651);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(223, 42);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 651);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(715, 42);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbProjectLead;
            this.layoutControlItem1.Location = new System.Drawing.Point(582, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(583, 28);
            this.layoutControlItem1.Text = "Project Lead";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(79, 18);
            // 
            // frmAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1169, 697);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmAddProject";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Project";
            this.Load += new System.EventHandler(this.frmAddProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjectLead.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRatings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRatings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LookUpEdit cmbProjectName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gcRatings;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRatings;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit txtDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LookUpEdit cmbProjectLead;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}