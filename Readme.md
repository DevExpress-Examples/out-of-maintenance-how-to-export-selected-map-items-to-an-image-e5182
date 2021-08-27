<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576426/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5182)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to export selected map items to an image


<p>The following example demonstrates how to export selected map items to an image.</p>
<p>To do this, handle the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapControl_ExportMapItemtopic"><u>MapControl.ExportMapItem</u></a> event and, if the map item is not selected (the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapExportMapItemEventArgs_IsSelectedtopic"><u>ExportMapItemEventArgs.IsSelected</u></a> property is set to <strong>false</strong>), set the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapExportMapItemEventArgs_Canceltopic"><u>ExportMapItemEventArgs.Cancel</u></a> property to<strong> true</strong>.<br /><br /> Then, call the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapControl_ExportToImagetopic"><u>MapControl.ExportToImage</u></a> method and provide the map path (where the map image should be stored) and the specified image format ( e.g., <strong>png</strong>).</p>

<br/>


