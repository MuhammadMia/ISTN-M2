<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BUSINESS_CLIENTS
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BUSINESSCLIENTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusinessNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusinessEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusinessTelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusinessAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BUSINESSCLIENTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 426)
        Me.Panel1.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(694, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 28)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "HOME"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.Label1.Location = New System.Drawing.Point(132, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(502, 61)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "BUSINESS CLIENTS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientIDDataGridViewTextBoxColumn, Me.EmployeeIDDataGridViewTextBoxColumn, Me.BusinessNameDataGridViewTextBoxColumn, Me.BusinessEmailDataGridViewTextBoxColumn, Me.BusinessTelephoneDataGridViewTextBoxColumn, Me.BusinessAddressDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BUSINESSCLIENTSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(65, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 269)
        Me.DataGridView1.TabIndex = 16
        '

        'BUSINESSCLIENTSBindingSource
        '
        Me.BUSINESSCLIENTSBindingSource.DataMember = "BUSINESS CLIENTS"
        '
        'BUSINESS_CLIENTSTableAdapter
        '
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
        'BusinessNameDataGridViewTextBoxColumn
        '
        Me.BusinessNameDataGridViewTextBoxColumn.DataPropertyName = "Business_Name"
        Me.BusinessNameDataGridViewTextBoxColumn.HeaderText = "Business_Name"
        Me.BusinessNameDataGridViewTextBoxColumn.Name = "BusinessNameDataGridViewTextBoxColumn"
        '
        'BusinessEmailDataGridViewTextBoxColumn
        '
        Me.BusinessEmailDataGridViewTextBoxColumn.DataPropertyName = "Business_Email"
        Me.BusinessEmailDataGridViewTextBoxColumn.HeaderText = "Business_Email"
        Me.BusinessEmailDataGridViewTextBoxColumn.Name = "BusinessEmailDataGridViewTextBoxColumn"
        '
        'BusinessTelephoneDataGridViewTextBoxColumn
        '
        Me.BusinessTelephoneDataGridViewTextBoxColumn.DataPropertyName = "Business_Telephone"
        Me.BusinessTelephoneDataGridViewTextBoxColumn.HeaderText = "Business_Telephone"
        Me.BusinessTelephoneDataGridViewTextBoxColumn.Name = "BusinessTelephoneDataGridViewTextBoxColumn"
        '
        'BusinessAddressDataGridViewTextBoxColumn
        '
        Me.BusinessAddressDataGridViewTextBoxColumn.DataPropertyName = "Business_Address"
        Me.BusinessAddressDataGridViewTextBoxColumn.HeaderText = "Business_Address"
        Me.BusinessAddressDataGridViewTextBoxColumn.Name = "BusinessAddressDataGridViewTextBoxColumn"
        '
        'BUSINESS_CLIENTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BUSINESS_CLIENTS"
        Me.Text = "BUSINESS_CLIENTS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BUSINESSCLIENTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BUSINESSCLIENTSBindingSource As BindingSource
    Friend WithEvents ClientIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BusinessNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BusinessEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BusinessTelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BusinessAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
