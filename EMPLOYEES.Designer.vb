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
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Group26DataSet6 = New M2.group26DataSet6()
        Me.EMPLOYEESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLOYEESTableAdapter = New M2.group26DataSet6TableAdapters.EMPLOYEESTableAdapter()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeCellDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeePasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeePositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group26DataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 426)
        Me.Panel1.TabIndex = 13
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIDDataGridViewTextBoxColumn, Me.EmployeeNameDataGridViewTextBoxColumn, Me.EmployeeCellDataGridViewTextBoxColumn, Me.EmployeeEmailDataGridViewTextBoxColumn, Me.EmployeePasswordDataGridViewTextBoxColumn, Me.EmployeePositionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EMPLOYEESBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(62, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(643, 273)
        Me.DataGridView1.TabIndex = 15
        '
        'Group26DataSet6
        '
        Me.Group26DataSet6.DataSetName = "group26DataSet6"
        Me.Group26DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPLOYEESBindingSource
        '
        Me.EMPLOYEESBindingSource.DataMember = "EMPLOYEES"
        Me.EMPLOYEESBindingSource.DataSource = Me.Group26DataSet6
        '
        'EMPLOYEESTableAdapter
        '
        Me.EMPLOYEESTableAdapter.ClearBeforeFill = True
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        '
        'EmployeeNameDataGridViewTextBoxColumn
        '
        Me.EmployeeNameDataGridViewTextBoxColumn.DataPropertyName = "Employee_Name"
        Me.EmployeeNameDataGridViewTextBoxColumn.HeaderText = "Employee_Name"
        Me.EmployeeNameDataGridViewTextBoxColumn.Name = "EmployeeNameDataGridViewTextBoxColumn"
        '
        'EmployeeCellDataGridViewTextBoxColumn
        '
        Me.EmployeeCellDataGridViewTextBoxColumn.DataPropertyName = "Employee_Cell"
        Me.EmployeeCellDataGridViewTextBoxColumn.HeaderText = "Employee_Cell"
        Me.EmployeeCellDataGridViewTextBoxColumn.Name = "EmployeeCellDataGridViewTextBoxColumn"
        '
        'EmployeeEmailDataGridViewTextBoxColumn
        '
        Me.EmployeeEmailDataGridViewTextBoxColumn.DataPropertyName = "Employee_Email"
        Me.EmployeeEmailDataGridViewTextBoxColumn.HeaderText = "Employee_Email"
        Me.EmployeeEmailDataGridViewTextBoxColumn.Name = "EmployeeEmailDataGridViewTextBoxColumn"
        '
        'EmployeePasswordDataGridViewTextBoxColumn
        '
        Me.EmployeePasswordDataGridViewTextBoxColumn.DataPropertyName = "Employee_Password"
        Me.EmployeePasswordDataGridViewTextBoxColumn.HeaderText = "Employee_Password"
        Me.EmployeePasswordDataGridViewTextBoxColumn.Name = "EmployeePasswordDataGridViewTextBoxColumn"
        '
        'EmployeePositionDataGridViewTextBoxColumn
        '
        Me.EmployeePositionDataGridViewTextBoxColumn.DataPropertyName = "Employee_Position"
        Me.EmployeePositionDataGridViewTextBoxColumn.HeaderText = "Employee_Position"
        Me.EmployeePositionDataGridViewTextBoxColumn.Name = "EmployeePositionDataGridViewTextBoxColumn"
        '
        'EMPLOYEES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EMPLOYEES"
        Me.Text = "EMPLOYEE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group26DataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Group26DataSet6 As group26DataSet6
    Friend WithEvents EMPLOYEESBindingSource As BindingSource
    Friend WithEvents EMPLOYEESTableAdapter As group26DataSet6TableAdapters.EMPLOYEESTableAdapter
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeCellDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeePasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeePositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
