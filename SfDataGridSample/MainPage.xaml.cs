namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Datagrid_SelectionChanged(object sender, Syncfusion.Maui.DataGrid.DataGridSelectionChangedEventArgs e)
        {
            Employee selectedBatchRecord = (e.AddedRows[0] as Employee);
        }
    }

}
