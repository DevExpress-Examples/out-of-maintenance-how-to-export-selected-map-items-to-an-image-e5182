namespace ExportSelectedItems {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraMap.ImageLayer imageTilesLayer1 = new DevExpress.XtraMap.ImageLayer();
            DevExpress.XtraMap.OpenStreetMapDataProvider openStreetMapDataProvider1 = new DevExpress.XtraMap.OpenStreetMapDataProvider();
            DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            DevExpress.XtraMap.MapItemStorage mapItemStorage1 = new DevExpress.XtraMap.MapItemStorage();
            DevExpress.XtraMap.MapRectangle mapRectangle1 = new DevExpress.XtraMap.MapRectangle();
            DevExpress.XtraMap.MapRectangle mapRectangle2 = new DevExpress.XtraMap.MapRectangle();
            DevExpress.XtraMap.MapRectangle mapRectangle3 = new DevExpress.XtraMap.MapRectangle();
            DevExpress.XtraMap.MapRectangle mapRectangle4 = new DevExpress.XtraMap.MapRectangle();
            DevExpress.XtraMap.MapRectangle mapRectangle5 = new DevExpress.XtraMap.MapRectangle();
            DevExpress.XtraMap.MapRectangle mapRectangle6 = new DevExpress.XtraMap.MapRectangle();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(60D, -100D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            imageTilesLayer1.DataProvider = openStreetMapDataProvider1;
            mapRectangle1.Fill = System.Drawing.Color.Red;
            mapRectangle1.Height = 300D;
            mapRectangle1.Location = new DevExpress.XtraMap.GeoPoint(55D, -120D);
            mapRectangle1.Width = 300D;
            mapRectangle2.Fill = System.Drawing.Color.Yellow;
            mapRectangle2.Height = 300D;
            mapRectangle2.Location = new DevExpress.XtraMap.GeoPoint(45D, -110D);
            mapRectangle2.Width = 300D;
            mapRectangle3.Fill = System.Drawing.Color.Lime;
            mapRectangle3.Height = 300D;
            mapRectangle3.Location = new DevExpress.XtraMap.GeoPoint(45D, -120D);
            mapRectangle3.Width = 300D;
            mapRectangle4.Fill = System.Drawing.Color.Blue;
            mapRectangle4.Height = 300D;
            mapRectangle4.Location = new DevExpress.XtraMap.GeoPoint(60D, -110D);
            mapRectangle4.Width = 300D;
            mapRectangle5.Fill = System.Drawing.Color.Fuchsia;
            mapRectangle5.Height = 300D;
            mapRectangle5.Location = new DevExpress.XtraMap.GeoPoint(60D, -120D);
            mapRectangle5.Width = 300D;
            mapRectangle6.Height = 300D;
            mapRectangle6.Location = new DevExpress.XtraMap.GeoPoint(55D, -110D);
            mapRectangle6.Width = 300D;
            mapItemStorage1.Items.Add(mapRectangle1);
            mapItemStorage1.Items.Add(mapRectangle2);
            mapItemStorage1.Items.Add(mapRectangle3);
            mapItemStorage1.Items.Add(mapRectangle4);
            mapItemStorage1.Items.Add(mapRectangle5);
            mapItemStorage1.Items.Add(mapRectangle6);
            vectorItemsLayer1.Data = mapItemStorage1;
            this.mapControl1.Layers.Add(imageTilesLayer1);
            this.mapControl1.Layers.Add(vectorItemsLayer1);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(513, 351);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 2D;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.simpleButton1.Location = new System.Drawing.Point(0, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(513, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "ExportToImage";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 351);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.mapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

