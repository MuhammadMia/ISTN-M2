<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.txbEmployeeNum = New System.Windows.Forms.TextBox()
        Me.txbPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TblEmployeesTableAdapter1 = New M2.SkyliteDBTableAdapters.tblEmployeesTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(313, 300)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 41)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "LOG IN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 124)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SKYLITE"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(672, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(101, 28)
        Me.Button8.TabIndex = 12
        Me.Button8.Text = "ADMIN LOG IN"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'txbEmployeeNum
        '
        Me.txbEmployeeNum.Location = New System.Drawing.Point(313, 182)
        Me.txbEmployeeNum.Name = "txbEmployeeNum"
        Me.txbEmployeeNum.Size = New System.Drawing.Size(163, 20)
        Me.txbEmployeeNum.TabIndex = 13
        '
        'txbPassword
        '
        Me.txbPassword.Location = New System.Drawing.Point(313, 240)
        Me.txbPassword.Name = "txbPassword"
        Me.txbPassword.Size = New System.Drawing.Size(163, 20)
        Me.txbPassword.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "EMPLOYEE ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(362, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "PASSWORD"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txbPassword)
        Me.Panel1.Controls.Add(Me.txbEmployeeNum)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 426)
        Me.Panel1.TabIndex = 6
        '
        'TblEmployeesTableAdapter1
        '
        Me.TblEmployeesTableAdapter1.ClearBeforeFill = True
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LOGIN"
        Me.Text = "LOGIN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents txbEmployeeNum As TextBox
    Friend WithEvents txbPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TblEmployeesTableAdapter1 As SkyliteDBTableAdapters.tblEmployeesTableAdapter
End Class
