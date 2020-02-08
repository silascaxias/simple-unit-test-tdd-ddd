using System;
using SimpleUnitTest.Application;
using SimpleUnitTest.Domain;
using Xunit;

namespace SimpleUnitTest.UnitTests {
    public class CustomerTests {
        [Fact]
        public void RegisterCustomer__Returns_Customer__When_Input_Are_Valid () {
            //
            // Arrange
            string expectName = "Silas Caxias";
            string expectPhoneNumber = "+55 19 997236192";

            IRegisterCustomerUseCase registerUC = new RegisterCustomerUseCase ();

            // Act
            CustomerResult actualCustomerResult = registerUC.Register (expectName, expectPhoneNumber);

            // Assert
            Assert.NotNull (actualCustomerResult);
            Assert.NotEqual (Guid.Empty, actualCustomerResult.Id);
            Assert.Equal (expectName, actualCustomerResult.Name);
            Assert.Equal (expectPhoneNumber, actualCustomerResult.PhoneNumber);
        }

        [Fact]
        public void CustomerCreate__Returns_Customer () {
            //
            // Arrange
            string expectName = "Silas Caxias";
            string expectPhoneNumber = "+55 19 997236192";

            // Act
            Customer actualCustomer = new Customer (expectName, expectPhoneNumber);

            // Assert
            Assert.NotNull (actualCustomer);
            Assert.NotEqual (Guid.Empty, actualCustomer.Id);
            Assert.Equal (expectName, actualCustomer.Name);
            Assert.Equal (expectPhoneNumber, actualCustomer.PhoneNumber);
        }
    }
}