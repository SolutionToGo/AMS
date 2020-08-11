namespace AMS
{
    partial class frmViewTimesheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewTimesheet));
            this.IsHoliday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsWeekend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtpSelectedMonth = new DevExpress.XtraEditors.DateEdit();
            this.cmbEmployeeList = new DevExpress.XtraEditors.LookUpEdit();
            this.gcTimesheet = new DevExpress.XtraGrid.GridControl();
            this.gvTimesheet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcBreaks = new DevExpress.XtraGrid.GridControl();
            this.gvBreaks = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTotalHours = new DevExpress.XtraGrid.GridControl();
            this.gvTotalHours = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSelectedMonth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSelectedMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmployeeList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTimesheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTimesheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBreaks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBreaks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTotalHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTotalHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // IsHoliday
            // 
            this.IsHoliday.Caption = "IsHoliday";
            this.IsHoliday.FieldName = "IsHoliday";
            this.IsHoliday.Name = "IsHoliday";
            this.IsHoliday.Visible = true;
            this.IsHoliday.VisibleIndex = 11;
            // 
            // IsWeekend
            // 
            this.IsWeekend.Caption = "IsWeekend";
            this.IsWeekend.FieldName = "IsWeekend";
            this.IsWeekend.Name = "IsWeekend";
            this.IsWeekend.Visible = true;
            this.IsWeekend.VisibleIndex = 12;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.layoutControl1.Appearance.Control.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlDisabled.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.layoutControl1.Appearance.ControlDisabled.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlDropDown.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.layoutControl1.Appearance.ControlDropDown.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlDropDownHeader.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.layoutControl1.Appearance.ControlDropDownHeader.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlFocused.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.layoutControl1.Appearance.ControlFocused.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlReadOnly.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.layoutControl1.Appearance.ControlReadOnly.Options.UseFont = true;
            this.layoutControl1.Controls.Add(this.btnRefresh);
            this.layoutControl1.Controls.Add(this.dtpSelectedMonth);
            this.layoutControl1.Controls.Add(this.cmbEmployeeList);
            this.layoutControl1.Controls.Add(this.gcTimesheet);
            this.layoutControl1.Controls.Add(this.gcBreaks);
            this.layoutControl1.Controls.Add(this.gcTotalHours);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(945, 441, 974, 599);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1143, 684);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtpSelectedMonth
            // 
            this.dtpSelectedMonth.EditValue = null;
            this.dtpSelectedMonth.Location = new System.Drawing.Point(166, 22);
            this.dtpSelectedMonth.Name = "dtpSelectedMonth";
            this.dtpSelectedMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpSelectedMonth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpSelectedMonth.Properties.DisplayFormat.FormatString = "y";
            this.dtpSelectedMonth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpSelectedMonth.Properties.EditFormat.FormatString = "y";
            this.dtpSelectedMonth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpSelectedMonth.Properties.Mask.EditMask = "y";
            this.dtpSelectedMonth.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtpSelectedMonth.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.dtpSelectedMonth.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            this.dtpSelectedMonth.Size = new System.Drawing.Size(396, 26);
            this.dtpSelectedMonth.StyleController = this.layoutControl1;
            this.dtpSelectedMonth.TabIndex = 10;
            this.dtpSelectedMonth.EditValueChanged += new System.EventHandler(this.dtpSelectedMonth_EditValueChanged);
            // 
            // cmbEmployeeList
            // 
            this.cmbEmployeeList.Location = new System.Drawing.Point(166, 52);
            this.cmbEmployeeList.Name = "cmbEmployeeList";
            this.cmbEmployeeList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEmployeeList.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserInfoID", "UserInfoID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "Employee ID", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Employee Name", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbEmployeeList.Properties.NullText = "Select";
            this.cmbEmployeeList.Size = new System.Drawing.Size(396, 26);
            this.cmbEmployeeList.StyleController = this.layoutControl1;
            this.cmbEmployeeList.TabIndex = 9;
            this.cmbEmployeeList.EditValueChanged += new System.EventHandler(this.cmbEmployeeList_EditValueChanged);
            // 
            // gcTimesheet
            // 
            this.gcTimesheet.Location = new System.Drawing.Point(12, 122);
            this.gcTimesheet.MainView = this.gvTimesheet;
            this.gcTimesheet.Name = "gcTimesheet";
            this.gcTimesheet.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit2});
            this.gcTimesheet.Size = new System.Drawing.Size(1119, 550);
            this.gcTimesheet.TabIndex = 8;
            this.gcTimesheet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTimesheet});
            // 
            // gvTimesheet
            // 
            this.gvTimesheet.Appearance.FooterPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvTimesheet.Appearance.FooterPanel.Options.UseFont = true;
            this.gvTimesheet.Appearance.HeaderPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvTimesheet.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTimesheet.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.gvTimesheet.Appearance.Row.Options.UseFont = true;
            this.gvTimesheet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.IsHoliday,
            this.IsWeekend});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.IsHoliday;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(65)))));
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = "1";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule1.StopIfTrue = true;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.IsWeekend;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(224)))));
            formatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue2.Value1 = "1";
            gridFormatRule2.Rule = formatConditionRuleValue2;
            this.gvTimesheet.FormatRules.Add(gridFormatRule1);
            this.gvTimesheet.FormatRules.Add(gridFormatRule2);
            this.gvTimesheet.GridControl = this.gcTimesheet;
            this.gvTimesheet.Name = "gvTimesheet";
            this.gvTimesheet.OptionsBehavior.Editable = false;
            this.gvTimesheet.OptionsCustomization.AllowColumnResizing = false;
            this.gvTimesheet.OptionsCustomization.AllowFilter = false;
            this.gvTimesheet.OptionsCustomization.AllowGroup = false;
            this.gvTimesheet.OptionsCustomization.AllowSort = false;
            this.gvTimesheet.OptionsFind.AllowFindPanel = false;
            this.gvTimesheet.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvTimesheet.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvTimesheet.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gvTimesheet.OptionsView.ShowGroupPanel = false;
            this.gvTimesheet.OptionsView.ShowIndicator = false;
            this.gvTimesheet.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvTimesheet_PopupMenuShowing);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ID";
            this.gridColumn4.FieldName = "ID";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "TimesheetID";
            this.gridColumn5.FieldName = "TimesheetID";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Date";
            this.gridColumn6.FieldName = "LogDate";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "LogDateDesc";
            this.gridColumn7.FieldName = "LogDateDesc";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Login";
            this.gridColumn8.ColumnEdit = this.repositoryItemDateEdit2;
            this.gridColumn8.FieldName = "DayLogin";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.DisplayFormat.FormatString = "T";
            this.repositoryItemDateEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit2.EditFormat.FormatString = "T";
            this.repositoryItemDateEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit2.Mask.EditMask = "T";
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Going For Lunch";
            this.gridColumn12.ColumnEdit = this.repositoryItemDateEdit2;
            this.gridColumn12.FieldName = "LunchLogin";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 5;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Back From Lunch";
            this.gridColumn13.ColumnEdit = this.repositoryItemDateEdit2;
            this.gridColumn13.FieldName = "LunchLogout";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 6;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Log out";
            this.gridColumn14.ColumnEdit = this.repositoryItemDateEdit2;
            this.gridColumn14.FieldName = "DayLogout";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 7;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Total Spent Time";
            this.gridColumn15.FieldName = "DayHours";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 8;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Lunch Time";
            this.gridColumn16.FieldName = "LunchHours";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 9;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Break Time";
            this.gridColumn17.FieldName = "BreakHours";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 10;
            // 
            // gcBreaks
            // 
            this.gcBreaks.Location = new System.Drawing.Point(566, 12);
            this.gcBreaks.MainView = this.gvBreaks;
            this.gcBreaks.Name = "gcBreaks";
            this.gcBreaks.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gcBreaks.Size = new System.Drawing.Size(322, 106);
            this.gcBreaks.TabIndex = 7;
            this.gcBreaks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBreaks});
            // 
            // gvBreaks
            // 
            this.gvBreaks.Appearance.GroupFooter.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvBreaks.Appearance.GroupFooter.Options.UseFont = true;
            this.gvBreaks.Appearance.HeaderPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvBreaks.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvBreaks.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.gvBreaks.Appearance.Row.Options.UseFont = true;
            this.gvBreaks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.gvBreaks.GridControl = this.gcBreaks;
            this.gvBreaks.Name = "gvBreaks";
            this.gvBreaks.OptionsBehavior.Editable = false;
            this.gvBreaks.OptionsCustomization.AllowColumnMoving = false;
            this.gvBreaks.OptionsCustomization.AllowColumnResizing = false;
            this.gvBreaks.OptionsCustomization.AllowFilter = false;
            this.gvBreaks.OptionsCustomization.AllowGroup = false;
            this.gvBreaks.OptionsCustomization.AllowSort = false;
            this.gvBreaks.OptionsFind.AllowFindPanel = false;
            this.gvBreaks.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvBreaks.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvBreaks.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gvBreaks.OptionsView.ShowGroupPanel = false;
            this.gvBreaks.OptionsView.ShowIndicator = false;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Going For Break";
            this.gridColumn9.ColumnEdit = this.repositoryItemDateEdit1;
            this.gridColumn9.FieldName = "BreakLogin";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.DisplayFormat.FormatString = "HH:MM";
            this.repositoryItemDateEdit1.CalendarTimeProperties.EditFormat.FormatString = "HH:MM";
            this.repositoryItemDateEdit1.CalendarTimeProperties.Mask.EditMask = "HH:MM";
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "T";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "T";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "T";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Back From Break";
            this.gridColumn10.ColumnEdit = this.repositoryItemDateEdit1;
            this.gridColumn10.FieldName = "BreakLogout";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Break Time";
            this.gridColumn11.FieldName = "BreakMins";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 2;
            // 
            // gcTotalHours
            // 
            this.gcTotalHours.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gcTotalHours.Location = new System.Drawing.Point(892, 12);
            this.gcTotalHours.MainView = this.gvTotalHours;
            this.gcTotalHours.Margin = new System.Windows.Forms.Padding(2);
            this.gcTotalHours.Name = "gcTotalHours";
            this.gcTotalHours.Size = new System.Drawing.Size(239, 106);
            this.gcTotalHours.TabIndex = 2;
            this.gcTotalHours.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTotalHours});
            // 
            // gvTotalHours
            // 
            this.gvTotalHours.Appearance.GroupFooter.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvTotalHours.Appearance.GroupFooter.Options.UseFont = true;
            this.gvTotalHours.Appearance.HeaderPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvTotalHours.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTotalHours.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvTotalHours.Appearance.Row.Options.UseFont = true;
            this.gvTotalHours.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvTotalHours.DetailHeight = 239;
            this.gvTotalHours.FixedLineWidth = 1;
            this.gvTotalHours.GridControl = this.gcTotalHours;
            this.gvTotalHours.Name = "gvTotalHours";
            this.gvTotalHours.OptionsBehavior.Editable = false;
            this.gvTotalHours.OptionsCustomization.AllowColumnMoving = false;
            this.gvTotalHours.OptionsCustomization.AllowColumnResizing = false;
            this.gvTotalHours.OptionsCustomization.AllowFilter = false;
            this.gvTotalHours.OptionsCustomization.AllowGroup = false;
            this.gvTotalHours.OptionsCustomization.AllowSort = false;
            this.gvTotalHours.OptionsFind.AllowFindPanel = false;
            this.gvTotalHours.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvTotalHours.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvTotalHours.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gvTotalHours.OptionsView.ShowGroupPanel = false;
            this.gvTotalHours.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Duration";
            this.gridColumn1.FieldName = "HoursDesc";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Total Hours";
            this.gridColumn2.FieldName = "TotalHours";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Logged Hours";
            this.gridColumn3.FieldName = "LoggedHours";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // Root
            // 
            this.Root.AppearanceGroup.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Root.AppearanceGroup.Options.UseFont = true;
            this.Root.AppearanceItemCaption.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.Root.AppearanceItemCaption.Options.UseFont = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1143, 684);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gcTotalHours;
            this.layoutControlItem4.Location = new System.Drawing.Point(880, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(243, 110);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.gcBreaks;
            this.layoutControlItem7.Location = new System.Drawing.Point(554, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(326, 110);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gcTimesheet;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 110);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1123, 554);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 68);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(374, 42);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbEmployeeList;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(554, 28);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(554, 28);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(554, 28);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Employee";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(151, 19);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(554, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dtpSelectedMonth;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 10);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(554, 30);
            this.layoutControlItem2.Text = "Selected Month/Year";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(151, 19);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.Location = new System.Drawing.Point(386, 80);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(176, 38);
            this.btnRefresh.StyleController = this.layoutControl1;
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnRefresh;
            this.layoutControlItem5.Location = new System.Drawing.Point(374, 68);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(180, 42);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // frmViewTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 684);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmViewTimesheet";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "View Timesheet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewTimesheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpSelectedMonth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSelectedMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmployeeList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTimesheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTimesheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBreaks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBreaks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTotalHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTotalHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcTimesheet;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTimesheet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn IsHoliday;
        private DevExpress.XtraGrid.Columns.GridColumn IsWeekend;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraGrid.GridControl gcBreaks;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBreaks;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.GridControl gcTotalHours;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTotalHours;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LookUpEdit cmbEmployeeList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.DateEdit dtpSelectedMonth;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}