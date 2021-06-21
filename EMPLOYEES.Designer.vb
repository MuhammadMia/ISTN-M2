<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMPLOYEES
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tblEmployees = New System.Windows.Forms.DataGridView()
        Me.EMPLOYEESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SkyliteDB = New M2.SkyliteDB()
        Me.SkyliteDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEmployeesTableAdapter = New M2.SkyliteDBTableAdapters.tblEmployeesTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txbCell = New System.Windows.Forms.TextBox()
        Me.txbLName = New System.Windows.Forms.TextBox()
        Me.txbFName = New System.Windows.Forms.TextBox()
        Me.txbEmpID = New System.Windows.Forms.TextBox()
        Me.txbPass = New System.Windows.Forms.TextBox()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbPosition = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.tblEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkyliteDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.tblEmployees)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 426)
        Me.Panel1.TabIndex = 13
        '
        'tblEmployees
        '
        Me.tblEmployees.AutoGenerateColumns = False
        Me.tblEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblEmployees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6})
        Me.tblEmployees.DataSource = Me.TblEmployeesBindingSource
        Me.tblEmployees.Location = New System.Drawing.Point(22, 94)
        Me.tblEmployees.Name = "tblEmployees"
        Me.tblEmployees.Size = New System.Drawing.Size(733, 312)
        Me.tblEmployees.TabIndex = 15
        '
        'EMPLOYEESBindingSource
        '
        Me.EMPLOYEESBindingSource.DataMember = "EMPLOYEES"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(3, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(79, 28)
        Me.Button8.TabIndex = 14
        Me.Button8.Text = "BACK"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 61)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "EMPLOYEES"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(694, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 28)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "REMOVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SkyliteDB
        '
        Me.SkyliteDB.DataSetName = "SkyliteDB"
        Me.SkyliteDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SkyliteDBBindingSource
        '
        Me.SkyliteDBBindingSource.DataSource = Me.SkyliteDB
        Me.SkyliteDBBindingSource.Position = 0
        '
        'TblEmployeesBindingSource
        '
        Me.TblEmployeesBindingSource.DataMember = "tblEmployees"
        Me.TblEmployeesBindingSource.DataSource = Me.SkyliteDBBindingSource
        '
        'TblEmployeesTableAdapter
        '
        Me.TblEmployeesTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Employee_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Employee_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Employee_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Employee_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Employee_Cell"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Employee_Cell"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Employee_Email"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Employee_Email"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Employee_Position"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Employee_Position"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(810, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(265, 56)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Add Employee"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(807, 284)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(807, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(807, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Cellphone"
        '
        'txbCell
        '
        Me.txbCell.Location = New System.Drawing.Point(897, 194)
        Me.txbCell.Name = "txbCell"
        Me.txbCell.Size = New System.Drawing.Size(178, 20)
        Me.txbCell.TabIndex = 53
        '
        'txbLName
        '
        Me.txbLName.Location = New System.Drawing.Point(897, 109)
        Me.txbLName.Name = "txbLName"
        Me.txbLName.Size = New System.Drawing.Size(178, 20)
        Me.txbLName.TabIndex = 52
        '
        'txbFName
        '
        Me.txbFName.Location = New System.Drawing.Point(897, 71)
        Me.txbFName.Name = "txbFName"
        Me.txbFName.Size = New System.Drawing.Size(178, 20)
        Me.txbFName.TabIndex = 51
        '
        'txbEmpID
        '
        Me.txbEmpID.Location = New System.Drawing.Point(897, 150)
        Me.txbEmpID.Name = "txbEmpID"
        Me.txbEmpID.Size = New System.Drawing.Size(178, 20)
        Me.txbEmpID.TabIndex = 50
        '
        'txbPass
        '
        Me.txbPass.Location = New System.Drawing.Point(897, 281)
        Me.txbPass.Name = "txbPass"
        Me.txbPass.Size = New System.Drawing.Size(178, 20)
        Me.txbPass.TabIndex = 48
        Me.txbPass.UseSystemPasswordChar = True
        '
        'txbEmail
        '
        Me.txbEmail.Location = New System.Drawing.Point(897, 237)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(178, 20)
        Me.txbEmail.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(835, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 31)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Add Employee"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(807, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Employee ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(807, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "First Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(807, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(807, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Position"
        '
        'txbPosition
        '
        Me.txbPosition.Location = New System.Drawing.Point(897, 323)
        Me.txbPosition.Name = "txbPosition"
        Me.txbPosition.Size = New System.Drawing.Size(178, 20)
        Me.txbPosition.TabIndex = 59
        '
        'EMPLOYEES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbPosition)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txbCell)
        Me.Controls.Add(Me.txbLName)
        Me.Controls.Add(Me.txbFName)
        Me.Controls.Add(Me.txbEmpID)
        Me.Controls.Add(Me.txbPass)
        Me.Controls.Add(Me.txbEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EMPLOYEES"
        Me.Text = "EMPLOYEE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tblEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkyliteDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tblEmployees As DataGridView
    Friend WithEvents EMPLOYEESBindingSource As BindingSource
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeCellDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeePasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeePositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents SkyliteDBBindingSource As BindingSource
    Friend WithEvents SkyliteDB As SkyliteDB
    Friend WithEvents TblEmployeesBindingSource As BindingSource
    Friend WithEvents TblEmployeesTableAdapter As SkyliteDBTableAdapters.tblEmployeesTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txbCell As TextBox
    Friend WithEvents txbLName As TextBox
    Friend WithEvents txbFName As TextBox
    Friend WithEvents txbEmpID As TextBox
    Friend WithEvents txbPass As TextBox
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txbPosition As TextBox
End Class
