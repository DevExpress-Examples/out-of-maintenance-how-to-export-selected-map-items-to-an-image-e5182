Imports Microsoft.VisualBasic
Imports System
Namespace ExportSelectedItems
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim imageTilesLayer1 As New DevExpress.XtraMap.ImageTilesLayer()
			Dim openStreetMapDataProvider1 As New DevExpress.XtraMap.OpenStreetMapDataProvider()
			Dim vectorItemsLayer1 As New DevExpress.XtraMap.VectorItemsLayer()
			Dim mapRectangle1 As New DevExpress.XtraMap.MapRectangle()
			Dim mapRectangle2 As New DevExpress.XtraMap.MapRectangle()
			Dim mapRectangle3 As New DevExpress.XtraMap.MapRectangle()
			Dim mapRectangle4 As New DevExpress.XtraMap.MapRectangle()
			Dim mapRectangle5 As New DevExpress.XtraMap.MapRectangle()
			Dim mapRectangle6 As New DevExpress.XtraMap.MapRectangle()
			Me.mapControl1 = New DevExpress.XtraMap.MapControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' mapControl1
			' 
			Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(60R, -100R)
			Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
			imageTilesLayer1.DataProvider = openStreetMapDataProvider1
			mapRectangle1.Fill = System.Drawing.Color.Red
			mapRectangle1.Height = 300R
			mapRectangle1.Location = New DevExpress.XtraMap.GeoPoint(55R, -120R)
			mapRectangle1.Width = 300R
			mapRectangle2.Fill = System.Drawing.Color.Yellow
			mapRectangle2.Height = 300R
			mapRectangle2.Location = New DevExpress.XtraMap.GeoPoint(45R, -110R)
			mapRectangle2.Width = 300R
			mapRectangle3.Fill = System.Drawing.Color.Lime
			mapRectangle3.Height = 300R
			mapRectangle3.Location = New DevExpress.XtraMap.GeoPoint(45R, -120R)
			mapRectangle3.Width = 300R
			mapRectangle4.Fill = System.Drawing.Color.Blue
			mapRectangle4.Height = 300R
			mapRectangle4.Location = New DevExpress.XtraMap.GeoPoint(60R, -110R)
			mapRectangle4.Width = 300R
			mapRectangle5.Fill = System.Drawing.Color.Fuchsia
			mapRectangle5.Height = 300R
			mapRectangle5.Location = New DevExpress.XtraMap.GeoPoint(60R, -120R)
			mapRectangle5.Width = 300R
			mapRectangle6.Height = 300R
			mapRectangle6.Location = New DevExpress.XtraMap.GeoPoint(55R, -110R)
			mapRectangle6.Width = 300R
			vectorItemsLayer1.Items.Add(mapRectangle1)
			vectorItemsLayer1.Items.Add(mapRectangle2)
			vectorItemsLayer1.Items.Add(mapRectangle3)
			vectorItemsLayer1.Items.Add(mapRectangle4)
			vectorItemsLayer1.Items.Add(mapRectangle5)
			vectorItemsLayer1.Items.Add(mapRectangle6)
			Me.mapControl1.Layers.Add(imageTilesLayer1)
			Me.mapControl1.Layers.Add(vectorItemsLayer1)
			Me.mapControl1.Location = New System.Drawing.Point(0, 0)
			Me.mapControl1.Name = "mapControl1"
			Me.mapControl1.Size = New System.Drawing.Size(513, 351)
			Me.mapControl1.TabIndex = 0
			Me.mapControl1.ZoomLevel = 2R
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Dock = System.Windows.Forms.DockStyle.Top
			Me.simpleButton1.Location = New System.Drawing.Point(0, 0)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(513, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "ExportToImage"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(513, 351)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.mapControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private mapControl1 As DevExpress.XtraMap.MapControl
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

