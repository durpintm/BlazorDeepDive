namespace ServerManagement.Models
{
    public static class CitiesRepository
    {
        private static List<string> Cities = new List<string> { "Toronto", "Calgary", "Halifax", "London" };

        public static List<string> GetCities() => Cities;
    }
}
