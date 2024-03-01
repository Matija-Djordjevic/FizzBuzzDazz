using FizzBuzzEnterprizz.SeriesModels;

namespace FizzBuzzEnterprizz.SeriesProvider
{
    public interface ISeriesProvider
    {
        Series GetSeries();
        Series GetSeries(int count);
        Series GetSeries(int start, int count);
    }
}
