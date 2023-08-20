using CityAPI.Model;

namespace CityAPI
{
    public class CityDataStore
    {
        public  List<CityDto> cities { get; set; }

        public static CityDataStore Instance { get; } = new CityDataStore();
        public CityDataStore() 
        {
            cities = new List<CityDto>()
            {
                new CityDto()
                { 
                    Id = 1,
                    Name = "Lwiw",
                },
                new CityDto()
                {
                    Id= 2,
                    Name = "Ivano-Frankivsk"
                },
                new CityDto() 
                {
                    Id = 3,
                    Name = "Ternopil"
                }
            };
        }
    }
}