using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Nairobi",
                    Description = "The capital city of Kenya",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Uhuru Gardens",
                            Description = "Newest museum in town"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Times Tower",
                            Description = "Tallest building in town"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Mombasa",
                    Description = "The city at the beach",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id= 3,
                            Name = "Beach",
                            Description = "Swim in the indian ocean"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Fort Jesus",
                            Description = "17th century fort built by the Portuguese"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Kisumu",
                    Description = "The omena city",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Migingo Island",
                            Description = "Most populated island in Kenya"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "Raila Odinga Avenue",
                            Description = "Road named after former Prime Minister"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 4,
                    Name = "Nakuru",
                    Description = "The youngest city",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 7,
                            Name = "Nakuru National Park",
                            Description = "Visit the big 5"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 8,
                            Name = "Lake Nakuru",
                            Description = "Visit flamingos"
                        }
                    }
                }
            };
        }
    }
}
