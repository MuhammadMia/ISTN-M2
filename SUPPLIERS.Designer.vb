<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUPPLIERS
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
        Me.tblSuppliers = New System.Windows.Forms.DataGridView()
        Me.SUPPLIERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SkyliteDB = New M2.SkyliteDB()
        Me.TblSuplliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSuplliersTableAdapter = New M2.SkyliteDBTableAdapters.tblSuplliersTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txbSuppID = New System.Windows.Forms.TextBox()
        Me.txbSuppName = New System.Windows.Forms.TextBox()
        Me.txbAddress = New System.Windows.Forms.TextBox()
        Me.txbPhone = New System.Windows.Forms.TextBox()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.tblSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUPPLIERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSuplliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.tblSuppliers)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 426)
        Me.Panel1.TabIndex = 11
        '
        'tblSuppliers
        '
        Me.tblSuppliers.AutoGenerateColumns = False
        Me.tblSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblSuppliers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.tblSuppliers.DataSource = Me.TblSuplliersBindingSource
        Me.tblSuppliers.Location = New System.Drawing.Point(29, 100)
        Me.tblSuppliers.Name = "tblSuppliers"
        Me.tblSuppliers.Size = New System.Drawing.Size(717, 302)
        Me.tblSuppliers.TabIndex = 15
        '
        'SUPPLIERSBindingSource
        '
        Me.SUPPLIERSBindingSource.DataMember = "SUPPLIERS"
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
        Me.Label1.Location = New System.Drawing.Point(230, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 61)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "SUPPLIERS"
        '
        'SkyliteDB
        '
        Me.SkyliteDB.DataSetName = "SkyliteDB"
        Me.SkyliteDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSuplliersBindingSource
        '
        Me.TblSuplliersBindingSource.DataMember = "tblSuplliers"
        Me.TblSuplliersBindingSource.DataSource = Me.SkyliteDB
        '
        'TblSuplliersTableAdapter
        '
        Me.TblSuplliersTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Supplier_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Supplier_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Supplier_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Supplier_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Supplier_Email"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Supplier_Email"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Supplier_Telephone"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Supplier_Telephone"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Supplier_Address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Supplier_Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(818, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(265, 56)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Add to Product List"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(815, 246)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Telephone"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(815, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(815, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Address"
        '
        'txbSuppID
        '
        Me.txbSuppID.Location = New System.Drawing.Point(905, 114)
        Me.txbSuppID.Name = "txbSuppID"
        Me.txbSuppID.Size = New System.Drawing.Size(178, 20)
        Me.txbSuppID.TabIndex = 52
        '
        'txbSuppName
        '
        Me.txbSuppName.Location = New System.Drawing.Point(905, 155)
        Me.txbSuppName.Name = "txbSuppName"
        Me.txbSuppName.Size = New System.Drawing.Size(178, 20)
        Me.txbSuppName.TabIndex = 50
        '
        'txbAddress
        '
        Me.txbAddress.Location = New System.Drawing.Point(905, 288)
        Me.txbAddress.Name = "txbAddress"
        Me.txbAddress.Size = New System.Drawing.Size(178, 20)
        Me.txbAddress.TabIndex = 49
        '
        'txbPhone
        '
        Me.txbPhone.Location = New System.Drawing.Point(905, 243)
        Me.txbPhone.Name = "txbPhone"
        Me.txbPhone.Size = New System.Drawing.Size(178, 20)
        Me.txbPhone.TabIndex = 48
        '
        'txbEmail
        '
        Me.txbEmail.Location = New System.Drawing.Point(905, 199)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(178, 20)
        Me.txbEmail.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(871, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 31)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Add Supplier"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(815, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Supplier Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(815, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Supplier ID"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(694, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 28)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "REMOVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SUPPLIERS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txbSuppID)
        Me.Controls.Add(Me.txbSuppName)
        Me.Controls.Add(Me.txbAddress)
        Me.Controls.Add(Me.txbPhone)
        Me.Controls.Add(Me.txbEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SUPPLIERS"
        Me.Text = "SUPPLIERS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tblSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUPPLIERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSuplliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tblSuppliers As DataGridView
    Friend WithEvents SUPPLIERSBindingSource As BindingSource
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierTelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SkyliteDB As SkyliteDB
    Friend WithEvents TblSuplliersBindingSource As BindingSource
    Friend WithEvents TblSuplliersTableAdapter As SkyliteDBTableAdapters.tblSuplliersTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txbSuppID As TextBox
    Friend WithEvents txbSuppName As TextBox
    Friend WithEvents txbAddress As TextBox
    Friend WithEvents txbPhone As TextBox
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
End Class
