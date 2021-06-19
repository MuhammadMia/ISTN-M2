<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CONTRACTS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Group26Contracts = New M2.group26Contracts()
        Me.CONTRACTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTRACTSTableAdapter = New M2.group26ContractsTableAdapters.CONTRACTSTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Group26DataSet = New M2.group26DataSet()
        Me.CONTRACTSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTRACTSTableAdapter1 = New M2.group26DataSetTableAdapters.CONTRACTSTableAdapter()
        Me.ContractIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractLengthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.Group26Contracts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRACTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRACTSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(211, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 61)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "CONTRACTS"
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
        'Group26Contracts
        '
        Me.Group26Contracts.DataSetName = "group26Contracts"
        Me.Group26Contracts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONTRACTSBindingSource
        '
        Me.CONTRACTSBindingSource.DataMember = "CONTRACTS"
        Me.CONTRACTSBindingSource.DataSource = Me.Group26Contracts
        '
        'CONTRACTSTableAdapter
        '
        Me.CONTRACTSTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ContractIDDataGridViewTextBoxColumn, Me.ClientIDDataGridViewTextBoxColumn, Me.SaleNumberDataGridViewTextBoxColumn, Me.ContractAmountDataGridViewTextBoxColumn, Me.ContractLengthDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CONTRACTSBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(106, 125)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 269)
        Me.DataGridView1.TabIndex = 15
        '
        'Group26DataSet
        '
        Me.Group26DataSet.DataSetName = "group26DataSet"
        Me.Group26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONTRACTSBindingSource1
        '
        Me.CONTRACTSBindingSource1.DataMember = "CONTRACTS"
        Me.CONTRACTSBindingSource1.DataSource = Me.Group26DataSet
        '
        'CONTRACTSTableAdapter1
        '
        Me.CONTRACTSTableAdapter1.ClearBeforeFill = True
        '
        'ContractIDDataGridViewTextBoxColumn
        '
        Me.ContractIDDataGridViewTextBoxColumn.DataPropertyName = "Contract_ID"
        Me.ContractIDDataGridViewTextBoxColumn.HeaderText = "Contract_ID"
        Me.ContractIDDataGridViewTextBoxColumn.Name = "ContractIDDataGridViewTextBoxColumn"
        '
        'ClientIDDataGridViewTextBoxColumn
        '
        Me.ClientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID"
        Me.ClientIDDataGridViewTextBoxColumn.HeaderText = "Client_ID"
        Me.ClientIDDataGridViewTextBoxColumn.Name = "ClientIDDataGridViewTextBoxColumn"
        '
        'SaleNumberDataGridViewTextBoxColumn
        '
        Me.SaleNumberDataGridViewTextBoxColumn.DataPropertyName = "Sale_Number"
        Me.SaleNumberDataGridViewTextBoxColumn.HeaderText = "Sale_Number"
        Me.SaleNumberDataGridViewTextBoxColumn.Name = "SaleNumberDataGridViewTextBoxColumn"
        '
        'ContractAmountDataGridViewTextBoxColumn
        '
        Me.ContractAmountDataGridViewTextBoxColumn.DataPropertyName = "Contract_Amount"
        Me.ContractAmountDataGridViewTextBoxColumn.HeaderText = "Contract_Amount"
        Me.ContractAmountDataGridViewTextBoxColumn.Name = "ContractAmountDataGridViewTextBoxColumn"
        '
        'ContractLengthDataGridViewTextBoxColumn
        '
        Me.ContractLengthDataGridViewTextBoxColumn.DataPropertyName = "Contract_Length"
        Me.ContractLengthDataGridViewTextBoxColumn.HeaderText = "Contract_Length"
        Me.ContractLengthDataGridViewTextBoxColumn.Name = "ContractLengthDataGridViewTextBoxColumn"
        '
        'CONTRACTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CONTRACTS"
        Me.Text = "CONTRACTS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Group26Contracts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRACTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRACTSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Group26Contracts As group26Contracts
    Friend WithEvents CONTRACTSBindingSource As BindingSource
    Friend WithEvents CONTRACTSTableAdapter As group26ContractsTableAdapters.CONTRACTSTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Group26DataSet As group26DataSet
    Friend WithEvents CONTRACTSBindingSource1 As BindingSource
    Friend WithEvents CONTRACTSTableAdapter1 As group26DataSetTableAdapters.CONTRACTSTableAdapter
    Friend WithEvents ContractIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaleNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContractAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContractLengthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
