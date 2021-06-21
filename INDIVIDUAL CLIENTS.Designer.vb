<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class INDIVIDUAL_CLIENTS
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
        Me.tblIndClients = New System.Windows.Forms.DataGridView()
        Me.ClientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndividualIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndividualNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndividualEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndividualCellDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblClientsIndividualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkyliteDB = New M2.SkyliteDB()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TblClientsIndividualTableAdapter = New M2.SkyliteDBTableAdapters.tblClientsIndividualTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.tblIndClients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClientsIndividualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.txbCell)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txbEmail)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.txbLName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txbFName)
        Me.Panel1.Controls.Add(Me.txbIndID)
        Me.Panel1.Controls.Add(Me.tblIndClients)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txbClientID)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(892, 426)
        Me.Panel1.TabIndex = 14
        '
        'tblIndClients
        '
        Me.tblIndClients.AutoGenerateColumns = False
        Me.tblIndClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblIndClients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientIDDataGridViewTextBoxColumn, Me.IndividualIDDataGridViewTextBoxColumn, Me.IndividualNameDataGridViewTextBoxColumn, Me.IndividualEmailDataGridViewTextBoxColumn, Me.IndividualCellDataGridViewTextBoxColumn})
        Me.tblIndClients.DataSource = Me.TblClientsIndividualBindingSource
        Me.tblIndClients.Location = New System.Drawing.Point(40, 100)
        Me.tblIndClients.Name = "tblIndClients"
        Me.tblIndClients.Size = New System.Drawing.Size(543, 302)
        Me.tblIndClients.TabIndex = 16
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
        'TblClientsIndividualBindingSource
        '
        Me.TblClientsIndividualBindingSource.DataMember = "tblClientsIndividual"
        Me.TblClientsIndividualBindingSource.DataSource = Me.SkyliteDB
        '
        'SkyliteDB
        '
        Me.SkyliteDB.DataSetName = "SkyliteDB"
        Me.SkyliteDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(557, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 20)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "X"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.Button8.TabIndex = 14
        Me.Button8.Text = "BACK"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(610, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(265, 56)
        Me.Button2.TabIndex = 58
        Me.Button2.Text = "Add Customer"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(607, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 14)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Cell"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(607, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 14)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(607, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 14)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Last Name"
        '
        'txbLName
        '
        Me.txbLName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbLName.Location = New System.Drawing.Point(697, 178)
        Me.txbLName.Name = "txbLName"
        Me.txbLName.Size = New System.Drawing.Size(178, 20)
        Me.txbLName.TabIndex = 53
        '
        'txbIndID
        '
        Me.txbIndID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbIndID.Location = New System.Drawing.Point(697, 126)
        Me.txbIndID.Name = "txbIndID"
        Me.txbIndID.Size = New System.Drawing.Size(178, 20)
        Me.txbIndID.TabIndex = 52
        '
        'txbClientID
        '
        Me.txbClientID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbClientID.Location = New System.Drawing.Point(697, 100)
        Me.txbClientID.Name = "txbClientID"
        Me.txbClientID.Size = New System.Drawing.Size(178, 20)
        Me.txbClientID.TabIndex = 51
        '
        'txbFName
        '
        Me.txbFName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbFName.Location = New System.Drawing.Point(697, 152)
        Me.txbFName.Name = "txbFName"
        Me.txbFName.Size = New System.Drawing.Size(178, 20)
        Me.txbFName.TabIndex = 50
        '
        'txbCell
        '
        Me.txbCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbCell.Location = New System.Drawing.Point(697, 230)
        Me.txbCell.Name = "txbCell"
        Me.txbCell.Size = New System.Drawing.Size(178, 20)
        Me.txbCell.TabIndex = 48
        '
        'txbEmail
        '
        Me.txbEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbEmail.Location = New System.Drawing.Point(697, 204)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(178, 20)
        Me.txbEmail.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(607, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 14)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(607, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 14)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Client ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(607, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 14)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Individual ID"
        '
        'TblClientsIndividualTableAdapter
        '
        Me.TblClientsIndividualTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(137, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(328, 20)
        Me.TextBox1.TabIndex = 64
        Me.TextBox1.Text = "Search..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(88, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(441, 59)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "INDIVIDUAL CLIENTS"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(610, 346)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(265, 56)
        Me.Button3.TabIndex = 65
        Me.Button3.Text = "Edit Customer"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(666, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 29)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Add/Edit Client"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(810, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(79, 28)
        Me.Button4.TabIndex = 66
        Me.Button4.Text = "HOME"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'INDIVIDUAL_CLIENTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "INDIVIDUAL_CLIENTS"
        Me.Text = "INDIVIDUAL_CLIENTS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tblIndClients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClientsIndividualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tblIndClients As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label5 As Label
End Class
