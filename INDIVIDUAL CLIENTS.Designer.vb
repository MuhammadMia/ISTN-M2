<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INDIVIDUAL_CLIENTS
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
        Me.Group26DataSet5 = New M2.group26DataSet5()
        Me.INDIVIDUALCLIENTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INDIVIDUAL_CLIENTSTableAdapter = New M2.group26DataSet5TableAdapters.INDIVIDUAL_CLIENTSTableAdapter()
        Me.ClientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndividualIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndividualNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndividualEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndividualCellDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group26DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INDIVIDUALCLIENTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(113, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(541, 61)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "INDIVIDUAL CLIENTS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientIDDataGridViewTextBoxColumn, Me.IndividualIDDataGridViewTextBoxColumn, Me.IndividualNameDataGridViewTextBoxColumn, Me.IndividualEmailDataGridViewTextBoxColumn, Me.IndividualCellDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.INDIVIDUALCLIENTSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(111, 129)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(543, 267)
        Me.DataGridView1.TabIndex = 16
        '
        'Group26DataSet5
        '
        Me.Group26DataSet5.DataSetName = "group26DataSet5"
        Me.Group26DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'INDIVIDUALCLIENTSBindingSource
        '
        Me.INDIVIDUALCLIENTSBindingSource.DataMember = "INDIVIDUAL CLIENTS"
        Me.INDIVIDUALCLIENTSBindingSource.DataSource = Me.Group26DataSet5
        '
        'INDIVIDUAL_CLIENTSTableAdapter
        '
        Me.INDIVIDUAL_CLIENTSTableAdapter.ClearBeforeFill = True
        '
        'ClientIDDataGridViewTextBoxColumn
        '
        Me.ClientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID"
        Me.ClientIDDataGridViewTextBoxColumn.HeaderText = "Client_ID"
        Me.ClientIDDataGridViewTextBoxColumn.Name = "ClientIDDataGridViewTextBoxColumn"
        '
        'IndividualIDDataGridViewTextBoxColumn
        '
        Me.IndividualIDDataGridViewTextBoxColumn.DataPropertyName = "Individual_ID"
        Me.IndividualIDDataGridViewTextBoxColumn.HeaderText = "Individual_ID"
        Me.IndividualIDDataGridViewTextBoxColumn.Name = "IndividualIDDataGridViewTextBoxColumn"
        '
        'IndividualNameDataGridViewTextBoxColumn
        '
        Me.IndividualNameDataGridViewTextBoxColumn.DataPropertyName = "Individual_Name"
        Me.IndividualNameDataGridViewTextBoxColumn.HeaderText = "Individual_Name"
        Me.IndividualNameDataGridViewTextBoxColumn.Name = "IndividualNameDataGridViewTextBoxColumn"
        '
        'IndividualEmailDataGridViewTextBoxColumn
        '
        Me.IndividualEmailDataGridViewTextBoxColumn.DataPropertyName = "Individual_Email"
        Me.IndividualEmailDataGridViewTextBoxColumn.HeaderText = "Individual_Email"
        Me.IndividualEmailDataGridViewTextBoxColumn.Name = "IndividualEmailDataGridViewTextBoxColumn"
        '
        'IndividualCellDataGridViewTextBoxColumn
        '
        Me.IndividualCellDataGridViewTextBoxColumn.DataPropertyName = "Individual_Cell"
        Me.IndividualCellDataGridViewTextBoxColumn.HeaderText = "Individual_Cell"
        Me.IndividualCellDataGridViewTextBoxColumn.Name = "IndividualCellDataGridViewTextBoxColumn"
        '
        'INDIVIDUAL_CLIENTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "INDIVIDUAL_CLIENTS"
        Me.Text = "INDIVIDUAL_CLIENTS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group26DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INDIVIDUALCLIENTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Group26DataSet5 As group26DataSet5
    Friend WithEvents INDIVIDUALCLIENTSBindingSource As BindingSource
    Friend WithEvents INDIVIDUAL_CLIENTSTableAdapter As group26DataSet5TableAdapters.INDIVIDUAL_CLIENTSTableAdapter
    Friend WithEvents ClientIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndividualIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndividualNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndividualEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndividualCellDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
