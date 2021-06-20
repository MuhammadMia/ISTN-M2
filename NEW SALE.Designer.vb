<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NEW_SALE
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
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbEmployeeID = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtSaleDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tblProducts = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalePriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkyliteDB = New M2.SkyliteDB()
        Me.PRODUCTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group26DataSet1 = New M2.group26DataSet1()
        Me.PRODUCTSTableAdapter = New M2.group26DataSet1TableAdapters.PRODUCTSTableAdapter()
        Me.txbSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.tblCart = New System.Windows.Forms.DataGridView()
        Me.txbClientID = New System.Windows.Forms.TextBox()
        Me.cmbSaleType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txbContractLength = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotalOnceOff = New System.Windows.Forms.Label()
        Me.lblTotalMonthly = New System.Windows.Forms.Label()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.TblProductsTableAdapter = New M2.SkyliteDBTableAdapters.tblProductsTableAdapter()
        CType(Me.tblProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group26DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(12, 12)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(79, 28)
        Me.Button8.TabIndex = 15
        Me.Button8.Text = "BACK"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1067, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 61)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "NEW SALE"
        '
        'cmbEmployeeID
        '
        Me.cmbEmployeeID.FormattingEnabled = True
        Me.cmbEmployeeID.Location = New System.Drawing.Point(99, 365)
        Me.cmbEmployeeID.Name = "cmbEmployeeID"
        Me.cmbEmployeeID.Size = New System.Drawing.Size(200, 21)
        Me.cmbEmployeeID.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Client ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 373)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Employee ID"
        '
        'dtSaleDate
        '
        Me.dtSaleDate.Location = New System.Drawing.Point(99, 405)
        Me.dtSaleDate.Name = "dtSaleDate"
        Me.dtSaleDate.Size = New System.Drawing.Size(200, 20)
        Me.dtSaleDate.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 411)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Sale Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 449)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Sale Type"
        '
        'tblProducts
        '
        Me.tblProducts.AutoGenerateColumns = False
        Me.tblProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ManufacturerDataGridViewTextBoxColumn, Me.ColourDataGridViewTextBoxColumn, Me.SalePriceDataGridViewTextBoxColumn, Me.CurrentStockDataGridViewTextBoxColumn})
        Me.tblProducts.DataSource = Me.TblProductsBindingSource
        Me.tblProducts.Location = New System.Drawing.Point(12, 101)
        Me.tblProducts.Name = "tblProducts"
        Me.tblProducts.Size = New System.Drawing.Size(649, 182)
        Me.tblProducts.TabIndex = 23
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        '
        'ManufacturerDataGridViewTextBoxColumn
        '
        Me.ManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.Name = "ManufacturerDataGridViewTextBoxColumn"
        '
        'ColourDataGridViewTextBoxColumn
        '
        Me.ColourDataGridViewTextBoxColumn.DataPropertyName = "Colour"
        Me.ColourDataGridViewTextBoxColumn.HeaderText = "Colour"
        Me.ColourDataGridViewTextBoxColumn.Name = "ColourDataGridViewTextBoxColumn"
        '
        'SalePriceDataGridViewTextBoxColumn
        '
        Me.SalePriceDataGridViewTextBoxColumn.DataPropertyName = "Sale_Price"
        Me.SalePriceDataGridViewTextBoxColumn.HeaderText = "Sale_Price"
        Me.SalePriceDataGridViewTextBoxColumn.Name = "SalePriceDataGridViewTextBoxColumn"
        '
        'CurrentStockDataGridViewTextBoxColumn
        '
        Me.CurrentStockDataGridViewTextBoxColumn.DataPropertyName = "Current_Stock"
        Me.CurrentStockDataGridViewTextBoxColumn.HeaderText = "Current_Stock"
        Me.CurrentStockDataGridViewTextBoxColumn.Name = "CurrentStockDataGridViewTextBoxColumn"
        '
        'TblProductsBindingSource
        '
        Me.TblProductsBindingSource.DataMember = "tblProducts"
        Me.TblProductsBindingSource.DataSource = Me.SkyliteDB
        '
        'SkyliteDB
        '
        Me.SkyliteDB.DataSetName = "SkyliteDB"
        Me.SkyliteDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUCTSBindingSource
        '
        Me.PRODUCTSBindingSource.DataMember = "PRODUCTS"
        Me.PRODUCTSBindingSource.DataSource = Me.Group26DataSet1
        '
        'Group26DataSet1
        '
        Me.Group26DataSet1.DataSetName = "group26DataSet1"
        Me.Group26DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUCTSTableAdapter
        '
        Me.PRODUCTSTableAdapter.ClearBeforeFill = True
        '
        'txbSearch
        '
        Me.txbSearch.Location = New System.Drawing.Point(66, 70)
        Me.txbSearch.Name = "txbSearch"
        Me.txbSearch.Size = New System.Drawing.Size(227, 20)
        Me.txbSearch.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Search"
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Location = New System.Drawing.Point(667, 101)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(91, 182)
        Me.btnAddToCart.TabIndex = 27
        Me.btnAddToCart.Text = "Add to Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(1257, 101)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(89, 182)
        Me.btnRemove.TabIndex = 28
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'tblCart
        '
        Me.tblCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblCart.Location = New System.Drawing.Point(798, 101)
        Me.tblCart.Name = "tblCart"
        Me.tblCart.Size = New System.Drawing.Size(453, 182)
        Me.tblCart.TabIndex = 29
        '
        'txbClientID
        '
        Me.txbClientID.Location = New System.Drawing.Point(99, 328)
        Me.txbClientID.Name = "txbClientID"
        Me.txbClientID.Size = New System.Drawing.Size(200, 20)
        Me.txbClientID.TabIndex = 30
        '
        'cmbSaleType
        '
        Me.cmbSaleType.FormattingEnabled = True
        Me.cmbSaleType.Location = New System.Drawing.Point(99, 446)
        Me.cmbSaleType.Name = "cmbSaleType"
        Me.cmbSaleType.Size = New System.Drawing.Size(200, 21)
        Me.cmbSaleType.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(386, 331)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Contract Length (Months)"
        '
        'txbContractLength
        '
        Me.txbContractLength.Location = New System.Drawing.Point(541, 328)
        Me.txbContractLength.Name = "txbContractLength"
        Me.txbContractLength.Size = New System.Drawing.Size(60, 20)
        Me.txbContractLength.TabIndex = 33
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(389, 365)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(212, 102)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Calculate Total"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(793, 373)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(189, 25)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Total Due Once-Off:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(795, 418)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(177, 25)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Total Due Monthly:"
        '
        'lblTotalOnceOff
        '
        Me.lblTotalOnceOff.AutoSize = True
        Me.lblTotalOnceOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalOnceOff.Location = New System.Drawing.Point(1007, 373)
        Me.lblTotalOnceOff.Name = "lblTotalOnceOff"
        Me.lblTotalOnceOff.Size = New System.Drawing.Size(68, 25)
        Me.lblTotalOnceOff.TabIndex = 38
        Me.lblTotalOnceOff.Text = "R0.00"
        '
        'lblTotalMonthly
        '
        Me.lblTotalMonthly.AutoSize = True
        Me.lblTotalMonthly.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMonthly.Location = New System.Drawing.Point(1007, 418)
        Me.lblTotalMonthly.Name = "lblTotalMonthly"
        Me.lblTotalMonthly.Size = New System.Drawing.Size(68, 25)
        Me.lblTotalMonthly.TabIndex = 39
        Me.lblTotalMonthly.Text = "R0.00"
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(1134, 373)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(212, 70)
        Me.btnPlaceOrder.TabIndex = 40
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'TblProductsTableAdapter
        '
        Me.TblProductsTableAdapter.ClearBeforeFill = True
        '
        'NEW_SALE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1365, 505)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.lblTotalMonthly)
        Me.Controls.Add(Me.lblTotalOnceOff)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txbContractLength)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbSaleType)
        Me.Controls.Add(Me.txbClientID)
        Me.Controls.Add(Me.tblCart)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txbSearch)
        Me.Controls.Add(Me.tblProducts)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtSaleDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbEmployeeID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button8)
        Me.Name = "NEW_SALE"
        Me.Text = "NEW_SALE"
        CType(Me.tblProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group26DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbEmployeeID As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtSaleDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tblProducts As DataGridView
    Friend WithEvents Group26DataSet1 As group26DataSet1
    Friend WithEvents PRODUCTSBindingSource As BindingSource
    Friend WithEvents PRODUCTSTableAdapter As group26DataSet1TableAdapters.PRODUCTSTableAdapter
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalePriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrentStockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txbSearch As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents tblCart As DataGridView
    Friend WithEvents txbClientID As TextBox
    Friend WithEvents cmbSaleType As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txbContractLength As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTotalOnceOff As Label
    Friend WithEvents lblTotalMonthly As Label
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents SkyliteDB As SkyliteDB
    Friend WithEvents TblProductsBindingSource As BindingSource
    Friend WithEvents TblProductsTableAdapter As SkyliteDBTableAdapters.tblProductsTableAdapter
End Class
