namespace GrafanaSimpleDataSource.Data.Example
{
    public class ExampleTableDataSource : ITableDataSource
    {
        public string Metric => "Example Table";

        public TableResponse GetData(TimeSeriesRequest request)
        {
            return null;
        }
    }
}
