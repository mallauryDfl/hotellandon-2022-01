using System;
using Xunit;
using HotelLandon.Models;

namespace TestUnitaire
{
    public class UnitTest1
    {
        /*[Fact]
        public void TestBirthDate()
        {
            //arrange
            Customer customer = new()
            {
                BirthDate = DateTime.Now(),

            };

            //act

            //assert 
            Assert.True(customer.BirthDate.Year = 1994);



        }*/

        [Fact]
        public void TestLastName()

        {
            //arrange
            Customer customer = new()
            {
                LastName = "Vtr",
            };

            //Act

            //Assert 
            Assert.True(customer.LastName.Length < 4);

            

        }

        [Fact]
        public void TestFirstName()
        {
            //arrange
            Customer customer = new()
            {
                FirstName = "Mallo",

            };

            //act

            //assert 
            Assert.Contains("M", customer.FirstName);



        }

        public void TestIRepository()
        {
            
        }

    }

    
}
