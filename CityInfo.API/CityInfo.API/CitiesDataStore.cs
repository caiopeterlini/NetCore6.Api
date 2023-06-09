﻿using CityInfo.API.Models;

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
                    Id= 1,
                    Name="New york City",
                    Description="the one with that big park."
                },
                  new CityDto()
                {
                    Id= 2,
                    Name="São Paulo",
                    Description="The city from brazil"
                }
            };
        }
    }
}
