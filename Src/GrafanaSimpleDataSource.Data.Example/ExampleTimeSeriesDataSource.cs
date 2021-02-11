using System;

namespace GrafanaSimpleDataSource.Data.Example
{
    public class ExampleTimeSeriesDataSource : ITimeSeriesDataSource
    {
        public string Metric => "Example TimeSeries";

        public TimeSeriesResponse GetData(TimeSeriesRequest request)
        {
            return null;
        }
    }
}
