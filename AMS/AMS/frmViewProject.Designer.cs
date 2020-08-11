namespace AMS
{
    partial class frmViewProject
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtManagementComments = new DevExpress.XtraEditors.MemoEdit();
            this.txtSelfComments = new DevExpress.XtraEditors.MemoEdit();
            this.cmbProjectLead = new DevExpress.XtraEditors.LookUpEdit();
            this.gcRatings = new DevExpress.XtraGrid.GridControl();
            this.gvRatings = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtDescription = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.cmbProjectName = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtManagementComments.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelfComments.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjectLead.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRatings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRatings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
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
            this.layoutControl1.Controls.Add(this.txtManagementComments);
            this.layoutControl1.Controls.Add(this.txtSelfComments);
            this.layoutControl1.Controls.Add(this.cmbProjectLead);
            this.layoutControl1.Controls.Add(this.gcRatings);
            this.layoutControl1.Controls.Add(this.cmbProjectName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1081, 167, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1032, 660);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtManagementComments
            // 
            this.txtManagementComments.Location = new System.Drawing.Point(518, 427);
            this.txtManagementComments.Name = "txtManagementComments";
            this.txtManagementComments.Size = new System.Drawing.Size(510, 229);
            this.txtManagementComments.StyleController = this.layoutControl1;
            this.txtManagementComments.TabIndex = 9;
            // 
            // txtSelfComments
            // 
            this.txtSelfComments.Location = new System.Drawing.Point(4, 427);
            this.txtSelfComments.Name = "txtSelfComments";
            this.txtSelfComments.Size = new System.Drawing.Size(510, 229);
            this.txtSelfComments.StyleController = this.layoutControl1;
            this.txtSelfComments.TabIndex = 8;
            // 
            // cmbProjectLead
            // 
            this.cmbProjectLead.Location = new System.Drawing.Point(662, 4);
            this.cmbProjectLead.Name = "cmbProjectLead";
            this.cmbProjectLead.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProjectLead.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserInfoID", "UserInfoID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Employee Name")});
            this.cmbProjectLead.Properties.NullText = "";
            this.cmbProjectLead.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbProjectLead.Size = new System.Drawing.Size(366, 24);
            this.cmbProjectLead.StyleController = this.layoutControl1;
            this.cmbProjectLead.TabIndex = 2;
            // 
            // gcRatings
            // 
            this.gcRatings.Location = new System.Drawing.Point(4, 32);
            this.gcRatings.MainView = this.gvRatings;
            this.gcRatings.Name = "gcRatings";
            this.gcRatings.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtDescription});
            this.gcRatings.Size = new System.Drawing.Size(1024, 370);
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
            this.gvRatings.GridControl = this.gcRatings;
            this.gvRatings.Name = "gvRatings";
            this.gvRatings.OptionsCustomization.AllowFilter = false;
            this.gvRatings.OptionsCustomization.AllowGroup = false;
            this.gvRatings.OptionsCustomization.AllowRowSizing = true;
            this.gvRatings.OptionsCustomization.AllowSort = false;
            this.gvRatings.OptionsView.RowAutoHeight = true;
            this.gvRatings.OptionsView.ShowGroupPanel = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Name = "txtDescription";
            // 
            // cmbProjectName
            // 
            this.cmbProjectName.Location = new System.Drawing.Point(148, 4);
            this.cmbProjectName.Name = "cmbProjectName";
            this.cmbProjectName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProjectName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProjectID", "ProjectID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProjectName", "Project Name")});
            this.cmbProjectName.Properties.NullText = "";
            this.cmbProjectName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbProjectName.Size = new System.Drawing.Size(366, 24);
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
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(1032, 660);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gcRatings;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1028, 374);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cmbProjectName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(514, 28);
            this.layoutControlItem2.Text = "Project Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(141, 18);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbProjectLead;
            this.layoutControlItem1.Location = new System.Drawing.Point(514, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(514, 28);
            this.layoutControlItem1.Text = "Project Lead";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(141, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtSelfComments;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 402);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(514, 254);
            this.layoutControlItem4.Text = "Self Comments";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(141, 18);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtManagementComments;
            this.layoutControlItem5.Location = new System.Drawing.Point(514, 402);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(514, 254);
            this.layoutControlItem5.Text = "Management Comments";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(141, 18);
            // 
            // frmViewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 660);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmViewProject";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Project";
            this.Load += new System.EventHandler(this.frmViewProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtManagementComments.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelfComments.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjectLead.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRatings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRatings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbProjectLead;
        private DevExpress.XtraGrid.GridControl gcRatings;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRatings;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit txtDescription;
        private DevExpress.XtraEditors.LookUpEdit cmbProjectName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.MemoEdit txtManagementComments;
        private DevExpress.XtraEditors.MemoEdit txtSelfComments;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}