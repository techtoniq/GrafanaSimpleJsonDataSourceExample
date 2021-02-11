namespace GrafanaSimpleDataSource.Data
{
    public interface IDataSource<TResponse>
    {
        string Metric { get; }

        TResponse GetData(TimeSeriesRequest request);
    }
}
