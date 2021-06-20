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
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SUPPLIERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierTelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUPPLIERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 11
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplierIDDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn, Me.SupplierEmailDataGridViewTextBoxColumn, Me.SupplierTelephoneDataGridViewTextBoxColumn, Me.SupplierAddressDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SUPPLIERSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(120, 123)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 263)
        Me.DataGridView1.TabIndex = 15
        '
        'Group26DataSet2
        '
        '
        'SUPPLIERSBindingSource
        '
        Me.SUPPLIERSBindingSource.DataMember = "SUPPLIERS"
        '
        'SUPPLIERSTableAdapter
        '
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        '
        'SupplierNameDataGridViewTextBoxColumn
        '
        Me.SupplierNameDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Name"
        Me.SupplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier_Name"
        Me.SupplierNameDataGridViewTextBoxColumn.Name = "SupplierNameDataGridViewTextBoxColumn"
        '
        'SupplierEmailDataGridViewTextBoxColumn
        '
        Me.SupplierEmailDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Email"
        Me.SupplierEmailDataGridViewTextBoxColumn.HeaderText = "Supplier_Email"
        Me.SupplierEmailDataGridViewTextBoxColumn.Name = "SupplierEmailDataGridViewTextBoxColumn"
        '
        'SupplierTelephoneDataGridViewTextBoxColumn
        '
        Me.SupplierTelephoneDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Telephone"
        Me.SupplierTelephoneDataGridViewTextBoxColumn.HeaderText = "Supplier_Telephone"
        Me.SupplierTelephoneDataGridViewTextBoxColumn.Name = "SupplierTelephoneDataGridViewTextBoxColumn"
        '
        'SupplierAddressDataGridViewTextBoxColumn
        '
        Me.SupplierAddressDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Address"
        Me.SupplierAddressDataGridViewTextBoxColumn.HeaderText = "Supplier_Address"
        Me.SupplierAddressDataGridViewTextBoxColumn.Name = "SupplierAddressDataGridViewTextBoxColumn"
        '
        'SUPPLIERS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SUPPLIERS"
        Me.Text = "SUPPLIERS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUPPLIERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SUPPLIERSBindingSource As BindingSource
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierTelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
