Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace ShowProgressReflector
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private i As Integer = 0

		Private Sub xrLabel2_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrLabel2.BeforePrint
			i += 1
			CType(sender, XRLabel).Text = "Row Number: " & i.ToString()
		End Sub

		Private Sub XtraReport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
			i = 0
			Me.ReportPrintOptions.DetailCountOnEmptyDataSource = CInt(Fix(TotalRowCount.Value))			
		End Sub

	End Class
End Namespace
