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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txbPhone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbSalesPersonID = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.txbClientID = New System.Windows.Forms.TextBox()
        Me.txbBName = New System.Windows.Forms.TextBox()
        Me.tblClientsBusiness = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblClientsBusinessBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkyliteDB = New M2.SkyliteDB()
        Me.txbAddress = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BUSINESSCLIENTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblClientsBusinessTableAdapter = New M2.SkyliteDBTableAdapters.tblClientsBusinessTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.tblClientsBusiness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClientsBusinessBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BUSINESSCLIENTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.txbPhone)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txbSalesPersonID)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.txbClientID)
        Me.Panel1.Controls.Add(Me.txbBName)
        Me.Panel1.Controls.Add(Me.tblClientsBusiness)
        Me.Panel1.Controls.Add(Me.txbAddress)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txbEmail)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(906, 426)
        Me.Panel1.TabIndex = 13
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(824, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(79, 28)
        Me.Button4.TabIndex = 67
        Me.Button4.Text = "HOME"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(657, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 29)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Add/Edit Client"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(606, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 14)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Address"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(609, 346)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(265, 56)
        Me.Button3.TabIndex = 73
        Me.Button3.Text = "Edit Client"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(606, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 14)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Email"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(609, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(265, 56)
        Me.Button2.TabIndex = 72
        Me.Button2.Text = "Add Client"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(606, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 14)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Telephone"
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(154, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(328, 20)
        Me.TextBox1.TabIndex = 66
        Me.TextBox1.Text = "Search..."
        '
        'txbPhone
        '
        Me.txbPhone.Location = New System.Drawing.Point(696, 178)
        Me.txbPhone.Name = "txbPhone"
        Me.txbPhone.Size = New System.Drawing.Size(178, 20)
        Me.txbPhone.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(116, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(405, 59)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "BUSINESS CLIENTS"
        '
        'txbSalesPersonID
        '
        Me.txbSalesPersonID.Location = New System.Drawing.Point(696, 126)
        Me.txbSalesPersonID.Name = "txbSalesPersonID"
        Me.txbSalesPersonID.Size = New System.Drawing.Size(178, 20)
        Me.txbSalesPersonID.TabIndex = 67
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
        Me.Button8.TabIndex = 20
        Me.Button8.Text = "BACK"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'txbClientID
        '
        Me.txbClientID.Location = New System.Drawing.Point(696, 100)
        Me.txbClientID.Name = "txbClientID"
        Me.txbClientID.Size = New System.Drawing.Size(178, 20)
        Me.txbClientID.TabIndex = 66
        '
        'txbBName
        '
        Me.txbBName.Location = New System.Drawing.Point(696, 152)
        Me.txbBName.Name = "txbBName"
        Me.txbBName.Size = New System.Drawing.Size(178, 20)
        Me.txbBName.TabIndex = 65
        '
        'tblClientsBusiness
        '
        Me.tblClientsBusiness.AutoGenerateColumns = False
        Me.tblClientsBusiness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblClientsBusiness.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.tblClientsBusiness.DataSource = Me.TblClientsBusinessBindingSource
        Me.tblClientsBusiness.Location = New System.Drawing.Point(40, 100)
        Me.tblClientsBusiness.Name = "tblClientsBusiness"
        Me.tblClientsBusiness.Size = New System.Drawing.Size(543, 302)
        Me.tblClientsBusiness.TabIndex = 16
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
        'TblClientsBusinessBindingSource
        '
        Me.TblClientsBusinessBindingSource.DataMember = "tblClientsBusiness"
        Me.TblClientsBusinessBindingSource.DataSource = Me.SkyliteDB
        '
        'SkyliteDB
        '
        Me.SkyliteDB.DataSetName = "SkyliteDB"
        Me.SkyliteDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txbAddress
        '
        Me.txbAddress.Location = New System.Drawing.Point(696, 232)
        Me.txbAddress.Name = "txbAddress"
        Me.txbAddress.Size = New System.Drawing.Size(178, 20)
        Me.txbAddress.TabIndex = 64
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(561, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 20)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txbEmail
        '
        Me.txbEmail.Location = New System.Drawing.Point(696, 206)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(178, 20)
        Me.txbEmail.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(606, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 14)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Salesperson ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(606, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 14)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Client ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(606, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 14)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Business Name"
        '
        'BUSINESSCLIENTSBindingSource
        '
        Me.BUSINESSCLIENTSBindingSource.DataMember = "BUSINESS CLIENTS"
        '
        'TblClientsBusinessTableAdapter
        '
        Me.TblClientsBusinessTableAdapter.ClearBeforeFill = True
        '
        'BUSINESS_CLIENTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BUSINESS_CLIENTS"
        Me.Text = "BUSINESS_CLIENTS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tblClientsBusiness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClientsBusinessBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BUSINESSCLIENTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents tblClientsBusiness As DataGridView
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
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
End Class
