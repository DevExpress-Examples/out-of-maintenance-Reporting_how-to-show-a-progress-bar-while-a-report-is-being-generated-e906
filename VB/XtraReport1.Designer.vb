Imports Microsoft.VisualBasic
Imports System
Namespace ShowProgressReflector
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
            Me.TotalRowCount = New DevExpress.XtraReports.Parameters.Parameter
            Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand
            Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2})
            Me.Detail.HeightF = 32.0!
            Me.Detail.KeepTogether = True
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrLabel2
            '
            Me.xrLabel2.Font = New System.Drawing.Font("Arial", 12.0!)
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(650.0!, 25.0!)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.Text = "Row number"
            '
            'ReportHeader
            '
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
            Me.ReportHeader.HeightF = 71.0!
            Me.ReportHeader.Name = "ReportHeader"
            '
            'xrLabel1
            '
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.TotalRowCount, "Text", "A very large report with {0} rows")})
            Me.xrLabel1.Font = New System.Drawing.Font("Arial", 20.0!)
            Me.xrLabel1.ForeColor = System.Drawing.Color.Navy
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 19.0!)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(650.0!, 42.0!)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "xrLabel1"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            '
            'TotalRowCount
            '
            Me.TotalRowCount.Name = "TotalRowCount"
            Me.TotalRowCount.Type = GetType(Integer)
            Me.TotalRowCount.Value = 0
            '
            'TopMarginBand1
            '
            Me.TopMarginBand1.Name = "TopMarginBand1"
            '
            'BottomMarginBand1
            '
            Me.BottomMarginBand1.Name = "BottomMarginBand1"
            '
            'XtraReport1
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.ReportHeader, Me.TopMarginBand1, Me.BottomMarginBand1})
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.TotalRowCount})
            Me.RequestParameters = False
            Me.Version = "10.2"
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Public TotalRowCount As DevExpress.XtraReports.Parameters.Parameter
        Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
	End Class
End Namespace
