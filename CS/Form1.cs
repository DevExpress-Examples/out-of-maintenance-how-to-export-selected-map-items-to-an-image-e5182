using System;
using System.Windows.Forms;
using System.Drawing.Imaging;
using DevExpress.XtraMap;
using System.Diagnostics;

namespace ExportSelectedItems {
    public partial class Form1 : Form {
        string mapPath = "Image.png";

        public Form1() {
            InitializeComponent();
            mapControl1.ExportMapItem += mapControl1_ExportMapItem;
        }

        private void mapControl1_ExportMapItem(object sender, ExportMapItemEventArgs e) {
            if (!e.IsSelected)
                e.Cancel = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            mapControl1.ExportToImage(mapPath, ImageFormat.Png);
            Process.Start(mapPath);
        }
    }
}
