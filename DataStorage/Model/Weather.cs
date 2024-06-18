namespace DataStorage.Model
{
    public class Weather
    {
        public string Cidade { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public float Temperatura { get; set; }
    }
}
