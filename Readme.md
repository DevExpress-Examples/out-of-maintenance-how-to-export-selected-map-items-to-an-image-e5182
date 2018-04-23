# How to export selected map items to an image


<p>The following example demonstrates how to export selected map items to an image.</p>
<p>To do this, handle the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapControl_ExportMapItemtopic"><u>MapControl.ExportMapItem</u></a> event and, if the map item is not selected (the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapExportMapItemEventArgs_IsSelectedtopic"><u>ExportMapItemEventArgs.IsSelected</u></a> property is set to <strong>false</strong>), set the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapExportMapItemEventArgs_Canceltopic"><u>ExportMapItemEventArgs.Cancel</u></a> property to<strong> true</strong>.<br /><br /> Then, call the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapControl_ExportToImagetopic"><u>MapControl.ExportToImage</u></a> method and provide the map path (where the map image should be stored) and the specified image format ( e.g., <strong>png</strong>).</p>

<br/>


