using System.Windows;
using DevExpress.Xpf.PivotGrid;
using DXPivotGrid_CancelFilterChanging.DataSet1TableAdapters;

namespace DXPivotGrid_CancelFilterChanging {
    public partial class MainWindow : Window {
        DataSet1.ProductReportsDataTable productReportsDataTable =
            new DataSet1.ProductReportsDataTable();
        ProductReportsTableAdapter productReportsDataAdapter = new ProductReportsTableAdapter();
        public MainWindow() {
            InitializeComponent();
            pivotGridControl1.DataSource = productReportsDataAdapter.GetData();
        }
        private void pivotGridControl1_FieldFilterChanging(object sender,
                                        PivotFieldFilterChangingEventArgs e) {
            if (Equals(e.Field, fieldCategoryName)) {
                if ((e.Field.FilterValues.FilterType == FieldFilterType.Excluded &&
                        e.Values.Contains("Beverages")) ||
                    (e.Field.FilterValues.FilterType == FieldFilterType.Included &&
                        !e.Values.Contains("Beverages"))) {
                    MessageBox.Show("You are not allowed to hide the 'Beverages' value.");
                    e.Cancel = true;
                }
            }
        }
    }
}
