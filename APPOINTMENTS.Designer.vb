<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APPOINTMENTS
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
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txbAppNum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.tblAppointments = New System.Windows.Forms.DataGridView()
        Me.AppNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppDetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APPOINTMENTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkyliteDB = New M2.SkyliteDB()
        Me.txbStatus = New System.Windows.Forms.TextBox()
        Me.txbDetails = New System.Windows.Forms.TextBox()
        Me.txbTime = New System.Windows.Forms.TextBox()
        Me.txbEmpID = New System.Windows.Forms.TextBox()
        Me.txbClientID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.APPOINTMENTSTableAdapter = New M2.SkyliteDBTableAdapters.APPOINTMENTSTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.tblAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APPOINTMENTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(3, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(79, 28)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "BACK"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.txbAppNum)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Controls.Add(Me.tblAppointments)
        Me.Panel1.Controls.Add(Me.txbStatus)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.txbDetails)
        Me.Panel1.Controls.Add(Me.txbTime)
        Me.Panel1.Controls.Add(Me.txbEmpID)
        Me.Panel1.Controls.Add(Me.txbClientID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1077, 430)
        Me.Panel1.TabIndex = 19
        '
        'txbAppNum
        '
        Me.txbAppNum.Location = New System.Drawing.Point(889, 102)
        Me.txbAppNum.Name = "txbAppNum"
        Me.txbAppNum.Size = New System.Drawing.Size(173, 20)
        Me.txbAppNum.TabIndex = 93
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(795, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Appointment No."
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(1, 2)
        Me.MonthCalendar1.Location = New System.Drawing.Point(16, 100)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 90
        '
        'tblAppointments
        '
        Me.tblAppointments.AutoGenerateColumns = False
        Me.tblAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblAppointments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AppNumberDataGridViewTextBoxColumn, Me.ClientIDDataGridViewTextBoxColumn, Me.EmployeeIDDataGridViewTextBoxColumn, Me.AppDateDataGridViewTextBoxColumn, Me.AppTimeDataGridViewTextBoxColumn, Me.AppDetailsDataGridViewTextBoxColumn, Me.AppStatusDataGridViewTextBoxColumn})
        Me.tblAppointments.DataSource = Me.APPOINTMENTSBindingSource
        Me.tblAppointments.Location = New System.Drawing.Point(250, 107)
        Me.tblAppointments.Name = "tblAppointments"
        Me.tblAppointments.Size = New System.Drawing.Size(536, 295)
        Me.tblAppointments.TabIndex = 89
        '
        'AppNumberDataGridViewTextBoxColumn
        '
        Me.AppNumberDataGridViewTextBoxColumn.DataPropertyName = "App_Number"
        Me.AppNumberDataGridViewTextBoxColumn.HeaderText = "App_Number"
        Me.AppNumberDataGridViewTextBoxColumn.Name = "AppNumberDataGridViewTextBoxColumn"
        '
        'ClientIDDataGridViewTextBoxColumn
        '
        Me.ClientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID"
        Me.ClientIDDataGridViewTextBoxColumn.HeaderText = "Client_ID"
        Me.ClientIDDataGridViewTextBoxColumn.Name = "ClientIDDataGridViewTextBoxColumn"
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        '
        'AppDateDataGridViewTextBoxColumn
        '
        Me.AppDateDataGridViewTextBoxColumn.DataPropertyName = "App_Date"
        Me.AppDateDataGridViewTextBoxColumn.HeaderText = "App_Date"
        Me.AppDateDataGridViewTextBoxColumn.Name = "AppDateDataGridViewTextBoxColumn"
        '
        'AppTimeDataGridViewTextBoxColumn
        '
        Me.AppTimeDataGridViewTextBoxColumn.DataPropertyName = "App_Time"
        Me.AppTimeDataGridViewTextBoxColumn.HeaderText = "App_Time"
        Me.AppTimeDataGridViewTextBoxColumn.Name = "AppTimeDataGridViewTextBoxColumn"
        '
        'AppDetailsDataGridViewTextBoxColumn
        '
        Me.AppDetailsDataGridViewTextBoxColumn.DataPropertyName = "App_Details"
        Me.AppDetailsDataGridViewTextBoxColumn.HeaderText = "App_Details"
        Me.AppDetailsDataGridViewTextBoxColumn.Name = "AppDetailsDataGridViewTextBoxColumn"
        '
        'AppStatusDataGridViewTextBoxColumn
        '
        Me.AppStatusDataGridViewTextBoxColumn.DataPropertyName = "App_Status"
        Me.AppStatusDataGridViewTextBoxColumn.HeaderText = "App_Status"
        Me.AppStatusDataGridViewTextBoxColumn.Name = "AppStatusDataGridViewTextBoxColumn"
        '
        'APPOINTMENTSBindingSource
        '
        Me.APPOINTMENTSBindingSource.DataMember = "APPOINTMENTS"
        Me.APPOINTMENTSBindingSource.DataSource = Me.SkyliteDB
        '
        'SkyliteDB
        '
        Me.SkyliteDB.DataSetName = "SkyliteDB"
        Me.SkyliteDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txbStatus
        '
        Me.txbStatus.Location = New System.Drawing.Point(889, 258)
        Me.txbStatus.Name = "txbStatus"
        Me.txbStatus.Size = New System.Drawing.Size(173, 20)
        Me.txbStatus.TabIndex = 88
        '
        'txbDetails
        '
        Me.txbDetails.Location = New System.Drawing.Point(889, 232)
        Me.txbDetails.Name = "txbDetails"
        Me.txbDetails.Size = New System.Drawing.Size(173, 20)
        Me.txbDetails.TabIndex = 87
        '
        'txbTime
        '
        Me.txbTime.Location = New System.Drawing.Point(889, 206)
        Me.txbTime.Name = "txbTime"
        Me.txbTime.Size = New System.Drawing.Size(173, 20)
        Me.txbTime.TabIndex = 85
        '
        'txbEmpID
        '
        Me.txbEmpID.Location = New System.Drawing.Point(889, 154)
        Me.txbEmpID.Name = "txbEmpID"
        Me.txbEmpID.Size = New System.Drawing.Size(173, 20)
        Me.txbEmpID.TabIndex = 83
        '
        'txbClientID
        '
        Me.txbClientID.Location = New System.Drawing.Point(889, 128)
        Me.txbClientID.Name = "txbClientID"
        Me.txbClientID.Size = New System.Drawing.Size(173, 20)
        Me.txbClientID.TabIndex = 82
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(794, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Status"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(797, 346)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(265, 56)
        Me.Button3.TabIndex = 80
        Me.Button3.Text = "Edit Appointments"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(250, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(506, 20)
        Me.TextBox1.TabIndex = 79
        Me.TextBox1.Text = "Search..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(807, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(236, 29)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Add/Edit Appointments"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(794, 209)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Time"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(797, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(265, 56)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "Add to Appointments"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(795, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Date"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(762, 81)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 20)
        Me.Button2.TabIndex = 66
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(795, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(795, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Client ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(795, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Employee ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(338, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 59)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "APPOINTMENTS"
        '
        'APPOINTMENTSTableAdapter
        '
        Me.APPOINTMENTSTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(889, 180)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(173, 20)
        Me.DateTimePicker1.TabIndex = 94
        '
        'APPOINTMENTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 454)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "APPOINTMENTS"
        Me.Text = "APPOINTMENTS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tblAppointments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APPOINTMENTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button8 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txbStatus As TextBox
    Friend WithEvents txbDetails As TextBox
    Friend WithEvents txbTime As TextBox
    Friend WithEvents txbEmpID As TextBox
    Friend WithEvents txbClientID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tblAppointments As DataGridView
    Friend WithEvents SkyliteDB As SkyliteDB
    Friend WithEvents APPOINTMENTSBindingSource As BindingSource
    Friend WithEvents APPOINTMENTSTableAdapter As SkyliteDBTableAdapters.APPOINTMENTSTableAdapter
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents AppNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppDetailsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txbAppNum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
