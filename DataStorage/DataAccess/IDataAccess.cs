using DataStorage.Model;

namespace DataStorage.DataAccess
{
    public interface IDataAccess
    {
        List<Weather> Weather { get; }

        Weather AddWeather(string city, float temp);
    }
}