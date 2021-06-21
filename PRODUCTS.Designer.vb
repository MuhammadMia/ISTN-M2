<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRODUCTS
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
        Me.lblSelectedProduct = New System.Windows.Forms.Label()
        Me.btnRemoveProduct = New System.Windows.Forms.Button()
        Me.tblProducts = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalePriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkyliteDB = New M2.SkyliteDB()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PRODUCTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProductsTableAdapter = New M2.SkyliteDBTableAdapters.tblProductsTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txbColor = New System.Windows.Forms.TextBox()
        Me.txbSuppID = New System.Windows.Forms.TextBox()
        Me.txbProdName = New System.Windows.Forms.TextBox()
        Me.txbManufacturer = New System.Windows.Forms.TextBox()
        Me.txbQuantity = New System.Windows.Forms.TextBox()
        Me.txbPrice = New System.Windows.Forms.TextBox()
        Me.txbCost = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.tblProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txbColor)
        Me.Panel1.Controls.Add(Me.lblSelectedProduct)
        Me.Panel1.Controls.Add(Me.txbSuppID)
        Me.Panel1.Controls.Add(Me.btnRemoveProduct)
        Me.Panel1.Controls.Add(Me.txbProdName)
        Me.Panel1.Controls.Add(Me.txbManufacturer)
        Me.Panel1.Controls.Add(Me.tblProducts)
        Me.Panel1.Controls.Add(Me.txbQuantity)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.txbPrice)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txbCost)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 426)
        Me.Panel1.TabIndex = 10
        '
        'lblSelectedProduct
        '
        Me.lblSelectedProduct.AutoSize = True
        Me.lblSelectedProduct.Location = New System.Drawing.Point(114, 78)
        Me.lblSelectedProduct.Name = "lblSelectedProduct"
        Me.lblSelectedProduct.Size = New System.Drawing.Size(0, 13)
        Me.lblSelectedProduct.TabIndex = 19
        '
        'btnRemoveProduct
        '
        Me.btnRemoveProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveProduct.ForeColor = System.Drawing.Color.Red
        Me.btnRemoveProduct.Location = New System.Drawing.Point(547, 71)
        Me.btnRemoveProduct.Name = "btnRemoveProduct"
        Me.btnRemoveProduct.Size = New System.Drawing.Size(25, 23)
        Me.btnRemoveProduct.TabIndex = 17
        Me.btnRemoveProduct.Text = "X"
        Me.btnRemoveProduct.UseVisualStyleBackColor = False
        '
        'tblProducts
        '
        Me.tblProducts.AutoGenerateColumns = False
        Me.tblProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.SupplierIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ManufacturerDataGridViewTextBoxColumn, Me.ColourDataGridViewTextBoxColumn, Me.CostPriceDataGridViewTextBoxColumn, Me.SalePriceDataGridViewTextBoxColumn, Me.CurrentStockDataGridViewTextBoxColumn})
        Me.tblProducts.DataSource = Me.TblProductsBindingSource
        Me.tblProducts.Location = New System.Drawing.Point(29, 100)
        Me.tblProducts.Name = "tblProducts"
        Me.tblProducts.Size = New System.Drawing.Size(543, 302)
        Me.tblProducts.TabIndex = 15
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
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
        'CostPriceDataGridViewTextBoxColumn
        '
        Me.CostPriceDataGridViewTextBoxColumn.DataPropertyName = "Cost_Price"
        Me.CostPriceDataGridViewTextBoxColumn.HeaderText = "Cost_Price"
        Me.CostPriceDataGridViewTextBoxColumn.Name = "CostPriceDataGridViewTextBoxColumn"
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
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(3, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(79, 28)
        Me.Button8.TabIndex = 14
        Me.Button8.Text = "BACK"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'PRODUCTSBindingSource
        '
        Me.PRODUCTSBindingSource.DataMember = "PRODUCTS"
        '
        'TblProductsTableAdapter
        '
        Me.TblProductsTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(606, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(265, 56)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Add to Product List"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(603, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Sale Price"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(603, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Cost Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(603, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Quantity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(603, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Colour"
        '
        'txbColor
        '
        Me.txbColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbColor.Location = New System.Drawing.Point(693, 180)
        Me.txbColor.Name = "txbColor"
        Me.txbColor.Size = New System.Drawing.Size(178, 20)
        Me.txbColor.TabIndex = 37
        '
        'txbSuppID
        '
        Me.txbSuppID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbSuppID.Location = New System.Drawing.Point(693, 128)
        Me.txbSuppID.Name = "txbSuppID"
        Me.txbSuppID.Size = New System.Drawing.Size(178, 20)
        Me.txbSuppID.TabIndex = 36
        '
        'txbProdName
        '
        Me.txbProdName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbProdName.Location = New System.Drawing.Point(693, 100)
        Me.txbProdName.Name = "txbProdName"
        Me.txbProdName.Size = New System.Drawing.Size(178, 20)
        Me.txbProdName.TabIndex = 35
        '
        'txbManufacturer
        '
        Me.txbManufacturer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbManufacturer.Location = New System.Drawing.Point(693, 154)
        Me.txbManufacturer.Name = "txbManufacturer"
        Me.txbManufacturer.Size = New System.Drawing.Size(178, 20)
        Me.txbManufacturer.TabIndex = 34
        '
        'txbQuantity
        '
        Me.txbQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbQuantity.Location = New System.Drawing.Point(693, 258)
        Me.txbQuantity.Name = "txbQuantity"
        Me.txbQuantity.Size = New System.Drawing.Size(178, 20)
        Me.txbQuantity.TabIndex = 33
        '
        'txbPrice
        '
        Me.txbPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbPrice.Location = New System.Drawing.Point(693, 232)
        Me.txbPrice.Name = "txbPrice"
        Me.txbPrice.Size = New System.Drawing.Size(178, 20)
        Me.txbPrice.TabIndex = 32
        '
        'txbCost
        '
        Me.txbCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txbCost.Location = New System.Drawing.Point(693, 206)
        Me.txbCost.Name = "txbCost"
        Me.txbCost.Size = New System.Drawing.Size(178, 20)
        Me.txbCost.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(603, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Manufacturer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(603, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Product Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(603, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Supplier ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(169, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 59)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "PRODUCTS"
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(129, 71)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(328, 20)
        Me.TextBox1.TabIndex = 60
        Me.TextBox1.Text = "Search..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(653, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 29)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Add/Edit Product"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(606, 346)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(265, 56)
        Me.Button2.TabIndex = 62
        Me.Button2.Text = "Edit Product List"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PRODUCTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PRODUCTS"
        Me.Text = "PRODUCTS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tblProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkyliteDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents tblProducts As DataGridView
    Friend WithEvents PRODUCTSBindingSource As BindingSource
    Friend WithEvents SkyliteDB As SkyliteDB
    Friend WithEvents TblProductsBindingSource As BindingSource
    Friend WithEvents TblProductsTableAdapter As SkyliteDBTableAdapters.tblProductsTableAdapter
    Friend WithEvents btnRemoveProduct As Button
    Friend WithEvents lblSelectedProduct As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txbColor As TextBox
    Friend WithEvents txbSuppID As TextBox
    Friend WithEvents txbProdName As TextBox
    Friend WithEvents txbManufacturer As TextBox
    Friend WithEvents txbQuantity As TextBox
    Friend WithEvents txbPrice As TextBox
    Friend WithEvents txbCost As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalePriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrentStockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
End Class
