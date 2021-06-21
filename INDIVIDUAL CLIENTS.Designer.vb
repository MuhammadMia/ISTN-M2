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
        Me.tblIndClients = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txbLName = New System.Windows.Forms.TextBox()
        Me.txbIndID = New System.Windows.Forms.TextBox()
        Me.txbClientID = New System.Windows.Forms.TextBox()
        Me.txbFName = New System.Windows.Forms.TextBox()
        Me.txbCell = New System.Windows.Forms.TextBox()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SkyliteDB = New M2.SkyliteDB()
        Me.TblClientsIndividualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblClientsIndividualTableAdapter = New M2.SkyliteDBTableAdapters.tblClientsIndividualTableAdapter()
        Me.ClientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndividualIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndividualNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndividualEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndividualCellDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.tblIndClients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClientsIndividualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tblIndClients)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 426)
        Me.Panel1.TabIndex = 14
        '
        'tblIndClients
        '
        Me.tblIndClients.AutoGenerateColumns = False
        Me.tblIndClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblIndClients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientIDDataGridViewTextBoxColumn, Me.IndividualIDDataGridViewTextBoxColumn, Me.IndividualNameDataGridViewTextBoxColumn, Me.IndividualEmailDataGridViewTextBoxColumn, Me.IndividualCellDataGridViewTextBoxColumn})
        Me.tblIndClients.DataSource = Me.TblClientsIndividualBindingSource
        Me.tblIndClients.Location = New System.Drawing.Point(28, 82)
        Me.tblIndClients.Name = "tblIndClients"
        Me.tblIndClients.Size = New System.Drawing.Size(720, 318)
        Me.tblIndClients.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(694, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 28)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Remove Client" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(809, 382)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(265, 56)
        Me.Button2.TabIndex = 58
        Me.Button2.Text = "Add Customer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(806, 284)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Cell"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(806, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(806, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Last Name"
        '
        'txbLName
        '
        Me.txbLName.Location = New System.Drawing.Point(896, 194)
        Me.txbLName.Name = "txbLName"
        Me.txbLName.Size = New System.Drawing.Size(178, 20)
        Me.txbLName.TabIndex = 53
        '
        'txbIndID
        '
        Me.txbIndID.Location = New System.Drawing.Point(896, 109)
        Me.txbIndID.Name = "txbIndID"
        Me.txbIndID.Size = New System.Drawing.Size(178, 20)
        Me.txbIndID.TabIndex = 52
        '
        'txbClientID
        '
        Me.txbClientID.Location = New System.Drawing.Point(896, 71)
        Me.txbClientID.Name = "txbClientID"
        Me.txbClientID.Size = New System.Drawing.Size(178, 20)
        Me.txbClientID.TabIndex = 51
        '
        'txbFName
        '
        Me.txbFName.Location = New System.Drawing.Point(896, 150)
        Me.txbFName.Name = "txbFName"
        Me.txbFName.Size = New System.Drawing.Size(178, 20)
        Me.txbFName.TabIndex = 50
        '
        'txbCell
        '
        Me.txbCell.Location = New System.Drawing.Point(896, 281)
        Me.txbCell.Name = "txbCell"
        Me.txbCell.Size = New System.Drawing.Size(178, 20)
        Me.txbCell.TabIndex = 48
        '
        'txbEmail
        '
        Me.txbEmail.Location = New System.Drawing.Point(896, 237)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(178, 20)
        Me.txbEmail.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(836, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 31)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Add New Client"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(806, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(806, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Client ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(806, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Individual ID"
        '
        'SkyliteDB
        '
        Me.SkyliteDB.DataSetName = "SkyliteDB"
        Me.SkyliteDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblClientsIndividualBindingSource
        '
        Me.TblClientsIndividualBindingSource.DataMember = "tblClientsIndividual"
        Me.TblClientsIndividualBindingSource.DataSource = Me.SkyliteDB
        '
        'TblClientsIndividualTableAdapter
        '
        Me.TblClientsIndividualTableAdapter.ClearBeforeFill = True
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
        Me.ClientSize = New System.Drawing.Size(1086, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txbLName)
        Me.Controls.Add(Me.txbIndID)
        Me.Controls.Add(Me.txbClientID)
        Me.Controls.Add(Me.txbFName)
        Me.Controls.Add(Me.txbCell)
        Me.Controls.Add(Me.txbEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "INDIVIDUAL_CLIENTS"
        Me.Text = "INDIVIDUAL_CLIENTS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tblIndClients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClientsIndividualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tblIndClients As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txbLName As TextBox
    Friend WithEvents txbIndID As TextBox
    Friend WithEvents txbClientID As TextBox
    Friend WithEvents txbFName As TextBox
    Friend WithEvents txbCell As TextBox
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SkyliteDB As SkyliteDB
    Friend WithEvents TblClientsIndividualBindingSource As BindingSource
    Friend WithEvents TblClientsIndividualTableAdapter As SkyliteDBTableAdapters.tblClientsIndividualTableAdapter
    Friend WithEvents ClientIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndividualIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndividualNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndividualEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndividualCellDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
