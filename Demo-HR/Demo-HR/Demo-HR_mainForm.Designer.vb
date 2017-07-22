<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView_Employees = New System.Windows.Forms.DataGridView()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewListBoxEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRDataTableDataSet = New WindowsApplication1.HRDataTableDataSet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_Department = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_JobTitle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_Region = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_Status = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_Email = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_StaffID = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_SearchByFirstName = New System.Windows.Forms.TextBox()
        Me.Button_NewEmployee = New System.Windows.Forms.Button()
        Me.Button_SaveChanges = New System.Windows.Forms.Button()
        Me.Button_DeleteEmployee = New System.Windows.Forms.Button()
        Me.Button_Refresh = New System.Windows.Forms.Button()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.View_ListBox_EmployeeTableAdapter = New WindowsApplication1.HRDataTableDataSetTableAdapters.view_ListBox_EmployeeTableAdapter()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView_Employees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewListBoxEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRDataTableDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(18, 162)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1082, 580)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.DataGridView_Employees)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.TextBox_Department)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.TextBox_JobTitle)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.TextBox_Region)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.TextBox_Status)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TextBox_Email)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TextBox_StaffID)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(1074, 547)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Employees"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView_Employees
        '
        Me.DataGridView_Employees.AllowUserToAddRows = False
        Me.DataGridView_Employees.AllowUserToDeleteRows = False
        Me.DataGridView_Employees.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Employees.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_Employees.AutoGenerateColumns = False
        Me.DataGridView_Employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView_Employees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DataGridView_Employees.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView_Employees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView_Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Employees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffIDDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView_Employees.DataSource = Me.ViewListBoxEmployeeBindingSource
        Me.DataGridView_Employees.Location = New System.Drawing.Point(21, 28)
        Me.DataGridView_Employees.MultiSelect = False
        Me.DataGridView_Employees.Name = "DataGridView_Employees"
        Me.DataGridView_Employees.RowTemplate.Height = 28
        Me.DataGridView_Employees.Size = New System.Drawing.Size(572, 492)
        Me.DataGridView_Employees.TabIndex = 20
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "StaffID"
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        Me.StaffIDDataGridViewTextBoxColumn.Width = 97
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.Width = 116
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        Me.SurnameDataGridViewTextBoxColumn.Width = 110
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.Width = 92
        '
        'ViewListBoxEmployeeBindingSource
        '
        Me.ViewListBoxEmployeeBindingSource.DataMember = "view_ListBox_Employee"
        Me.ViewListBoxEmployeeBindingSource.DataSource = Me.HRDataTableDataSet
        '
        'HRDataTableDataSet
        '
        Me.HRDataTableDataSet.DataSetName = "HRDataTableDataSet"
        Me.HRDataTableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(672, 82)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Department"
        '
        'TextBox_Department
        '
        Me.TextBox_Department.Location = New System.Drawing.Point(780, 71)
        Me.TextBox_Department.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_Department.Name = "TextBox_Department"
        Me.TextBox_Department.Size = New System.Drawing.Size(276, 26)
        Me.TextBox_Department.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(672, 116)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Job Title"
        '
        'TextBox_JobTitle
        '
        Me.TextBox_JobTitle.Location = New System.Drawing.Point(780, 111)
        Me.TextBox_JobTitle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_JobTitle.Name = "TextBox_JobTitle"
        Me.TextBox_JobTitle.Size = New System.Drawing.Size(276, 26)
        Me.TextBox_JobTitle.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(672, 151)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Region"
        '
        'TextBox_Region
        '
        Me.TextBox_Region.Location = New System.Drawing.Point(780, 151)
        Me.TextBox_Region.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_Region.Name = "TextBox_Region"
        Me.TextBox_Region.Size = New System.Drawing.Size(148, 26)
        Me.TextBox_Region.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(672, 196)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Status"
        '
        'TextBox_Status
        '
        Me.TextBox_Status.Location = New System.Drawing.Point(780, 196)
        Me.TextBox_Status.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_Status.Name = "TextBox_Status"
        Me.TextBox_Status.Size = New System.Drawing.Size(148, 26)
        Me.TextBox_Status.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(672, 251)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Email"
        '
        'TextBox_Email
        '
        Me.TextBox_Email.Location = New System.Drawing.Point(780, 251)
        Me.TextBox_Email.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_Email.Name = "TextBox_Email"
        Me.TextBox_Email.Size = New System.Drawing.Size(148, 26)
        Me.TextBox_Email.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(672, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Staff ID"
        '
        'TextBox_StaffID
        '
        Me.TextBox_StaffID.Location = New System.Drawing.Point(780, 31)
        Me.TextBox_StaffID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_StaffID.Name = "TextBox_StaffID"
        Me.TextBox_StaffID.Size = New System.Drawing.Size(148, 26)
        Me.TextBox_StaffID.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Size = New System.Drawing.Size(1074, 547)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(279, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "By Last Name"
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.Location = New System.Drawing.Point(270, 81)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 26)
        Me.TextBox1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "By First Name"
        '
        'TextBox_SearchByFirstName
        '
        Me.TextBox_SearchByFirstName.AcceptsReturn = True
        Me.TextBox_SearchByFirstName.Location = New System.Drawing.Point(88, 81)
        Me.TextBox_SearchByFirstName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_SearchByFirstName.Name = "TextBox_SearchByFirstName"
        Me.TextBox_SearchByFirstName.Size = New System.Drawing.Size(170, 26)
        Me.TextBox_SearchByFirstName.TabIndex = 1
        '
        'Button_NewEmployee
        '
        Me.Button_NewEmployee.Location = New System.Drawing.Point(14, 771)
        Me.Button_NewEmployee.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_NewEmployee.Name = "Button_NewEmployee"
        Me.Button_NewEmployee.Size = New System.Drawing.Size(180, 35)
        Me.Button_NewEmployee.TabIndex = 2
        Me.Button_NewEmployee.Text = "New Employee"
        Me.Button_NewEmployee.UseVisualStyleBackColor = True
        '
        'Button_SaveChanges
        '
        Me.Button_SaveChanges.Location = New System.Drawing.Point(194, 771)
        Me.Button_SaveChanges.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_SaveChanges.Name = "Button_SaveChanges"
        Me.Button_SaveChanges.Size = New System.Drawing.Size(180, 35)
        Me.Button_SaveChanges.TabIndex = 3
        Me.Button_SaveChanges.Text = "Save Changes"
        Me.Button_SaveChanges.UseVisualStyleBackColor = True
        '
        'Button_DeleteEmployee
        '
        Me.Button_DeleteEmployee.Location = New System.Drawing.Point(374, 771)
        Me.Button_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_DeleteEmployee.Name = "Button_DeleteEmployee"
        Me.Button_DeleteEmployee.Size = New System.Drawing.Size(180, 35)
        Me.Button_DeleteEmployee.TabIndex = 4
        Me.Button_DeleteEmployee.Text = "Delete Employee"
        Me.Button_DeleteEmployee.UseVisualStyleBackColor = True
        '
        'Button_Refresh
        '
        Me.Button_Refresh.Location = New System.Drawing.Point(554, 771)
        Me.Button_Refresh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Refresh.Name = "Button_Refresh"
        Me.Button_Refresh.Size = New System.Drawing.Size(180, 35)
        Me.Button_Refresh.TabIndex = 7
        Me.Button_Refresh.Text = "Refresh"
        Me.Button_Refresh.UseVisualStyleBackColor = True
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Location = New System.Drawing.Point(734, 771)
        Me.Button_Cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(180, 35)
        Me.Button_Cancel.TabIndex = 6
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_Close
        '
        Me.Button_Close.Location = New System.Drawing.Point(914, 771)
        Me.Button_Close.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(180, 35)
        Me.Button_Close.TabIndex = 5
        Me.Button_Close.Text = "Close"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 56)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.MaximumSize = New System.Drawing.Size(150, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Search"
        '
        'View_ListBox_EmployeeTableAdapter
        '
        Me.View_ListBox_EmployeeTableAdapter.ClearBeforeFill = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton, Me.ToolStripSplitButton1})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1104, 32)
        Me.FillByToolStrip.TabIndex = 9
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(56, 29)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(45, 29)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 862)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button_Refresh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.TextBox_SearchByFirstName)
        Me.Controls.Add(Me.Button_DeleteEmployee)
        Me.Controls.Add(Me.Button_SaveChanges)
        Me.Controls.Add(Me.Button_NewEmployee)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Open Windows Corp - HR Maintenance"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView_Employees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewListBoxEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRDataTableDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button_NewEmployee As System.Windows.Forms.Button
    Friend WithEvents Button_SaveChanges As System.Windows.Forms.Button
    Friend WithEvents Button_DeleteEmployee As System.Windows.Forms.Button
    Friend WithEvents Button_Refresh As System.Windows.Forms.Button
    Friend WithEvents Button_Cancel As System.Windows.Forms.Button
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents TextBox_SearchByFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_StaffID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Department As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox_JobTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Region As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Status As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Email As System.Windows.Forms.TextBox
    Friend WithEvents HRDataTableDataSet As WindowsApplication1.HRDataTableDataSet
    Friend WithEvents ViewListBoxEmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_ListBox_EmployeeTableAdapter As WindowsApplication1.HRDataTableDataSetTableAdapters.view_ListBox_EmployeeTableAdapter
    Friend WithEvents DataGridView_Employees As System.Windows.Forms.DataGridView
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton

End Class
