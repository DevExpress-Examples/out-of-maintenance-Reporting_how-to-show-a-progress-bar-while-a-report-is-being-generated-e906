Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting.Native
' ...

Public Class Form1
    Private report As XtraReport1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create a report and make it
        ' a document source of the document viewer.
        report = New XtraReport1()
        DocumentViewer1.DocumentSource = report

        ' Create a form to show a progress bar,
        ' and adjust its properties.
        Dim form As New Form() With {.FormBorderStyle = FormBorderStyle.None, .Size = New System.Drawing.Size(300, 25), .ShowInTaskbar = False, .StartPosition = FormStartPosition.CenterScreen, .TopMost = True}

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
            report.PrintingSystem.ProgressReflector = reflectorBar
            report.CreateDocument()
        Finally
            ' Unregister the reflector bar, so that it no longer
            ' reflects the state of a ProgressReflector.
            report.PrintingSystem.ResetProgressReflector()
            form.Close()
            form.Dispose()
        End Try
    End Sub
End Class
