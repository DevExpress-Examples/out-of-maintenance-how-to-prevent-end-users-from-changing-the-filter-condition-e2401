Imports System.Windows
Imports DevExpress.Xpf.PivotGrid
Imports DXPivotGrid_CancelFilterChanging.DataSet1TableAdapters

Namespace DXPivotGrid_CancelFilterChanging

    Public Partial Class MainWindow
        Inherits Window

        Private productReportsDataTable As DataSet1.ProductReportsDataTable = New DataSet1.ProductReportsDataTable()

        Private productReportsDataAdapter As ProductReportsTableAdapter = New ProductReportsTableAdapter()

        Public Sub New()
            Me.InitializeComponent()
            Me.pivotGridControl1.DataSource = productReportsDataAdapter.GetData()
        End Sub

        Private Sub pivotGridControl1_FieldFilterChanging(ByVal sender As Object, ByVal e As PivotFieldFilterChangingEventArgs)
            If Object.Equals(e.Field, Me.fieldCategoryName) Then
                If e.Field.FilterValues.FilterType = FieldFilterType.Excluded AndAlso e.Values.Contains("Beverages") OrElse e.Field.FilterValues.FilterType = FieldFilterType.Included AndAlso Not e.Values.Contains("Beverages") Then
                    MessageBox.Show("You are not allowed to hide the 'Beverages' value.")
                    e.Cancel = True
                End If
            End If
        End Sub
    End Class
End Namespace
