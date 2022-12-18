<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128578875/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2401)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXPivotGrid_CancelFilterChanging/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXPivotGrid_CancelFilterChanging/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DXPivotGrid_CancelFilterChanging/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXPivotGrid_CancelFilterChanging/MainWindow.xaml.vb))
<!-- default file list end -->
# How to prevent end-users from changing the filter condition


<p>The following example shows how to prevent end-users from changing the filter condition.</p><p>In this example, the FieldFilterChanging event is handled to prevent an end-user from hiding the 'Beverages' field value. If an end-user tries to hide the 'Beverages' field value, the event handler sets the event parameter's Cancel property to true to cancel changing the filter condition.</p>

<br/>


