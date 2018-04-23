Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing.Imaging
Imports DevExpress.XtraMap
Imports System.Diagnostics

Namespace ExportSelectedItems
	Partial Public Class Form1
		Inherits Form
		Private mapPath As String = "Image.png"

		Public Sub New()
			InitializeComponent()
			AddHandler mapControl1.ExportMapItem, AddressOf mapControl1_ExportMapItem
		End Sub

		Private Sub mapControl1_ExportMapItem(ByVal sender As Object, ByVal e As ExportMapItemEventArgs)
			If (Not e.IsSelected) Then
				e.Cancel = True
			End If
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			mapControl1.ExportToImage(mapPath, ImageFormat.Png)
			Process.Start(mapPath)
		End Sub
	End Class
End Namespace
