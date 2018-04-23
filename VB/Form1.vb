Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Native
Imports DevExpress.XtraReports.UI


Namespace ShowProgressReflector
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim report As New XtraReport1()
			report.TotalRowCount.Value = 100000
			ShowPreview(report)
		End Sub

		Private Shared Sub ShowPreview(ByVal report As XtraReport)
			' Create a form to show a progress bar,
			' and adjust its properties.
			Dim form As New Form()
			form.FormBorderStyle = FormBorderStyle.None
			form.Size = New System.Drawing.Size(300, 25)
			form.ShowInTaskbar = False
			form.StartPosition = FormStartPosition.CenterScreen
			form.TopMost = True

			' Create a ProgressBar along with its ReflectorBar.
			Dim progressBar As New ProgressBarControl()
			Dim reflectorBar As New ReflectorBar(progressBar)

			' Add a progress bar to a form and show it.
			form.Controls.Add(progressBar)
			progressBar.Dock = DockStyle.Fill
			form.Show()

			Try
				' Register the reflector bar, so that it reflects
				' the state of a ProgressReflector.
				ProgressReflector.RegisterReflector(reflectorBar)
				report.CreateDocument()
			Finally
				' Unregister the reflector bar, so that it no longer
				' reflects the state of a ProgressReflector.
				ProgressReflector.UnregisterReflector(reflectorBar)
				form.Close()
				form.Dispose()
			End Try

			' Show the preview of the created document.
			report.ShowPreviewDialog()
		End Sub

	End Class
End Namespace