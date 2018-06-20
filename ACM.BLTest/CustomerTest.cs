using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "FirstName",
                LastName = "LastName"
            };
            var expectedValue = "LastName, FirstName";
            
            //Act
            var actualValue = customer.FullName;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void FullNameFirstNameIsEmpty()
        {
            //Arrange
            Customer customer = new Customer
            {
                LastName = "LastName"
            };
            var expectedValue = "LastName";

            //Act
            var actualValue = customer.FullName;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void FullNameLastNameIsEmpty()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "FirstName",
            };
            var expectedValue = "FirstName";

            //Act
            var actualValue = customer.FullName;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            Customer customerOne = new Customer
            {
                FirstName = "One",
            };
            Customer.InstanceCount++;
            Customer customerTwo = new Customer
            {
                FirstName = "Two",
            };
            Customer.InstanceCount++;
            Customer customerThree = new Customer
            {
                FirstName = "Three",
            };
            Customer.InstanceCount++;
            var expectedValue = 3;

            //Act
            var actualValue = Customer.InstanceCount;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ValidateValidCustomerTest()
        {
            //Arrange
            Customer validCustomer = new Customer
            {
                FirstName = "One",
                LastName = "LastName",
                EmailAddress = "one@test.com"
            };
            var expectedValue = true;

            //Act
            var actualValue = validCustomer.Validate();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ValidateMissingLastNameTest()
        {
            //Arrange
            Customer validCustomer = new Customer
            {
                FirstName = "One",
                EmailAddress = "one@test.com"
            };
            var expectedValue = false;

            //Act
            var actualValue = validCustomer.Validate();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ValidateMissingEmailAddressTest()
        {
            //Arrange
            Customer validCustomer = new Customer
            {
                FirstName = "One",
                LastName = "LastName",
            };
            var expectedValue = false;

            //Act
            var actualValue = validCustomer.Validate();

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
