public class CityPair
{
    public CityPair(City city1, City city2)
    {
        City1 = city1;
        City2 = city2;
    }

    public City City1 { get; private set; }
    public City City2 { get; private set; }
}