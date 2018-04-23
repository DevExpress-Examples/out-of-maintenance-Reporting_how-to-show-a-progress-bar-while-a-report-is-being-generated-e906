<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport1
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.NwindDataSet1 = New WindowsApplication1.nwindDataSet()
        Me.CategoriesTableAdapter = New WindowsApplication1.nwindDataSetTableAdapters.CategoriesTableAdapter()
        Me.ProductsTableAdapter1 = New WindowsApplication1.nwindDataSetTableAdapters.ProductsTableAdapter()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 47.91667!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrTableCell1
        '
        Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.ProductName")})
        Me.xrTableCell1.Name = "xrTableCell1"
        Me.xrTableCell1.StylePriority.UseTextAlignment = False
        Me.xrTableCell1.Text = "xrTableCell1"
        Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrTableCell1.Weight = 1.2703297289163433R
        '
        'xrTable2
        '
        Me.xrTable2.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.xrTable2.BorderColor = System.Drawing.Color.White
        Me.xrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTable2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrTable2.ForeColor = System.Drawing.Color.White
        Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrTable2.Name = "xrTable2"
        Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
        Me.xrTable2.SizeF = New System.Drawing.SizeF(481.9999!, 23.95833!)
        Me.xrTable2.StylePriority.UseBackColor = False
        Me.xrTable2.StylePriority.UseBorderColor = False
        Me.xrTable2.StylePriority.UseBorders = False
        Me.xrTable2.StylePriority.UseFont = False
        Me.xrTable2.StylePriority.UseForeColor = False
        Me.xrTable2.StylePriority.UsePadding = False
        Me.xrTable2.StylePriority.UseTextAlignment = False
        Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 46.875!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrLabel2
        '
        Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
        Me.xrLabel2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.xrLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(9.999959!, 92.66669!)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(293.25!, 23.0!)
        Me.xrLabel2.StylePriority.UseFont = False
        Me.xrLabel2.StylePriority.UseForeColor = False
        Me.xrLabel2.Text = "xrLabel2"
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.ReportHeader})
        Me.DetailReport.DataAdapter = Me.ProductsTableAdapter1
        Me.DetailReport.DataMember = "Categories.CategoriesProducts"
        Me.DetailReport.DataSource = Me.NwindDataSet1
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(303.25!, 10.00001!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(168.75!, 115.7083!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'xrTableRow2
        '
        Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
        Me.xrTableRow2.Name = "xrTableRow2"
        Me.xrTableRow2.Weight = 1.0R
        '
        'xrTableCell5
        '
        Me.xrTableCell5.Name = "xrTableCell5"
        Me.xrTableCell5.StylePriority.UseTextAlignment = False
        Me.xrTableCell5.Text = "Unit Price"
        Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrTableCell5.Weight = 0.94065943851606626R
        '
        'xrTableCell6
        '
        Me.xrTableCell6.Name = "xrTableCell6"
        Me.xrTableCell6.StylePriority.UseTextAlignment = False
        Me.xrTableCell6.Text = "Units in Stock"
        Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrTableCell6.Weight = 0.83991147965505908R
        '
        'xrLabel1
        '
        Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
        Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(9.999959!, 57.91667!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(293.2501!, 23.0!)
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.StylePriority.UseForeColor = False
        Me.xrLabel1.Text = "xrLabel1"
        '
        'xrTableCell3
        '
        Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitsInStock")})
        Me.xrTableCell3.Name = "xrTableCell3"
        Me.xrTableCell3.StylePriority.UseTextAlignment = False
        Me.xrTableCell3.Text = "xrTableCell3"
        Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xrTableCell3.Weight = 0.83991147965505908R
        '
        'xrTableRow1
        '
        Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
        Me.xrTableRow1.Name = "xrTableRow1"
        Me.xrTableRow1.Weight = 1.0R
        '
        'xrTableCell4
        '
        Me.xrTableCell4.Name = "xrTableCell4"
        Me.xrTableCell4.StylePriority.UseTextAlignment = False
        Me.xrTableCell4.Text = "Product Name"
        Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrTableCell4.Weight = 1.2703297289163433R
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
        Me.Detail1.HeightF = 23.95833!
        Me.Detail1.Name = "Detail1"
        '
        'xrTableCell2
        '
        Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitPrice", "{0:$0.00}")})
        Me.xrTableCell2.Name = "xrTableCell2"
        Me.xrTableCell2.StylePriority.UseTextAlignment = False
        Me.xrTableCell2.Text = "xrTableCell2"
        Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.xrTableCell2.Weight = 0.94065943851606626R
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2, Me.xrLabel1, Me.xrPictureBox1})
        Me.Detail.HeightF = 127.0833!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
        Me.ReportHeader.HeightF = 23.95833!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'xrTable1
        '
        Me.xrTable1.BorderColor = System.Drawing.Color.LightGray
        Me.xrTable1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTable1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrTable1.Name = "xrTable1"
        Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100.0!)
        Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
        Me.xrTable1.SizeF = New System.Drawing.SizeF(481.9999!, 23.95833!)
        Me.xrTable1.StylePriority.UseBorderColor = False
        Me.xrTable1.StylePriority.UseBorders = False
        Me.xrTable1.StylePriority.UseFont = False
        Me.xrTable1.StylePriority.UseForeColor = False
        Me.xrTable1.StylePriority.UsePadding = False
        '
        'NwindDataSet1
        '
        Me.NwindDataSet1.DataSetName = "nwindDataSet"
        Me.NwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'ProductsTableAdapter1
        '
        Me.ProductsTableAdapter1.ClearBeforeFill = True
        '
        'XtraReport1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport})
        Me.DataAdapter = Me.CategoriesTableAdapter
        Me.DataMember = "Categories"
        Me.DataSource = Me.NwindDataSet1
        Me.FilterString = "[CategoryID] <> 2"
        Me.Margins = New System.Drawing.Printing.Margins(50, 51, 48, 47)
        Me.PageHeight = 827
        Me.PageWidth = 583
        Me.PaperKind = System.Drawing.Printing.PaperKind.A5
        Me.Version = "13.1"
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents xrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ProductsTableAdapter1 As WindowsApplication1.nwindDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents NwindDataSet1 As WindowsApplication1.nwindDataSet
    Friend WithEvents CategoriesTableAdapter As WindowsApplication1.nwindDataSetTableAdapters.CategoriesTableAdapter
End Class
