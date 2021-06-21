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
        Me.tblBusClients = New System.Windows.Forms.DataGridView()
        Me.BUSINESSCLIENTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txbPhone = New System.Windows.Forms.TextBox()
        Me.txbSalesPersonID = New System.Windows.Forms.TextBox()
        Me.txbClientID = New System.Windows.Forms.TextBox()
        Me.txbBName = New System.Windows.Forms.TextBox()
        Me.txbAddress = New System.Windows.Forms.TextBox()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SkyliteDB = New M2.SkyliteDB()
        Me.TblClientsBusinessBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblClientsBusinessTableAdapter = New M2.SkyliteDBTableAdapters.tblClientsBusinessTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.tblBusClients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BUSINESSCLIENTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClientsBusinessBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tblBusClients)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 426)
        Me.Panel1.TabIndex = 13
        '
        'tblBusClients
        '
        Me.tblBusClients.AutoGenerateColumns = False
        Me.tblBusClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblBusClients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.tblBusClients.DataSource = Me.TblClientsBusinessBindingSource
        Me.tblBusClients.Location = New System.Drawing.Point(35, 88)
        Me.tblBusClients.Name = "tblBusClients"
        Me.tblBusClients.Size = New System.Drawing.Size(711, 309)
        Me.tblBusClients.TabIndex = 16
        '
        'BUSINESSCLIENTSBindingSource
        '
        Me.BUSINESSCLIENTSBindingSource.DataMember = "BUSINESS CLIENTS"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(694, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 28)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "REMOVE"
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(822, 382)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(265, 56)
        Me.Button2.TabIndex = 72
        Me.Button2.Text = "Add Client"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(819, 284)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(819, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(819, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Telephone"
        '
        'txbPhone
        '
        Me.txbPhone.Location = New System.Drawing.Point(909, 194)
        Me.txbPhone.Name = "txbPhone"
        Me.txbPhone.Size = New System.Drawing.Size(178, 20)
        Me.txbPhone.TabIndex = 68
        '
        'txbSalesPersonID
        '
        Me.txbSalesPersonID.Location = New System.Drawing.Point(909, 109)
        Me.txbSalesPersonID.Name = "txbSalesPersonID"
        Me.txbSalesPersonID.Size = New System.Drawing.Size(178, 20)
        Me.txbSalesPersonID.TabIndex = 67
        '
        'txbClientID
        '
        Me.txbClientID.Location = New System.Drawing.Point(909, 71)
        Me.txbClientID.Name = "txbClientID"
        Me.txbClientID.Size = New System.Drawing.Size(178, 20)
        Me.txbClientID.TabIndex = 66
        '
        'txbBName
        '
        Me.txbBName.Location = New System.Drawing.Point(909, 150)
        Me.txbBName.Name = "txbBName"
        Me.txbBName.Size = New System.Drawing.Size(178, 20)
        Me.txbBName.TabIndex = 65
        '
        'txbAddress
        '
        Me.txbAddress.Location = New System.Drawing.Point(909, 281)
        Me.txbAddress.Name = "txbAddress"
        Me.txbAddress.Size = New System.Drawing.Size(178, 20)
        Me.txbAddress.TabIndex = 64
        '
        'txbEmail
        '
        Me.txbEmail.Location = New System.Drawing.Point(909, 237)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(178, 20)
        Me.txbEmail.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(849, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 31)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Add New Client"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(819, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Business Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(819, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Client ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(819, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Salesperson ID"
        '
        'SkyliteDB
        '
        Me.SkyliteDB.DataSetName = "SkyliteDB"
        Me.SkyliteDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblClientsBusinessBindingSource
        '
        Me.TblClientsBusinessBindingSource.DataMember = "tblClientsBusiness"
        Me.TblClientsBusinessBindingSource.DataSource = Me.SkyliteDB
        '
        'TblClientsBusinessTableAdapter
        '
        Me.TblClientsBusinessTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Client_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Client_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Employee_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Employee_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Business_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Business_Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Business_Email"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Business_Email"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Business_Telephone"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Business_Telephone"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Business_Address"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Business_Address"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'BUSINESS_CLIENTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txbPhone)
        Me.Controls.Add(Me.txbSalesPersonID)
        Me.Controls.Add(Me.txbClientID)
        Me.Controls.Add(Me.txbBName)
        Me.Controls.Add(Me.txbAddress)
        Me.Controls.Add(Me.txbEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BUSINESS_CLIENTS"
        Me.Text = "BUSINESS_CLIENTS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tblBusClients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BUSINESSCLIENTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClientsBusinessBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tblBusClients As DataGridView
    Friend WithEvents BUSINESSCLIENTSBindingSource As BindingSource
    Friend WithEvents ClientIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BusinessNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BusinessEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BusinessTelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BusinessAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txbPhone As TextBox
    Friend WithEvents txbSalesPersonID As TextBox
    Friend WithEvents txbClientID As TextBox
    Friend WithEvents txbBName As TextBox
    Friend WithEvents txbAddress As TextBox
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SkyliteDB As SkyliteDB
    Friend WithEvents TblClientsBusinessBindingSource As BindingSource
    Friend WithEvents TblClientsBusinessTableAdapter As SkyliteDBTableAdapters.tblClientsBusinessTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
