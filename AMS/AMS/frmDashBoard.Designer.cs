namespace AMS
{
    partial class frmDashBoard
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue3 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue4 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule5 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue5 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.StateCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcDashBoard = new DevExpress.XtraGrid.GridControl();
            this.gvDashBoard = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UserInfoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDashBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDashBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // StateCode
            // 
            this.StateCode.Caption = "StateCode";
            this.StateCode.FieldName = "StateCode";
            this.StateCode.Name = "StateCode";
            // 
            // EmployeeStatus
            // 
            this.EmployeeStatus.Caption = "Status";
            this.EmployeeStatus.FieldName = "EmployeeStatus";
            this.EmployeeStatus.Name = "EmployeeStatus";
            this.EmployeeStatus.Visible = true;
            this.EmployeeStatus.VisibleIndex = 2;
            this.EmployeeStatus.Width = 238;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcDashBoard);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(943, 667);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcDashBoard
            // 
            this.gcDashBoard.Location = new System.Drawing.Point(12, 12);
            this.gcDashBoard.MainView = this.gvDashBoard;
            this.gcDashBoard.Name = "gcDashBoard";
            this.gcDashBoard.Size = new System.Drawing.Size(919, 643);
            this.gcDashBoard.TabIndex = 0;
            this.gcDashBoard.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDashBoard});
            // 
            // gvDashBoard
            // 
            this.gvDashBoard.Appearance.FooterPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvDashBoard.Appearance.FooterPanel.Options.UseFont = true;
            this.gvDashBoard.Appearance.GroupFooter.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvDashBoard.Appearance.GroupFooter.Options.UseFont = true;
            this.gvDashBoard.Appearance.GroupPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvDashBoard.Appearance.GroupPanel.Options.UseFont = true;
            this.gvDashBoard.Appearance.GroupRow.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvDashBoard.Appearance.GroupRow.Options.UseFont = true;
            this.gvDashBoard.Appearance.HeaderPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvDashBoard.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDashBoard.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.gvDashBoard.Appearance.Row.Options.UseFont = true;
            this.gvDashBoard.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UserInfoID,
            this.UserName,
            this.FullName,
            this.EmployeeStatus,
            this.StateCode});
            gridFormatRule1.Column = this.StateCode;
            gridFormatRule1.ColumnApplyTo = this.EmployeeStatus;
            gridFormatRule1.Name = "NotLoggedin";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.Red;
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = "1";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.Column = this.StateCode;
            gridFormatRule2.ColumnApplyTo = this.EmployeeStatus;
            gridFormatRule2.Name = "LoggedIn";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            formatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue2.Value1 = "4";
            gridFormatRule2.Rule = formatConditionRuleValue2;
            gridFormatRule3.Column = this.StateCode;
            gridFormatRule3.ColumnApplyTo = this.EmployeeStatus;
            gridFormatRule3.Name = "OnLunchBreak";
            formatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            formatConditionRuleValue3.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue3.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue3.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue3.Value1 = "2";
            gridFormatRule3.Rule = formatConditionRuleValue3;
            gridFormatRule4.Column = this.StateCode;
            gridFormatRule4.ColumnApplyTo = this.EmployeeStatus;
            gridFormatRule4.Name = "OnDayBreak";
            formatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.Yellow;
            formatConditionRuleValue4.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue4.Value1 = "3";
            gridFormatRule4.Rule = formatConditionRuleValue4;
            gridFormatRule5.Column = this.StateCode;
            gridFormatRule5.ColumnApplyTo = this.EmployeeStatus;
            gridFormatRule5.Name = "Loggedout";
            formatConditionRuleValue5.Appearance.BackColor = System.Drawing.Color.SlateGray;
            formatConditionRuleValue5.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue5.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue5.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue5.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue5.Value1 = "5";
            gridFormatRule5.Rule = formatConditionRuleValue5;
            this.gvDashBoard.FormatRules.Add(gridFormatRule1);
            this.gvDashBoard.FormatRules.Add(gridFormatRule2);
            this.gvDashBoard.FormatRules.Add(gridFormatRule3);
            this.gvDashBoard.FormatRules.Add(gridFormatRule4);
            this.gvDashBoard.FormatRules.Add(gridFormatRule5);
            this.gvDashBoard.GridControl = this.gcDashBoard;
            this.gvDashBoard.Name = "gvDashBoard";
            this.gvDashBoard.OptionsBehavior.Editable = false;
            this.gvDashBoard.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvDashBoard.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvDashBoard.OptionsSelection.EnableAppearanceHideSelection = false;
            // 
            // UserInfoID
            // 
            this.UserInfoID.Caption = "UserInfoID";
            this.UserInfoID.FieldName = "UserInfoID";
            this.UserInfoID.Name = "UserInfoID";
            // 
            // UserName
            // 
            this.UserName.Caption = "EmployeeID";
            this.UserName.FieldName = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.Visible = true;
            this.UserName.VisibleIndex = 0;
            this.UserName.Width = 134;
            // 
            // FullName
            // 
            this.FullName.Caption = "Name";
            this.FullName.FieldName = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 1;
            this.FullName.Width = 384;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(943, 667);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcDashBoard;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(923, 647);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 667);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmDashBoard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDashBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDashBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcDashBoard;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDashBoard;
        private DevExpress.XtraGrid.Columns.GridColumn UserInfoID;
        private DevExpress.XtraGrid.Columns.GridColumn UserName;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeStatus;
        private DevExpress.XtraGrid.Columns.GridColumn StateCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}