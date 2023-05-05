using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_NET_Libraries.JSON.utils;
using Testing_NET_Libraries.JSONReader.car;
using Testing_NET_Libraries.JSONReader.utils;
using Xunit;

namespace Testing_NET_Libraries.Tests.JSON_Tests
{
    public class JSON_Utils_Tests
    {
        private readonly JSONReader<Car>? jsonReader = new();


        [Fact]
        public void ReadJson_ShouldReturnListOfCars()
        {
            // Arrange
            List<Car> cars;

            // Act
            cars = jsonReader.readJson(@"../../../JSON/datafiles/cars.json");

            // Assert
            Assert.True(cars.Any());
        }


        //[Fact]
        //public void WriteJson_ShouldAddANewCarToJSON()
        //{
        //    // Arrange
        //    JSONWriter<Car>? jsonWriter = Substitute.For<JSONWriter<Car>>();

        //    int firstCarsListCount;
        //    int secondCarsListCount;

        //    // Act
        //    firstCarsListCount = jsonReader.readJson(@"../../../JSON/datafiles/cars.json").Count;

        //    jsonWriter.writeJSONToFile(@"../../../JSON/datafiles/cars.json", new(5, "Corolla", "Toyota"));

        //    secondCarsListCount = jsonReader.readJson(@"../../../JSON/datafiles/cars.json").Count;

        //    // Assert
        //    Assert.True(secondCarsListCount == firstCarsListCount + 1);

        //}
    }
}
