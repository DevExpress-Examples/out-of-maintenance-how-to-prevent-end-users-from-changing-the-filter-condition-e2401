Imports System.Windows
Imports DevExpress.Xpf.PivotGrid
Imports DXPivotGrid_CancelFilterChanging.DataSet1TableAdapters

Namespace DXPivotGrid_CancelFilterChanging
	Partial Public Class MainWindow
		Inherits Window

'INSTANT VB NOTE: The variable productReportsDataTable was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Private productReportsDataTable_Conflict As New DataSet1.ProductReportsDataTable()
		Private productReportsDataAdapter As New ProductReportsTableAdapter()
		Public Sub New()
			InitializeComponent()
			pivotGridControl1.DataSource = productReportsDataAdapter.GetData()
		End Sub
		Private Sub pivotGridControl1_FieldFilterChanging(ByVal sender As Object, ByVal e As PivotFieldFilterChangingEventArgs)
			If Equals(e.Field, fieldCategoryName) Then
				If (e.Field.FilterValues.FilterType = FieldFilterType.Excluded AndAlso e.Values.Contains("Beverages")) OrElse (e.Field.FilterValues.FilterType = FieldFilterType.Included AndAlso Not e.Values.Contains("Beverages")) Then
					MessageBox.Show("You are not allowed to hide the 'Beverages' value.")
					e.Cancel = True
				End If
			End If
		End Sub
	End Class
End Namespace
