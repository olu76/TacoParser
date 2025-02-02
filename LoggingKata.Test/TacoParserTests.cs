using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {

        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("33.556383, -86.889051, Taco Bell Birmingha...", -86.889051)]
        [InlineData("32.609135,-85.479907,Taco Bell Auburn...", -85.479907)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            //Parse method is located inside of the TacoParser class

            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        public void ShouldParseLatitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Latitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            //Parse method is located inside of the TacoParser class

            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Latitude);


        }
    }
}
