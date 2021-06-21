<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NEW_SALE
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
        Me.Button8 = New System.Windows.Forms.Button()
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
        Me.txbSearch = New System.Windows.Forms.TextBox()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.tblCart = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColourDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalePriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentStockDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblProductsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.tblProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblCart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Button8.TabIndex = 15
        Me.Button8.Text = "BACK"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'cmbEmployeeID
        '
        Me.cmbEmployeeID.FormattingEnabled = True
        Me.cmbEmployeeID.Location = New System.Drawing.Point(148, 353)
        Me.cmbEmployeeID.Name = "cmbEmployeeID"
        Me.cmbEmployeeID.Size = New System.Drawing.Size(200, 21)
        Me.cmbEmployeeID.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(28, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Client ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(30, 359)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Employee ID"
        '
        'dtSaleDate
        '
        Me.dtSaleDate.Location = New System.Drawing.Point(148, 392)
        Me.dtSaleDate.Name = "dtSaleDate"
        Me.dtSaleDate.Size = New System.Drawing.Size(200, 20)
        Me.dtSaleDate.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(28, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Sale Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(30, 433)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Sale Type"
        '
        'tblProducts
        '
        Me.tblProducts.AutoGenerateColumns = False
        Me.tblProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ManufacturerDataGridViewTextBoxColumn, Me.ColourDataGridViewTextBoxColumn, Me.SalePriceDataGridViewTextBoxColumn, Me.CurrentStockDataGridViewTextBoxColumn})
        Me.tblProducts.DataSource = Me.TblProductsBindingSource
        Me.tblProducts.Location = New System.Drawing.Point(3, 89)
        Me.tblProducts.Name = "tblProducts"
        Me.tblProducts.Size = New System.Drawing.Size(529, 182)
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
        '
        'txbSearch
        '
        Me.txbSearch.Location = New System.Drawing.Point(3, 63)
        Me.txbSearch.Name = "txbSearch"
        Me.txbSearch.Size = New System.Drawing.Size(244, 20)
        Me.txbSearch.TabIndex = 25
        Me.txbSearch.Text = "Search..."
        '
        'btnAddToCart
        '
        Me.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddToCart.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToCart.ForeColor = System.Drawing.Color.White
        Me.btnAddToCart.Location = New System.Drawing.Point(538, 89)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(91, 182)
        Me.btnAddToCart.TabIndex = 27
        Me.btnAddToCart.Text = "Add to Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(1081, 89)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(89, 182)
        Me.btnRemove.TabIndex = 28
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'tblCart
        '
        Me.tblCart.AutoGenerateColumns = False
        Me.tblCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn1, Me.SupplierIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn1, Me.ProductDescriptionDataGridViewTextBoxColumn, Me.ManufacturerDataGridViewTextBoxColumn1, Me.ColourDataGridViewTextBoxColumn1, Me.CostPriceDataGridViewTextBoxColumn, Me.SalePriceDataGridViewTextBoxColumn1, Me.CurrentStockDataGridViewTextBoxColumn1})
        Me.tblCart.DataSource = Me.TblProductsBindingSource1
        Me.tblCart.Location = New System.Drawing.Point(658, 89)
        Me.tblCart.Name = "tblCart"
        Me.tblCart.Size = New System.Drawing.Size(417, 182)
        Me.tblCart.TabIndex = 29
        '
        'ProductIDDataGridViewTextBoxColumn1
        '
        Me.ProductIDDataGridViewTextBoxColumn1.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn1.HeaderText = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn1.Name = "ProductIDDataGridViewTextBoxColumn1"
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        '
        'ProductNameDataGridViewTextBoxColumn1
        '
        Me.ProductNameDataGridViewTextBoxColumn1.DataPropertyName = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn1.HeaderText = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn1.Name = "ProductNameDataGridViewTextBoxColumn1"
        '
        'ProductDescriptionDataGridViewTextBoxColumn
        '
        Me.ProductDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Product_Description"
        Me.ProductDescriptionDataGridViewTextBoxColumn.HeaderText = "Product_Description"
        Me.ProductDescriptionDataGridViewTextBoxColumn.Name = "ProductDescriptionDataGridViewTextBoxColumn"
        '
        'ManufacturerDataGridViewTextBoxColumn1
        '
        Me.ManufacturerDataGridViewTextBoxColumn1.DataPropertyName = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn1.HeaderText = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn1.Name = "ManufacturerDataGridViewTextBoxColumn1"
        '
        'ColourDataGridViewTextBoxColumn1
        '
        Me.ColourDataGridViewTextBoxColumn1.DataPropertyName = "Colour"
        Me.ColourDataGridViewTextBoxColumn1.HeaderText = "Colour"
        Me.ColourDataGridViewTextBoxColumn1.Name = "ColourDataGridViewTextBoxColumn1"
        '
        'CostPriceDataGridViewTextBoxColumn
        '
        Me.CostPriceDataGridViewTextBoxColumn.DataPropertyName = "Cost_Price"
        Me.CostPriceDataGridViewTextBoxColumn.HeaderText = "Cost_Price"
        Me.CostPriceDataGridViewTextBoxColumn.Name = "CostPriceDataGridViewTextBoxColumn"
        '
        'SalePriceDataGridViewTextBoxColumn1
        '
        Me.SalePriceDataGridViewTextBoxColumn1.DataPropertyName = "Sale_Price"
        Me.SalePriceDataGridViewTextBoxColumn1.HeaderText = "Sale_Price"
        Me.SalePriceDataGridViewTextBoxColumn1.Name = "SalePriceDataGridViewTextBoxColumn1"
        '
        'CurrentStockDataGridViewTextBoxColumn1
        '
        Me.CurrentStockDataGridViewTextBoxColumn1.DataPropertyName = "Current_Stock"
        Me.CurrentStockDataGridViewTextBoxColumn1.HeaderText = "Current_Stock"
        Me.CurrentStockDataGridViewTextBoxColumn1.Name = "CurrentStockDataGridViewTextBoxColumn1"
        '
        'TblProductsBindingSource1
        '
        Me.TblProductsBindingSource1.DataMember = "tblProducts"
        Me.TblProductsBindingSource1.DataSource = Me.SkyliteDB
        '
        'txbClientID
        '
        Me.txbClientID.Location = New System.Drawing.Point(148, 316)
        Me.txbClientID.Name = "txbClientID"
        Me.txbClientID.Size = New System.Drawing.Size(200, 20)
        Me.txbClientID.TabIndex = 30
        '
        'cmbSaleType
        '
        Me.cmbSaleType.FormattingEnabled = True
        Me.cmbSaleType.Location = New System.Drawing.Point(148, 431)
        Me.cmbSaleType.Name = "cmbSaleType"
        Me.cmbSaleType.Size = New System.Drawing.Size(200, 21)
        Me.cmbSaleType.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(414, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 15)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Contract Length (Months)"
        '
        'txbContractLength
        '
        Me.txbContractLength.Location = New System.Drawing.Point(569, 316)
        Me.txbContractLength.Name = "txbContractLength"
        Me.txbContractLength.Size = New System.Drawing.Size(60, 20)
        Me.txbContractLength.TabIndex = 33
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(417, 353)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(212, 102)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Calculate Total"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(670, 369)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 24)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Total Due Once-Off:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(672, 414)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 24)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Total Due Monthly:"
        '
        'lblTotalOnceOff
        '
        Me.lblTotalOnceOff.AutoSize = True
        Me.lblTotalOnceOff.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalOnceOff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTotalOnceOff.Location = New System.Drawing.Point(884, 369)
        Me.lblTotalOnceOff.Name = "lblTotalOnceOff"
        Me.lblTotalOnceOff.Size = New System.Drawing.Size(59, 24)
        Me.lblTotalOnceOff.TabIndex = 38
        Me.lblTotalOnceOff.Text = "R0.00"
        '
        'lblTotalMonthly
        '
        Me.lblTotalMonthly.AutoSize = True
        Me.lblTotalMonthly.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMonthly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTotalMonthly.Location = New System.Drawing.Point(884, 414)
        Me.lblTotalMonthly.Name = "lblTotalMonthly"
        Me.lblTotalMonthly.Size = New System.Drawing.Size(59, 24)
        Me.lblTotalMonthly.TabIndex = 39
        Me.lblTotalMonthly.Text = "R0.00"
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlaceOrder.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaceOrder.ForeColor = System.Drawing.Color.White
        Me.btnPlaceOrder.Location = New System.Drawing.Point(958, 353)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(212, 102)
        Me.btnPlaceOrder.TabIndex = 40
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = False
        '
        'TblProductsTableAdapter
        '
        Me.TblProductsTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txbClientID)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmbSaleType)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tblProducts)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.dtSaleDate)
        Me.Panel1.Controls.Add(Me.txbSearch)
        Me.Panel1.Controls.Add(Me.cmbEmployeeID)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txbContractLength)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.btnPlaceOrder)
        Me.Panel1.Controls.Add(Me.lblTotalMonthly)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblTotalOnceOff)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btnAddToCart)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.tblCart)
        Me.Panel1.Controls.Add(Me.btnRemove)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1176, 481)
        Me.Panel1.TabIndex = 41
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Corbel Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(488, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(237, 59)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "NEW SALE"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1091, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 28)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "HOME"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NEW_SALE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 505)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NEW_SALE"
        Me.Text = "NEW_SALE"
        CType(Me.tblProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblCart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button8 As Button
    Friend WithEvents cmbEmployeeID As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtSaleDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tblProducts As DataGridView
    Friend WithEvents PRODUCTSBindingSource As BindingSource
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalePriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrentStockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txbSearch As TextBox
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
    Friend WithEvents ProductIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProductDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ColourDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CostPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalePriceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CurrentStockDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TblProductsBindingSource1 As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
End Class
