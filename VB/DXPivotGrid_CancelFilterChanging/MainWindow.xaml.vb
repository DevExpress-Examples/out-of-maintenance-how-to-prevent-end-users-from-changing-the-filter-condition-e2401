Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.PivotGrid
Imports DXPivotGrid_CancelFilterChanging.DataSet1TableAdapters

Namespace DXPivotGrid_CancelFilterChanging
	Partial Public Class MainWindow
		Inherits Window
		Private productReportsDataTable As New DataSet1.ProductReportsDataTable()
		Private productReportsDataAdapter As New ProductReportsTableAdapter()
		Public Sub New()
			InitializeComponent()
			pivotGridControl1.DataSource = productReportsDataAdapter.GetData()
		End Sub

		Private Sub pivotGridControl1_FieldFilterChanging(ByVal sender As Object, _
					ByVal e As PivotFieldFilterChangingEventArgs)
			If Equals(e.Field, fieldCategoryName) Then
				If (e.Field.FilterValues.FilterType = FieldFilterType.Excluded AndAlso _
							e.Values.Contains("Beverages")) OrElse _
							(e.Field.FilterValues.FilterType = FieldFilterType.Included AndAlso _
							(Not e.Values.Contains("Beverages"))) Then
					MessageBox.Show("You are not allowed to hide the 'Beverages' value.")
					e.Cancel = True
				End If
			End If
		End Sub
	End Class
End Namespace
